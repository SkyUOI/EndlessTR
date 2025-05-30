using Ionic.Zip;
using Microsoft.Build.Tasks;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using rail;
using ReLogic.OS;
using SteelSeries.GameSense;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using Terraria;
using Terraria.GameInput;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace EndlessTR.WorldData;

public static class Debug
{
    public static void Error(string s) { throw new Exception(s); }
    public static Func<T, T> Check<T>(Action<T> f) { return t => { f(t); return t; }; }

    public static void Hack(Type t, string methodName, BindingFlags flag, Action<ILCursor> ilFunc)
    {
        MonoModHooks.Modify(t.GetMethod(methodName, flag), il =>
        {
            ILCursor cursor = new ILCursor(il);
            ilFunc(cursor);
        });
    }
}

public class ExtendingMap
{
    private static Tile[][,] newTileBlocksLeft = { new Tile[Main.maxTilesX, Main.maxTilesY] };
    private static Tile[][,] newTileBlocksRight = { new Tile[Main.maxTilesX, Main.maxTilesY] };

    private Tile[,] selectTilemap(int block_id)
    {
        if (block_id < 0)
        {
            return newTileBlocksLeft[-block_id];
        }
        else if (block_id > 0)
        {
            return newTileBlocksRight[block_id];
        }
        else
        {
            throw new Exception("Invalid block_id");
        }
    }

    public Tile this[int block_id, int x, int y]
    {
        get
        {
            if (block_id == 0) return Main.tile[x, y];
            var map = selectTilemap(block_id);
            return map[x, y];
        }
        set
        {
            throw new InvalidOperationException("tModLoader does that so I do it too");
        }
    }
}

public class WorldData
{
	public static int nowBlock = 0;
	public static int nowGenerating = 0;

	public static int nowSaving = 0;
	public static int nowLoading = 0;

    public static ExtendingMap MapData = new ExtendingMap();

	public static int blockLeft;

	public static int blockRight;

    public static int versionNumber;

	WorldData() { }
	public static void initiate() // 在世界生成时进行一些内容的初始化
	{
		blockLeft = blockRight = 0;
		nowBlock = 0;
	}

	public static void Hack()
	{
		HackSaveWorld();
		HackLoadWorld();

		HackWriteArchive();

		HackEraseWorld();

		HackUpdate();
	}

	public static void HackUpdate()
	{
		// TODO: Hack Pleyer 中的 Update (位于Player.cs 20098行)
		// 检查两边的块, 若没有生成, 则生成, 若有, 则加载
		var Player = typeof(Mod).Assembly.GetType("Terraria.Player");
		if (Player == null)
		{
			Debug.Error("Player == null");
		}
		var Update = Player.GetMethod("Update", BindingFlags.Public | BindingFlags.Instance);
		if (Update == null)
		{
			Debug.Error("Update == null");
		}
		MonoModHooks.Modify(Update, il =>
		{
			ILCursor cursor = new ILCursor(il);
			cursor.EmitDelegate(LoadBlocks);
		});
	}

	/// <summary>
	/// 加载某一个块中的内容, 若未生成则会生成该块
	/// </summary>
	/// <param name="blockId"> 加载的块的编号 </param>
	/// <param name="tileMapId"> 对应extendingMap中的编号 </param>
	public static void LoadBlock(int blockId, int extendingMapId)
	{
		nowGenerating = extendingMapId;
		nowLoading = extendingMapId;
		// 检查是否存在该block的文件, 若没有则生成
		if (!CheckBlockFile(blockId))
		{
			WorldGen.GenerateWorld(Main.ActiveWorldFileData.Seed);
		}

		// 实际的加载代码
		LoadWorldWld(blockId, extendingMapId);
	}

	private static bool CheckBlockFile(int blockId) // 检查
	{
		return FileUtilities.Exists(GetPath.GetWldPath(blockId), false);
	}

	public static void LoadBlocks()
	{
		LoadBlock(nowBlock - 1, -1);
		LoadBlock(nowBlock + 1, 1);
	}

	public static void HackEraseWorld()
	{
		try
		{
			var EraseWorld = typeof(Main).GetMethod("EraseWorld",
				BindingFlags.Static | BindingFlags.NonPublic);
			if (EraseWorld == null)
			{
				Debug.Error("HackEraseWorld EraseWorld == null");
			}
			MonoModHooks.Modify(EraseWorld, il =>
			{
				var cursor = new ILCursor(il);
				cursor.GotoNext(MoveType.Before, i => i.MatchBrtrue(out var _)
				&& i.Next.MatchCall(out var func)
				&& func.Name == "Get");
				cursor.Index += 1;
				cursor.EmitLdarg0();
				cursor.EmitDelegate(EraseWlds);
			});
		}
		catch
		{
			Debug.Error("HackEraseWorld Error");
		}


	}

	public static void EraseWlds(int i)
	{
		try
		{
			Platform.Get<IPathService>().MoveToRecycleBin(Path.GetDirectoryName(
				Main.WorldList[i].Path[..^5] + "\\"));
		}
		catch
		{
			Debug.Error("EraseWlds Error");
		}

	}

	public static void HackWriteArchive()
	{
		var World = typeof(Mod).Assembly.GetType("Terraria.ModLoader.BackupIO+World");
		if (World == null) throw new Exception("HackWriteArchive World == null!");
		var WriteArchive = World.GetMethod("WriteArchive", BindingFlags.Static | BindingFlags.NonPublic);
		MonoModHooks.Modify(WriteArchive, ILWriteArchive);

	}

	public static void ILWriteArchive(ILContext il)
	{
		var cursor = new ILCursor(il);
		// cursor.EmitDelegate(() => Debug.Error("WriteArchive"));
		cursor.EmitLdarg0();
		cursor.EmitLdarg1();
		cursor.EmitLdarg2();
		cursor.EmitDelegate(BackupWlds);
	}

	public static void BackupWlds(Ionic.Zip.ZipFile zip, bool isCloudSave, string path)
	{
		// throw new Exception("backupWlds");
		Assembly terraria = Assembly.Load("tModLoader");
		var BackupIO = terraria.GetType("Terraria.ModLoader.BackupIO");
		if (BackupIO == null)
		{
			Debug.Error("BackupWlds: BackupIO == null");
		}

		var AddZipEntry = BackupIO.GetMethod("AddZipEntry", BindingFlags.Static | BindingFlags.NonPublic);
		if (AddZipEntry == null)
		{
			Debug.Error("BackupWlds: AddZipEntry == null");
		}
		for (int i = blockLeft; i <= blockRight; ++i)
		{
			if (FileUtilities.Exists(path, isCloudSave))
				AddZipEntry.Invoke(null, [zip, GetPath.GetWldPath(i), isCloudSave]);
		}

	}

	public static void HackLoadWorld()
	{
		var flag = BindingFlags.Public | BindingFlags.Static;
		var WF = typeof(WorldFile);
		var version2 = WF.GetMethod("LoadWorld_Version2", flag);
		MonoModHooks.Modify(version2, ILLoadWorld_Version2);
		var LoadWorld = WF.GetMethod("LoadWorld", flag);
		MonoModHooks.Modify(LoadWorld, ILLoadWorld);


		var LoadHeader = WF.GetMethod("LoadHeader", flag);
		MonoModHooks.Modify(LoadHeader, il =>
		{
			var cursor = new ILCursor(il);
			ILLabel iLLabel = cursor.DefineLabel();
			cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0() && i.Next.MatchCallvirt(out var t)
				&& i.Next.Next.MatchStsfld(out var b) && b.Name == "dungeonX");
			cursor.EmitBr(iLLabel);
			cursor.Index += 6;
			cursor.MarkLabel(iLLabel);
		});


		Debug.Hack(WF, "LoadFileFormatHeader", flag, cursor =>
		{
			// 把有关importance的部分去掉, 放到另一个函数里用于wld文件load
			// 同时注意save也要修改

			// 	// ushort num2 = reader.ReadUInt16();
			// IL_0078: ldarg.0
			// IL_0079: callvirt instance uint16[System.Runtime]System.IO.BinaryReader::ReadUInt16()
			// IL_007e: stloc.1
			// 匹配到这里
			try
			{
				cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
				&& i.Next.MatchCallvirt(out var t) && t.Name == "ReadUInt16"
				&& i.Next.Next.MatchStloc1());
			}
			catch
			{
				Debug.Error("gotoNext LoadFileFormatHeader ReadUInt16 Error");
			}

			cursor.EmitLdcI4(1);
			cursor.EmitRet();
		});
	}

	public static void ILSaveFileFormatHeader(ILContext il)
	{
		var cursor = new ILCursor(il);
		cursor.GotoNext(MoveType.Before, i => i.MatchLdcI4(out var t) && t == 11);
		cursor.Remove();
		cursor.EmitLdcI4(4);

		try
		{
			cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
			&& i.Next.MatchLdloc0() && i.Next.Next.MatchCallvirt(out var t) && t.Name == "Write");
		}
		catch
		{
			Debug.Error("gotoNext SaveFileFormatHeader Write Error");
		}

		// 将有关importance的部分去除, 直接跳转到结尾
		ILLabel importanceEnd = cursor.DefineLabel();
		cursor.EmitBr(importanceEnd);

		try
		{
			cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
			&& i.Next.MatchCallvirt(out var t) && t.Name == "get_BaseStream");
		}
		catch
		{
			Debug.Error("gotoNext SaveFileFormatHeader get_BaseStream Error");
		}

		cursor.MarkLabel(importanceEnd);
	}

	public static void ILSaveWorldHeader(ILContext il)
	{
		/* TODO: 
			处理类似地牢坐标的可能原本在header中但无限世界后需要多个的数据
		*/
		var cursor = new ILCursor(il);
		cursor.GotoNext(MoveType.Before, i => i.Next != null
			&& i.Next.MatchLdsfld(out var t) && t.DeclaringType.FullName == "Terraria.Main"
			&& t.Name == "dungeonX");
		ILLabel ilLabel = cursor.DefineLabel();
		cursor.EmitBr(ilLabel);
		cursor.GotoNext(MoveType.Before, i => i != null
			&& i.MatchLdsfld(out var t) && t.DeclaringType.FullName == "Terraria.Main"
			&& t.Name == "dungeonY");
		cursor.Index += 2;
		cursor.MarkLabel(ilLabel);
	}

	public static void ILLoadWorld_Version2(ILContext il)
	{
		var cursor = new ILCursor(il);


		var LoadWorldTiles = typeof(WorldFile).GetMethod("LoadWorldTiles",
			BindingFlags.Public | BindingFlags.Static
		);
		cursor.GotoNext(MoveType.Before, i => i.Next.Next.MatchCall(LoadWorldTiles));
		cursor.Index -= 3;

		cursor.Remove();
		ILLabel br = cursor.DefineLabel();
		cursor.EmitBeq(br);
		// cursor.GotoNext(MoveType.Before, i => i.Next.Next.MatchCall(LoadWorldTiles));
		// ILLabel iLLabel = cursor.DefineLabel();
		// cursor.MarkLabel(br);
		// cursor.EmitBr(iLLabel);


		cursor.GotoNext(MoveType.Before, i => i.MatchLdsfld(out var t)
			&& t.Name == "_versionNumber" && t.DeclaringType.FullName == "Terraria.IO.WorldFile"
			&& i.Next.MatchLdcI4(220));
		cursor.MarkLabel(br);

		// 3355




		cursor.GotoNext(MoveType.Before, i => i.MatchLdcI4(10));
		cursor.Remove();
		cursor.EmitLdcI4(2);


		var LastMinuteFixes = typeof(WorldFile).GetMethod("LoadWorld_LastMinuteFixes",
			BindingFlags.Static | BindingFlags.NonPublic);
		cursor.GotoNext(MoveType.Before, i => i.MatchCall(LastMinuteFixes));

		ILLabel lLoadEndlessTR = cursor.DefineLabel();
		cursor.Index -= 3;
		cursor.Remove();
		cursor.EmitBeq(lLoadEndlessTR);

		// cursor.EmitLdarg0();
		// cursor.EmitDelegate<Action<BinaryReader>>(r => Debug.Error("rd " + r.BaseStream.Position.ToString()));

		cursor.GotoNext(MoveType.Before, i => i.MatchCall(LastMinuteFixes));
		cursor.MarkLabel(lLoadEndlessTR);
		cursor.EmitLdarg0();
		cursor.EmitDelegate<Action<BinaryReader>>(i => LoadEndlessTR(i));

	}


	public static void SetVersionNumber(int i)
	{
		versionNumber = i;
	}

	public static void ILLoadWorld(ILContext il)
	{
		var cursor = new ILCursor(il);

		cursor.GotoNext(MoveType.Before, i => i.MatchLdsfld(out var t) && i.Next.MatchLdcI4(0) && i.Next.Next.MatchBle(out var a));
		cursor.EmitLdloc(5);
		cursor.EmitDelegate(SetVersionNumber);


		var OnWorldLoad = typeof(SystemLoader).GetMethod(
			"OnWorldLoad",
			BindingFlags.Static | BindingFlags.Public
		);

		cursor.GotoNext(MoveType.Before, i => i.MatchCall(OnWorldLoad));
		cursor.EmitDelegate(() =>
		{
			LoadWorldWld(nowBlock, 0);
		});
	}

	public static void LoadWorldWld(int blockId, int extendingMapId)
	{
		nowLoading = extendingMapId;
		try
		{

			/* TODO: 
				处理地牢坐标, 以及其他可能原本在header中但无限世界后需要多个的数据
			*/
			using MemoryStream memoryStream = new MemoryStream(FileUtilities.ReadAllBytes(GetPath.GetWldPath(blockId), false));
			using BinaryReader binaryReader = new BinaryReader(memoryStream);
			bool[] importance;
			if (!LoadImportance(binaryReader, out importance))
			{
				Debug.Error("LoadImportance Error");
			}
			try
			{
				WorldFile.LoadWorldTiles(binaryReader, importance);
			}
			catch
			{
				Debug.Error("LoadWorldTiles Error");
			}

			WorldFile.LoadChests(binaryReader);
			WorldFile.LoadSigns(binaryReader);
			WorldFile.LoadNPCs(binaryReader);
			WorldFile.LoadTileEntities(binaryReader);
			WorldFile.LoadWeightedPressurePlates(binaryReader);
			WorldFile.LoadTownManager(binaryReader);
			WorldFile.LoadBestiary(binaryReader, versionNumber);

		}
		catch
		{
			throw new Exception("LoadWorldWlds error");
		}
	}

	public static bool LoadImportance(BinaryReader reader, out bool[] importance)
	{
		ushort num2 = reader.ReadUInt16();
		importance = new bool[num2];
		byte b = 0;
		byte b2 = 128;
		for (int i = 0; i < num2; i++)
		{
			if (b2 == 128)
			{
				b = reader.ReadByte();
				b2 = 1;
			}
			else
			{
				b2 = (byte)(b2 << 1);
			}

			if ((b & b2) == b2)
				importance[i] = true;
		}

		return true;
	}

	public static void HackSaveWorld()
	{
		var flag = BindingFlags.NonPublic | BindingFlags.Static;
		var InternalSaveWorld = typeof(WorldFile).GetMethod("InternalSaveWorld", flag);
		MonoModHooks.Modify(InternalSaveWorld, ILInternalSaveWorld);

		var flag_ = BindingFlags.Public | BindingFlags.Static;

		var SaveWorldHeader = typeof(WorldFile).GetMethod("SaveWorldHeader", flag_);
		MonoModHooks.Modify(SaveWorldHeader, ILSaveWorldHeader);


		var SaveFileFormatHeader = typeof(WorldFile).GetMethod("SaveFileFormatHeader", flag_);
		MonoModHooks.Modify(SaveFileFormatHeader, ILSaveFileFormatHeader);

	}

	public static void ILInternalSaveWorld(ILContext il)
	{
		var cursor = new ILCursor(il);
		// 用SaveWorldEWld替换SaveWorld_Version2
		MethodInfo version2 = typeof(Terraria.IO.WorldFile).GetMethod(
			"SaveWorld_Version2",
			BindingFlags.Static | BindingFlags.Public
		);
		cursor.GotoNext(MoveType.Before, i => i.MatchCall(version2));
		cursor.Remove();
		cursor.EmitDelegate(SaveWorldEWld);
		// 在文件夹内保存.wld文件
		cursor.GotoNext(MoveType.Before, i => i.MatchLdloc1() && i.Next.MatchLdloc0() &&
				 i.Next.Next.MatchLdarg0());
		cursor.EmitLdarg0();
		cursor.EmitDelegate(() =>
		{
			SaveWorldWld(nowBlock, 0);
		});

		// 备份世界文件前需要验证文件, 先把他去掉
		// TODO: 修改验证文件的函数valiateWorld

		var ValidateWorld = typeof(WorldFile).GetMethod("ValidateWorld", BindingFlags.Static | BindingFlags.Public);
		if (ValidateWorld == null)
		{
			Debug.Error("ILInternalSaveWorld: ValidateWorld == null");
		}
		cursor.GotoNext(MoveType.Before, i => i.MatchLdloc(8) && i.Next.MatchCall(ValidateWorld));
		cursor.RemoveRange(2);
		cursor.EmitLdcI4(1);

	}

	public static void SaveWorldWld(BinaryWriter writer)
	{
		/* TODO: 
			处理地牢坐标, 以及其他可能原本在header中但无限世界后需要多个的数据
		*/
		SaveImportance(writer); // 原本在fileformatheader里的内容, 与tile有关
		WorldFile.SaveWorldTiles(writer);
		WorldFile.SaveChests(writer);
		WorldFile.SaveSigns(writer);
		WorldFile.SaveNPCs(writer);
		WorldFile.SaveTileEntities(writer);
		WorldFile.SaveWeightedPressurePlates(writer);
		WorldFile.SaveTownManager(writer);
		WorldFile.SaveBestiary(writer);
	}

	public static int SaveImportance(BinaryWriter writer)
	{
		ushort count = Terraria.ID.TileID.Count;
		writer.Write(count);
		byte b = 0;
		byte b2 = 1;
		for (int i = 0; i < count; i++)
		{
			if (Main.tileFrameImportant[i])
				b = (byte)(b | b2);

			if (b2 == 128)
			{
				writer.Write(b);
				b = 0;
				b2 = 1;
			}
			else
			{
				b2 = (byte)(b2 << 1);
			}
		}

		if (b2 != 1)
			writer.Write(b);

		return (int)writer.BaseStream.Position;
	}



	

	public static void SaveWorldWld(int blockId, int extendingMapId)
	{
		nowSaving = extendingMapId;
		int num;
		byte[] array;

		using (MemoryStream memoryStream = new MemoryStream(7000000))
		{
			using (BinaryWriter writer = new BinaryWriter(memoryStream))
			{
				SaveWorldWld(writer);
			}
			array = memoryStream.ToArray();
			num = array.Length;
		}
		FileUtilities.Write(GetPath.GetWldPath(blockId), array, num, false);
		FileUtilities.Write(GetPath.GetWldBakPath(blockId), array, num, false);

	}

	public static int SaveEndlessTR(BinaryWriter writer) // 保存有关此模组的内容
	{
		writer.Write(WorldData.blockLeft);
		writer.Write(WorldData.blockRight);
		writer.Write(WorldData.nowBlock);
		return (int)writer.BaseStream.Position;
	}

	public static void LoadEndlessTR(BinaryReader reader)
	{
		WorldData.blockLeft = reader.ReadInt32();
		WorldData.blockRight = reader.ReadInt32();
		WorldData.nowBlock = reader.ReadInt32();
	}

	public static void SaveWorldEWld(BinaryWriter writer)
	{
		int[] pointers = [
			WorldFile.SaveFileFormatHeader(writer),
			WorldFile.SaveWorldHeader(writer),
			WorldFile.SaveCreativePowers(writer),
			SaveEndlessTR(writer),
		];

		WorldFile.SaveFooter(writer);
		WorldFile.SaveHeaderPointers(writer, pointers);
	}

	public class GetPath
	{
		public static string GetDirPath()
		{
			return Main.worldPathName[..^5];
		}

		public static string GetWldPath(int i)
		{
			return GetDirPath() + "\\" + Main.worldName + i.ToString() + ".wld";
		}

		public static string GetWldBakPath(int i)
	{
		return Path.ChangeExtension(GetWldPath(i), "bak");
	}
	}
}