using System;
using Terraria;

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

    WorldData() { }
}