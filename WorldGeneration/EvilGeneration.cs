using MonoMod.Cil;
using ReLogic.Utilities;
using System;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;
using static tModPorter.ProgressUpdate;

namespace EndlessTR.WorldGeneration;

public class EvilGeneration
{
    public static void HackAllFunc()
    {
        WorldGen.ModifyPass((PassLegacy)WorldGen.VanillaGenPasses["Corruption"], ILGenerateEvil);
        WorldGen.ModifyPass((PassLegacy)WorldGen.VanillaGenPasses["Altars"], ILGenerateAltars);
        WorldGen.ModifyPass((PassLegacy)WorldGen.VanillaGenPasses["Tile Cleanup"], ILTileClean);
    }

    private static void ILGenerateEvil(ILContext il)
    {
        var cursor = new ILCursor(il);
        cursor.EmitLdarg0();
        cursor.EmitLdarg1();
        cursor.EmitDelegate(GenerateEvil);
        cursor.EmitRet();
    }

    private static void ILGenerateAltars(ILContext il)
    {
        var cursor = new ILCursor(il); cursor.EmitLdarg0();
        cursor.EmitLdarg1();
        cursor.EmitDelegate(GenerateAltar);
        cursor.EmitRet();
    }

    private static void ILTileClean(ILContext il)
    {
        var cursor = new ILCursor(il); cursor.EmitLdarg0();
        cursor.EmitLdarg1();
        cursor.EmitDelegate(TileClean);
        cursor.EmitRet();
    }


    /// <summary>
    /// 该函数的主要更改在于每一片邪恶地形都是随机生成的，并删除了特殊种子，同时进行了一定的重构和拆分
    /// </summary>
    /// <param name="progress"></param>
    /// <param name="passConfig"></param>
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
                                    {
                                        tmp = Main.tile[m, n];
                                        tmp.HasTile = false;
                                    }
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

    /// <summary>
    /// 该函数的主要更改在于，使得每个放置的野生祭坛都随机为腐化或猩红
    /// </summary>
    /// <param name="progress"></param>
    /// <param name="passConfig"></param>
    private static void GenerateAltar(GenerationProgress progress, GameConfiguration passConfig)
    {
        Main.tileSolid[484] = false;
        progress.Message = Lang.gen[26].Value;
        int AltarNums = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3.3E-06);

        for (int i = 0; i < AltarNums; i++)
        {
            progress.Set((double)i / (double)AltarNums);
            for (int j = 0; j < 10000; j++)
            {
                int num663 = WorldGen.genRand.Next(281, Main.maxTilesX - 3 - 280);
                while ((double)num663 > (double)Main.maxTilesX * 0.45 && (double)num663 < (double)Main.maxTilesX * 0.55)
                {
                    num663 = WorldGen.genRand.Next(281, Main.maxTilesX - 3 - 280);
                }

                int num664 = WorldGen.genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, (int)(Main.rockLayer + (double)((Main.maxTilesY - 350) * 2)) / 3);

                while (WorldGen.oceanDepths(num663, num664) || Vector2D.Distance(new Vector2D(num663, num664), GenVars.shimmerPosition) < (double)WorldGen.shimmerSafetyDistance)
                {
                    num663 = WorldGen.genRand.Next(281, Main.maxTilesX - 3 - 280);
                    while ((double)num663 > (double)Main.maxTilesX * 0.45 && (double)num663 < (double)Main.maxTilesX * 0.55)
                    {
                        num663 = WorldGen.genRand.Next(281, Main.maxTilesX - 3 - 280);
                    }

                    num664 = WorldGen.genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, (int)(Main.rockLayer + (double)((Main.maxTilesY - 350) * 2)) / 3);
                }

                int style2 = WorldGen.genRand.Next(0, 1);

                if (!WorldGen.IsTileNearby(num663, num664, TileID.DemonAltar, 3))
                    WorldGen.Place3x2(num663, num664, TileID.DemonAltar, style2);

                if (Main.tile[num663, num664].TileType == TileID.DemonAltar)
                    break;
            }
        }
    }

    /// <summary>
    /// 该函数的主要更改逻辑是从判断替换祭坛处前加一个判断祭坛类型，并删除特殊种子
    /// </summary>
    /// <param name="progress"></param>
    /// <param name="passConfig"></param>
    private static void TileClean(GenerationProgress progress, GameConfiguration passConfig)
    {
        progress.Message = Lang.gen[84].Value;
        for (int i = 40; i < Main.maxTilesX - 40; i++)
        {
            progress.Set((double)(i - 40) / (double)(Main.maxTilesX - 80));
            for (int j = 40; j < Main.maxTilesY - 40; j++)
            {
                if (Main.tile[i, j].HasTile && Main.tile[i, j].TopSlope && ((Main.tile[i, j].LeftSlope && Main.tile[i + 1, j].IsHalfBlock) || (Main.tile[i, j].RightSlope && Main.tile[i - 1, j].IsHalfBlock)))
                {
                    var tmp = Main.tile[i, j];
                    tmp.Slope = 0;
                    tmp.IsHalfBlock = true;
                }

                if (Main.tile[i, j].HasTile && Main.tile[i, j].LiquidAmount > 0 && TileID.Sets.SlowlyDiesInWater[Main.tile[i, j].TileType])
                    WorldGen.KillTile(i, j);

                if (!Main.tile[i, j].HasTile && Main.tile[i, j].LiquidAmount == 0 && !WorldGen.genRand.NextBool(3) && WorldGen.SolidTile(i, j - 1))
                {
                    int length = WorldGen.genRand.Next(15, 21);
                    for (int k = j - 2; k >= j - length; k--)
                    {
                        if (Main.tile[i, k].LiquidAmount >= 128 && !(Main.tile[i, k].LiquidType == LiquidID.Shimmer))
                        {
                            int num68 = 373;
                            if (Main.tile[i, k].LiquidType == LiquidID.Lava)
                                num68 = 374;
                            else if (Main.tile[i, k].LiquidType == LiquidID.Honey)
                                num68 = 375;

                            int maxValue3 = j - k;
                            if (WorldGen.genRand.Next(maxValue3) <= 1)
                            {
                                if (Main.tile[i, j].WallType == 86)
                                    num68 = 375;

                                Main.tile[i, j].TileType = (ushort)num68;
                                Main.tile[i, j].TileFrameX = 0;
                                Main.tile[i, j].TileFrameY = 0;
                                var tmp = Main.tile[i, j];
                                tmp.HasTile = true;
                                break;
                            }
                        }
                    }

                    if (!Main.tile[i, j].HasTile)
                    {
                        length = WorldGen.genRand.Next(3, 11);
                        for (int num69 = j + 1; num69 <= j + length; num69++)
                        {
                            if (Main.tile[i, num69].LiquidAmount >= 200 && !(Main.tile[i, num69].LiquidType == LiquidID.Shimmer))
                            {
                                int num70 = 373;
                                if (Main.tile[i, num69].LiquidType == LiquidID.Lava)
                                    num70 = 374;
                                else if (Main.tile[i, num69].LiquidType == LiquidID.Honey)
                                    num70 = 375;

                                int num71 = num69 - j;
                                if (WorldGen.genRand.Next(num71 * 3) <= 1)
                                {
                                    Main.tile[i, j].TileType = (ushort)num70;
                                    Main.tile[i, j].TileFrameX = 0;
                                    Main.tile[i, j].TileFrameY = 0;
                                    var tmp = Main.tile[i, j];
                                    tmp.HasTile = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!Main.tile[i, j].HasTile && WorldGen.genRand.NextBool(4))
                    {
                        Tile tile3 = Main.tile[i, j - 1];
                        if (TileID.Sets.Conversion.Sandstone[tile3.TileType] || TileID.Sets.Conversion.HardenedSand[tile3.TileType])
                        {
                            Main.tile[i, j].TileType = 461;
                            Main.tile[i, j].TileFrameX = 0;
                            Main.tile[i, j].TileFrameY = 0;
                            var tmp = Main.tile[i, j];
                            tmp.HasTile = true;
                        }
                    }
                }

                if (Main.tile[i, j].TileType == 137)
                {
                    int num72 = Main.tile[i, j].TileFrameY / 18;
                    if (num72 <= 2 || num72 == 5)
                    {
                        int num73 = -1;
                        if (Main.tile[i, j].TileFrameX >= 18)
                            num73 = 1;

                        var tmp = Main.tile[i + num73, j];
                        if (tmp.IsHalfBlock || tmp.Slope != 0)
                            tmp.HasTile = false;
                    }
                }
                else if (Main.tile[i, j].TileType == 162 && Main.tile[i, j + 1].LiquidAmount == 0 && WorldGen.CanKillTile(i, j))
                {
                    var tmp = Main.tile[i, j];
                    tmp.HasTile = false;
                }

                if (Main.tile[i, j].WallType == 13 || Main.tile[i, j].WallType == 14)
                    Main.tile[i, j].LiquidAmount = 0;

                if (Main.tile[i, j].TileType == 31)
                {
                    int num74 = Main.tile[i, j].TileFrameX / 18;
                    int num75 = 0;
                    int num76 = i;
                    num75 += num74 / 2;
                    num75 = ((!drunkWorldGen) ? (crimson ? 1 : 0) : ((Main.tile[i, j].WallType == 83) ? 1 : 0));
                    num74 %= 2;
                    num76 -= num74;
                    int num77 = Main.tile[i, j].TileFrameY / 18;
                    int num78 = 0;
                    int num79 = j;
                    num78 += num77 / 2;
                    num77 %= 2;
                    num79 -= num77;
                    for (int num80 = 0; num80 < 2; num80++)
                    {
                        for (int num81 = 0; num81 < 2; num81++)
                        {
                            int num82 = num76 + num80;
                            int num83 = num79 + num81;
                            var tmp = Main.tile[num82, num83];
                            tmp.HasTile = true;
                            tmp.Slope = 0;
                            tmp.IsHalfBlock = false;
                            Main.tile[num82, num83].TileType = 31;
                            Main.tile[num82, num83].TileFrameX = (short)(num80 * 18 + 36 * num75);
                            Main.tile[num82, num83].TileFrameY = (short)(num81 * 18 + 36 * num78);
                        }
                    }
                }

                if (Main.tile[i, j].TileType == 12)
                {
                    int num84 = Main.tile[i, j].TileFrameX / 18;
                    int num85 = 0;
                    int num86 = i;
                    num85 += num84 / 2;
                    num84 %= 2;
                    num86 -= num84;
                    int num87 = Main.tile[i, j].TileFrameY / 18;
                    int num88 = 0;
                    int num89 = j;
                    num88 += num87 / 2;
                    num87 %= 2;
                    num89 -= num87;
                    for (int num90 = 0; num90 < 2; num90++)
                    {
                        for (int num91 = 0; num91 < 2; num91++)
                        {
                            int num92 = num86 + num90;
                            int num93 = num89 + num91;
                            var tmp1 = Main.tile[num92, num93];
                            tmp1.HasTile = true;
                            tmp1.Slope = 0;
                            tmp1.IsHalfBlock = false;
                            Main.tile[num92, num93].TileType = 12;
                            Main.tile[num92, num93].TileFrameX = (short)(num90 * 18 + 36 * num85);
                            Main.tile[num92, num93].TileFrameY = (short)(num91 * 18 + 36 * num88);
                        }

                        var tmp = Main.tile[num90, j + 2];
                        if (!Main.tile[num90, j + 2].HasTile)
                        {
                            tmp.HasTile = true;
                            if (!Main.tileSolid[Main.tile[num90, j + 2].TileType] || Main.tileSolidTop[Main.tile[num90, j + 2].TileType])
                                Main.tile[num90, j + 2].TileType = 0;
                        }

                        tmp.Slope = 0;
                        tmp.IsHalfBlock = false;
                    }
                }

                if (Main.tile[i, j].TileType == 639)
                {
                    int num94 = Main.tile[i, j].TileFrameX / 18;
                    int num95 = 0;
                    int num96 = i;
                    num95 += num94 / 2;
                    num94 %= 2;
                    num96 -= num94;
                    int num97 = Main.tile[i, j].TileFrameY / 18;
                    int num98 = 0;
                    int num99 = j;
                    num98 += num97 / 2;
                    num97 %= 2;
                    num99 -= num97;
                    for (int num100 = 0; num100 < 2; num100++)
                    {
                        for (int num101 = 0; num101 < 2; num101++)
                        {
                            int num102 = num96 + num100;
                            int num103 = num99 + num101;
                            var tmp1 = Main.tile[num102, num103];
                            tmp1.HasTile = true;
                            tmp1.Slope = 0;
                            tmp1.IsHalfBlock = false;
                            Main.tile[num102, num103].TileType = 639;
                            Main.tile[num102, num103].TileFrameX = (short)(num100 * 18 + 36 * num95);
                            Main.tile[num102, num103].TileFrameY = (short)(num101 * 18 + 36 * num98);
                        }
                        var tmp = Main.tile[num100, j + 2];
                        if (!Main.tile[num100, j + 2].HasTile)
                        {
                            tmp.HasTile = true;
                            if (!Main.tileSolid[Main.tile[num100, j + 2].TileType] || Main.tileSolidTop[Main.tile[num100, j + 2].TileType])
                                Main.tile[num100, j + 2].TileType = 0;
                        }

                        tmp.Slope = 0;
                        tmp.IsHalfBlock = false;
                    }
                }

                if (TileID.Sets.BasicChest[Main.tile[i, j].TileType])
                {
                    int num104 = Main.tile[i, j].TileFrameX / 18;
                    int num105 = 0;
                    // Extra patch context.
                    ushort type2 = 21;
                    int num106 = i;
                    int num107 = j - Main.tile[i, j].TileFrameY / 18;
                    if (Main.tile[i, j].TileType == 467)
                        type2 = 467;

                    // Added to allow automatic fixing of modded chests
                    if (TileID.Sets.BasicChest[Main.tile[i, j].TileType])
                        type2 = Main.tile[i, j].TileType;

                    while (num104 >= 2)
                    {
                        num105++;
                        num104 -= 2;
                    }

                    num106 -= num104;
                    int num108 = Chest.FindChest(num106, num107);
                    if (num108 != -1)
                    {
                        switch (Main.chest[num108].item[0].type)
                        {
                            case 1156:
                                num105 = 23;
                                break;
                            case 1571:
                                num105 = 24;
                                break;
                            case 1569:
                                num105 = 25;
                                break;
                            case 1260:
                                num105 = 26;
                                break;
                            case 1572:
                                num105 = 27;
                                break;
                        }
                    }

                    for (int num109 = 0; num109 < 2; num109++)
                    {
                        for (int num110 = 0; num110 < 2; num110++)
                        {
                            int num111 = num106 + num109;
                            int num112 = num107 + num110;
                            var tmp1 = Main.tile[num111, num112];
                            tmp1.HasTile = true;
                            tmp1.Slope = 0;
                            tmp1.IsHalfBlock = false;
                            Main.tile[num111, num112].TileType = type2;
                            Main.tile[num111, num112].TileFrameX = (short)(num109 * 18 + 36 * num105);
                            Main.tile[num111, num112].TileFrameY = (short)(num110 * 18);
                        }

                        var tmp = Main.tile[num109, j + 2];
                        if (!Main.tile[num109, j + 2].HasTile)
                        {
                            tmp.HasTile = true;

                            if (!Main.tileSolid[Main.tile[num109, j + 2].TileType] || Main.tileSolidTop[Main.tile[num109, j + 2].TileType])
                                Main.tile[num109, j + 2].TileType = 0;
                        }

                        tmp.Slope = 0;
                        tmp.IsHalfBlock = false;
                    }
                }

                if (Main.tile[i, j].TileType == 28)
                {
                    int num113 = Main.tile[i, j].TileFrameX / 18;
                    int num114 = 0;
                    int num115 = i;
                    while (num113 >= 2)
                    {
                        num114++;
                        num113 -= 2;
                    }

                    num115 -= num113;
                    int num116 = Main.tile[i, j].TileFrameY / 18;
                    int num117 = 0;
                    int num118 = j;
                    while (num116 >= 2)
                    {
                        num117++;
                        num116 -= 2;
                    }

                    num118 -= num116;
                    for (int num119 = 0; num119 < 2; num119++)
                    {
                        for (int num120 = 0; num120 < 2; num120++)
                        {
                            int num121 = num115 + num119;
                            int num122 = num118 + num120;
                            var tmp1 = Main.tile[num121, num122];
                            tmp1.HasTile = true;
                            if (!Main.tile[num121, num122].HasTile)
                            {
                                throw new Exception("Error");
                            }
                            tmp1.Slope = 0;
                            tmp1.IsHalfBlock = false;
                            Main.tile[num121, num122].TileType = 28;
                            Main.tile[num121, num122].TileFrameX = (short)(num119 * 18 + 36 * num114);
                            Main.tile[num121, num122].TileFrameY = (short)(num120 * 18 + 36 * num117);
                        }

                        var tmp = Main.tile[num119, j + 2];
                        if (!Main.tile[num119, j + 2].HasTile)
                        {
                            tmp.HasTile = true;
                            if (!Main.tileSolid[Main.tile[num119, j + 2].TileType] || Main.tileSolidTop[Main.tile[num119, j + 2].TileType])
                                Main.tile[num119, j + 2].TileType = 0;
                        }

                        tmp.Slope = 0;
                        tmp.IsHalfBlock = false;
                    }
                }

                if (Main.tile[i, j].TileType == 26)
                {
                    int num123 = Main.tile[i, j].TileFrameX / 18;
                    int num124 = 0;
                    int num125 = i;
                    int num126 = j - Main.tile[i, j].TileFrameY / 18;
                    while (num123 >= 3)
                    {
                        num124++;
                        num123 -= 3;
                    }

                    num125 -= num123;
                    num124 = (drunkWorldGen ? ((Main.tile[i, j].WallType == 83) ? 1 : 0) : (crimson ? 1 : 0));
                    for (int num127 = 0; num127 < 3; num127++)
                    {
                        for (int num128 = 0; num128 < 2; num128++)
                        {
                            int num129 = num125 + num127;
                            int num130 = num126 + num128;
                            var tmp = Main.tile[num129, num130];
                            tmp.HasTile = true;
                            tmp.Slope = 0;
                            tmp.IsHalfBlock = false;
                            Main.tile[num129, num130].TileType = 26;
                            Main.tile[num129, num130].TileFrameX = (short)(num127 * 18 + 54 * num124);
                            Main.tile[num129, num130].TileFrameY = (short)(num128 * 18);
                        }
                        var tmp1 = Main.tile[num125 + num127, num126 + 2];
                        if (!Main.tile[num125 + num127, num126 + 2].HasTile || !Main.tileSolid[Main.tile[num125 + num127, num126 + 2].TileType] || Main.tileSolidTop[Main.tile[num125 + num127, num126 + 2].TileType])
                        {
                            tmp1.HasTile = true;
                            if (!TileID.Sets.Platforms[Main.tile[num125 + num127, num126 + 2].TileType])
                            {
                                if (Main.tile[num125 + num127, num126 + 2].TileType == 484)
                                    Main.tile[num125 + num127, num126 + 2].TileType = 397;
                                else if (TileID.Sets.Boulders[Main.tile[num125 + num127, num126 + 2].TileType] || !Main.tileSolid[Main.tile[num125 + num127, num126 + 2].TileType] || Main.tileSolidTop[Main.tile[num125 + num127, num126 + 2].TileType])
                                    Main.tile[num125 + num127, num126 + 2].TileType = 0;
                            }
                        }

                        tmp1.Slope = 0;
                        tmp1.IsHalfBlock = false;
                        if (Main.tile[num125 + num127, num126 + 3].TileType == 28 && Main.tile[num125 + num127, num126 + 3].TileFrameY % 36 >= 18)
                        {
                            Main.tile[num125 + num127, num126 + 3].TileType = 0;
                            tmp1 = Main.tile[num125 + num127, num126 + 3];
                            tmp1.HasTile = false;
                        }
                    }

                    for (int num131 = 0; num131 < 3; num131++)
                    {
                        if ((Main.tile[num125 - 1, num126 + num131].TileType == 28 || Main.tile[num125 - 1, num126 + num131].TileType == 12 || Main.tile[num125 - 1, num126 + num131].TileType == 639) && Main.tile[num125 - 1, num126 + num131].TileFrameX % 36 < 18)
                        {
                            Main.tile[num125 - 1, num126 + num131].TileType = 0;
                            var tmp = Main.tile[num125 - 1, num126 + num131];
                            tmp.HasTile = false;
                        }

                        if ((Main.tile[num125 + 3, num126 + num131].TileType == 28 || Main.tile[num125 + 3, num126 + num131].TileType == 12 || Main.tile[num125 - 1, num126 + num131].TileType == 639) && Main.tile[num125 + 3, num126 + num131].TileFrameX % 36 >= 18)
                        {
                            Main.tile[num125 + 3, num126 + num131].TileType = 0;
                            var tmp = Main.tile[num125 + 3, num126 + num131];
                            tmp.HasTile = false;
                        }
                    }
                }

                if (Main.tile[i, j].TileType == 237 && Main.tile[i, j + 1].TileType == 232)
                    Main.tile[i, j + 1].TileType = 226;

                if (Main.tile[i, j].WallType == 87)
                    Main.tile[i, j].LiquidAmount = 0;
            }
        }
    }
}