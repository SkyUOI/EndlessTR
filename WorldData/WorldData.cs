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

    public static ExtendingMap MapData = new ExtendingMap();

    public static int blockNum;

    public static int versionNumber;

    WorldData() { }

    public static void initiate() // 在世界生成时进行一些内容的初始化
    {
        blockNum = 1;
        nowBlock = 0;
    }

    public static void Hack()
    {

    }
}