using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.GameContent.Biomes;
using Terraria.WorldBuilding;

namespace EndlessTR.WorldGeneration;

partial class WorldGeneration
{
    private static void Dunes()
    {
        // progress.Message = Lang.gen[1].Value;
        // int random9 = passConfig.Get<WorldGenRange>("Count").GetRandom(genRand);

        double num1081 = (double)Main.maxTilesX / 4200.0;
        // GenVars.PyrX = new int[random9 + 3];
        // GenVars.PyrY = new int[random9 + 3];
        DunesBiome dunesBiome = GenVars.configuration.CreateBiome<DunesBiome>();
        // for (int num1082 = 0; num1082 < random9; num1082++)
        // {
        // progress.Set((double)num1082 / (double)random9);
        Point origin5 = Point.Zero;
        bool flag62 = false;
        int num1083 = 0;
        while (!flag62)
        {
            origin5 = RandomWorldPoint(0, 500, 0, 500);
            bool flag63 = Math.Abs(origin5.X - GenVars.jungleOriginX) < (int)(600.0 * num1081);
            bool flag64 = Math.Abs(origin5.X - Main.maxTilesX / 2) < 300;
            bool flag65 = origin5.X > GenVars.snowOriginLeft - 300 && origin5.X < GenVars.snowOriginRight + 300;
            num1083++;
            if (num1083 >= Main.maxTilesX)
                flag63 = false;

            if (num1083 >= Main.maxTilesX * 2)
                flag65 = false;

            flag62 = !(flag63 || flag64 || flag65);
        }

        dunesBiome.Place(origin5, GenVars.structures);
        if (config.PyramidCount > 0)
        {
            config.PyramidCount--;
            int num1084 = WorldGen.genRand.Next(origin5.X - 200, origin5.X + 200);
            for (int num1085 = 0; num1085 < Main.maxTilesY; num1085++)
            {
                if (tile[num1084, num1085].HasTile)
                {
                    GenVars.PyrX[GenVars.numPyr] = num1084;
                    GenVars.PyrY[GenVars.numPyr] = num1085 + 20;
                    GenVars.numPyr++;
                    break;
                }
            }
        }
        // }
    }
}