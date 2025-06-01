using Ionic.Zip;
using Microsoft.Build.Tasks;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using rail;
using ReLogic.OS;
using SteelSeries.GameSense;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

	public static void LogIL(ILContext il)
	{
		var sb = new StringBuilder();
		sb.AppendLine($"IL for {il.Method.Name}:");
		foreach (var instr in il.Instrs)
		{
			sb.AppendLine($"{instr.OpCode} {instr.Operand}");
		}
		EndlessTR.Log.Debug(sb.ToString());
	}
}

public class ExtendingMap
{
	private static Tile[][,] newTileBlocksLeft = { new Tile[Main.maxTilesX, Main.maxTilesY] };
	private static Tile[][,] newTileBlocksRight = { new Tile[Main.maxTilesX, Main.maxTilesY] };



	public static bool[] loaded = [false, false, false];

	public static bool GetLoaded(int blockId)
	{
		return loaded[blockId + 1];
	}

	public static void SetLoaded(int blockId, bool val)
	{
		loaded[blockId + 1] = val;
	}



	private Tile[,] selectTilemap(int block_id)
	{
		if (block_id < 0)
		{
			return newTileBlocksLeft[-(block_id - 1)];
		}
		else if (block_id > 0)
		{
			return newTileBlocksRight[block_id - 1];
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

public class ExtendingVars
{
	public static double ladyBugRainBoost;

	public static bool getGoodWorld;
	public static bool drunkWorld;
	public static bool tenthAnniversaryWorld;
	public static bool dontStarveWorld;
	public static bool notTheBeesWorld;
	public static bool remixWorld;
	public static bool noTrapsWorld;
	public static bool zenithWorld;
	public static bool afterPartyOfDoom;
	public static bool shimmerAlpha;
	public static bool shimmerDarken;
	public static bool shimmerBrightenDelay;

}

public class WorldData
{
	public static int nowBlock = 0;
	public static int nowGenerating = 0;

	public static int nowSaveAndLoad = 0;

	public static ExtendingMap MapData = new ExtendingMap();

	public static int blockLeft;

	public static int blockRight;

	public static int versionNumber;

	private static Task[] task = new Task[3];

	WorldData() { }
	public static void initiate() // 在世界生成时进行一些内容的初始化
	{
		blockLeft = blockRight = 0;
		nowBlock = 0;
	}

	public static void Hack()
	{
		HackUpdate();
	}

	public static void HackUpdate()
	{
		// 检查两边的块, 若没有生成, 则生成, 若有, 则加载
		var Update = typeof(Terraria.Player).GetMethod("Update", BindingFlags.Public | BindingFlags.Instance);
		if (Update == null)
		{
			Debug.Error("Update == null");
		}
		MonoModHooks.Modify(Update, il =>
		{
			ILCursor cursor = new ILCursor(il);
			var LoadBlocks_ = typeof(WorldData).GetMethod("LoadBlocks", BindingFlags.Static | BindingFlags.Public);
			if (LoadBlocks_ == null)
			{
				Debug.Error("LoadBlocks_ == null");
			}

			cursor.EmitCall(LoadBlocks_);
		});
	}

	/// <summary>
	/// 加载某一个块中的内容, 若未生成则会生成该块
	/// </summary>
	/// <param name="blockId"> 加载的块的编号 </param>
	/// <param name="tileMapId"> 对应extendingMap中的编号 </param>
	public static void LoadBlock(int blockId, int extendingMapId)
	{
		if (task[extendingMapId + 1] != null && !task[extendingMapId + 1].IsCompleted) return;
		task[extendingMapId + 1] = Task.Run(() =>
		{
			nowGenerating = extendingMapId;
			// 检查是否存在该block的文件, 若没有则生成
			if (!CheckBlockFile(blockId))
			{

				WorldGen.GenerateWorld(Main.ActiveWorldFileData.Seed);
				Ewld.SaveWorldWld(blockId, extendingMapId);
			}
			// 实际的加载代码
			Ewld.LoadWorldWld(blockId, extendingMapId);
		});
	}

	private static bool CheckBlockFile(int blockId) // 检查
	{
		return FileUtilities.Exists(Utils.GetPath.GetWldPath(blockId), false);
	}

	public static void LoadBlocks()
	{
		LoadBlock(nowBlock - 1, -1);
		LoadBlock(nowBlock + 1, 1);
	}


}

public static class GetTile
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Tile WorldGenGetTile(ref this Tilemap instance, int x, int y)
	{
		return WorldData.MapData[WorldData.nowGenerating, x, y];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Tile WorldFileGetTile(ref this Tilemap instance, int x, int y)
	{
		return WorldData.MapData[WorldData.nowSaveAndLoad, x, y];
	}
}