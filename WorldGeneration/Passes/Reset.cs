using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.WorldBuilding;

namespace EndlessTR.WorldGeneration;

partial class WorldGeneration
{
    /// <summary>
    /// 对应代码中的"Reset" Pass
    /// </summary>
    public static void ResetBlock()
    {
        Liquid.ReInit();
        WorldGen.SetupStatueList();
        Main.checkXMas();
        Main.checkHalloween();

        // WorldGen
        var type = typeof(WorldGen);
        var ResetGenerator = type.GetMethod("ResetGenerator", BindingFlags.NonPublic | BindingFlags.Static);
        ResetGenerator.Invoke(null, null);

        List<int> list3 = new List<int> {
                274,
                220,
                112,
                218,
                3019
            };

        List<int> list4 = new List<int>();
        while (list3.Count > 0)
        {
            int index = WorldGen.genRand.Next(list3.Count);
            int item = list3[index];
            list4.Add(item);
            list3.RemoveAt(index);
        }

        GenVars.hellChestItem = list4.ToArray();
        int num1086 = 86400;
        Main.slimeRainTime = -WorldGen.genRand.Next(num1086 * 2, num1086 * 3);
        Main.cloudBGActive = -WorldGen.genRand.Next(8640, 86400);

        if (GenVars.jungleHut == 0)
            GenVars.jungleHut = 119;
        else if (GenVars.jungleHut == 1)
            GenVars.jungleHut = 120;
        else if (GenVars.jungleHut == 2)
            GenVars.jungleHut = 158;
        else if (GenVars.jungleHut == 3)
            GenVars.jungleHut = 175;
        else if (GenVars.jungleHut == 4)
            GenVars.jungleHut = 45;

        // ?
        // RandomizeTreeStyle();
        // RandomizeCaveBackgrounds();
        // RandomizeBackgrounds(genRand);
        // TreeTops.CopyExistingWorldInfoForWorldGeneration();

        int minValue3 = 15;
        int maxValue12 = 30;

        if (GenVars.dungeonSide == -1)
        {
            double num1089 = 1.0 - (double)WorldGen.genRand.Next(minValue3, maxValue12) * 0.01;
            GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num1089);
        }
        else
        {
            double num1090 = (double)WorldGen.genRand.Next(minValue3, maxValue12) * 0.01;
            GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num1090);
        }

        int num1091 = WorldGen.genRand.Next(Main.maxTilesX);

        if (GenVars.dungeonSide == 1)
        {
            while ((double)num1091 < (double)Main.maxTilesX * 0.6 || (double)num1091 > (double)Main.maxTilesX * 0.75)
            {
                num1091 = WorldGen.genRand.Next(Main.maxTilesX);
            }
        }
        else
        {
            while ((double)num1091 < (double)Main.maxTilesX * 0.25 || (double)num1091 > (double)Main.maxTilesX * 0.4)
            {
                num1091 = WorldGen.genRand.Next(Main.maxTilesX);
            }
        }

        int num1092 = WorldGen.genRand.Next(50, 90);
        double num1093 = (double)Main.maxTilesX / 4200.0;
        num1092 += (int)((double)WorldGen.genRand.Next(20, 40) * num1093);
        num1092 += (int)((double)WorldGen.genRand.Next(20, 40) * num1093);
        int num1094 = num1091 - num1092;
        num1092 = WorldGen.genRand.Next(50, 90);
        num1092 += (int)((double)WorldGen.genRand.Next(20, 40) * num1093);
        num1092 += (int)((double)WorldGen.genRand.Next(20, 40) * num1093);
        int num1095 = num1091 + num1092;
        if (num1094 < 0)
            num1094 = 0;

        if (num1095 > Main.maxTilesX)
            num1095 = Main.maxTilesX;

        GenVars.snowOriginLeft = num1094;
        GenVars.snowOriginRight = num1095;
        GenVars.leftBeachEnd = WorldGen.genRand.Next(GenVars.beachSandRandomCenter - GenVars.beachSandRandomWidthRange, GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange);

        if (GenVars.dungeonSide == 1)
            GenVars.leftBeachEnd += GenVars.beachSandDungeonExtraWidth;
        else
            GenVars.leftBeachEnd += GenVars.beachSandJungleExtraWidth;

        GenVars.rightBeachStart = Main.maxTilesX - WorldGen.genRand.Next(GenVars.beachSandRandomCenter - GenVars.beachSandRandomWidthRange, GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange);

        if (GenVars.dungeonSide == -1)
            GenVars.rightBeachStart -= GenVars.beachSandDungeonExtraWidth;
        else
            GenVars.rightBeachStart -= GenVars.beachSandJungleExtraWidth;

        int num1096 = 50;
        if (GenVars.dungeonSide == -1)
            GenVars.dungeonLocation = WorldGen.genRand.Next(GenVars.leftBeachEnd + num1096, (int)((double)Main.maxTilesX * 0.2));
        else
            GenVars.dungeonLocation = WorldGen.genRand.Next((int)((double)Main.maxTilesX * 0.8), GenVars.rightBeachStart - num1096);

        int num1097 = 0;
        if (Main.maxTilesX >= 8400)
            num1097 = 2;
        else if (Main.maxTilesX >= 6400)
            num1097 = 1;

        GenVars.extraBastStatueCountMax = 2 + num1097;
        Main.tileSolid[659] = false;
    }
}