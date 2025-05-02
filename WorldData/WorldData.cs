using Terraria;

namespace EndlessTR.WorldData;

public class WorldData
{
    public int nowBlock = 0;
    public static Tile[,] tileLeft = new Tile[Main.maxTilesX, Main.maxTilesY];
    public static Tile[,] tileRight = new Tile[Main.maxTilesX, Main.maxTilesY];

    WorldData() { }
}