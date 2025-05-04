using MonoMod.Cil;
using System;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.ID;
using Terraria.WorldBuilding;

namespace EndlessTR.WorldGeneration;

public class EvilGeneration
{
    public static void HackAllFunc()
    {
        WorldGen.ModifyPass((PassLegacy)WorldGen.VanillaGenPasses["Corruption"], ILGenerateEvil);
    }

    private static void ILGenerateEvil(ILContext il)
    {
        var cursor = new ILCursor(il);
        cursor.EmitLdarg0();
        cursor.EmitLdarg1();
        cursor.EmitDelegate(GenerateEvil);
        cursor.EmitRet();
    }

    public static void GenerateEvil(GenerationProgress progress, GameConfiguration passConfig)
    {
        int AvailableMaxBorderSide1 = Main.maxTilesX;
        int AvailableMinBorderSide1 = 0;
        int AvailableMaxBorderSide2 = Main.maxTilesX;
        int AvailableMinBorderSide2 = 0;
        for (int i = 0; i < Main.maxTilesX; i++)
        {
            for (int j = 0; (double)j < Main.worldSurface; j++)
            {
                if (Main.tile[i, j].HasTile)
                {
                    if (Main.tile[i, j].TileType == TileID.JungleGrass)
                    {
                        if (i < AvailableMaxBorderSide1)
                            AvailableMaxBorderSide1 = i;

                        if (i > AvailableMinBorderSide1)
                            AvailableMinBorderSide1 = i;
                    }
                    else if (Main.tile[i, j].TileType == TileID.SnowBlock || Main.tile[i, j].TileType == TileID.IceBlock)
                    {
                        if (i < AvailableMaxBorderSide2)
                            AvailableMaxBorderSide2 = i;

                        if (i > AvailableMinBorderSide2)
                            AvailableMinBorderSide2 = i;
                    }
                }
            }
        }

        int ShortenSize = 10;
        AvailableMaxBorderSide1 -= ShortenSize;
        AvailableMinBorderSide1 += ShortenSize;
        AvailableMaxBorderSide2 -= ShortenSize;
        AvailableMinBorderSide2 += ShortenSize;
        int[] AvailableBorders = [
            AvailableMaxBorderSide1,
            AvailableMinBorderSide1,
            AvailableMaxBorderSide2,
            AvailableMinBorderSide2,
        ];
        int num785 = 500;
        int num786 = 100;
        double EvilAreaNum = (double)Main.maxTilesX * 0.00045;

        CrimsonAndCorruptionGenerate(progress, EvilAreaNum, AvailableBorders, num785, num786);
    }

    private static void CrimsonAndCorruptionGenerate(GenerationProgress progress, double EvilAreaNum, int[] AvailableBorders, int num785, int num786)
    {
        progress.Message = Lang.gen[20].Value;
        for (int i = 0; (double)i < EvilAreaNum; i++)
        {
            int num789 = AvailableBorders[0];//AvailableMaxBorderSide2;
            int num790 = AvailableBorders[1];//AvailableMinBorderSide2;
            int num791 = AvailableBorders[2];//AvailableMaxBorderSide1;
            int num792 = AvailableBorders[3];//AvailableMinBorderSide1;
            double GeneratingProgress = (double)i / EvilAreaNum;
            progress.Set(GeneratingProgress);
            bool IsPositionOk = false;
            int num793 = 0;
            int EvilLeftBorder = 0;
            int EvilRightBorder = 0;
            while (!IsPositionOk)
            {
                IsPositionOk = true;
                int WorldMid = Main.maxTilesX / 2;
                int num797 = 200;

                num793 = WorldGen.genRand.Next(num785, Main.maxTilesX - num785);

                EvilLeftBorder = num793 - WorldGen.genRand.Next(200) - 100;
                EvilRightBorder = num793 + WorldGen.genRand.Next(200) + 100;
                if (EvilLeftBorder < GenVars.evilBiomeBeachAvoidance)
                    EvilLeftBorder = GenVars.evilBiomeBeachAvoidance;

                if (EvilRightBorder > Main.maxTilesX - GenVars.evilBiomeBeachAvoidance)
                    EvilRightBorder = Main.maxTilesX - GenVars.evilBiomeBeachAvoidance;

                if (num793 < EvilLeftBorder + GenVars.evilBiomeAvoidanceMidFixer)
                    num793 = EvilLeftBorder + GenVars.evilBiomeAvoidanceMidFixer;

                if (num793 > EvilRightBorder - GenVars.evilBiomeAvoidanceMidFixer)
                    num793 = EvilRightBorder - GenVars.evilBiomeAvoidanceMidFixer;

                if (GenVars.dungeonSide < 0 && EvilLeftBorder < 400)
                    EvilLeftBorder = 400;
                else if (GenVars.dungeonSide > 0 && EvilLeftBorder > Main.maxTilesX - 400)
                    EvilLeftBorder = Main.maxTilesX - 400;

                if (EvilLeftBorder < GenVars.dungeonLocation + num786 && EvilRightBorder > GenVars.dungeonLocation - num786)
                    IsPositionOk = false;

                if (num793 > WorldMid - num797 && num793 < WorldMid + num797)
                    IsPositionOk = false;

                if (EvilLeftBorder > WorldMid - num797 && EvilLeftBorder < WorldMid + num797)
                    IsPositionOk = false;

                if (EvilRightBorder > WorldMid - num797 && EvilRightBorder < WorldMid + num797)
                    IsPositionOk = false;

                if (num793 > GenVars.UndergroundDesertLocation.X && num793 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
                    IsPositionOk = false;

                if (EvilLeftBorder > GenVars.UndergroundDesertLocation.X && EvilLeftBorder < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
                    IsPositionOk = false;

                if (EvilRightBorder > GenVars.UndergroundDesertLocation.X && EvilRightBorder < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
                    IsPositionOk = false;

                if (EvilLeftBorder < num790 && EvilRightBorder > num789)
                {
                    num789++;
                    num790--;
                    IsPositionOk = false;
                }

                if (EvilLeftBorder < num792 && EvilRightBorder > num791)
                {
                    num791++;
                    num792--;
                    IsPositionOk = false;
                }
            }
            int evilType = WorldGen.genRand.Next(2);
            if (evilType == 1) // 生成猩红
            {
                OneCrimsonGenerate(num793, EvilLeftBorder, EvilRightBorder);
            }
            else // 生成腐化
            {
                OneCorruptionGenerate(num793, EvilLeftBorder, EvilRightBorder);
            }
        }
    }

    private static void OneCrimsonGenerate(int num793, int EvilLeftBorder, int EvilRightBorder)
    {
        WorldGen.CrimStart(num793, (int)GenVars.worldSurfaceLow - 10);
        // 猩红化丛林
        for (int j = EvilLeftBorder; j < EvilRightBorder; j++)
        {
            for (int k = (int)GenVars.worldSurfaceLow; (double)k < Main.worldSurface - 1.0; k++)
            {
                if (Main.tile[j, k].HasTile)
                {
                    int num800 = k + WorldGen.genRand.Next(10, 14);
                    for (int m = k; m < num800; m++)
                    {
                        if (Main.tile[j, m].TileType == TileID.JungleGrass && j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j < EvilRightBorder - WorldGen.genRand.Next(5))
                            Main.tile[j, m].TileType = TileID.CrimsonJungleGrass;
                    }
                    break;
                }
            }
        }

        double y_limit = Main.worldSurface + 40.0;
        for (int j = EvilLeftBorder; j < EvilRightBorder; j++)
        {
            // 防止生成在地表
            y_limit += (double)WorldGen.genRand.Next(-2, 3);
            if (y_limit < Main.worldSurface + 30.0)
                y_limit = Main.worldSurface + 30.0;

            if (y_limit > Main.worldSurface + 50.0)
                y_limit = Main.worldSurface + 50.0;

            bool flag51 = false;
            for (int k = (int)GenVars.worldSurfaceLow; (double)k < y_limit; k++)
            {
                if (Main.tile[j, k].HasTile)
                {

                    if (Main.tile[j, k].TileType == TileID.Sand && j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j <= EvilRightBorder - WorldGen.genRand.Next(5))
                        Main.tile[j, k].TileType = TileID.Crimsand;

                    if ((double)k < Main.worldSurface - 1.0 && !flag51)
                    {
                        if (Main.tile[j, k].TileType == TileID.Dirt)
                        {
                            WorldGen.grassSpread = 0;
                            WorldGen.SpreadGrass(j, k, 0, TileID.CrimsonGrass);
                        }
                        else if (Main.tile[j, k].TileType == TileID.Mud)
                        {
                            WorldGen.grassSpread = 0;
                            WorldGen.SpreadGrass(j, k, 59, TileID.CrimsonJungleGrass);
                        }
                    }

                    flag51 = true;
                    // 猩红化
                    if (Main.tile[j, k].WallType == WallID.HardenedSand)
                        Main.tile[j, k].WallType = WallID.CrimsonHardenedSand;
                    else if (Main.tile[j, k].WallType == WallID.Sandstone)
                        Main.tile[j, k].WallType = WallID.CrimsonSandstone;

                    if (Main.tile[j, k].TileType == TileID.Stone)
                    {
                        if (j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j <= EvilRightBorder - WorldGen.genRand.Next(5))
                            Main.tile[j, k].TileType = TileID.Crimstone;
                    }
                    else if (Main.tile[j, k].TileType == TileID.Grass)
                    {
                        Main.tile[j, k].TileType = TileID.CrimsonGrass;
                    }
                    else if (Main.tile[j, k].TileType == TileID.JungleGrass)
                    {
                        Main.tile[j, k].TileType = TileID.CrimsonJungleGrass;
                    }
                    else if (Main.tile[j, k].TileType == TileID.IceBlock)
                    {
                        Main.tile[j, k].TileType = TileID.FleshIce;
                    }
                    else if (Main.tile[j, k].TileType == TileID.Sandstone)
                    {
                        Main.tile[j, k].TileType = TileID.CrimsonSandstone;
                    }
                    else if (Main.tile[j, k].TileType == TileID.HardenedSand)
                    {
                        Main.tile[j, k].TileType = TileID.CrimsonHardenedSand;
                    }
                }
            }
        }

        // 生成猩红祭坛
        int AlterNums = WorldGen.genRand.Next(10, 15);
        for (int j = 0; j < AlterNums; j++)
        {
            int num807 = 0;
            bool AltarGenerateFinish = false;
            int num808 = 0;
            while (!AltarGenerateFinish)
            {
                num807++;
                int x_pos = WorldGen.genRand.Next(EvilLeftBorder - num808, EvilRightBorder + num808);
                int y_pos = WorldGen.genRand.Next((int)(Main.worldSurface - (double)(num808 / 2)), (int)(Main.worldSurface + 100.0 + (double)num808));
                // 调整祭坛到合适的位置进行生成
                while (WorldGen.oceanDepths(x_pos, y_pos))
                {
                    x_pos = WorldGen.genRand.Next(EvilLeftBorder - num808, EvilRightBorder + num808);
                    y_pos = WorldGen.genRand.Next((int)(Main.worldSurface - (double)(num808 / 2)), (int)(Main.worldSurface + 100.0 + (double)num808));
                }

                if (num807 > 100)
                {
                    num808++;
                    num807 = 0;
                }

                if (!Main.tile[x_pos, y_pos].HasTile)
                {
                    for (; !Main.tile[x_pos, y_pos].HasTile; y_pos++)
                    {
                    }

                    y_pos--;
                }
                else
                {
                    while (Main.tile[x_pos, y_pos].HasTile && (double)y_pos > Main.worldSurface)
                    {
                        y_pos--;
                    }
                }

                if ((num808 > 10 || (Main.tile[x_pos, y_pos + 1].HasTile && Main.tile[x_pos, y_pos + 1].TileType == TileID.Crimstone)) && !WorldGen.IsTileNearby(x_pos, y_pos, TileID.DemonAltar, 3))
                {
                    WorldGen.Place3x2(x_pos, y_pos, TileID.DemonAltar, 1);
                    if (Main.tile[x_pos, y_pos].TileType == TileID.DemonAltar)
                        AltarGenerateFinish = true;
                }

                if (num808 > 100)
                    AltarGenerateFinish = true;
            }
        }
        WorldGen.CrimPlaceHearts();
    }

    private static void OneCorruptionGenerate(int num816, int EvilLeftBorder, int EvilRightBorder)
    {
        int ChasmGenerateWaitCounter = 0;
        for (int j = EvilLeftBorder; j < EvilRightBorder; j++)
        {
            // 不断移动，直到计数器归零，往下挖峡谷
            if (ChasmGenerateWaitCounter > 0)
                ChasmGenerateWaitCounter--;

            if (j == num816 || ChasmGenerateWaitCounter == 0)
            {
                for (int k = (int)GenVars.worldSurfaceLow; (double)k < Main.worldSurface - 1.0; k++)
                {
                    if (Main.tile[j, k].HasTile || Main.tile[j, k].WallType > 0)
                    {
                        if (j == num816)
                        {
                            ChasmGenerateWaitCounter = 20;
                            WorldGen.ChasmRunner(j, k, WorldGen.genRand.Next(150) + 150, makeOrb: true);
                        }
                        else if (WorldGen.genRand.NextBool(35) && ChasmGenerateWaitCounter == 0)
                        {
                            ChasmGenerateWaitCounter = 30;
                            bool makeOrb = true;
                            WorldGen.ChasmRunner(j, k, WorldGen.genRand.Next(50) + 50, makeOrb);
                        }

                        break;
                    }
                }
            }

            for (int k = (int)GenVars.worldSurfaceLow; (double)k < Main.worldSurface - 1.0; k++)
            {
                if (Main.tile[j, k].HasTile)
                {
                    int num825 = k + WorldGen.genRand.Next(10, 14);
                    for (int num826 = k; num826 < num825; num826++)
                    {
                        if (Main.tile[j, num826].TileType == TileID.JungleGrass && j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j < EvilRightBorder - WorldGen.genRand.Next(5))
                            Main.tile[j, num826].TileType = TileID.CorruptJungleGrass;
                    }

                    break;
                }
            }
        }

        double y_pos = Main.worldSurface + 40.0;
        for (int j = EvilLeftBorder; j < EvilRightBorder; j++)
        {
            // 地面向下一段距离
            // 防止生成到错误的位置
            y_pos += (double)WorldGen.genRand.Next(-2, 3);
            if (y_pos < Main.worldSurface + 30.0)
                y_pos = Main.worldSurface + 30.0;

            if (y_pos > Main.worldSurface + 50.0)
                y_pos = Main.worldSurface + 50.0;

            bool flag54 = false;
            for (int k = (int)GenVars.worldSurfaceLow; (double)k < y_pos; k++)
            {
                if (Main.tile[j, k].HasTile)
                {
                    if (Main.tile[j, k].TileType == TileID.Sand && j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j <= EvilRightBorder - WorldGen.genRand.Next(5))
                        Main.tile[j, k].TileType = TileID.Ebonsand;

                    if ((double)k < Main.worldSurface - 1.0 && !flag54)
                    {
                        if (Main.tile[j, k].TileType == TileID.Dirt)
                        {
                            WorldGen.grassSpread = 0;
                            WorldGen.SpreadGrass(j, k, 0, 23);
                        }
                        else if (Main.tile[j, k].TileType == TileID.Mud)
                        {
                            WorldGen.grassSpread = 0;
                            WorldGen.SpreadGrass(j, k, 59, TileID.CorruptJungleGrass);
                        }
                    }

                    flag54 = true;
                    // 将原本正常的物品腐化掉
                    if (Main.tile[j, k].WallType == WallID.HardenedSand)
                        Main.tile[j, k].WallType = WallID.CorruptHardenedSand;
                    else if (Main.tile[j, k].WallType == WallID.Sandstone)
                        Main.tile[j, k].WallType = WallID.CorruptSandstone;

                    if (Main.tile[j, k].TileType == TileID.Stone)
                    {
                        if (j >= EvilLeftBorder + WorldGen.genRand.Next(5) && j <= EvilRightBorder - WorldGen.genRand.Next(5))
                            Main.tile[j, k].TileType = TileID.Ebonstone;
                    }
                    else if (Main.tile[j, k].TileType == TileID.Grass)
                    {
                        Main.tile[j, k].TileType = TileID.CorruptGrass;
                    }
                    else if (Main.tile[j, k].TileType == TileID.JungleGrass)
                    {
                        Main.tile[j, k].TileType = TileID.CorruptJungleGrass;
                    }
                    else if (Main.tile[j, k].TileType == TileID.IceBlock)
                    {
                        Main.tile[j, k].TileType = TileID.CorruptIce;
                    }
                    else if (Main.tile[j, k].TileType == TileID.Sandstone)
                    {
                        Main.tile[j, k].TileType = TileID.CorruptSandstone;
                    }
                    else if (Main.tile[j, k].TileType == TileID.HardenedSand)
                    {
                        Main.tile[j, k].TileType = TileID.CorruptHardenedSand;
                    }
                }
            }
        }

        // 放置暗影珠
        for (int j = EvilLeftBorder; j < EvilRightBorder; j++)
        {
            for (int k = 0; k < Main.maxTilesY - 50; k++)
            {
                if (Main.tile[j, k].HasTile && Main.tile[j, k].TileType == TileID.ShadowOrbs)
                {
                    int LeftBorder = j - 13;
                    int RightBorder = j + 13;
                    int TopBorder = k - 13;
                    int BottomBorder = k + 13;
                    for (int m = LeftBorder; m < RightBorder; m++)
                    {
                        if (m > 10 && m < Main.maxTilesX - 10)
                        {
                            for (int n = TopBorder; n < BottomBorder; n++)
                            {
                                if (Math.Abs(m - j) + Math.Abs(n - k) < 9 + WorldGen.genRand.Next(11) && !WorldGen.genRand.NextBool(3) && Main.tile[m, n].TileType != TileID.ShadowOrbs)
                                {
                                    var tmp = Main.tile[m, n];
                                    tmp.HasTile = true;
                                    Main.tile[m, n].TileType = TileID.Ebonstone;
                                    if (Math.Abs(m - j) <= 1 && Math.Abs(n - k) <= 1)
                                        tmp = Main.tile[m, n];
                                    tmp.HasTile = false;
                                }

                                if (Main.tile[m, n].TileType != TileID.ShadowOrbs && Math.Abs(m - j) <= 2 + WorldGen.genRand.Next(3) && Math.Abs(n - k) <= 2 + WorldGen.genRand.Next(3))
                                {
                                    var tmp = Main.tile[m, n];
                                    tmp.HasTile = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}