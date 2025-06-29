using Terraria;
using MonoMod.Cil;
using System.Reflection;
using System;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace EndlessTR.WorldGeneration;

internal class Tilemap
{
    public Tile this[int x, int y]
    {
        get
        {
            return WorldData.WorldData.MapData[WorldData.WorldData.nowGenerating, x, y];
        }
        set
        {
            WorldData.WorldData.MapData[WorldData.WorldData.nowGenerating, x, y] = value;
        }
    }
}

internal class Config
{
    public int PyramidCount;
}

public partial class WorldGeneration
{
    static private Tilemap tile;

    static private Config config;

    static private BiomeType nowGeneratingBiome;
    static public int[] BorderX;
    static public int[] PreviousBorderX;

    public static void GenerateBlock()
    {
        ResetBlock();
        // Dunes();
        MapGeneration.GenerateHeightMap();
    }

    public static void GenerateInitialBlock()
    {
        WorldGen.RandomizeWeather();
    }

    public static Point RandomWorldPoint(int top = 0, int right = 0, int bottom = 0, int left = 0)
    {
        return WorldGen.RandomWorldPoint(top, right, bottom, left);
    }
}

enum BiomeType
{
    None,
    Desert,
}

public class Hack
{

    /// <summary>
    /// 将do_worldGenCallBack中对GenerateWorld的调用修改成调用GenerateBlock
    /// </summary>
    public static void Hack_do_worldGenCallBack()
    {
        var flag = BindingFlags.Public | BindingFlags.Static;

        var method = typeof(WorldGen).GetMethod("do_worldGenCallBack", flag);
        if (method == null)
        {
            throw new Exception("method == null");
        }
        var clearWorld = typeof(WorldGen).GetMethod("clearWorld", flag);
        if (method == null)
        {
            throw new Exception("clearWorld == null");
        }

        var GenerateBlock = typeof(WorldGeneration).GetMethod("GenerateBlock", flag);

        MonoModHooks.Modify(method, il =>
        {
            ILCursor cursor = new(il);
            cursor.GotoNext(i => i.MatchCall(clearWorld));
            // 把调用GenerateWorld去掉
            cursor.RemoveRange(5);
            cursor.EmitCall(GenerateBlock);
        });

    }
}