using MonoMod.Cil;
using System;
using System.IO;
using System.Reflection;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace EndlessTR.WorldData;

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

    public static ExtendingMap MapData = new ExtendingMap();

    public static int blockNum;

	public static bool[] importance;
	public static int versionNumber;

    WorldData() { }
    public static void initiate() // 在世界生成时进行一些内容的初始化
	{
		blockNum = 1;
		nowBlock = 0;
	}

	public static void Hack()
	{
		HackSaveWorld();
		// HackLoadWorld();
	}

	public static void HackLoadWorld()
	{
		var flag = BindingFlags.Public | BindingFlags.Static;
		var LoadWorld = typeof(WorldFile).GetMethod("LoadWorld", flag);
		MonoModHooks.Modify(LoadWorld, ILLoadWorld);
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

		MethodInfo version2 = typeof(WorldFile).GetMethod(
			"LoadWorld_Version2",
			BindingFlags.Static | BindingFlags.Public
		);
		cursor.GotoNext(MoveType.Before, i => i.MatchCall(version2));
		cursor.Remove();
		cursor.EmitLdarg0();
		cursor.EmitDelegate(LoadWorldEWld);

		MethodInfo OnWorldLoad = typeof(WorldFile).GetMethod(
			"OnWorldLoad",
			BindingFlags.Static | BindingFlags.Public
		);
		cursor.GotoNext(MoveType.Before, i => i.MatchCall(OnWorldLoad));
		cursor.EmitLdarg0();
		cursor.EmitDelegate(LoadWorldWlds);
		cursor.EmitRet();
	}

	public static void LoadWorldWlds(bool loadFromCloud)
	{
		bool flag = loadFromCloud && Terraria.Social.SocialAPI.Cloud != null;
		try
		{
			for (int i = 0; i < blockNum; ++i)
			{
				using MemoryStream memoryStream = new MemoryStream(FileUtilities.ReadAllBytes(Main.worldPathName, flag));
				using BinaryReader binaryReader = new BinaryReader(memoryStream);
				WorldFile.LoadWorldTiles(binaryReader, importance);
				WorldFile.LoadChests(binaryReader);
				WorldFile.LoadSigns(binaryReader);
				WorldFile.LoadNPCs(binaryReader);
				WorldFile.LoadTileEntities(binaryReader);
				WorldFile.LoadWeightedPressurePlates(binaryReader);
				WorldFile.LoadTownManager(binaryReader);
				WorldFile.LoadBestiary(binaryReader, versionNumber);
			}
		}
		catch
		{
			throw new Exception("LoadWorldWlds error");
		}
	}

	public static int LoadWorldEWld(BinaryReader reader)
	{
		reader.BaseStream.Position = 0L;
		if (!WorldFile.LoadFileFormatHeader(reader, out importance, out var positions))
			return 5;

		if (reader.BaseStream.Position != positions[0])
			return 5;

		WorldFile.LoadHeader(reader);
		if (reader.BaseStream.Position != positions[1])
			return 5;


		if (versionNumber >= 220)
		{
			WorldFile.LoadCreativePowers(reader, versionNumber);
			if (reader.BaseStream.Position != positions[10])
				return 5;
		}

		LoadEndlessTR(reader);


		// WorldFile.LoadWorld_LastMinuteFixes();
		return WorldFile.LoadFooter(reader);
	}

	

	public static void HackSaveWorld()
	{
		var flag = BindingFlags.NonPublic | BindingFlags.Static;
		var InternalSaveWorld = typeof(WorldFile).GetMethod("InternalSaveWorld", flag);
		MonoModHooks.Modify(InternalSaveWorld, ILInternalSaveWorld);
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
		cursor.EmitDelegate(SaveWorldWlds);
	}

	public static void SaveWorldWld(BinaryWriter writer)
	{
		int[] pointers = new int[] {
			WorldFile.SaveWorldTiles(writer),
			WorldFile.SaveChests(writer),
			WorldFile.SaveSigns(writer),
			WorldFile.SaveNPCs(writer),
			WorldFile.SaveTileEntities(writer),
			WorldFile.SaveWeightedPressurePlates(writer),
			WorldFile.SaveTownManager(writer),
			WorldFile.SaveBestiary(writer),
		};
		WorldFile.SaveHeaderPointers(writer, pointers);
	}
	public static string GetWldPath(int i)
	{
		return Main.worldPathName[..^5] + "\\" + Main.worldName + i.ToString();
	}

	public static void SaveWorldWlds(bool useCloudSaving)
	{
		int num;
		byte[] array;
		for (int i = 0; i < blockNum; ++i)
		{
			using (MemoryStream memoryStream = new MemoryStream(7000000))
			{
				using (BinaryWriter writer = new BinaryWriter(memoryStream))
				{
					SaveWorldWld(writer);
				}
				array = memoryStream.ToArray();
				num = array.Length;
			}
			FileUtilities.Write(GetWldPath(i), array, num, useCloudSaving);
		}
	}

	public static int SaveEndlessTR(BinaryWriter writer) // 保存有关此模组的内容
	{
		writer.Write(WorldData.blockNum);
		writer.Write(WorldData.nowBlock);
		return (int)writer.BaseStream.Position;
	}

	public static void LoadEndlessTR(BinaryReader reader)
	{
		WorldData.blockNum = reader.ReadInt32();
		WorldData.blockNum = reader.ReadInt32();
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


}