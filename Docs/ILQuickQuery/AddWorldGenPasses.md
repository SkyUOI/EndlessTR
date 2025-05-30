# IL of AddWorldGenPasses

```
.method assembly hidebysig static 
	void AddGenPasses () cil managed 
{
	// Method begins at RVA 0x418b6c
	// Header size: 12
	// Code size: 4326 (0x10e6)
	.maxstack 3

	// 	AddGenerationPass("Reset", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
	// 		if (genRand.Next(2) == 0)
	// 		{
	// 			GenVars.crimsonLeft = false;
	// 		}
	// 		else
	// 		{
	// 			GenVars.crimsonLeft = true;
	// 		}
	// 		GenVars.numOceanCaveTreasure = 0;
	// 		GenVars.skipDesertTileCheck = false;
	// 		growGrassUnderground = false;
	// 		gen = true;
	// 		Liquid.ReInit();
	// 		noTileActions = true;
	// 		progress.Message = "";
	// 		SetupStatueList();
	// 		RandomizeWeather();
	// 		Main.cloudAlpha = 0f;
	// 		Main.maxRaining = 0f;
	// 		Main.raining = false;
	// 		heartCount = 0;
	// 		GenVars.extraBastStatueCount = 0;
	// 		GenVars.extraBastStatueCountMax = 2;
	// 		Main.checkXMas();
	// 		Main.checkHalloween();
	// 		ResetGenerator();
	// 		GenVars.UndergroundDesertLocation = Rectangle.Empty;
	// 		GenVars.UndergroundDesertHiveLocation = Rectangle.Empty;
	// 		GenVars.numLarva = 0;
	// 		List<int> list = new List<int> { 274, 220, 112, 218, 3019 };
	// 		if (remixWorldGen)
	// 		{
	// 			list = new List<int> { 274, 220, 683, 218, 3019 };
	// 		}
	// 		List<int> list2 = new List<int>();
	// 		while (list.Count > 0)
	// 		{
	// 			int index = genRand.Next(list.Count);
	// 			int item = list[index];
	// 			list2.Add(item);
	// 			list.RemoveAt(index);
	// 		}
	// 		GenVars.hellChestItem = list2.ToArray();
	// 		int num = 86400;
	// 		Main.slimeRainTime = -genRand.Next(num * 2, num * 3);
	// 		Main.cloudBGActive = -genRand.Next(8640, 86400);
	// 		skipFramingDuringGen = false;
	// 		SavedOreTiers.Copper = 7;
	// 		SavedOreTiers.Iron = 6;
	// 		SavedOreTiers.Silver = 9;
	// 		SavedOreTiers.Gold = 8;
	// 		GenVars.copperBar = 20;
	// 		GenVars.ironBar = 22;
	// 		GenVars.silverBar = 21;
	// 		GenVars.goldBar = 19;
	// 		if (genRand.Next(2) == 0)
	// 		{
	// 			GenVars.copper = 166;
	// 			GenVars.copperBar = 703;
	// 			SavedOreTiers.Copper = 166;
	// 		}
	// 		if ((!dontStarveWorldGen || drunkWorldGen) && genRand.Next(2) == 0)
	// 		{
	// 			GenVars.iron = 167;
	// 			GenVars.ironBar = 704;
	// 			SavedOreTiers.Iron = 167;
	// 		}
	// 		if (genRand.Next(2) == 0)
	// 		{
	// 			GenVars.silver = 168;
	// 			GenVars.silverBar = 705;
	// 			SavedOreTiers.Silver = 168;
	// 		}
	// 		if ((!dontStarveWorldGen || drunkWorldGen) && genRand.Next(2) == 0)
	// 		{
	// 			GenVars.gold = 169;
	// 			GenVars.goldBar = 706;
	// 			SavedOreTiers.Gold = 169;
	// 		}
	// 		crimson = genRand.Next(2) == 0;
	// 		if (WorldGenParam_Evil == 0)
	// 		{
	// 			crimson = false;
	// 		}
	// 		if (WorldGenParam_Evil == 1)
	// 		{
	// 			crimson = true;
	// 		}
	// 		if (GenVars.jungleHut == 0)
	// 		{
	// 			GenVars.jungleHut = 119;
	// 		}
	// 		else if (GenVars.jungleHut == 1)
	// 		{
	// 			GenVars.jungleHut = 120;
	// 		}
	// 		else if (GenVars.jungleHut == 2)
	// 		{
	// 			GenVars.jungleHut = 158;
	// 		}
	// 		else if (GenVars.jungleHut == 3)
	// 		{
	// 			GenVars.jungleHut = 175;
	// 		}
	// 		else if (GenVars.jungleHut == 4)
	// 		{
	// 			GenVars.jungleHut = 45;
	// 		}
	// 		Main.worldID = genRand.Next(int.MaxValue);
	// 		RandomizeTreeStyle();
	// 		RandomizeCaveBackgrounds();
	// 		RandomizeBackgrounds(genRand);
	// 		RandomizeMoonState(genRand);
	// 		TreeTops.CopyExistingWorldInfoForWorldGeneration();
	// 		GenVars.dungeonSide = ((genRand.Next(2) != 0) ? 1 : (-1));
	// 		if (remixWorldGen)
	// 		{
	// 			if (GenVars.dungeonSide == -1)
	// 			{
	// 				double num2 = 1.0 - (double)genRand.Next(20, 35) * 0.01;
	// 				GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num2);
	// 			}
	// 			else
	// 			{
	// 				double num3 = (double)genRand.Next(20, 35) * 0.01;
	// 				GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num3);
	// 			}
	// 		}
	// 		else
	// 		{
	// 			int minValue = 15;
	// 			int maxValue = 30;
	// 			if (tenthAnniversaryWorldGen && !remixWorldGen)
	// 			{
	// 				minValue = 25;
	// 				maxValue = 35;
	// 			}
	// 			if (GenVars.dungeonSide == -1)
	// 			{
	// 				double num4 = 1.0 - (double)genRand.Next(minValue, maxValue) * 0.01;
	// 				GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num4);
	// 			}
	// 			else
	// 			{
	// 				double num5 = (double)genRand.Next(minValue, maxValue) * 0.01;
	// 				GenVars.jungleOriginX = (int)((double)Main.maxTilesX * num5);
	// 			}
	// 		}
	// 		int num6 = genRand.Next(Main.maxTilesX);
	// 		if (drunkWorldGen)
	// 		{
	// 			GenVars.dungeonSide *= -1;
	// 		}
	// 		if (GenVars.dungeonSide == 1)
	// 		{
	// 			while ((double)num6 < (double)Main.maxTilesX * 0.6 || (double)num6 > (double)Main.maxTilesX * 0.75)
	// 			{
	// 				num6 = genRand.Next(Main.maxTilesX);
	// 			}
	// 		}
	// 		else
	// 		{
	// 			while ((double)num6 < (double)Main.maxTilesX * 0.25 || (double)num6 > (double)Main.maxTilesX * 0.4)
	// 			{
	// 				num6 = genRand.Next(Main.maxTilesX);
	// 			}
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			GenVars.dungeonSide *= -1;
	// 		}
	// 		int num7 = genRand.Next(50, 90);
	// 		double num8 = (double)Main.maxTilesX / 4200.0;
	// 		num7 += (int)((double)genRand.Next(20, 40) * num8);
	// 		num7 += (int)((double)genRand.Next(20, 40) * num8);
	// 		int num9 = num6 - num7;
	// 		num7 = genRand.Next(50, 90);
	// 		num7 += (int)((double)genRand.Next(20, 40) * num8);
	// 		num7 += (int)((double)genRand.Next(20, 40) * num8);
	// 		int num10 = num6 + num7;
	// 		if (num9 < 0)
	// 		{
	// 			num9 = 0;
	// 		}
	// 		if (num10 > Main.maxTilesX)
	// 		{
	// 			num10 = Main.maxTilesX;
	// 		}
	// 		GenVars.snowOriginLeft = num9;
	// 		GenVars.snowOriginRight = num10;
	// 		GenVars.leftBeachEnd = genRand.Next(GenVars.beachSandRandomCenter - GenVars.beachSandRandomWidthRange, GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange);
	// 		if (tenthAnniversaryWorldGen && !remixWorldGen)
	// 		{
	// 			GenVars.leftBeachEnd = GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange;
	// 		}
	// 		if (GenVars.dungeonSide == 1)
	// 		{
	// 			GenVars.leftBeachEnd += GenVars.beachSandDungeonExtraWidth;
	// 		}
	// 		else
	// 		{
	// 			GenVars.leftBeachEnd += GenVars.beachSandJungleExtraWidth;
	// 		}
	// 		GenVars.rightBeachStart = Main.maxTilesX - genRand.Next(GenVars.beachSandRandomCenter - GenVars.beachSandRandomWidthRange, GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange);
	// 		if (tenthAnniversaryWorldGen && !remixWorldGen)
	// 		{
	// 			GenVars.rightBeachStart = Main.maxTilesX - (GenVars.beachSandRandomCenter + GenVars.beachSandRandomWidthRange);
	// 		}
	// 		if (GenVars.dungeonSide == -1)
	// 		{
	// 			GenVars.rightBeachStart -= GenVars.beachSandDungeonExtraWidth;
	// 		}
	// 		else
	// 		{
	// 			GenVars.rightBeachStart -= GenVars.beachSandJungleExtraWidth;
	// 		}
	// 		int num11 = 50;
	// 		if (GenVars.dungeonSide == -1)
	// 		{
	// 			GenVars.dungeonLocation = genRand.Next(GenVars.leftBeachEnd + num11, (int)((double)Main.maxTilesX * 0.2));
	// 		}
	// 		else
	// 		{
	// 			GenVars.dungeonLocation = genRand.Next((int)((double)Main.maxTilesX * 0.8), GenVars.rightBeachStart - num11);
	// 		}
	// 		int num12 = 0;
	// 		if (Main.maxTilesX >= 8400)
	// 		{
	// 			num12 = 2;
	// 		}
	// 		else if (Main.maxTilesX >= 6400)
	// 		{
	// 			num12 = 1;
	// 		}
	// 		GenVars.extraBastStatueCountMax = 2 + num12;
	// 		Main.tileSolid[659] = false;
	// 	});
	IL_0000: ldstr "Reset"
	IL_0005: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_0'
	IL_000a: dup
	IL_000b: brtrue.s IL_0024

	// (no C# code)
	IL_000d: pop
	IL_000e: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0013: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_0'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0019: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_001e: dup
	IL_001f: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_0'

	// AddGenerationPass(new TerrainPass());
	IL_0024: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0029: newobj instance void Terraria.GameContent.Biomes.TerrainPass::.ctor()
	IL_002e: call void Terraria.WorldGen::AddGenerationPass(class Terraria.WorldBuilding.GenPass)
	// 	AddGenerationPass("Dunes", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[1].Value;
	// 		int random = passConfig.Get<WorldGenRange>("Count").GetRandom(genRand);
	// 		double num = passConfig.Get<double>("ChanceOfPyramid");
	// 		if (drunkWorldGen)
	// 		{
	// 			num = 1.0;
	// 		}
	// 		double num2 = (double)Main.maxTilesX / 4200.0;
	// 		GenVars.PyrX = new int[random + 3];
	// 		GenVars.PyrY = new int[random + 3];
	// 		DunesBiome dunesBiome = GenVars.configuration.CreateBiome<DunesBiome>();
	// 		for (int i = 0; i < random; i++)
	// 		{
	// 			progress.Set((double)i / (double)random);
	// 			Point val = Point.Zero;
	// 			bool flag = false;
	// 			int num3 = 0;
	// 			while (!flag)
	// 			{
	// 				val = RandomWorldPoint(0, 500, 0, 500);
	// 				bool flag2 = Math.Abs(val.X - GenVars.jungleOriginX) < (int)(600.0 * num2);
	// 				bool flag3 = Math.Abs(val.X - Main.maxTilesX / 2) < 300;
	// 				bool flag4 = val.X > GenVars.snowOriginLeft - 300 && val.X < GenVars.snowOriginRight + 300;
	// 				num3++;
	// 				if (num3 >= Main.maxTilesX)
	// 				{
	// 					flag2 = false;
	// 				}
	// 				if (num3 >= Main.maxTilesX * 2)
	// 				{
	// 					flag4 = false;
	// 				}
	// 				flag = !(flag2 || flag3 || flag4);
	// 			}
	// 			dunesBiome.Place(val, GenVars.structures);
	// 			if (genRand.NextDouble() <= num)
	// 			{
	// 				int num4 = genRand.Next(val.X - 200, val.X + 200);
	// 				for (int j = 0; j < Main.maxTilesY; j++)
	// 				{
	// 					if (Main.tile[num4, j].active())
	// 					{
	// 						GenVars.PyrX[GenVars.numPyr] = num4;
	// 						GenVars.PyrY[GenVars.numPyr] = j + 20;
	// 						GenVars.numPyr++;
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0033: ldstr "Dunes"
	IL_0038: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_1'
	IL_003d: dup
	IL_003e: brtrue.s IL_0057

	// (no C# code)
	IL_0040: pop
	IL_0041: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0046: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_1'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_004c: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0051: dup
	IL_0052: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_1'

	// 	AddGenerationPass("Ocean Sand", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Language.GetTextValue("WorldGeneration.OceanSand");
	// 		for (int i = 0; i < 3; i++)
	// 		{
	// 			progress.Set((double)i / 3.0);
	// 			int num = genRand.Next(Main.maxTilesX);
	// 			while ((double)num > (double)Main.maxTilesX * 0.4 && (double)num < (double)Main.maxTilesX * 0.6)
	// 			{
	// 				num = genRand.Next(Main.maxTilesX);
	// 			}
	// 			int num2 = genRand.Next(35, 90);
	// 			if (i == 1)
	// 			{
	// 				double num3 = (double)Main.maxTilesX / 4200.0;
	// 				num2 += (int)((double)genRand.Next(20, 40) * num3);
	// 			}
	// 			if (genRand.Next(3) == 0)
	// 			{
	// 				num2 *= 2;
	// 			}
	// 			if (i == 1)
	// 			{
	// 				num2 *= 2;
	// 			}
	// 			int num4 = num - num2;
	// 			num2 = genRand.Next(35, 90);
	// 			if (genRand.Next(3) == 0)
	// 			{
	// 				num2 *= 2;
	// 			}
	// 			if (i == 1)
	// 			{
	// 				num2 *= 2;
	// 			}
	// 			int num5 = num + num2;
	// 			if (num4 < 0)
	// 			{
	// 				num4 = 0;
	// 			}
	// 			if (num5 > Main.maxTilesX)
	// 			{
	// 				num5 = Main.maxTilesX;
	// 			}
	// 			if (i == 0)
	// 			{
	// 				num4 = 0;
	// 				num5 = GenVars.leftBeachEnd;
	// 			}
	// 			else if (i == 2)
	// 			{
	// 				num4 = GenVars.rightBeachStart;
	// 				num5 = Main.maxTilesX;
	// 			}
	// 			else if (i == 1)
	// 			{
	// 				continue;
	// 			}
	// 			int num6 = genRand.Next(50, 100);
	// 			for (int j = num4; j < num5; j++)
	// 			{
	// 				if (genRand.Next(2) == 0)
	// 				{
	// 					num6 += genRand.Next(-1, 2);
	// 					if (num6 < 50)
	// 					{
	// 						num6 = 50;
	// 					}
	// 					if (num6 > 200)
	// 					{
	// 						num6 = 200;
	// 					}
	// 				}
	// 				for (int k = 0; (double)k < (Main.worldSurface + Main.rockLayer) / 2.0; k++)
	// 				{
	// 					if (Main.tile[j, k].active())
	// 					{
	// 						if (j == (num4 + num5) / 2 && genRand.Next(6) == 0)
	// 						{
	// 							GenVars.PyrX[GenVars.numPyr] = j;
	// 							GenVars.PyrY[GenVars.numPyr] = k;
	// 							GenVars.numPyr++;
	// 						}
	// 						int num7 = num6;
	// 						if (j - num4 < num7)
	// 						{
	// 							num7 = j - num4;
	// 						}
	// 						if (num5 - j < num7)
	// 						{
	// 							num7 = num5 - j;
	// 						}
	// 						num7 += genRand.Next(5);
	// 						for (int l = k; l < k + num7; l++)
	// 						{
	// 							if (j > num4 + genRand.Next(5) && j < num5 - genRand.Next(5))
	// 							{
	// 								Main.tile[j, l].type = 53;
	// 							}
	// 						}
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0057: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_005c: ldstr "Ocean Sand"
	IL_0061: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_2'
	IL_0066: dup
	IL_0067: brtrue.s IL_0080

	// (no C# code)
	IL_0069: pop
	IL_006a: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_006f: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_2'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0075: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_007a: dup
	IL_007b: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_2'

	// 	AddGenerationPass("Sand Patches", delegate
	// 	{
	// 		int num = (int)((double)Main.maxTilesX * 0.013);
	// 		if (remixWorldGen)
	// 		{
	// 			num /= 4;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			int num2 = genRand.Next(0, Main.maxTilesX);
	// 			int num3 = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 			if (remixWorldGen)
	// 			{
	// 				num3 = genRand.Next((int)Main.rockLayer - 100, Main.maxTilesY - 350);
	// 			}
	// 			while ((double)num2 > (double)Main.maxTilesX * 0.46 && (double)num2 < (double)Main.maxTilesX * 0.54 && (double)num3 < Main.worldSurface + 150.0)
	// 			{
	// 				num2 = genRand.Next(0, Main.maxTilesX);
	// 				num3 = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 			}
	// 			int num4 = genRand.Next(15, 70);
	// 			int steps = genRand.Next(20, 130);
	// 			TileRunner(num2, num3, num4, steps, 53);
	// 		}
	// 	});
	IL_0080: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0085: ldstr "Sand Patches"
	IL_008a: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_3'
	IL_008f: dup
	IL_0090: brtrue.s IL_00a9

	// (no C# code)
	IL_0092: pop
	IL_0093: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0098: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_3'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_009e: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_00a3: dup
	IL_00a4: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_3'

	// 	AddGenerationPass("Tunnels", delegate
	// 	{
	// 		int num = (int)((double)Main.maxTilesX * 0.0015);
	// 		if (remixWorldGen)
	// 		{
	// 			num = (int)((double)num * 1.5);
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			if (GenVars.numTunnels >= GenVars.maxTunnels - 1)
	// 			{
	// 				break;
	// 			}
	// 			int[] array = new int[10];
	// 			int[] array2 = new int[10];
	// 			int num2 = genRand.Next(450, Main.maxTilesX - 450);
	// 			if (!remixWorldGen)
	// 			{
	// 				if (tenthAnniversaryWorldGen)
	// 				{
	// 					num2 = genRand.Next((int)((double)Main.maxTilesX * 0.2), (int)((double)Main.maxTilesX * 0.8));
	// 				}
	// 				else
	// 				{
	// 					while ((double)num2 > (double)Main.maxTilesX * 0.4 && (double)num2 < (double)Main.maxTilesX * 0.6)
	// 					{
	// 						num2 = genRand.Next(450, Main.maxTilesX - 450);
	// 					}
	// 				}
	// 			}
	// 			int j = 0;
	// 			bool flag;
	// 			do
	// 			{
	// 				flag = false;
	// 				for (int k = 0; k < 10; k++)
	// 				{
	// 					for (num2 %= Main.maxTilesX; !Main.tile[num2, j].active(); j++)
	// 					{
	// 					}
	// 					if (Main.tile[num2, j].type == 53)
	// 					{
	// 						flag = true;
	// 					}
	// 					array[k] = num2;
	// 					array2[k] = j - genRand.Next(11, 16);
	// 					num2 += genRand.Next(5, 11);
	// 				}
	// 			}
	// 			while (flag);
	// 			GenVars.tunnelX[GenVars.numTunnels] = array[5];
	// 			GenVars.numTunnels++;
	// 			for (int l = 0; l < 10; l++)
	// 			{
	// 				TileRunner(array[l], array2[l], genRand.Next(5, 8), genRand.Next(6, 9), 0, addTile: true, -2.0, -0.3);
	// 				TileRunner(array[l], array2[l], genRand.Next(5, 8), genRand.Next(6, 9), 0, addTile: true, 2.0, -0.3);
	// 			}
	// 		}
	// 	});
	IL_00a9: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_00ae: ldstr "Tunnels"
	IL_00b3: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_4'
	IL_00b8: dup
	IL_00b9: brtrue.s IL_00d2

	// (no C# code)
	IL_00bb: pop
	IL_00bc: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_00c1: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_4'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_00c7: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_00cc: dup
	IL_00cd: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_4'

	// 	AddGenerationPass("Mount Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		GenVars.numMCaves = 0;
	// 		progress.Message = Lang.gen[2].Value;
	// 		int num = (int)((double)Main.maxTilesX * 0.001);
	// 		if (remixWorldGen)
	// 		{
	// 			num = (int)((double)num * 1.5);
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			progress.Set((double)i / (double)num);
	// 			int num2 = 0;
	// 			bool flag = false;
	// 			bool flag2 = false;
	// 			int num3 = genRand.Next((int)((double)Main.maxTilesX * 0.25), (int)((double)Main.maxTilesX * 0.75));
	// 			while (!flag2)
	// 			{
	// 				flag2 = true;
	// 				if (!remixWorldGen)
	// 				{
	// 					while (num3 > Main.maxTilesX / 2 - 90 && num3 < Main.maxTilesX / 2 + 90)
	// 					{
	// 						num3 = genRand.Next((int)((double)Main.maxTilesX * 0.25), (int)((double)Main.maxTilesX * 0.75));
	// 					}
	// 				}
	// 				for (int j = 0; j < GenVars.numMCaves; j++)
	// 				{
	// 					if (Math.Abs(num3 - GenVars.mCaveX[j]) < 100)
	// 					{
	// 						num2++;
	// 						flag2 = false;
	// 						break;
	// 					}
	// 				}
	// 				if (num2 >= Main.maxTilesX / 5)
	// 				{
	// 					flag = true;
	// 					break;
	// 				}
	// 			}
	// 			if (!flag)
	// 			{
	// 				for (int k = 0; (double)k < Main.worldSurface; k++)
	// 				{
	// 					if (Main.tile[num3, k].active())
	// 					{
	// 						for (int l = num3 - 50; l < num3 + 50; l++)
	// 						{
	// 							for (int m = k - 25; m < k + 25; m++)
	// 							{
	// 								if (Main.tile[l, m].active() && (Main.tile[l, m].type == 53 || Main.tile[l, m].type == 151 || Main.tile[l, m].type == 274))
	// 								{
	// 									flag = true;
	// 								}
	// 							}
	// 						}
	// 						if (!flag)
	// 						{
	// 							Mountinater(num3, k);
	// 							GenVars.mCaveX[GenVars.numMCaves] = num3;
	// 							GenVars.mCaveY[GenVars.numMCaves] = k;
	// 							GenVars.numMCaves++;
	// 							break;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_00d2: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_00d7: ldstr "Mount Caves"
	IL_00dc: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_5'
	IL_00e1: dup
	IL_00e2: brtrue.s IL_00fb

	// (no C# code)
	IL_00e4: pop
	IL_00e5: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_00ea: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_5'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_00f0: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_00f5: dup
	IL_00f6: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_5'

	// 	AddGenerationPass("Dirt Wall Backgrounds", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[3].Value;
	// 		int num = 0;
	// 		for (int i = 1; i < Main.maxTilesX - 1; i++)
	// 		{
	// 			ushort num2 = 2;
	// 			double value = (double)i / (double)Main.maxTilesX;
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			num += genRand.Next(-1, 2);
	// 			if (num < 0)
	// 			{
	// 				num = 0;
	// 			}
	// 			if (num > 10)
	// 			{
	// 				num = 10;
	// 			}
	// 			for (int j = 0; (double)j < Main.worldSurface + 10.0 && !((double)j > Main.worldSurface + (double)num); j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					num2 = (ushort)((Main.tile[i, j].type != 147) ? 2u : 40u);
	// 				}
	// 				if (flag && Main.tile[i, j].wall != 64)
	// 				{
	// 					Main.tile[i, j].wall = num2;
	// 				}
	// 				if (Main.tile[i, j].active() && Main.tile[i - 1, j].active() && Main.tile[i + 1, j].active() && Main.tile[i, j + 1].active() && Main.tile[i - 1, j + 1].active() && Main.tile[i + 1, j + 1].active())
	// 				{
	// 					flag = true;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_00fb: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0100: ldstr "Dirt Wall Backgrounds"
	IL_0105: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_6'
	IL_010a: dup
	IL_010b: brtrue.s IL_0124

	// (no C# code)
	IL_010d: pop
	IL_010e: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0113: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_6'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0119: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_011e: dup
	IL_011f: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_6'

	// 	AddGenerationPass("Rocks In Dirt", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[4].Value;
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.00015;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow + 1), genRand.Next(4, 15), genRand.Next(5, 40), 1);
	// 		}
	// 		progress.Set(0.34);
	// 		num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.0002;
	// 		for (int j = 0; (double)j < num; j++)
	// 		{
	// 			int num2 = genRand.Next(0, Main.maxTilesX);
	// 			int num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh + 1);
	// 			if (!Main.tile[num2, num3 - 10].active())
	// 			{
	// 				num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh + 1);
	// 			}
	// 			TileRunner(num2, num3, genRand.Next(4, 10), genRand.Next(5, 30), 1);
	// 		}
	// 		progress.Set(0.67);
	// 		num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.0045;
	// 		for (int k = 0; (double)k < num; k++)
	// 		{
	// 			TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh + 1), genRand.Next(2, 7), genRand.Next(2, 23), 1);
	// 		}
	// 	});
	IL_0124: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0129: ldstr "Rocks In Dirt"
	IL_012e: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_7'
	IL_0133: dup
	IL_0134: brtrue.s IL_014d

	// (no C# code)
	IL_0136: pop
	IL_0137: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_013c: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_7'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0142: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0147: dup
	IL_0148: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_7'

	// 	AddGenerationPass("Dirt In Rocks", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[5].Value;
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.005;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			progress.Set((double)i / num);
	// 			TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(2, 6), genRand.Next(2, 40), 0);
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			for (int j = 0; j < Main.maxTilesX; j++)
	// 			{
	// 				for (int k = (int)Main.worldSurface + genRand.Next(-1, 3); k < Main.maxTilesY; k++)
	// 				{
	// 					if (Main.tile[j, k].active())
	// 					{
	// 						if (Main.tile[j, k].type == 0)
	// 						{
	// 							Main.tile[j, k].type = 1;
	// 						}
	// 						else if (Main.tile[j, k].type == 1)
	// 						{
	// 							Main.tile[j, k].type = 0;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_014d: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0152: ldstr "Dirt In Rocks"
	IL_0157: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_8'
	IL_015c: dup
	IL_015d: brtrue.s IL_0176

	// (no C# code)
	IL_015f: pop
	IL_0160: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0165: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_8'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_016b: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0170: dup
	IL_0171: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_8'

	// 	AddGenerationPass("Clay", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[6].Value;
	// 		for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2E-05); i++)
	// 		{
	// 			TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow), genRand.Next(4, 14), genRand.Next(10, 50), 40);
	// 		}
	// 		progress.Set(0.25);
	// 		if (remixWorldGen)
	// 		{
	// 			for (int j = 0; j < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 7E-05); j++)
	// 			{
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayer - 25, Main.maxTilesY - 350), genRand.Next(8, 15), genRand.Next(5, 50), 40);
	// 			}
	// 		}
	// 		else
	// 		{
	// 			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 5E-05); k++)
	// 			{
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh + 1), genRand.Next(8, 14), genRand.Next(15, 45), 40);
	// 			}
	// 			progress.Set(0.5);
	// 			for (int l = 0; l < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2E-05); l++)
	// 			{
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh + 1), genRand.Next(8, 15), genRand.Next(5, 50), 40);
	// 			}
	// 		}
	// 		progress.Set(0.75);
	// 		for (int m = 5; m < Main.maxTilesX - 5; m++)
	// 		{
	// 			for (int n = 1; (double)n < Main.worldSurface - 1.0; n++)
	// 			{
	// 				if (Main.tile[m, n].active())
	// 				{
	// 					for (int num = n; num < n + 5; num++)
	// 					{
	// 						if (Main.tile[m, num].type == 40)
	// 						{
	// 							Main.tile[m, num].type = 0;
	// 						}
	// 					}
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0176: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_017b: ldstr "Clay"
	IL_0180: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_9'
	IL_0185: dup
	IL_0186: brtrue.s IL_019f

	// (no C# code)
	IL_0188: pop
	IL_0189: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_018e: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_9'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0194: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0199: dup
	IL_019a: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_9'

	// 	AddGenerationPass("Small Holes", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[7].Value;
	// 		double worldSurfaceHigh = GenVars.worldSurfaceHigh;
	// 		for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0015); i++)
	// 		{
	// 			double value = (double)i / ((double)(Main.maxTilesX * Main.maxTilesY) * 0.0015);
	// 			progress.Set(value);
	// 			int type = -1;
	// 			if (genRand.Next(5) == 0)
	// 			{
	// 				type = -2;
	// 			}
	// 			int num = genRand.Next(0, Main.maxTilesX);
	// 			int num2 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY);
	// 			if (!remixWorldGen && tenthAnniversaryWorldGen)
	// 			{
	// 				while ((double)num < (double)Main.maxTilesX * 0.2 && (double)num > (double)Main.maxTilesX * 0.8 && (double)num2 < GenVars.worldSurface)
	// 				{
	// 					num = genRand.Next(0, Main.maxTilesX);
	// 					num2 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY);
	// 				}
	// 			}
	// 			else
	// 			{
	// 				while (((num < GenVars.smallHolesBeachAvoidance || num > Main.maxTilesX - GenVars.smallHolesBeachAvoidance) && (double)num2 < worldSurfaceHigh) || ((double)num > (double)Main.maxTilesX * 0.45 && (double)num < (double)Main.maxTilesX * 0.55 && (double)num2 < GenVars.worldSurface))
	// 				{
	// 					num = genRand.Next(0, Main.maxTilesX);
	// 					num2 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY);
	// 				}
	// 			}
	// 			int num3 = genRand.Next(2, 5);
	// 			int num4 = genRand.Next(2, 20);
	// 			if (remixWorldGen && (double)num2 > Main.rockLayer)
	// 			{
	// 				num3 = (int)((double)num3 * 0.8);
	// 				num4 = (int)((double)num4 * 0.9);
	// 			}
	// 			TileRunner(num, num2, num3, num4, type);
	// 			num = genRand.Next(0, Main.maxTilesX);
	// 			num2 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY);
	// 			while (((num < GenVars.smallHolesBeachAvoidance || num > Main.maxTilesX - GenVars.smallHolesBeachAvoidance) && (double)num2 < worldSurfaceHigh) || ((double)num > (double)Main.maxTilesX * 0.45 && (double)num < (double)Main.maxTilesX * 0.55 && (double)num2 < GenVars.worldSurface))
	// 			{
	// 				num = genRand.Next(0, Main.maxTilesX);
	// 				num2 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY);
	// 			}
	// 			num3 = genRand.Next(8, 15);
	// 			num4 = genRand.Next(7, 30);
	// 			if (remixWorldGen && (double)num2 > Main.rockLayer)
	// 			{
	// 				num3 = (int)((double)num3 * 0.7);
	// 				num4 = (int)((double)num4 * 0.9);
	// 			}
	// 			TileRunner(num, num2, num3, num4, type);
	// 		}
	// 	});
	IL_019f: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_01a4: ldstr "Small Holes"
	IL_01a9: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_10'
	IL_01ae: dup
	IL_01af: brtrue.s IL_01c8

	// (no C# code)
	IL_01b1: pop
	IL_01b2: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_01b7: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_10'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_01bd: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_01c2: dup
	IL_01c3: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_10'

	// 	AddGenerationPass("Dirt Layer Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[8].Value;
	// 		double worldSurfaceHigh = GenVars.worldSurfaceHigh;
	// 		int num = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3E-05);
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 2;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			double value = (double)i / (double)num;
	// 			progress.Set(value);
	// 			if (GenVars.rockLayerHigh <= (double)Main.maxTilesY)
	// 			{
	// 				int type = -1;
	// 				if (genRand.Next(6) == 0)
	// 				{
	// 					type = -2;
	// 				}
	// 				int num2 = genRand.Next(0, Main.maxTilesX);
	// 				int num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.rockLayerHigh + 1);
	// 				while (((num2 < GenVars.smallHolesBeachAvoidance || num2 > Main.maxTilesX - GenVars.smallHolesBeachAvoidance) && (double)num3 < worldSurfaceHigh) || ((double)num2 >= (double)Main.maxTilesX * 0.45 && (double)num2 <= (double)Main.maxTilesX * 0.55 && (double)num3 < Main.worldSurface))
	// 				{
	// 					num2 = genRand.Next(0, Main.maxTilesX);
	// 					num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.rockLayerHigh + 1);
	// 				}
	// 				int num4 = genRand.Next(5, 15);
	// 				int num5 = genRand.Next(30, 200);
	// 				if (remixWorldGen)
	// 				{
	// 					num4 = (int)((double)num4 * 1.1);
	// 					num5 = (int)((double)num5 * 1.9);
	// 				}
	// 				TileRunner(num2, num3, num4, num5, type);
	// 			}
	// 		}
	// 	});
	IL_01c8: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_01cd: ldstr "Dirt Layer Caves"
	IL_01d2: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_11'
	IL_01d7: dup
	IL_01d8: brtrue.s IL_01f1

	// (no C# code)
	IL_01da: pop
	IL_01db: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_01e0: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_11'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_01e6: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_01eb: dup
	IL_01ec: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_11'

	// 	AddGenerationPass("Rock Layer Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[9].Value;
	// 		int num = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00013);
	// 		if (remixWorldGen)
	// 		{
	// 			num = (int)((double)num * 1.1);
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			double value = (double)i / (double)num;
	// 			progress.Set(value);
	// 			if (GenVars.rockLayerHigh <= (double)Main.maxTilesY)
	// 			{
	// 				int type = -1;
	// 				if (genRand.Next(10) == 0)
	// 				{
	// 					type = -2;
	// 				}
	// 				int num2 = genRand.Next(6, 20);
	// 				int num3 = genRand.Next(50, 300);
	// 				if (remixWorldGen)
	// 				{
	// 					num2 = (int)((double)num2 * 0.7);
	// 					num3 = (int)((double)num3 * 0.7);
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerHigh, Main.maxTilesY), num2, num3, type);
	// 			}
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			num = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00013 * 0.4);
	// 			for (int j = 0; j < num; j++)
	// 			{
	// 				if (GenVars.rockLayerHigh <= (double)Main.maxTilesY)
	// 				{
	// 					int type2 = -1;
	// 					if (genRand.Next(10) == 0)
	// 					{
	// 						type2 = -2;
	// 					}
	// 					int num4 = genRand.Next(7, 26);
	// 					int steps = genRand.Next(50, 200);
	// 					double num5 = (double)genRand.Next(100, 221) * 0.1;
	// 					double num6 = (double)genRand.Next(-10, 11) * 0.02;
	// 					int i2 = genRand.Next(0, Main.maxTilesX);
	// 					int j2 = genRand.Next((int)GenVars.rockLayerHigh, Main.maxTilesY);
	// 					TileRunner(i2, j2, num4, steps, type2, addTile: false, num5, num6, noYChange: true);
	// 					TileRunner(i2, j2, num4, steps, type2, addTile: false, 0.0 - num5, 0.0 - num6, noYChange: true);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_01f1: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_01f6: ldstr "Rock Layer Caves"
	IL_01fb: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_12'
	IL_0200: dup
	IL_0201: brtrue.s IL_021a

	// (no C# code)
	IL_0203: pop
	IL_0204: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0209: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_12'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_020f: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0214: dup
	IL_0215: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_12'

	// 	AddGenerationPass("Surface Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[10].Value;
	// 		int num = (int)((double)Main.maxTilesX * 0.002);
	// 		int num2 = (int)((double)Main.maxTilesX * 0.0007);
	// 		int num3 = (int)((double)Main.maxTilesX * 0.0003);
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 3;
	// 			num2 *= 3;
	// 			num3 *= 3;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			int num4 = genRand.Next(0, Main.maxTilesX);
	// 			while (((double)num4 > (double)Main.maxTilesX * 0.45 && (double)num4 < (double)Main.maxTilesX * 0.55) || num4 < GenVars.leftBeachEnd + 20 || num4 > GenVars.rightBeachStart - 20)
	// 			{
	// 				num4 = genRand.Next(0, Main.maxTilesX);
	// 			}
	// 			for (int j = 0; (double)j < GenVars.worldSurfaceHigh; j++)
	// 			{
	// 				if (Main.tile[num4, j].active())
	// 				{
	// 					TileRunner(num4, j, genRand.Next(3, 6), genRand.Next(5, 50), -1, addTile: false, (double)genRand.Next(-10, 11) * 0.1, 1.0);
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		progress.Set(0.2);
	// 		for (int k = 0; k < num2; k++)
	// 		{
	// 			int num5 = genRand.Next(0, Main.maxTilesX);
	// 			while (((double)num5 > (double)Main.maxTilesX * 0.43 && (double)num5 < (double)Main.maxTilesX * 0.5700000000000001) || num5 < GenVars.leftBeachEnd + 20 || num5 > GenVars.rightBeachStart - 20)
	// 			{
	// 				num5 = genRand.Next(0, Main.maxTilesX);
	// 			}
	// 			for (int l = 0; (double)l < GenVars.worldSurfaceHigh; l++)
	// 			{
	// 				if (Main.tile[num5, l].active())
	// 				{
	// 					TileRunner(num5, l, genRand.Next(10, 15), genRand.Next(50, 130), -1, addTile: false, (double)genRand.Next(-10, 11) * 0.1, 2.0);
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		progress.Set(0.4);
	// 		for (int m = 0; m < num3; m++)
	// 		{
	// 			int num6 = genRand.Next(0, Main.maxTilesX);
	// 			while (((double)num6 > (double)Main.maxTilesX * 0.4 && (double)num6 < (double)Main.maxTilesX * 0.6) || num6 < GenVars.leftBeachEnd + 20 || num6 > GenVars.rightBeachStart - 20)
	// 			{
	// 				num6 = genRand.Next(0, Main.maxTilesX);
	// 			}
	// 			for (int n = 0; (double)n < GenVars.worldSurfaceHigh; n++)
	// 			{
	// 				if (Main.tile[num6, n].active())
	// 				{
	// 					TileRunner(num6, n, genRand.Next(12, 25), genRand.Next(150, 500), -1, addTile: false, (double)genRand.Next(-10, 11) * 0.1, 4.0);
	// 					TileRunner(num6, n, genRand.Next(8, 17), genRand.Next(60, 200), -1, addTile: false, (double)genRand.Next(-10, 11) * 0.1, 2.0);
	// 					TileRunner(num6, n, genRand.Next(5, 13), genRand.Next(40, 170), -1, addTile: false, (double)genRand.Next(-10, 11) * 0.1, 2.0);
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		progress.Set(0.6);
	// 		for (int num7 = 0; num7 < (int)((double)Main.maxTilesX * 0.0004); num7++)
	// 		{
	// 			int num8 = genRand.Next(0, Main.maxTilesX);
	// 			while (((double)num8 > (double)Main.maxTilesX * 0.4 && (double)num8 < (double)Main.maxTilesX * 0.6) || num8 < GenVars.leftBeachEnd + 20 || num8 > GenVars.rightBeachStart - 20)
	// 			{
	// 				num8 = genRand.Next(0, Main.maxTilesX);
	// 			}
	// 			for (int num9 = 0; (double)num9 < GenVars.worldSurfaceHigh; num9++)
	// 			{
	// 				if (Main.tile[num8, num9].active())
	// 				{
	// 					TileRunner(num8, num9, genRand.Next(7, 12), genRand.Next(150, 250), -1, addTile: false, 0.0, 1.0, noYChange: true);
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		progress.Set(0.8);
	// 		double num10 = (double)Main.maxTilesX / 4200.0;
	// 		for (int num11 = 0; (double)num11 < 5.0 * num10; num11++)
	// 		{
	// 			try
	// 			{
	// 				int num12 = (int)Main.rockLayer;
	// 				int num13 = Main.maxTilesY - 400;
	// 				if (num12 >= num13)
	// 				{
	// 					num12 = num13 - 1;
	// 				}
	// 				Caverer(genRand.Next(GenVars.surfaceCavesBeachAvoidance2, Main.maxTilesX - GenVars.surfaceCavesBeachAvoidance2), genRand.Next(num12, num13));
	// 			}
	// 			catch
	// 			{
	// 			}
	// 		}
	// 	});
	IL_021a: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_021f: ldstr "Surface Caves"
	IL_0224: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_13'
	IL_0229: dup
	IL_022a: brtrue.s IL_0243

	// (no C# code)
	IL_022c: pop
	IL_022d: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0232: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_13'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0238: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_023d: dup
	IL_023e: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_13'

	// 	AddGenerationPass("Wavy Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (dontStarveWorldGen)
	// 		{
	// 			progress.Message = Language.GetTextValue("WorldGeneration.WavyCaves");
	// 			double num = (double)Main.maxTilesX / 4200.0;
	// 			num *= num;
	// 			int num2 = (int)(35.0 * num);
	// 			if (Main.remixWorld)
	// 			{
	// 				num2 /= 3;
	// 			}
	// 			int num3 = 0;
	// 			int num4 = 80;
	// 			for (int i = 0; i < num2; i++)
	// 			{
	// 				double num5 = (double)i / (double)(num2 - 1);
	// 				progress.Set(num5);
	// 				int num6 = genRand.Next((int)Main.worldSurface + 100, Main.UnderworldLayer - 100);
	// 				int num7 = 0;
	// 				while (Math.Abs(num6 - num3) < num4)
	// 				{
	// 					num7++;
	// 					if (num7 > 100)
	// 					{
	// 						break;
	// 					}
	// 					num6 = genRand.Next((int)Main.worldSurface + 100, Main.UnderworldLayer - 100);
	// 				}
	// 				num3 = num6;
	// 				int num8 = 80;
	// 				int startX = num8 + (int)((double)(Main.maxTilesX - num8 * 2) * num5);
	// 				try
	// 				{
	// 					WavyCaverer(startX, num6, 12 + genRand.Next(3, 6), 0.25 + genRand.NextDouble(), genRand.Next(300, 500), -1);
	// 				}
	// 				catch
	// 				{
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0243: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0248: ldstr "Wavy Caves"
	IL_024d: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_14'
	IL_0252: dup
	IL_0253: brtrue.s IL_026c

	// (no C# code)
	IL_0255: pop
	IL_0256: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_025b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_14'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0261: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0266: dup
	IL_0267: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_14'

	// 	AddGenerationPass("Generate Ice Biome", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[56].Value;
	// 		GenVars.snowTop = (int)Main.worldSurface;
	// 		int num = GenVars.lavaLine - genRand.Next(160, 200);
	// 		int num2 = GenVars.lavaLine;
	// 		if (remixWorldGen)
	// 		{
	// 			num2 = Main.maxTilesY - 250;
	// 			num = num2 - genRand.Next(160, 200);
	// 		}
	// 		int num3 = GenVars.snowOriginLeft;
	// 		int num4 = GenVars.snowOriginRight;
	// 		int num5 = 10;
	// 		for (int i = 0; i <= num2 - 140; i++)
	// 		{
	// 			progress.Set((double)i / (double)(num2 - 140));
	// 			num3 += genRand.Next(-4, 4);
	// 			num4 += genRand.Next(-3, 5);
	// 			if (i > 0)
	// 			{
	// 				num3 = (num3 + GenVars.snowMinX[i - 1]) / 2;
	// 				num4 = (num4 + GenVars.snowMaxX[i - 1]) / 2;
	// 			}
	// 			if (GenVars.dungeonSide > 0)
	// 			{
	// 				if (genRand.Next(4) == 0)
	// 				{
	// 					num3++;
	// 					num4++;
	// 				}
	// 			}
	// 			else if (genRand.Next(4) == 0)
	// 			{
	// 				num3--;
	// 				num4--;
	// 			}
	// 			GenVars.snowMinX[i] = num3;
	// 			GenVars.snowMaxX[i] = num4;
	// 			for (int j = num3; j < num4; j++)
	// 			{
	// 				if (i < num)
	// 				{
	// 					if (Main.tile[j, i].wall == 2)
	// 					{
	// 						Main.tile[j, i].wall = 40;
	// 					}
	// 					switch (Main.tile[j, i].type)
	// 					{
	// 					case 0:
	// 					case 2:
	// 					case 23:
	// 					case 40:
	// 					case 53:
	// 						Main.tile[j, i].type = 147;
	// 						break;
	// 					case 1:
	// 						Main.tile[j, i].type = 161;
	// 						break;
	// 					}
	// 				}
	// 				else
	// 				{
	// 					num5 += genRand.Next(-3, 4);
	// 					if (genRand.Next(3) == 0)
	// 					{
	// 						num5 += genRand.Next(-4, 5);
	// 						if (genRand.Next(3) == 0)
	// 						{
	// 							num5 += genRand.Next(-6, 7);
	// 						}
	// 					}
	// 					if (num5 < 0)
	// 					{
	// 						num5 = genRand.Next(3);
	// 					}
	// 					else if (num5 > 50)
	// 					{
	// 						num5 = 50 - genRand.Next(3);
	// 					}
	// 					for (int k = i; k < i + num5; k++)
	// 					{
	// 						if (Main.tile[j, k].wall == 2)
	// 						{
	// 							Main.tile[j, k].wall = 40;
	// 						}
	// 						switch (Main.tile[j, k].type)
	// 						{
	// 						case 0:
	// 						case 2:
	// 						case 23:
	// 						case 40:
	// 						case 53:
	// 							Main.tile[j, k].type = 147;
	// 							break;
	// 						case 1:
	// 							Main.tile[j, k].type = 161;
	// 							break;
	// 						}
	// 					}
	// 				}
	// 			}
	// 			if (GenVars.snowBottom < i)
	// 			{
	// 				GenVars.snowBottom = i;
	// 			}
	// 		}
	// 	});
	IL_026c: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0271: ldstr "Generate Ice Biome"
	IL_0276: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_15'
	IL_027b: dup
	IL_027c: brtrue.s IL_0295

	// (no C# code)
	IL_027e: pop
	IL_027f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0284: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_15'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_028a: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_028f: dup
	IL_0290: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_15'

	// 	AddGenerationPass("Grass", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.002;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			progress.Set((double)i / num);
	// 			int num2 = genRand.Next(1, Main.maxTilesX - 1);
	// 			int num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh);
	// 			if (num3 >= Main.maxTilesY)
	// 			{
	// 				num3 = Main.maxTilesY - 2;
	// 			}
	// 			if (Main.tile[num2 - 1, num3].active() && Main.tile[num2 - 1, num3].type == 0 && Main.tile[num2 + 1, num3].active() && Main.tile[num2 + 1, num3].type == 0 && Main.tile[num2, num3 - 1].active() && Main.tile[num2, num3 - 1].type == 0 && Main.tile[num2, num3 + 1].active() && Main.tile[num2, num3 + 1].type == 0)
	// 			{
	// 				Main.tile[num2, num3].active(active: true);
	// 				Main.tile[num2, num3].type = 2;
	// 			}
	// 			num2 = genRand.Next(1, Main.maxTilesX - 1);
	// 			num3 = genRand.Next(0, (int)GenVars.worldSurfaceLow);
	// 			if (num3 >= Main.maxTilesY)
	// 			{
	// 				num3 = Main.maxTilesY - 2;
	// 			}
	// 			if (Main.tile[num2 - 1, num3].active() && Main.tile[num2 - 1, num3].type == 0 && Main.tile[num2 + 1, num3].active() && Main.tile[num2 + 1, num3].type == 0 && Main.tile[num2, num3 - 1].active() && Main.tile[num2, num3 - 1].type == 0 && Main.tile[num2, num3 + 1].active() && Main.tile[num2, num3 + 1].type == 0)
	// 			{
	// 				Main.tile[num2, num3].active(active: true);
	// 				Main.tile[num2, num3].type = 2;
	// 			}
	// 		}
	// 	});
	IL_0295: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_029a: ldstr "Grass"
	IL_029f: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_16'
	IL_02a4: dup
	IL_02a5: brtrue.s IL_02be

	// (no C# code)
	IL_02a7: pop
	IL_02a8: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_02ad: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_16'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_02b3: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_02b8: dup
	IL_02b9: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_16'

	// AddGenerationPass(new JunglePass());
	IL_02be: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_02c3: newobj instance void Terraria.GameContent.Biomes.JunglePass::.ctor()
	IL_02c8: call void Terraria.WorldGen::AddGenerationPass(class Terraria.WorldBuilding.GenPass)
	// 	AddGenerationPass("Mud Caves To Grass", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[77].Value;
	// 		NotTheBees();
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			for (int j = 0; j < Main.maxTilesY; j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					grassSpread = 0;
	// 					SpreadGrass(i, j, 59, 60);
	// 				}
	// 				progress.Set(0.2 * ((double)(i * Main.maxTilesY + j) / (double)(Main.maxTilesX * Main.maxTilesY)));
	// 			}
	// 		}
	// 		SmallConsecutivesFound = 0;
	// 		SmallConsecutivesEliminated = 0;
	// 		double num = Main.maxTilesX - 20;
	// 		for (int k = 10; k < Main.maxTilesX - 10; k++)
	// 		{
	// 			ScanTileColumnAndRemoveClumps(k);
	// 			double num2 = (double)(k - 10) / num;
	// 			progress.Set(0.2 + num2 * 0.8);
	// 		}
	// 	});
	IL_02cd: ldstr "Mud Caves To Grass"
	IL_02d2: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_17'
	IL_02d7: dup
	IL_02d8: brtrue.s IL_02f1

	// (no C# code)
	IL_02da: pop
	IL_02db: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_02e0: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_17'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_02e6: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_02eb: dup
	IL_02ec: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_17'

	// 	AddGenerationPass("Full Desert", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[78].Value;
	// 		Main.tileSolid[484] = false;
	// 		int num = 0;
	// 		int num2 = GenVars.dungeonSide;
	// 		int num3 = Main.maxTilesX / 2;
	// 		int num4 = genRand.Next(num3) / 8;
	// 		num4 += num3 / 8;
	// 		int num5 = num3 + num4 * -num2;
	// 		int num6 = 0;
	// 		DesertBiome desertBiome = GenVars.configuration.CreateBiome<DesertBiome>();
	// 		while (!desertBiome.Place(new Point(num5, (int)GenVars.worldSurfaceHigh + 25), GenVars.structures))
	// 		{
	// 			num4 = genRand.Next(num3) / 2;
	// 			num4 += num3 / 8;
	// 			num4 += genRand.Next(num6 / 12);
	// 			num5 = num3 + num4 * -num2;
	// 			if (++num6 > Main.maxTilesX / 4)
	// 			{
	// 				num2 *= -1;
	// 				num6 = 0;
	// 				num++;
	// 				if (num >= 2)
	// 				{
	// 					GenVars.skipDesertTileCheck = true;
	// 				}
	// 			}
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			for (int i = 50; i < Main.maxTilesX - 50; i++)
	// 			{
	// 				for (int j = (int)Main.rockLayer + genRand.Next(-1, 2); j < Main.maxTilesY - 50; j++)
	// 				{
	// 					if ((Main.tile[i, j].type == 396 || Main.tile[i, j].type == 397 || Main.tile[i, j].type == 53) && !SolidTile(i, j - 1))
	// 					{
	// 						for (int k = j; k < j + genRand.Next(4, 7) && Main.tile[i, k + 1].active() && (Main.tile[i, k].type == 396 || Main.tile[i, k].type == 397); k++)
	// 						{
	// 							Main.tile[i, k].type = 53;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_02f1: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_02f6: ldstr "Full Desert"
	IL_02fb: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_18'
	IL_0300: dup
	IL_0301: brtrue.s IL_031a

	// (no C# code)
	IL_0303: pop
	IL_0304: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0309: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_18'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_030f: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0314: dup
	IL_0315: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_18'

	// 	AddGenerationPass("Floating Islands", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		GenVars.numIslandHouses = 0;
	// 		GenVars.skyIslandHouseCount = 0;
	// 		progress.Message = Lang.gen[12].Value;
	// 		int num = (int)((double)Main.maxTilesX * 0.0008);
	// 		int num2 = 0;
	// 		double num3 = num + GenVars.skyLakes;
	// 		for (int i = 0; (double)i < num3; i++)
	// 		{
	// 			progress.Set((double)i / num3);
	// 			int num4 = Main.maxTilesX;
	// 			while (--num4 > 0)
	// 			{
	// 				bool flag = true;
	// 				int num5 = genRand.Next((int)((double)Main.maxTilesX * 0.1), (int)((double)Main.maxTilesX * 0.9));
	// 				while (num5 > Main.maxTilesX / 2 - 150 && num5 < Main.maxTilesX / 2 + 150)
	// 				{
	// 					num5 = genRand.Next((int)((double)Main.maxTilesX * 0.1), (int)((double)Main.maxTilesX * 0.9));
	// 				}
	// 				for (int j = 0; j < GenVars.numIslandHouses; j++)
	// 				{
	// 					if (num5 > GenVars.floatingIslandHouseX[j] - 180 && num5 < GenVars.floatingIslandHouseX[j] + 180)
	// 					{
	// 						flag = false;
	// 						break;
	// 					}
	// 				}
	// 				if (flag)
	// 				{
	// 					flag = false;
	// 					int num6 = 0;
	// 					for (int k = 200; (double)k < Main.worldSurface; k++)
	// 					{
	// 						if (Main.tile[num5, k].active())
	// 						{
	// 							num6 = k;
	// 							flag = true;
	// 							break;
	// 						}
	// 					}
	// 					if (flag)
	// 					{
	// 						int num7 = 0;
	// 						num4 = -1;
	// 						int val = genRand.Next(90, num6 - 100);
	// 						val = Math.Min(val, (int)GenVars.worldSurfaceLow - 50);
	// 						if (num2 >= num)
	// 						{
	// 							GenVars.skyLake[GenVars.numIslandHouses] = true;
	// 							CloudLake(num5, val);
	// 						}
	// 						else
	// 						{
	// 							GenVars.skyLake[GenVars.numIslandHouses] = false;
	// 							if (drunkWorldGen && !remixWorldGen)
	// 							{
	// 								if (genRand.Next(2) == 0)
	// 								{
	// 									num7 = 3;
	// 									SnowCloudIsland(num5, val);
	// 								}
	// 								else
	// 								{
	// 									num7 = 1;
	// 									DesertCloudIsland(num5, val);
	// 								}
	// 							}
	// 							else
	// 							{
	// 								if (remixWorldGen && drunkWorldGen)
	// 								{
	// 									num7 = ((GenVars.crimsonLeft && num5 < Main.maxTilesX / 2) ? 5 : ((GenVars.crimsonLeft || num5 <= Main.maxTilesX / 2) ? 4 : 5));
	// 								}
	// 								else if (getGoodWorldGen || remixWorldGen)
	// 								{
	// 									num7 = ((!crimson) ? 4 : 5);
	// 								}
	// 								else if (Main.tenthAnniversaryWorld)
	// 								{
	// 									num7 = 6;
	// 								}
	// 								CloudIsland(num5, val);
	// 							}
	// 						}
	// 						GenVars.floatingIslandHouseX[GenVars.numIslandHouses] = num5;
	// 						GenVars.floatingIslandHouseY[GenVars.numIslandHouses] = val;
	// 						GenVars.floatingIslandStyle[GenVars.numIslandHouses] = num7;
	// 						GenVars.numIslandHouses++;
	// 						num2++;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_031a: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_031f: ldstr "Floating Islands"
	IL_0324: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_19'
	IL_0329: dup
	IL_032a: brtrue.s IL_0343

	// (no C# code)
	IL_032c: pop
	IL_032d: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0332: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_19'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0338: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_033d: dup
	IL_033e: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_19'

	// 	AddGenerationPass("Mushroom Patches", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[13].Value;
	// 		if (remixWorldGen)
	// 		{
	// 			for (int i = 10; i < Main.maxTilesX - 10; i++)
	// 			{
	// 				for (int j = Main.maxTilesY + genRand.Next(3) - 350; j < Main.maxTilesY - 10; j++)
	// 				{
	// 					if (Main.tile[i, j].type == 0)
	// 					{
	// 						Main.tile[i, j].type = 59;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		double num = (double)Main.maxTilesX / 700.0;
	// 		if (num > (double)GenVars.maxMushroomBiomes)
	// 		{
	// 			num = GenVars.maxMushroomBiomes;
	// 		}
	// 		for (int k = 0; (double)k < num; k++)
	// 		{
	// 			int num2 = 0;
	// 			bool flag = true;
	// 			while (flag)
	// 			{
	// 				int num3 = genRand.Next((int)((double)Main.maxTilesX * 0.2), (int)((double)Main.maxTilesX * 0.8));
	// 				if (num2 > Main.maxTilesX / 4)
	// 				{
	// 					num3 = genRand.Next((int)((double)Main.maxTilesX * 0.25), (int)((double)Main.maxTilesX * 0.975));
	// 				}
	// 				int num4 = ((!remixWorldGen) ? genRand.Next((int)Main.rockLayer + 50, Main.maxTilesY - 300) : genRand.Next((int)Main.worldSurface + 50, (int)Main.rockLayer - 50));
	// 				flag = false;
	// 				int num5 = 100;
	// 				int num6 = 500;
	// 				for (int l = num3 - num5; l < num3 + num5; l += 3)
	// 				{
	// 					for (int m = num4 - num5; m < num4 + num5; m += 3)
	// 					{
	// 						if (InWorld(l, m))
	// 						{
	// 							if (Main.tile[l, m].type == 147 || Main.tile[l, m].type == 161 || Main.tile[l, m].type == 162 || Main.tile[l, m].type == 60 || Main.tile[l, m].type == 368 || Main.tile[l, m].type == 367)
	// 							{
	// 								flag = true;
	// 								break;
	// 							}
	// 							if (((Rectangle)(ref GenVars.UndergroundDesertLocation)).Contains(new Point(l, m)))
	// 							{
	// 								flag = true;
	// 								break;
	// 							}
	// 						}
	// 						else
	// 						{
	// 							flag = true;
	// 						}
	// 					}
	// 				}
	// 				if (!flag)
	// 				{
	// 					for (int n = 0; n < GenVars.numMushroomBiomes; n++)
	// 					{
	// 						if (Vector2D.Distance(GenVars.mushroomBiomesPosition[n].ToVector2D(), new Vector2D((double)num3, (double)num4)) < (double)num6)
	// 						{
	// 							flag = true;
	// 						}
	// 					}
	// 				}
	// 				if (!flag && GenVars.numMushroomBiomes < GenVars.maxMushroomBiomes)
	// 				{
	// 					ShroomPatch(num3, num4);
	// 					for (int num7 = 0; num7 < 5; num7++)
	// 					{
	// 						int i2 = num3 + genRand.Next(-40, 41);
	// 						int j2 = num4 + genRand.Next(-40, 41);
	// 						ShroomPatch(i2, j2);
	// 					}
	// 					GenVars.mushroomBiomesPosition[GenVars.numMushroomBiomes].X = num3;
	// 					GenVars.mushroomBiomesPosition[GenVars.numMushroomBiomes].Y = num4;
	// 					GenVars.numMushroomBiomes++;
	// 				}
	// 				num2++;
	// 				if (num2 > Main.maxTilesX / 2)
	// 				{
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		for (int num8 = 0; num8 < Main.maxTilesX; num8++)
	// 		{
	// 			progress.Set((double)num8 / (double)Main.maxTilesX);
	// 			for (int num9 = (int)Main.worldSurface; num9 < Main.maxTilesY; num9++)
	// 			{
	// 				if (InWorld(num8, num9, 50) && Main.tile[num8, num9].active())
	// 				{
	// 					grassSpread = 0;
	// 					SpreadGrass(num8, num9, 59, 70, repeat: false);
	// 				}
	// 			}
	// 		}
	// 		for (int num10 = 0; num10 < Main.maxTilesX; num10++)
	// 		{
	// 			for (int num11 = (int)Main.worldSurface; num11 < Main.maxTilesY; num11++)
	// 			{
	// 				if (Main.tile[num10, num11].active() && Main.tile[num10, num11].type == 70)
	// 				{
	// 					int type = 59;
	// 					for (int num12 = num10 - 1; num12 <= num10 + 1; num12++)
	// 					{
	// 						for (int num13 = num11 - 1; num13 <= num11 + 1; num13++)
	// 						{
	// 							if (Main.tile[num12, num13].active())
	// 							{
	// 								if (!Main.tile[num12 - 1, num13].active() && !Main.tile[num12 + 1, num13].active())
	// 								{
	// 									KillTile(num12, num13);
	// 								}
	// 								else if (!Main.tile[num12, num13 - 1].active() && !Main.tile[num12, num13 + 1].active())
	// 								{
	// 									KillTile(num12, num13);
	// 								}
	// 							}
	// 							else if (Main.tile[num12 - 1, num13].active() && Main.tile[num12 + 1, num13].active())
	// 							{
	// 								PlaceTile(num12, num13, type);
	// 								if (Main.tile[num12 - 1, num11].type == 70)
	// 								{
	// 									Main.tile[num12 - 1, num11].type = 59;
	// 								}
	// 								if (Main.tile[num12 + 1, num11].type == 70)
	// 								{
	// 									Main.tile[num12 + 1, num11].type = 59;
	// 								}
	// 							}
	// 							else if (Main.tile[num12, num13 - 1].active() && Main.tile[num12, num13 + 1].active())
	// 							{
	// 								PlaceTile(num12, num13, type);
	// 								if (Main.tile[num12, num11 - 1].type == 70)
	// 								{
	// 									Main.tile[num12, num11 - 1].type = 59;
	// 								}
	// 								if (Main.tile[num12, num11 + 1].type == 70)
	// 								{
	// 									Main.tile[num12, num11 + 1].type = 59;
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if (genRand.Next(4) == 0)
	// 					{
	// 						int x = num10 + genRand.Next(-20, 21);
	// 						int y = num11 + genRand.Next(-20, 21);
	// 						if (InWorld(x, y) && Main.tile[x, y].type == 59)
	// 						{
	// 							Main.tile[x, y].type = 70;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0343: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0348: ldstr "Mushroom Patches"
	IL_034d: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_20'
	IL_0352: dup
	IL_0353: brtrue.s IL_036c

	// (no C# code)
	IL_0355: pop
	IL_0356: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_035b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_20'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0361: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0366: dup
	IL_0367: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_20'

	// 	AddGenerationPass("Marble", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[80].Value;
	// 		int num = passConfig.Get<WorldGenRange>("Count").GetRandom(genRand);
	// 		double num2 = (double)(Main.maxTilesX - 160) / (double)num;
	// 		MarbleBiome marbleBiome = GenVars.configuration.CreateBiome<MarbleBiome>();
	// 		int num3 = 0;
	// 		int num4 = 0;
	// 		while (num4 < num)
	// 		{
	// 			double num5 = (double)num4 / (double)num;
	// 			progress.Set(num5);
	// 			Point val = RandomRectanglePoint((int)(num5 * (double)(Main.maxTilesX - 160)) + 80, (int)GenVars.rockLayer + 20, (int)num2, Main.maxTilesY - ((int)GenVars.rockLayer + 40) - 200);
	// 			if (remixWorldGen)
	// 			{
	// 				val = RandomRectanglePoint((int)(num5 * (double)(Main.maxTilesX - 160)) + 80, (int)GenVars.worldSurface + 100, (int)num2, (int)GenVars.rockLayer - (int)GenVars.worldSurface - 100);
	// 			}
	// 			while ((double)val.X > (double)Main.maxTilesX * 0.45 && (double)val.X < (double)Main.maxTilesX * 0.55)
	// 			{
	// 				val.X = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 			}
	// 			num3++;
	// 			if (marbleBiome.Place(val, GenVars.structures))
	// 			{
	// 				num4++;
	// 				num3 = 0;
	// 			}
	// 			else if (num3 > Main.maxTilesX * 10)
	// 			{
	// 				num = num4;
	// 				num4++;
	// 				num3 = 0;
	// 			}
	// 		}
	// 	});
	IL_036c: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0371: ldstr "Marble"
	IL_0376: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_21'
	IL_037b: dup
	IL_037c: brtrue.s IL_0395

	// (no C# code)
	IL_037e: pop
	IL_037f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0384: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_21'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_038a: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_038f: dup
	IL_0390: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_21'

	// 	AddGenerationPass("Granite", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[81].Value;
	// 		int num = passConfig.Get<WorldGenRange>("Count").GetRandom(genRand);
	// 		double num2 = (double)(Main.maxTilesX - 200) / (double)num;
	// 		List<Point> list = new List<Point>(num);
	// 		int num3 = 0;
	// 		int num4 = 0;
	// 		while (num4 < num)
	// 		{
	// 			double num5 = (double)num4 / (double)num;
	// 			progress.Set(num5);
	// 			Point val = RandomRectanglePoint((int)(num5 * (double)(Main.maxTilesX - 200)) + 100, (int)GenVars.rockLayer + 20, (int)num2, Main.maxTilesY - ((int)GenVars.rockLayer + 40) - 200);
	// 			if (remixWorldGen)
	// 			{
	// 				val = RandomRectanglePoint((int)(num5 * (double)(Main.maxTilesX - 200)) + 100, (int)GenVars.worldSurface + 100, (int)num2, (int)GenVars.rockLayer - (int)GenVars.worldSurface - 100);
	// 			}
	// 			while ((double)val.X > (double)Main.maxTilesX * 0.45 && (double)val.X < (double)Main.maxTilesX * 0.55)
	// 			{
	// 				val.X = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 			}
	// 			num3++;
	// 			if (GraniteBiome.CanPlace(val, GenVars.structures))
	// 			{
	// 				list.Add(val);
	// 				num4++;
	// 			}
	// 			else if (num3 > Main.maxTilesX * 10)
	// 			{
	// 				num = num4;
	// 				num4++;
	// 				num3 = 0;
	// 			}
	// 		}
	// 		GraniteBiome graniteBiome = GenVars.configuration.CreateBiome<GraniteBiome>();
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			graniteBiome.Place(list[i], GenVars.structures);
	// 		}
	// 	});
	IL_0395: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_039a: ldstr "Granite"
	IL_039f: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_22'
	IL_03a4: dup
	IL_03a5: brtrue.s IL_03be

	// (no C# code)
	IL_03a7: pop
	IL_03a8: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_03ad: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_22'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_03b3: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_03b8: dup
	IL_03b9: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_22'

	// 	AddGenerationPass("Dirt To Mud", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[14].Value;
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) * 0.001;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			progress.Set((double)i / num);
	// 			if (remixWorldGen)
	// 			{
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.worldSurface, (int)GenVars.rockLayerLow), genRand.Next(2, 6), genRand.Next(2, 40), 59, addTile: false, 0.0, 0.0, noYChange: false, overRide: true, 53);
	// 			}
	// 			else
	// 			{
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(2, 6), genRand.Next(2, 40), 59, addTile: false, 0.0, 0.0, noYChange: false, overRide: true, 53);
	// 			}
	// 		}
	// 	});
	IL_03be: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_03c3: ldstr "Dirt To Mud"
	IL_03c8: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_23'
	IL_03cd: dup
	IL_03ce: brtrue.s IL_03e7

	// (no C# code)
	IL_03d0: pop
	IL_03d1: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_03d6: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_23'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_03dc: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_03e1: dup
	IL_03e2: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_23'

	// 	AddGenerationPass("Silt", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[15].Value;
	// 		for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0001); i++)
	// 		{
	// 			int num = genRand.Next(0, Main.maxTilesX);
	// 			int num2 = genRand.Next((int)GenVars.rockLayerHigh, Main.maxTilesY);
	// 			if (remixWorldGen)
	// 			{
	// 				num2 = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 			}
	// 			if (Main.tile[num, num2].wall != 187 && Main.tile[num, num2].wall != 216)
	// 			{
	// 				TileRunner(num, num2, genRand.Next(5, 12), genRand.Next(15, 50), 123);
	// 			}
	// 		}
	// 		for (int j = 0; j < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0005); j++)
	// 		{
	// 			int num3 = genRand.Next(0, Main.maxTilesX);
	// 			int num4 = genRand.Next((int)GenVars.rockLayerHigh, Main.maxTilesY);
	// 			if (remixWorldGen)
	// 			{
	// 				num4 = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 			}
	// 			if (Main.tile[num3, num4].wall != 187 && Main.tile[num3, num4].wall != 216)
	// 			{
	// 				TileRunner(num3, num4, genRand.Next(2, 5), genRand.Next(2, 5), 123);
	// 			}
	// 		}
	// 	});
	IL_03e7: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_03ec: ldstr "Silt"
	IL_03f1: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_24'
	IL_03f6: dup
	IL_03f7: brtrue.s IL_0410

	// (no C# code)
	IL_03f9: pop
	IL_03fa: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_03ff: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_24'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0405: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_040a: dup
	IL_040b: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_24'

	// 	AddGenerationPass("Shinies", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[16].Value;
	// 		if (remixWorldGen)
	// 		{
	// 			for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh), genRand.Next(3, 6), genRand.Next(2, 6), GenVars.copper);
	// 			}
	// 			for (int j = 0; j < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 8E-05); j++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh), genRand.Next(3, 7), genRand.Next(3, 7), GenVars.copper);
	// 			}
	// 			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0002); k++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.copper);
	// 			}
	// 			for (int l = 0; l < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3E-05); l++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh), genRand.Next(3, 7), genRand.Next(2, 5), GenVars.iron);
	// 			}
	// 			for (int m = 0; m < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 8E-05); m++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh), genRand.Next(3, 6), genRand.Next(3, 6), GenVars.iron);
	// 			}
	// 			for (int n = 0; n < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0002); n++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.iron);
	// 			}
	// 			for (int num = 0; num < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.6E-05); num++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer - 100, Main.maxTilesY - 250), genRand.Next(3, 6), genRand.Next(3, 6), GenVars.silver);
	// 			}
	// 			for (int num2 = 0; num2 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00015); num2++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.worldSurface, (int)Main.rockLayer), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.silver);
	// 			}
	// 			for (int num3 = 0; num3 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00017); num3++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.silver);
	// 			}
	// 			for (int num4 = 0; num4 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00012); num4++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.gold = 8;
	// 					}
	// 					else
	// 					{
	// 						GenVars.gold = 169;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.worldSurface, (int)Main.rockLayer), genRand.Next(4, 8), genRand.Next(4, 8), GenVars.gold);
	// 			}
	// 			for (int num5 = 0; num5 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00012); num5++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.gold = 8;
	// 					}
	// 					else
	// 					{
	// 						GenVars.gold = 169;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow - 20), genRand.Next(4, 8), genRand.Next(4, 8), GenVars.gold);
	// 			}
	// 			if (drunkWorldGen)
	// 			{
	// 				for (int num6 = 0; num6 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05 / 2.0); num6++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 204);
	// 				}
	// 				for (int num7 = 0; num7 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05 / 2.0); num7++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 22);
	// 				}
	// 			}
	// 			if (crimson)
	// 			{
	// 				for (int num8 = 0; num8 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 4.25E-05); num8++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.worldSurface, (int)Main.rockLayer), genRand.Next(3, 6), genRand.Next(4, 8), 204);
	// 				}
	// 			}
	// 			else
	// 			{
	// 				for (int num9 = 0; num9 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 4.25E-05); num9++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.worldSurface, (int)Main.rockLayer), genRand.Next(3, 6), genRand.Next(4, 8), 22);
	// 				}
	// 			}
	// 		}
	// 		else
	// 		{
	// 			for (int num10 = 0; num10 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); num10++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh), genRand.Next(3, 6), genRand.Next(2, 6), GenVars.copper);
	// 			}
	// 			for (int num11 = 0; num11 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 8E-05); num11++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh), genRand.Next(3, 7), genRand.Next(3, 7), GenVars.copper);
	// 			}
	// 			for (int num12 = 0; num12 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0002); num12++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.copper = 7;
	// 					}
	// 					else
	// 					{
	// 						GenVars.copper = 166;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.copper);
	// 			}
	// 			for (int num13 = 0; num13 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3E-05); num13++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh), genRand.Next(3, 7), genRand.Next(2, 5), GenVars.iron);
	// 			}
	// 			for (int num14 = 0; num14 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 8E-05); num14++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh), genRand.Next(3, 6), genRand.Next(3, 6), GenVars.iron);
	// 			}
	// 			for (int num15 = 0; num15 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0002); num15++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.iron = 6;
	// 					}
	// 					else
	// 					{
	// 						GenVars.iron = 167;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.iron);
	// 			}
	// 			for (int num16 = 0; num16 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.6E-05); num16++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh), genRand.Next(3, 6), genRand.Next(3, 6), GenVars.silver);
	// 			}
	// 			for (int num17 = 0; num17 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00015); num17++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.silver);
	// 			}
	// 			for (int num18 = 0; num18 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00017); num18++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.silver = 9;
	// 					}
	// 					else
	// 					{
	// 						GenVars.silver = 168;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow), genRand.Next(4, 9), genRand.Next(4, 8), GenVars.silver);
	// 			}
	// 			for (int num19 = 0; num19 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00012); num19++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.gold = 8;
	// 					}
	// 					else
	// 					{
	// 						GenVars.gold = 169;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY), genRand.Next(4, 8), genRand.Next(4, 8), GenVars.gold);
	// 			}
	// 			for (int num20 = 0; num20 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00012); num20++)
	// 			{
	// 				if (drunkWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						GenVars.gold = 8;
	// 					}
	// 					else
	// 					{
	// 						GenVars.gold = 169;
	// 					}
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(0, (int)GenVars.worldSurfaceLow - 20), genRand.Next(4, 8), genRand.Next(4, 8), GenVars.gold);
	// 			}
	// 			if (drunkWorldGen)
	// 			{
	// 				for (int num21 = 0; num21 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05 / 2.0); num21++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 204);
	// 				}
	// 				for (int num22 = 0; num22 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05 / 2.0); num22++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 22);
	// 				}
	// 			}
	// 			if (crimson)
	// 			{
	// 				for (int num23 = 0; num23 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05); num23++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 204);
	// 				}
	// 			}
	// 			else
	// 			{
	// 				for (int num24 = 0; num24 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2.25E-05); num24++)
	// 				{
	// 					TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next((int)Main.rockLayer, Main.maxTilesY), genRand.Next(3, 6), genRand.Next(4, 8), 22);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0410: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0415: ldstr "Shinies"
	IL_041a: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_25'
	IL_041f: dup
	IL_0420: brtrue.s IL_0439

	// (no C# code)
	IL_0422: pop
	IL_0423: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0428: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_25'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_042e: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0433: dup
	IL_0434: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_25'

	// 	AddGenerationPass("Webs", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[17].Value;
	// 		for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0006); i++)
	// 		{
	// 			int j = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY - 20);
	// 			if (i < GenVars.numMCaves)
	// 			{
	// 				j = GenVars.mCaveX[i];
	// 				num = GenVars.mCaveY[i];
	// 			}
	// 			if (!Main.tile[j, num].active() && ((double)num > Main.worldSurface || Main.tile[j, num].wall > 0))
	// 			{
	// 				while (!Main.tile[j, num].active() && num > (int)GenVars.worldSurfaceLow)
	// 				{
	// 					num--;
	// 				}
	// 				num++;
	// 				int num2 = 1;
	// 				if (genRand.Next(2) == 0)
	// 				{
	// 					num2 = -1;
	// 				}
	// 				for (; !Main.tile[j, num].active() && j > 10 && j < Main.maxTilesX - 10; j += num2)
	// 				{
	// 				}
	// 				j -= num2;
	// 				if ((double)num > Main.worldSurface || Main.tile[j, num].wall > 0)
	// 				{
	// 					TileRunner(j, num, genRand.Next(4, 11), genRand.Next(2, 4), 51, addTile: true, num2, -1.0, noYChange: false, overRide: false);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0439: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_043e: ldstr "Webs"
	IL_0443: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_26'
	IL_0448: dup
	IL_0449: brtrue.s IL_0462

	// (no C# code)
	IL_044b: pop
	IL_044c: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0451: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_26'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0457: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_045c: dup
	IL_045d: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_26'

	// 	AddGenerationPass("Underworld", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[18].Value;
	// 		progress.Set(0.0);
	// 		int num = Main.maxTilesY - genRand.Next(150, 190);
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			num += genRand.Next(-3, 4);
	// 			if (num < Main.maxTilesY - 190)
	// 			{
	// 				num = Main.maxTilesY - 190;
	// 			}
	// 			if (num > Main.maxTilesY - 160)
	// 			{
	// 				num = Main.maxTilesY - 160;
	// 			}
	// 			for (int j = num - 20 - genRand.Next(3); j < Main.maxTilesY; j++)
	// 			{
	// 				if (j >= num)
	// 				{
	// 					Main.tile[i, j].active(active: false);
	// 					Main.tile[i, j].lava(lava: false);
	// 					Main.tile[i, j].liquid = 0;
	// 				}
	// 				else
	// 				{
	// 					Main.tile[i, j].type = 57;
	// 				}
	// 			}
	// 		}
	// 		int num2 = Main.maxTilesY - genRand.Next(40, 70);
	// 		for (int k = 10; k < Main.maxTilesX - 10; k++)
	// 		{
	// 			num2 += genRand.Next(-10, 11);
	// 			if (num2 > Main.maxTilesY - 60)
	// 			{
	// 				num2 = Main.maxTilesY - 60;
	// 			}
	// 			if (num2 < Main.maxTilesY - 100)
	// 			{
	// 				num2 = Main.maxTilesY - 120;
	// 			}
	// 			for (int l = num2; l < Main.maxTilesY - 10; l++)
	// 			{
	// 				if (!Main.tile[k, l].active())
	// 				{
	// 					Main.tile[k, l].lava(lava: true);
	// 					Main.tile[k, l].liquid = byte.MaxValue;
	// 				}
	// 			}
	// 		}
	// 		for (int m = 0; m < Main.maxTilesX; m++)
	// 		{
	// 			if (genRand.Next(50) == 0)
	// 			{
	// 				int num3 = Main.maxTilesY - 65;
	// 				while (!Main.tile[m, num3].active() && num3 > Main.maxTilesY - 135)
	// 				{
	// 					num3--;
	// 				}
	// 				TileRunner(genRand.Next(0, Main.maxTilesX), num3 + genRand.Next(20, 50), genRand.Next(15, 20), 1000, 57, addTile: true, 0.0, genRand.Next(1, 3), noYChange: true);
	// 			}
	// 		}
	// 		Liquid.QuickWater(-2);
	// 		for (int n = 0; n < Main.maxTilesX; n++)
	// 		{
	// 			double num4 = (double)n / (double)(Main.maxTilesX - 1);
	// 			progress.Set(num4 / 2.0 + 0.5);
	// 			if (genRand.Next(13) == 0)
	// 			{
	// 				int num5 = Main.maxTilesY - 65;
	// 				while ((Main.tile[n, num5].liquid > 0 || Main.tile[n, num5].active()) && num5 > Main.maxTilesY - 140)
	// 				{
	// 					num5--;
	// 				}
	// 				if ((!drunkWorldGen && !remixWorldGen) || genRand.Next(3) == 0 || !((double)n > (double)Main.maxTilesX * 0.4) || !((double)n < (double)Main.maxTilesX * 0.6))
	// 				{
	// 					TileRunner(n, num5 - genRand.Next(2, 5), genRand.Next(5, 30), 1000, 57, addTile: true, 0.0, genRand.Next(1, 3), noYChange: true);
	// 				}
	// 				double num6 = genRand.Next(1, 3);
	// 				if (genRand.Next(3) == 0)
	// 				{
	// 					num6 *= 0.5;
	// 				}
	// 				if ((!drunkWorldGen && !remixWorldGen) || genRand.Next(3) == 0 || !((double)n > (double)Main.maxTilesX * 0.4) || !((double)n < (double)Main.maxTilesX * 0.6))
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						TileRunner(n, num5 - genRand.Next(2, 5), (int)((double)genRand.Next(5, 15) * num6), (int)((double)genRand.Next(10, 15) * num6), 57, addTile: true, 1.0, 0.3);
	// 					}
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						num6 = genRand.Next(1, 3);
	// 						TileRunner(n, num5 - genRand.Next(2, 5), (int)((double)genRand.Next(5, 15) * num6), (int)((double)genRand.Next(10, 15) * num6), 57, addTile: true, -1.0, 0.3);
	// 					}
	// 				}
	// 				TileRunner(n + genRand.Next(-10, 10), num5 + genRand.Next(-10, 10), genRand.Next(5, 15), genRand.Next(5, 10), -2, addTile: false, genRand.Next(-1, 3), genRand.Next(-1, 3));
	// 				if (genRand.Next(3) == 0)
	// 				{
	// 					TileRunner(n + genRand.Next(-10, 10), num5 + genRand.Next(-10, 10), genRand.Next(10, 30), genRand.Next(10, 20), -2, addTile: false, genRand.Next(-1, 3), genRand.Next(-1, 3));
	// 				}
	// 				if (genRand.Next(5) == 0)
	// 				{
	// 					TileRunner(n + genRand.Next(-15, 15), num5 + genRand.Next(-15, 10), genRand.Next(15, 30), genRand.Next(5, 20), -2, addTile: false, genRand.Next(-1, 3), genRand.Next(-1, 3));
	// 				}
	// 			}
	// 		}
	// 		for (int num7 = 0; num7 < Main.maxTilesX; num7++)
	// 		{
	// 			TileRunner(genRand.Next(20, Main.maxTilesX - 20), genRand.Next(Main.maxTilesY - 180, Main.maxTilesY - 10), genRand.Next(2, 7), genRand.Next(2, 7), -2);
	// 		}
	// 		if (drunkWorldGen || remixWorldGen)
	// 		{
	// 			for (int num8 = 0; num8 < Main.maxTilesX * 2; num8++)
	// 			{
	// 				TileRunner(genRand.Next((int)((double)Main.maxTilesX * 0.35), (int)((double)Main.maxTilesX * 0.65)), genRand.Next(Main.maxTilesY - 180, Main.maxTilesY - 10), genRand.Next(5, 20), genRand.Next(5, 10), -2);
	// 			}
	// 		}
	// 		for (int num9 = 0; num9 < Main.maxTilesX; num9++)
	// 		{
	// 			if (!Main.tile[num9, Main.maxTilesY - 145].active())
	// 			{
	// 				Main.tile[num9, Main.maxTilesY - 145].liquid = byte.MaxValue;
	// 				Main.tile[num9, Main.maxTilesY - 145].lava(lava: true);
	// 			}
	// 			if (!Main.tile[num9, Main.maxTilesY - 144].active())
	// 			{
	// 				Main.tile[num9, Main.maxTilesY - 144].liquid = byte.MaxValue;
	// 				Main.tile[num9, Main.maxTilesY - 144].lava(lava: true);
	// 			}
	// 		}
	// 		for (int num10 = 0; num10 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0008); num10++)
	// 		{
	// 			TileRunner(genRand.Next(0, Main.maxTilesX), genRand.Next(Main.maxTilesY - 140, Main.maxTilesY), genRand.Next(2, 7), genRand.Next(3, 7), 58);
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			int num11 = (int)((double)Main.maxTilesX * 0.38);
	// 			int num12 = (int)((double)Main.maxTilesX * 0.62);
	// 			int num13 = num11;
	// 			int num14 = Main.maxTilesY - 1;
	// 			int num15 = Main.maxTilesY - 135;
	// 			int num16 = Main.maxTilesY - 160;
	// 			bool flag = false;
	// 			Liquid.QuickWater(-2);
	// 			for (; num14 < Main.maxTilesY - 1 || num13 < num12; num13++)
	// 			{
	// 				if (!flag)
	// 				{
	// 					num14 -= genRand.Next(1, 4);
	// 					if (num14 < num15)
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 				else if (num13 >= num12)
	// 				{
	// 					num14 += genRand.Next(1, 4);
	// 					if (num14 > Main.maxTilesY - 1)
	// 					{
	// 						num14 = Main.maxTilesY - 1;
	// 					}
	// 				}
	// 				else
	// 				{
	// 					if ((num13 <= Main.maxTilesX / 2 - 5 || num13 >= Main.maxTilesX / 2 + 5) && genRand.Next(4) == 0)
	// 					{
	// 						if (genRand.Next(3) == 0)
	// 						{
	// 							num14 += genRand.Next(-1, 2);
	// 						}
	// 						else if (genRand.Next(6) == 0)
	// 						{
	// 							num14 += genRand.Next(-2, 3);
	// 						}
	// 						else if (genRand.Next(8) == 0)
	// 						{
	// 							num14 += genRand.Next(-4, 5);
	// 						}
	// 					}
	// 					if (num14 < num16)
	// 					{
	// 						num14 = num16;
	// 					}
	// 					if (num14 > num15)
	// 					{
	// 						num14 = num15;
	// 					}
	// 				}
	// 				for (int num17 = num14; num17 > num14 - 20; num17--)
	// 				{
	// 					Main.tile[num13, num17].liquid = 0;
	// 				}
	// 				for (int num18 = num14; num18 < Main.maxTilesY; num18++)
	// 				{
	// 					Main.tile[num13, num18].Clear(TileDataType.All);
	// 					Main.tile[num13, num18].active(active: true);
	// 					Main.tile[num13, num18].type = 57;
	// 				}
	// 			}
	// 			Liquid.QuickWater(-2);
	// 			for (int num19 = num11; num19 < num12 + 15; num19++)
	// 			{
	// 				for (int num20 = Main.maxTilesY - 300; num20 < num15 + 20; num20++)
	// 				{
	// 					Main.tile[num19, num20].liquid = 0;
	// 					if (Main.tile[num19, num20].type == 57 && Main.tile[num19, num20].active() && (!Main.tile[num19 - 1, num20 - 1].active() || !Main.tile[num19, num20 - 1].active() || !Main.tile[num19 + 1, num20 - 1].active() || !Main.tile[num19 - 1, num20].active() || !Main.tile[num19 + 1, num20].active() || !Main.tile[num19 - 1, num20 + 1].active() || !Main.tile[num19, num20 + 1].active() || !Main.tile[num19 + 1, num20 + 1].active()))
	// 					{
	// 						Main.tile[num19, num20].type = 633;
	// 					}
	// 				}
	// 			}
	// 			for (int num21 = num11; num21 < num12 + 15; num21++)
	// 			{
	// 				for (int num22 = Main.maxTilesY - 200; num22 < num15 + 20; num22++)
	// 				{
	// 					if (Main.tile[num21, num22].type == 633 && Main.tile[num21, num22].active() && !Main.tile[num21, num22 - 1].active() && genRand.Next(3) == 0)
	// 					{
	// 						TryGrowingTreeByType(634, num21, num22);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		else if (!drunkWorldGen)
	// 		{
	// 			for (int num23 = 25; num23 < Main.maxTilesX - 25; num23++)
	// 			{
	// 				if ((double)num23 < (double)Main.maxTilesX * 0.17 || (double)num23 > (double)Main.maxTilesX * 0.83)
	// 				{
	// 					for (int num24 = Main.maxTilesY - 300; num24 < Main.maxTilesY - 100 + genRand.Next(-1, 2); num24++)
	// 					{
	// 						if (Main.tile[num23, num24].type == 57 && Main.tile[num23, num24].active() && (!Main.tile[num23 - 1, num24 - 1].active() || !Main.tile[num23, num24 - 1].active() || !Main.tile[num23 + 1, num24 - 1].active() || !Main.tile[num23 - 1, num24].active() || !Main.tile[num23 + 1, num24].active() || !Main.tile[num23 - 1, num24 + 1].active() || !Main.tile[num23, num24 + 1].active() || !Main.tile[num23 + 1, num24 + 1].active()))
	// 						{
	// 							Main.tile[num23, num24].type = 633;
	// 						}
	// 					}
	// 				}
	// 			}
	// 			for (int num25 = 25; num25 < Main.maxTilesX - 25; num25++)
	// 			{
	// 				if ((double)num25 < (double)Main.maxTilesX * 0.17 || (double)num25 > (double)Main.maxTilesX * 0.83)
	// 				{
	// 					for (int num26 = Main.maxTilesY - 200; num26 < Main.maxTilesY - 50; num26++)
	// 					{
	// 						if (Main.tile[num25, num26].type == 633 && Main.tile[num25, num26].active() && !Main.tile[num25, num26 - 1].active() && genRand.Next(3) == 0)
	// 						{
	// 							TryGrowingTreeByType(634, num25, num26);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		AddHellHouses();
	// 		if (drunkWorldGen)
	// 		{
	// 			for (int num27 = 25; num27 < Main.maxTilesX - 25; num27++)
	// 			{
	// 				for (int num28 = Main.maxTilesY - 300; num28 < Main.maxTilesY - 100 + genRand.Next(-1, 2); num28++)
	// 				{
	// 					if (Main.tile[num27, num28].type == 57 && Main.tile[num27, num28].active() && (!Main.tile[num27 - 1, num28 - 1].active() || !Main.tile[num27, num28 - 1].active() || !Main.tile[num27 + 1, num28 - 1].active() || !Main.tile[num27 - 1, num28].active() || !Main.tile[num27 + 1, num28].active() || !Main.tile[num27 - 1, num28 + 1].active() || !Main.tile[num27, num28 + 1].active() || !Main.tile[num27 + 1, num28 + 1].active()))
	// 					{
	// 						Main.tile[num27, num28].type = 633;
	// 					}
	// 				}
	// 			}
	// 			for (int num29 = 25; num29 < Main.maxTilesX - 25; num29++)
	// 			{
	// 				for (int num30 = Main.maxTilesY - 200; num30 < Main.maxTilesY - 50; num30++)
	// 				{
	// 					if (Main.tile[num29, num30].type == 633 && Main.tile[num29, num30].active() && !Main.tile[num29, num30 - 1].active() && genRand.Next(3) == 0)
	// 					{
	// 						TryGrowingTreeByType(634, num29, num30);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0462: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0467: ldstr "Underworld"
	IL_046c: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_27'
	IL_0471: dup
	IL_0472: brtrue.s IL_048b

	// (no C# code)
	IL_0474: pop
	IL_0475: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_047a: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_27'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0480: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0485: dup
	IL_0486: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_27'

	// 	AddGenerationPass("Corruption", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		int num = Main.maxTilesX;
	// 		int num2 = 0;
	// 		int num3 = Main.maxTilesX;
	// 		int num4 = 0;
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			for (int j = 0; (double)j < Main.worldSurface; j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					if (Main.tile[i, j].type == 60)
	// 					{
	// 						if (i < num)
	// 						{
	// 							num = i;
	// 						}
	// 						if (i > num2)
	// 						{
	// 							num2 = i;
	// 						}
	// 					}
	// 					else if (Main.tile[i, j].type == 147 || Main.tile[i, j].type == 161)
	// 					{
	// 						if (i < num3)
	// 						{
	// 							num3 = i;
	// 						}
	// 						if (i > num4)
	// 						{
	// 							num4 = i;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		int num5 = 10;
	// 		num -= num5;
	// 		num2 += num5;
	// 		num3 -= num5;
	// 		num4 += num5;
	// 		int num6 = 500;
	// 		int num7 = 100;
	// 		bool flag = crimson;
	// 		double num8 = (double)Main.maxTilesX * 0.00045;
	// 		if (remixWorldGen)
	// 		{
	// 			num8 *= 2.0;
	// 		}
	// 		else if (tenthAnniversaryWorldGen)
	// 		{
	// 			num6 *= 2;
	// 			num7 *= 2;
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			flag = true;
	// 			num8 /= 2.0;
	// 		}
	// 		if (flag)
	// 		{
	// 			progress.Message = Lang.gen[72].Value;
	// 			for (int k = 0; (double)k < num8; k++)
	// 			{
	// 				int num9 = num3;
	// 				int num10 = num4;
	// 				int num11 = num;
	// 				int num12 = num2;
	// 				double value = (double)k / num8;
	// 				progress.Set(value);
	// 				bool flag2 = false;
	// 				int num13 = 0;
	// 				int num14 = 0;
	// 				int num15 = 0;
	// 				while (!flag2)
	// 				{
	// 					flag2 = true;
	// 					int num16 = Main.maxTilesX / 2;
	// 					int num17 = 200;
	// 					if (drunkWorldGen)
	// 					{
	// 						num17 = 100;
	// 						num13 = ((!GenVars.crimsonLeft) ? genRand.Next((int)((double)Main.maxTilesX * 0.5), Main.maxTilesX - num6) : genRand.Next(num6, (int)((double)Main.maxTilesX * 0.5)));
	// 					}
	// 					else
	// 					{
	// 						num13 = genRand.Next(num6, Main.maxTilesX - num6);
	// 					}
	// 					num14 = num13 - genRand.Next(200) - 100;
	// 					num15 = num13 + genRand.Next(200) + 100;
	// 					if (num14 < GenVars.evilBiomeBeachAvoidance)
	// 					{
	// 						num14 = GenVars.evilBiomeBeachAvoidance;
	// 					}
	// 					if (num15 > Main.maxTilesX - GenVars.evilBiomeBeachAvoidance)
	// 					{
	// 						num15 = Main.maxTilesX - GenVars.evilBiomeBeachAvoidance;
	// 					}
	// 					if (num13 < num14 + GenVars.evilBiomeAvoidanceMidFixer)
	// 					{
	// 						num13 = num14 + GenVars.evilBiomeAvoidanceMidFixer;
	// 					}
	// 					if (num13 > num15 - GenVars.evilBiomeAvoidanceMidFixer)
	// 					{
	// 						num13 = num15 - GenVars.evilBiomeAvoidanceMidFixer;
	// 					}
	// 					if (GenVars.dungeonSide < 0 && num14 < 400)
	// 					{
	// 						num14 = 400;
	// 					}
	// 					else if (GenVars.dungeonSide > 0 && num14 > Main.maxTilesX - 400)
	// 					{
	// 						num14 = Main.maxTilesX - 400;
	// 					}
	// 					if (num14 < GenVars.dungeonLocation + num7 && num15 > GenVars.dungeonLocation - num7)
	// 					{
	// 						flag2 = false;
	// 					}
	// 					if (!remixWorldGen)
	// 					{
	// 						if (!tenthAnniversaryWorldGen)
	// 						{
	// 							if (num13 > num16 - num17 && num13 < num16 + num17)
	// 							{
	// 								flag2 = false;
	// 							}
	// 							if (num14 > num16 - num17 && num14 < num16 + num17)
	// 							{
	// 								flag2 = false;
	// 							}
	// 							if (num15 > num16 - num17 && num15 < num16 + num17)
	// 							{
	// 								flag2 = false;
	// 							}
	// 						}
	// 						if (num13 > GenVars.UndergroundDesertLocation.X && num13 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag2 = false;
	// 						}
	// 						if (num14 > GenVars.UndergroundDesertLocation.X && num14 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag2 = false;
	// 						}
	// 						if (num15 > GenVars.UndergroundDesertLocation.X && num15 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag2 = false;
	// 						}
	// 						if (num14 < num10 && num15 > num9)
	// 						{
	// 							num9++;
	// 							num10--;
	// 							flag2 = false;
	// 						}
	// 						if (num14 < num12 && num15 > num11)
	// 						{
	// 							num11++;
	// 							num12--;
	// 							flag2 = false;
	// 						}
	// 					}
	// 				}
	// 				CrimStart(num13, (int)GenVars.worldSurfaceLow - 10);
	// 				for (int l = num14; l < num15; l++)
	// 				{
	// 					for (int m = (int)GenVars.worldSurfaceLow; (double)m < Main.worldSurface - 1.0; m++)
	// 					{
	// 						if (Main.tile[l, m].active())
	// 						{
	// 							int num18 = m + genRand.Next(10, 14);
	// 							for (int n = m; n < num18; n++)
	// 							{
	// 								if (Main.tile[l, n].type == 60 && l >= num14 + genRand.Next(5) && l < num15 - genRand.Next(5))
	// 								{
	// 									Main.tile[l, n].type = 662;
	// 								}
	// 							}
	// 							break;
	// 						}
	// 					}
	// 				}
	// 				double num19 = Main.worldSurface + 40.0;
	// 				for (int num20 = num14; num20 < num15; num20++)
	// 				{
	// 					num19 += (double)genRand.Next(-2, 3);
	// 					if (num19 < Main.worldSurface + 30.0)
	// 					{
	// 						num19 = Main.worldSurface + 30.0;
	// 					}
	// 					if (num19 > Main.worldSurface + 50.0)
	// 					{
	// 						num19 = Main.worldSurface + 50.0;
	// 					}
	// 					bool flag3 = false;
	// 					for (int num21 = (int)GenVars.worldSurfaceLow; (double)num21 < num19; num21++)
	// 					{
	// 						if (Main.tile[num20, num21].active())
	// 						{
	// 							if (Main.tile[num20, num21].type == 53 && num20 >= num14 + genRand.Next(5) && num20 <= num15 - genRand.Next(5))
	// 							{
	// 								Main.tile[num20, num21].type = 234;
	// 							}
	// 							if ((double)num21 < Main.worldSurface - 1.0 && !flag3)
	// 							{
	// 								if (Main.tile[num20, num21].type == 0)
	// 								{
	// 									grassSpread = 0;
	// 									SpreadGrass(num20, num21, 0, 199);
	// 								}
	// 								else if (Main.tile[num20, num21].type == 59)
	// 								{
	// 									grassSpread = 0;
	// 									SpreadGrass(num20, num21, 59, 662);
	// 								}
	// 							}
	// 							flag3 = true;
	// 							if (Main.tile[num20, num21].wall == 216)
	// 							{
	// 								Main.tile[num20, num21].wall = 218;
	// 							}
	// 							else if (Main.tile[num20, num21].wall == 187)
	// 							{
	// 								Main.tile[num20, num21].wall = 221;
	// 							}
	// 							if (Main.tile[num20, num21].type == 1)
	// 							{
	// 								if (num20 >= num14 + genRand.Next(5) && num20 <= num15 - genRand.Next(5))
	// 								{
	// 									Main.tile[num20, num21].type = 203;
	// 								}
	// 							}
	// 							else if (Main.tile[num20, num21].type == 2)
	// 							{
	// 								Main.tile[num20, num21].type = 199;
	// 							}
	// 							else if (Main.tile[num20, num21].type == 60)
	// 							{
	// 								Main.tile[num20, num21].type = 662;
	// 							}
	// 							else if (Main.tile[num20, num21].type == 161)
	// 							{
	// 								Main.tile[num20, num21].type = 200;
	// 							}
	// 							else if (Main.tile[num20, num21].type == 396)
	// 							{
	// 								Main.tile[num20, num21].type = 401;
	// 							}
	// 							else if (Main.tile[num20, num21].type == 397)
	// 							{
	// 								Main.tile[num20, num21].type = 399;
	// 							}
	// 						}
	// 					}
	// 				}
	// 				int num22 = genRand.Next(10, 15);
	// 				for (int num23 = 0; num23 < num22; num23++)
	// 				{
	// 					int num24 = 0;
	// 					bool flag4 = false;
	// 					int num25 = 0;
	// 					while (!flag4)
	// 					{
	// 						num24++;
	// 						int x = genRand.Next(num14 - num25, num15 + num25);
	// 						int num26 = genRand.Next((int)(Main.worldSurface - (double)(num25 / 2)), (int)(Main.worldSurface + 100.0 + (double)num25));
	// 						while (oceanDepths(x, num26))
	// 						{
	// 							x = genRand.Next(num14 - num25, num15 + num25);
	// 							num26 = genRand.Next((int)(Main.worldSurface - (double)(num25 / 2)), (int)(Main.worldSurface + 100.0 + (double)num25));
	// 						}
	// 						if (num24 > 100)
	// 						{
	// 							num25++;
	// 							num24 = 0;
	// 						}
	// 						if (!Main.tile[x, num26].active())
	// 						{
	// 							for (; !Main.tile[x, num26].active(); num26++)
	// 							{
	// 							}
	// 							num26--;
	// 						}
	// 						else
	// 						{
	// 							while (Main.tile[x, num26].active() && (double)num26 > Main.worldSurface)
	// 							{
	// 								num26--;
	// 							}
	// 						}
	// 						if ((num25 > 10 || (Main.tile[x, num26 + 1].active() && Main.tile[x, num26 + 1].type == 203)) && !IsTileNearby(x, num26, 26, 3))
	// 						{
	// 							Place3x2(x, num26, 26, 1);
	// 							if (Main.tile[x, num26].type == 26)
	// 							{
	// 								flag4 = true;
	// 							}
	// 						}
	// 						if (num25 > 100)
	// 						{
	// 							flag4 = true;
	// 						}
	// 					}
	// 				}
	// 			}
	// 			CrimPlaceHearts();
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			flag = false;
	// 		}
	// 		if (!flag)
	// 		{
	// 			progress.Message = Lang.gen[20].Value;
	// 			for (int num27 = 0; (double)num27 < num8; num27++)
	// 			{
	// 				int num28 = num3;
	// 				int num29 = num4;
	// 				int num30 = num;
	// 				int num31 = num2;
	// 				double value2 = (double)num27 / num8;
	// 				progress.Set(value2);
	// 				bool flag5 = false;
	// 				int num32 = 0;
	// 				int num33 = 0;
	// 				int num34 = 0;
	// 				while (!flag5)
	// 				{
	// 					flag5 = true;
	// 					int num35 = Main.maxTilesX / 2;
	// 					int num36 = 200;
	// 					num32 = ((!drunkWorldGen) ? genRand.Next(num6, Main.maxTilesX - num6) : (GenVars.crimsonLeft ? genRand.Next((int)((double)Main.maxTilesX * 0.5), Main.maxTilesX - num6) : genRand.Next(num6, (int)((double)Main.maxTilesX * 0.5))));
	// 					num33 = num32 - genRand.Next(200) - 100;
	// 					num34 = num32 + genRand.Next(200) + 100;
	// 					if (num33 < GenVars.evilBiomeBeachAvoidance)
	// 					{
	// 						num33 = GenVars.evilBiomeBeachAvoidance;
	// 					}
	// 					if (num34 > Main.maxTilesX - GenVars.evilBiomeBeachAvoidance)
	// 					{
	// 						num34 = Main.maxTilesX - GenVars.evilBiomeBeachAvoidance;
	// 					}
	// 					if (num32 < num33 + GenVars.evilBiomeAvoidanceMidFixer)
	// 					{
	// 						num32 = num33 + GenVars.evilBiomeAvoidanceMidFixer;
	// 					}
	// 					if (num32 > num34 - GenVars.evilBiomeAvoidanceMidFixer)
	// 					{
	// 						num32 = num34 - GenVars.evilBiomeAvoidanceMidFixer;
	// 					}
	// 					if (num33 < GenVars.dungeonLocation + num7 && num34 > GenVars.dungeonLocation - num7)
	// 					{
	// 						flag5 = false;
	// 					}
	// 					if (!remixWorldGen)
	// 					{
	// 						if (!tenthAnniversaryWorldGen)
	// 						{
	// 							if (num32 > num35 - num36 && num32 < num35 + num36)
	// 							{
	// 								flag5 = false;
	// 							}
	// 							if (num33 > num35 - num36 && num33 < num35 + num36)
	// 							{
	// 								flag5 = false;
	// 							}
	// 							if (num34 > num35 - num36 && num34 < num35 + num36)
	// 							{
	// 								flag5 = false;
	// 							}
	// 						}
	// 						if (num32 > GenVars.UndergroundDesertLocation.X && num32 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag5 = false;
	// 						}
	// 						if (num33 > GenVars.UndergroundDesertLocation.X && num33 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag5 = false;
	// 						}
	// 						if (num34 > GenVars.UndergroundDesertLocation.X && num34 < GenVars.UndergroundDesertLocation.X + GenVars.UndergroundDesertLocation.Width)
	// 						{
	// 							flag5 = false;
	// 						}
	// 						if (num33 < num29 && num34 > num28)
	// 						{
	// 							num28++;
	// 							num29--;
	// 							flag5 = false;
	// 						}
	// 						if (num33 < num31 && num34 > num30)
	// 						{
	// 							num30++;
	// 							num31--;
	// 							flag5 = false;
	// 						}
	// 					}
	// 				}
	// 				int num37 = 0;
	// 				for (int num38 = num33; num38 < num34; num38++)
	// 				{
	// 					if (num37 > 0)
	// 					{
	// 						num37--;
	// 					}
	// 					if (num38 == num32 || num37 == 0)
	// 					{
	// 						for (int num39 = (int)GenVars.worldSurfaceLow; (double)num39 < Main.worldSurface - 1.0; num39++)
	// 						{
	// 							if (Main.tile[num38, num39].active() || Main.tile[num38, num39].wall > 0)
	// 							{
	// 								if (num38 == num32)
	// 								{
	// 									num37 = 20;
	// 									ChasmRunner(num38, num39, genRand.Next(150) + 150, makeOrb: true);
	// 								}
	// 								else if (genRand.Next(35) == 0 && num37 == 0)
	// 								{
	// 									num37 = 30;
	// 									bool makeOrb = true;
	// 									ChasmRunner(num38, num39, genRand.Next(50) + 50, makeOrb);
	// 								}
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					for (int num40 = (int)GenVars.worldSurfaceLow; (double)num40 < Main.worldSurface - 1.0; num40++)
	// 					{
	// 						if (Main.tile[num38, num40].active())
	// 						{
	// 							int num41 = num40 + genRand.Next(10, 14);
	// 							for (int num42 = num40; num42 < num41; num42++)
	// 							{
	// 								if (Main.tile[num38, num42].type == 60 && num38 >= num33 + genRand.Next(5) && num38 < num34 - genRand.Next(5))
	// 								{
	// 									Main.tile[num38, num42].type = 661;
	// 								}
	// 							}
	// 							break;
	// 						}
	// 					}
	// 				}
	// 				double num43 = Main.worldSurface + 40.0;
	// 				for (int num44 = num33; num44 < num34; num44++)
	// 				{
	// 					num43 += (double)genRand.Next(-2, 3);
	// 					if (num43 < Main.worldSurface + 30.0)
	// 					{
	// 						num43 = Main.worldSurface + 30.0;
	// 					}
	// 					if (num43 > Main.worldSurface + 50.0)
	// 					{
	// 						num43 = Main.worldSurface + 50.0;
	// 					}
	// 					bool flag6 = false;
	// 					for (int num45 = (int)GenVars.worldSurfaceLow; (double)num45 < num43; num45++)
	// 					{
	// 						if (Main.tile[num44, num45].active())
	// 						{
	// 							if (Main.tile[num44, num45].type == 53 && num44 >= num33 + genRand.Next(5) && num44 <= num34 - genRand.Next(5))
	// 							{
	// 								Main.tile[num44, num45].type = 112;
	// 							}
	// 							if ((double)num45 < Main.worldSurface - 1.0 && !flag6)
	// 							{
	// 								if (Main.tile[num44, num45].type == 0)
	// 								{
	// 									grassSpread = 0;
	// 									SpreadGrass(num44, num45, 0, 23);
	// 								}
	// 								else if (Main.tile[num44, num45].type == 59)
	// 								{
	// 									grassSpread = 0;
	// 									SpreadGrass(num44, num45, 59, 661);
	// 								}
	// 							}
	// 							flag6 = true;
	// 							if (Main.tile[num44, num45].wall == 216)
	// 							{
	// 								Main.tile[num44, num45].wall = 217;
	// 							}
	// 							else if (Main.tile[num44, num45].wall == 187)
	// 							{
	// 								Main.tile[num44, num45].wall = 220;
	// 							}
	// 							if (Main.tile[num44, num45].type == 1)
	// 							{
	// 								if (num44 >= num33 + genRand.Next(5) && num44 <= num34 - genRand.Next(5))
	// 								{
	// 									Main.tile[num44, num45].type = 25;
	// 								}
	// 							}
	// 							else if (Main.tile[num44, num45].type == 2)
	// 							{
	// 								Main.tile[num44, num45].type = 23;
	// 							}
	// 							else if (Main.tile[num44, num45].type == 60)
	// 							{
	// 								Main.tile[num44, num45].type = 661;
	// 							}
	// 							else if (Main.tile[num44, num45].type == 161)
	// 							{
	// 								Main.tile[num44, num45].type = 163;
	// 							}
	// 							else if (Main.tile[num44, num45].type == 396)
	// 							{
	// 								Main.tile[num44, num45].type = 400;
	// 							}
	// 							else if (Main.tile[num44, num45].type == 397)
	// 							{
	// 								Main.tile[num44, num45].type = 398;
	// 							}
	// 						}
	// 					}
	// 				}
	// 				for (int num46 = num33; num46 < num34; num46++)
	// 				{
	// 					for (int num47 = 0; num47 < Main.maxTilesY - 50; num47++)
	// 					{
	// 						if (Main.tile[num46, num47].active() && Main.tile[num46, num47].type == 31)
	// 						{
	// 							int num48 = num46 - 13;
	// 							int num49 = num46 + 13;
	// 							int num50 = num47 - 13;
	// 							int num51 = num47 + 13;
	// 							for (int num52 = num48; num52 < num49; num52++)
	// 							{
	// 								if (num52 > 10 && num52 < Main.maxTilesX - 10)
	// 								{
	// 									for (int num53 = num50; num53 < num51; num53++)
	// 									{
	// 										if (Math.Abs(num52 - num46) + Math.Abs(num53 - num47) < 9 + genRand.Next(11) && genRand.Next(3) != 0 && Main.tile[num52, num53].type != 31)
	// 										{
	// 											Main.tile[num52, num53].active(active: true);
	// 											Main.tile[num52, num53].type = 25;
	// 											if (Math.Abs(num52 - num46) <= 1 && Math.Abs(num53 - num47) <= 1)
	// 											{
	// 												Main.tile[num52, num53].active(active: false);
	// 											}
	// 										}
	// 										if (Main.tile[num52, num53].type != 31 && Math.Abs(num52 - num46) <= 2 + genRand.Next(3) && Math.Abs(num53 - num47) <= 2 + genRand.Next(3))
	// 										{
	// 											Main.tile[num52, num53].active(active: false);
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_048b: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0490: ldstr "Corruption"
	IL_0495: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_28'
	IL_049a: dup
	IL_049b: brtrue.s IL_04b4

	// (no C# code)
	IL_049d: pop
	IL_049e: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_04a3: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_28'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_04a9: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_04ae: dup
	IL_04af: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_28'

	// 	AddGenerationPass("Lakes", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[19].Value;
	// 		double num = (double)Main.maxTilesX / 4200.0;
	// 		int num2 = genRand.Next((int)(num * 3.0), (int)(num * 6.0));
	// 		for (int i = 0; i < num2; i++)
	// 		{
	// 			int num3 = Main.maxTilesX / 4;
	// 			if (GenVars.numLakes >= GenVars.maxLakes - 1)
	// 			{
	// 				break;
	// 			}
	// 			double value = (double)i / (double)num2;
	// 			progress.Set(value);
	// 			while (num3 > 0)
	// 			{
	// 				bool flag = false;
	// 				num3--;
	// 				int num4 = genRand.Next(GenVars.lakesBeachAvoidance, Main.maxTilesX - GenVars.lakesBeachAvoidance);
	// 				if (tenthAnniversaryWorldGen && !remixWorldGen)
	// 				{
	// 					num4 = genRand.Next((int)((double)Main.maxTilesX * 0.15), (int)((double)Main.maxTilesX * 0.85));
	// 				}
	// 				else
	// 				{
	// 					while ((double)num4 > (double)Main.maxTilesX * 0.45 && (double)num4 < (double)Main.maxTilesX * 0.55)
	// 					{
	// 						num4 = genRand.Next(GenVars.lakesBeachAvoidance, Main.maxTilesX - GenVars.lakesBeachAvoidance);
	// 					}
	// 				}
	// 				for (int j = 0; j < GenVars.numLakes; j++)
	// 				{
	// 					if (Math.Abs(num4 - GenVars.LakeX[j]) < 150)
	// 					{
	// 						flag = true;
	// 						break;
	// 					}
	// 				}
	// 				for (int k = 0; k < GenVars.numMCaves; k++)
	// 				{
	// 					if (Math.Abs(num4 - GenVars.mCaveX[k]) < 100)
	// 					{
	// 						flag = true;
	// 						break;
	// 					}
	// 				}
	// 				for (int l = 0; l < GenVars.numTunnels; l++)
	// 				{
	// 					if (Math.Abs(num4 - GenVars.tunnelX[l]) < 100)
	// 					{
	// 						flag = true;
	// 						break;
	// 					}
	// 				}
	// 				if (!flag)
	// 				{
	// 					int num5 = (int)GenVars.worldSurfaceLow - 20;
	// 					while (!Main.tile[num4, num5].active())
	// 					{
	// 						num5++;
	// 						if ((double)num5 >= Main.worldSurface || Main.tile[num4, num5].wall > 0)
	// 						{
	// 							flag = true;
	// 							break;
	// 						}
	// 					}
	// 					if (Main.tile[num4, num5].type == 53)
	// 					{
	// 						flag = true;
	// 					}
	// 					if (!flag)
	// 					{
	// 						int num6 = 50;
	// 						for (int m = num4 - num6; m <= num4 + num6; m++)
	// 						{
	// 							for (int n = num5 - num6; n <= num5 + num6; n++)
	// 							{
	// 								if (Main.tile[m, n].type == 203 || Main.tile[m, n].type == 25)
	// 								{
	// 									flag = true;
	// 									break;
	// 								}
	// 							}
	// 						}
	// 						if (!flag)
	// 						{
	// 							int num7 = num5;
	// 							num6 = 20;
	// 							while (!SolidTile(num4 - num6, num5) || !SolidTile(num4 + num6, num5))
	// 							{
	// 								num5++;
	// 								if ((double)num5 > Main.worldSurface - 50.0)
	// 								{
	// 									flag = true;
	// 								}
	// 							}
	// 							if (num5 - num7 <= 10)
	// 							{
	// 								num6 = 60;
	// 								for (int num8 = num4 - num6; num8 <= num4 + num6; num8++)
	// 								{
	// 									int y = num5 - 20;
	// 									if (Main.tile[num8, y].active() || Main.tile[num8, y].wall > 0)
	// 									{
	// 										flag = true;
	// 									}
	// 								}
	// 								if (!flag)
	// 								{
	// 									int num9 = 0;
	// 									for (int num10 = num4 - num6; num10 <= num4 + num6; num10++)
	// 									{
	// 										for (int num11 = num5; num11 <= num5 + num6 * 2; num11++)
	// 										{
	// 											if (SolidTile(num10, num11))
	// 											{
	// 												num9++;
	// 											}
	// 										}
	// 									}
	// 									int num12 = (num6 * 2 + 1) * (num6 * 2 + 1);
	// 									if (!((double)num9 < (double)num12 * 0.8) && !((Rectangle)(ref GenVars.UndergroundDesertLocation)).Intersects(new Rectangle(num4 - 8, num5 - 8, 16, 16)))
	// 									{
	// 										SonOfLakinater(num4, num5);
	// 										GenVars.LakeX[GenVars.numLakes] = num4;
	// 										GenVars.numLakes++;
	// 										break;
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_04b4: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_04b9: ldstr "Lakes"
	IL_04be: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_29'
	IL_04c3: dup
	IL_04c4: brtrue.s IL_04dd

	// (no C# code)
	IL_04c6: pop
	IL_04c7: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_04cc: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_29'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_04d2: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_04d7: dup
	IL_04d8: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_29'

	// 	AddGenerationPass("Dungeon", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		int dungeonLocation = GenVars.dungeonLocation;
	// 		int num = (int)((Main.worldSurface + Main.rockLayer) / 2.0) + genRand.Next(-200, 200);
	// 		int num2 = (int)((Main.worldSurface + Main.rockLayer) / 2.0) + 200;
	// 		int i = num;
	// 		bool flag = false;
	// 		for (int j = 0; j < 10; j++)
	// 		{
	// 			if (SolidTile(dungeonLocation, i + j))
	// 			{
	// 				flag = true;
	// 				break;
	// 			}
	// 		}
	// 		if (!flag)
	// 		{
	// 			for (; i < num2 && !SolidTile(dungeonLocation, i + 10); i++)
	// 			{
	// 			}
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			i = (int)Main.worldSurface + 70;
	// 		}
	// 		MakeDungeon(dungeonLocation, i);
	// 	});
	IL_04dd: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_04e2: ldstr "Dungeon"
	IL_04e7: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_30'
	IL_04ec: dup
	IL_04ed: brtrue.s IL_0506

	// (no C# code)
	IL_04ef: pop
	IL_04f0: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_04f5: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_30'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_04fb: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0500: dup
	IL_0501: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_30'

	// 	AddGenerationPass("Slush", delegate
	// 	{
	// 		for (int i = GenVars.snowTop; i < GenVars.snowBottom; i++)
	// 		{
	// 			for (int j = GenVars.snowMinX[i]; j < GenVars.snowMaxX[i]; j++)
	// 			{
	// 				switch (Main.tile[j, i].type)
	// 				{
	// 				case 123:
	// 					Main.tile[j, i].type = 224;
	// 					break;
	// 				case 59:
	// 				{
	// 					bool flag = true;
	// 					int num = 3;
	// 					for (int k = j - num; k <= j + num; k++)
	// 					{
	// 						for (int l = i - num; l <= i + num; l++)
	// 						{
	// 							if (Main.tile[k, l].type == 60 || Main.tile[k, l].type == 70 || Main.tile[k, l].type == 71 || Main.tile[k, l].type == 72)
	// 							{
	// 								flag = false;
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					if (flag)
	// 					{
	// 						Main.tile[j, i].type = 224;
	// 					}
	// 					break;
	// 				}
	// 				case 1:
	// 					Main.tile[j, i].type = 161;
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0506: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_050b: ldstr "Slush"
	IL_0510: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_31'
	IL_0515: dup
	IL_0516: brtrue.s IL_052f

	// (no C# code)
	IL_0518: pop
	IL_0519: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_051e: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_31'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0524: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0529: dup
	IL_052a: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_31'

	// 	AddGenerationPass("Mountain Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[21].Value;
	// 		for (int i = 0; i < GenVars.numMCaves; i++)
	// 		{
	// 			int i2 = GenVars.mCaveX[i];
	// 			int j = GenVars.mCaveY[i];
	// 			CaveOpenater(i2, j);
	// 			Cavinator(i2, j, genRand.Next(40, 50));
	// 		}
	// 	});
	IL_052f: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0534: ldstr "Mountain Caves"
	IL_0539: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_32'
	IL_053e: dup
	IL_053f: brtrue.s IL_0558

	// (no C# code)
	IL_0541: pop
	IL_0542: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0547: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_32'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_054d: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0552: dup
	IL_0553: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_32'

	// 	AddGenerationPass("Beaches", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		int num = 50;
	// 		progress.Message = Lang.gen[22].Value;
	// 		bool floridaStyle = false;
	// 		bool floridaStyle2 = false;
	// 		if (genRand.Next(4) == 0)
	// 		{
	// 			if (genRand.Next(2) == 0)
	// 			{
	// 				floridaStyle = true;
	// 			}
	// 			else
	// 			{
	// 				floridaStyle2 = true;
	// 			}
	// 		}
	// 		for (int i = 0; i < 2; i++)
	// 		{
	// 			int num2 = 0;
	// 			int num3 = 0;
	// 			if (i == 0)
	// 			{
	// 				num2 = 0;
	// 				num3 = genRand.Next(GenVars.oceanWaterStartRandomMin, GenVars.oceanWaterStartRandomMax);
	// 				if (GenVars.dungeonSide == 1)
	// 				{
	// 					num3 = GenVars.oceanWaterForcedJungleLength;
	// 				}
	// 				int num4 = GenVars.leftBeachEnd - num;
	// 				if (num3 > num4)
	// 				{
	// 					num3 = num4;
	// 				}
	// 				int num5 = 0;
	// 				double num6 = 1.0;
	// 				int j;
	// 				for (j = 0; !Main.tile[num3 - 1, j].active(); j++)
	// 				{
	// 				}
	// 				GenVars.shellStartYLeft = j;
	// 				j += genRand.Next(1, 5);
	// 				for (int num7 = num3 - 1; num7 >= num2; num7--)
	// 				{
	// 					if (num7 > 30)
	// 					{
	// 						num5++;
	// 						num6 = TuneOceanDepth(num5, num6, floridaStyle);
	// 					}
	// 					else
	// 					{
	// 						num6 += 1.0;
	// 					}
	// 					int num8 = genRand.Next(15, 20);
	// 					for (int k = 0; (double)k < (double)j + num6 + (double)num8; k++)
	// 					{
	// 						if ((double)k < (double)j + num6 * 0.75 - 3.0)
	// 						{
	// 							Main.tile[num7, k].active(active: false);
	// 							if (k > j)
	// 							{
	// 								Main.tile[num7, k].liquid = byte.MaxValue;
	// 								Main.tile[num7, k].lava(lava: false);
	// 							}
	// 							else if (k == j)
	// 							{
	// 								Main.tile[num7, k].liquid = 127;
	// 								if (GenVars.shellStartXLeft == 0)
	// 								{
	// 									GenVars.shellStartXLeft = num7;
	// 								}
	// 							}
	// 						}
	// 						else if (k > j)
	// 						{
	// 							Main.tile[num7, k].type = 53;
	// 							Main.tile[num7, k].active(active: true);
	// 						}
	// 						Main.tile[num7, k].wall = 0;
	// 					}
	// 				}
	// 			}
	// 			else
	// 			{
	// 				num2 = Main.maxTilesX - genRand.Next(GenVars.oceanWaterStartRandomMin, GenVars.oceanWaterStartRandomMax);
	// 				num3 = Main.maxTilesX;
	// 				if (GenVars.dungeonSide == -1)
	// 				{
	// 					num2 = Main.maxTilesX - GenVars.oceanWaterForcedJungleLength;
	// 				}
	// 				int num9 = GenVars.rightBeachStart + num;
	// 				if (num2 < num9)
	// 				{
	// 					num2 = num9;
	// 				}
	// 				double num10 = 1.0;
	// 				int num11 = 0;
	// 				int l;
	// 				for (l = 0; !Main.tile[num2, l].active(); l++)
	// 				{
	// 				}
	// 				GenVars.shellStartXRight = 0;
	// 				GenVars.shellStartYRight = l;
	// 				l += genRand.Next(1, 5);
	// 				for (int m = num2; m < num3; m++)
	// 				{
	// 					if (m < num3 - 30)
	// 					{
	// 						num11++;
	// 						num10 = TuneOceanDepth(num11, num10, floridaStyle2);
	// 					}
	// 					else
	// 					{
	// 						num10 += 1.0;
	// 					}
	// 					int num12 = genRand.Next(15, 20);
	// 					for (int n = 0; (double)n < (double)l + num10 + (double)num12; n++)
	// 					{
	// 						if ((double)n < (double)l + num10 * 0.75 - 3.0)
	// 						{
	// 							Main.tile[m, n].active(active: false);
	// 							if (n > l)
	// 							{
	// 								Main.tile[m, n].liquid = byte.MaxValue;
	// 								Main.tile[m, n].lava(lava: false);
	// 							}
	// 							else if (n == l)
	// 							{
	// 								Main.tile[m, n].liquid = 127;
	// 								if (GenVars.shellStartXRight == 0)
	// 								{
	// 									GenVars.shellStartXRight = m;
	// 								}
	// 							}
	// 						}
	// 						else if (n > l)
	// 						{
	// 							Main.tile[m, n].type = 53;
	// 							Main.tile[m, n].active(active: true);
	// 						}
	// 						Main.tile[m, n].wall = 0;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0558: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_055d: ldstr "Beaches"
	IL_0562: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_33'
	IL_0567: dup
	IL_0568: brtrue.s IL_0581

	// (no C# code)
	IL_056a: pop
	IL_056b: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0570: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_33'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0576: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_057b: dup
	IL_057c: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_33'

	// 	AddGenerationPass("Gems", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[23].Value;
	// 		Main.tileSolid[484] = false;
	// 		for (int i = 63; i <= 68; i++)
	// 		{
	// 			double value = (double)(i - 63) / 6.0;
	// 			progress.Set(value);
	// 			double num = 0.0;
	// 			switch (i)
	// 			{
	// 			case 67:
	// 				num = (double)Main.maxTilesX * 0.5;
	// 				break;
	// 			case 66:
	// 				num = (double)Main.maxTilesX * 0.45;
	// 				break;
	// 			case 63:
	// 				num = (double)Main.maxTilesX * 0.3;
	// 				break;
	// 			case 65:
	// 				num = (double)Main.maxTilesX * 0.25;
	// 				break;
	// 			case 64:
	// 				num = (double)Main.maxTilesX * 0.1;
	// 				break;
	// 			case 68:
	// 				num = (double)Main.maxTilesX * 0.05;
	// 				break;
	// 			}
	// 			num *= 0.2;
	// 			for (int j = 0; (double)j < num; j++)
	// 			{
	// 				int num2 = genRand.Next(0, Main.maxTilesX);
	// 				int num3 = genRand.Next((int)Main.worldSurface, Main.maxTilesY);
	// 				while (Main.tile[num2, num3].type != 1)
	// 				{
	// 					num2 = genRand.Next(0, Main.maxTilesX);
	// 					num3 = genRand.Next((int)Main.worldSurface, Main.maxTilesY);
	// 				}
	// 				TileRunner(num2, num3, genRand.Next(2, 6), genRand.Next(3, 7), i);
	// 			}
	// 		}
	// 		for (int k = 0; k < 2; k++)
	// 		{
	// 			int num4 = 1;
	// 			int num5 = 5;
	// 			int num6 = Main.maxTilesX - 5;
	// 			if (k == 1)
	// 			{
	// 				num4 = -1;
	// 				num5 = Main.maxTilesX - 5;
	// 				num6 = 5;
	// 			}
	// 			for (int l = num5; l != num6; l += num4)
	// 			{
	// 				if (l <= ((Rectangle)(ref GenVars.UndergroundDesertLocation)).Left || l >= ((Rectangle)(ref GenVars.UndergroundDesertLocation)).Right)
	// 				{
	// 					for (int m = 10; m < Main.maxTilesY - 10; m++)
	// 					{
	// 						if (Main.tile[l, m].active() && Main.tile[l, m + 1].active() && Main.tileSand[Main.tile[l, m].type] && Main.tileSand[Main.tile[l, m + 1].type])
	// 						{
	// 							ushort type = Main.tile[l, m].type;
	// 							int x = l + num4;
	// 							int n = m + 1;
	// 							if (!Main.tile[x, m].active() && !Main.tile[x, n].active())
	// 							{
	// 								for (; !Main.tile[x, n].active(); n++)
	// 								{
	// 								}
	// 								n--;
	// 								Main.tile[l, m].active(active: false);
	// 								Main.tile[x, n].active(active: true);
	// 								Main.tile[x, n].type = type;
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0581: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0586: ldstr "Gems"
	IL_058b: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_34'
	IL_0590: dup
	IL_0591: brtrue.s IL_05aa

	// (no C# code)
	IL_0593: pop
	IL_0594: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0599: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_34'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_059f: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_05a4: dup
	IL_05a5: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_34'

	// 	AddGenerationPass("Gravitating Sand", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[24].Value;
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			double value = (double)i / (double)(Main.maxTilesX - 1);
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			int num = 0;
	// 			for (int num2 = Main.maxTilesY - 1; num2 > 0; num2--)
	// 			{
	// 				if (SolidOrSlopedTile(i, num2))
	// 				{
	// 					ushort type = Main.tile[i, num2].type;
	// 					if (flag && num2 < (int)Main.worldSurface && num2 != num - 1 && TileID.Sets.Falling[type])
	// 					{
	// 						for (int j = num2; j < num; j++)
	// 						{
	// 							Main.tile[i, j].ResetToType(type);
	// 						}
	// 					}
	// 					flag = true;
	// 					num = num2;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_05aa: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_05af: ldstr "Gravitating Sand"
	IL_05b4: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_35'
	IL_05b9: dup
	IL_05ba: brtrue.s IL_05d3

	// (no C# code)
	IL_05bc: pop
	IL_05bd: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_05c2: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_35'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_05c8: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_05cd: dup
	IL_05ce: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_35'

	// 	AddGenerationPass("Create Ocean Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		int maxValue = 3;
	// 		if (remixWorldGen)
	// 		{
	// 			maxValue = 2;
	// 		}
	// 		for (int i = 0; i < 2; i++)
	// 		{
	// 			if ((i != 0 || GenVars.dungeonSide <= 0) && (i != 1 || GenVars.dungeonSide >= 0) && (genRand.Next(maxValue) == 0 || drunkWorldGen || tenthAnniversaryWorldGen))
	// 			{
	// 				progress.Message = Lang.gen[90].Value;
	// 				int num = genRand.Next(55, 95);
	// 				if (i == 1)
	// 				{
	// 					num = genRand.Next(Main.maxTilesX - 95, Main.maxTilesX - 55);
	// 				}
	// 				int j;
	// 				for (j = 0; !Main.tile[num, j].active(); j++)
	// 				{
	// 				}
	// 				oceanCave(num, j);
	// 			}
	// 		}
	// 	});
	IL_05d3: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_05d8: ldstr "Create Ocean Caves"
	IL_05dd: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_36'
	IL_05e2: dup
	IL_05e3: brtrue.s IL_05fc

	// (no C# code)
	IL_05e5: pop
	IL_05e6: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_05eb: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_36'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_05f1: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_05f6: dup
	IL_05f7: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_36'

	// 	AddGenerationPass("Shimmer", delegate
	// 	{
	// 		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
	// 		int num = 50;
	// 		int num2 = (int)(Main.worldSurface + Main.rockLayer) / 2 + num;
	// 		int num3 = (int)((double)((Main.maxTilesY - 250) * 2) + Main.rockLayer) / 3;
	// 		if (num3 > Main.maxTilesY - 330 - 100 - 30)
	// 		{
	// 			num3 = Main.maxTilesY - 330 - 100 - 30;
	// 		}
	// 		if (num3 <= num2)
	// 		{
	// 			num3 = num2 + 50;
	// 		}
	// 		int num4 = genRand.Next(num2, num3);
	// 		int num5 = ((GenVars.dungeonSide < 0) ? genRand.Next((int)((double)Main.maxTilesX * 0.89), Main.maxTilesX - 200) : genRand.Next(200, (int)((double)Main.maxTilesX * 0.11)));
	// 		int num6 = (int)Main.worldSurface + 150;
	// 		int num7 = (int)(Main.rockLayer + Main.worldSurface + 200.0) / 2;
	// 		if (num7 <= num6)
	// 		{
	// 			num7 = num6 + 50;
	// 		}
	// 		if (tenthAnniversaryWorldGen)
	// 		{
	// 			num4 = genRand.Next(num6, num7);
	// 		}
	// 		int num8 = 0;
	// 		while (!ShimmerMakeBiome(num5, num4))
	// 		{
	// 			num8++;
	// 			if (tenthAnniversaryWorldGen && num8 < 10000)
	// 			{
	// 				num4 = genRand.Next(num6, num7);
	// 				num5 = ((GenVars.dungeonSide < 0) ? genRand.Next((int)((double)Main.maxTilesX * 0.89), Main.maxTilesX - 200) : genRand.Next(200, (int)((double)Main.maxTilesX * 0.11)));
	// 			}
	// 			else if (num8 > 20000)
	// 			{
	// 				num4 = genRand.Next((int)Main.worldSurface + 100 + 20, num3);
	// 				num5 = ((GenVars.dungeonSide < 0) ? genRand.Next((int)((double)Main.maxTilesX * 0.8), Main.maxTilesX - 200) : genRand.Next(200, (int)((double)Main.maxTilesX * 0.2)));
	// 			}
	// 			else
	// 			{
	// 				num4 = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2 + 20, num3);
	// 				num5 = ((GenVars.dungeonSide < 0) ? genRand.Next((int)((double)Main.maxTilesX * 0.89), Main.maxTilesX - 200) : genRand.Next(200, (int)((double)Main.maxTilesX * 0.11)));
	// 			}
	// 		}
	// 		GenVars.shimmerPosition = new Vector2D((double)num5, (double)num4);
	// 		int num9 = 200;
	// 		GenVars.structures.AddProtectedStructure(new Rectangle(num5 - num9 / 2, num4 - num9 / 2, num9, num9));
	// 	});
	IL_05fc: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0601: ldstr "Shimmer"
	IL_0606: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_37'
	IL_060b: dup
	IL_060c: brtrue.s IL_0625

	// (no C# code)
	IL_060e: pop
	IL_060f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0614: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_37'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_061a: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_061f: dup
	IL_0620: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_37'

	// 	AddGenerationPass("Clean Up Dirt", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[25].Value;
	// 		for (int i = 3; i < Main.maxTilesX - 3; i++)
	// 		{
	// 			double num = (double)i / (double)Main.maxTilesX;
	// 			progress.Set(0.5 * num);
	// 			bool flag = true;
	// 			for (int j = 0; (double)j < Main.worldSurface; j++)
	// 			{
	// 				if (flag)
	// 				{
	// 					if (Main.tile[i, j].wall == 2 || Main.tile[i, j].wall == 40 || Main.tile[i, j].wall == 64 || Main.tile[i, j].wall == 86)
	// 					{
	// 						Main.tile[i, j].wall = 0;
	// 					}
	// 					if (Main.tile[i, j].type != 53 && Main.tile[i, j].type != 112 && Main.tile[i, j].type != 234)
	// 					{
	// 						if (Main.tile[i - 1, j].wall == 2 || Main.tile[i - 1, j].wall == 40 || Main.tile[i - 1, j].wall == 40)
	// 						{
	// 							Main.tile[i - 1, j].wall = 0;
	// 						}
	// 						if ((Main.tile[i - 2, j].wall == 2 || Main.tile[i - 2, j].wall == 40 || Main.tile[i - 2, j].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[i - 2, j].wall = 0;
	// 						}
	// 						if ((Main.tile[i - 3, j].wall == 2 || Main.tile[i - 3, j].wall == 40 || Main.tile[i - 3, j].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[i - 3, j].wall = 0;
	// 						}
	// 						if (Main.tile[i + 1, j].wall == 2 || Main.tile[i + 1, j].wall == 40 || Main.tile[i + 1, j].wall == 40)
	// 						{
	// 							Main.tile[i + 1, j].wall = 0;
	// 						}
	// 						if ((Main.tile[i + 2, j].wall == 2 || Main.tile[i + 2, j].wall == 40 || Main.tile[i + 2, j].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[i + 2, j].wall = 0;
	// 						}
	// 						if ((Main.tile[i + 3, j].wall == 2 || Main.tile[i + 3, j].wall == 40 || Main.tile[i + 3, j].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[i + 3, j].wall = 0;
	// 						}
	// 						if (Main.tile[i, j].active())
	// 						{
	// 							flag = false;
	// 						}
	// 					}
	// 				}
	// 				else if (Main.tile[i, j].wall == 0 && Main.tile[i, j + 1].wall == 0 && Main.tile[i, j + 2].wall == 0 && Main.tile[i, j + 3].wall == 0 && Main.tile[i, j + 4].wall == 0 && Main.tile[i - 1, j].wall == 0 && Main.tile[i + 1, j].wall == 0 && Main.tile[i - 2, j].wall == 0 && Main.tile[i + 2, j].wall == 0 && !Main.tile[i, j].active() && !Main.tile[i, j + 1].active() && !Main.tile[i, j + 2].active() && !Main.tile[i, j + 3].active())
	// 				{
	// 					flag = true;
	// 				}
	// 			}
	// 		}
	// 		for (int num2 = Main.maxTilesX - 5; num2 >= 5; num2--)
	// 		{
	// 			double num3 = (double)num2 / (double)Main.maxTilesX;
	// 			progress.Set(1.0 - 0.5 * num3);
	// 			bool flag2 = true;
	// 			for (int k = 0; (double)k < Main.worldSurface; k++)
	// 			{
	// 				if (flag2)
	// 				{
	// 					if (Main.tile[num2, k].wall == 2 || Main.tile[num2, k].wall == 40 || Main.tile[num2, k].wall == 64)
	// 					{
	// 						Main.tile[num2, k].wall = 0;
	// 					}
	// 					if (Main.tile[num2, k].type != 53)
	// 					{
	// 						if (Main.tile[num2 - 1, k].wall == 2 || Main.tile[num2 - 1, k].wall == 40 || Main.tile[num2 - 1, k].wall == 40)
	// 						{
	// 							Main.tile[num2 - 1, k].wall = 0;
	// 						}
	// 						if ((Main.tile[num2 - 2, k].wall == 2 || Main.tile[num2 - 2, k].wall == 40 || Main.tile[num2 - 2, k].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[num2 - 2, k].wall = 0;
	// 						}
	// 						if ((Main.tile[num2 - 3, k].wall == 2 || Main.tile[num2 - 3, k].wall == 40 || Main.tile[num2 - 3, k].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[num2 - 3, k].wall = 0;
	// 						}
	// 						if (Main.tile[num2 + 1, k].wall == 2 || Main.tile[num2 + 1, k].wall == 40 || Main.tile[num2 + 1, k].wall == 40)
	// 						{
	// 							Main.tile[num2 + 1, k].wall = 0;
	// 						}
	// 						if ((Main.tile[num2 + 2, k].wall == 2 || Main.tile[num2 + 2, k].wall == 40 || Main.tile[num2 + 2, k].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[num2 + 2, k].wall = 0;
	// 						}
	// 						if ((Main.tile[num2 + 3, k].wall == 2 || Main.tile[num2 + 3, k].wall == 40 || Main.tile[num2 + 3, k].wall == 40) && genRand.Next(2) == 0)
	// 						{
	// 							Main.tile[num2 + 3, k].wall = 0;
	// 						}
	// 						if (Main.tile[num2, k].active())
	// 						{
	// 							flag2 = false;
	// 						}
	// 					}
	// 				}
	// 				else if (Main.tile[num2, k].wall == 0 && Main.tile[num2, k + 1].wall == 0 && Main.tile[num2, k + 2].wall == 0 && Main.tile[num2, k + 3].wall == 0 && Main.tile[num2, k + 4].wall == 0 && Main.tile[num2 - 1, k].wall == 0 && Main.tile[num2 + 1, k].wall == 0 && Main.tile[num2 - 2, k].wall == 0 && Main.tile[num2 + 2, k].wall == 0 && !Main.tile[num2, k].active() && !Main.tile[num2, k + 1].active() && !Main.tile[num2, k + 2].active() && !Main.tile[num2, k + 3].active())
	// 				{
	// 					flag2 = true;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0625: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_062a: ldstr "Clean Up Dirt"
	IL_062f: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_38'
	IL_0634: dup
	IL_0635: brtrue.s IL_064e

	// (no C# code)
	IL_0637: pop
	IL_0638: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_063d: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_38'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0643: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0648: dup
	IL_0649: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_38'

	// 	AddGenerationPass("Pyramids", delegate
	// 	{
	// 		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
	// 		Rectangle undergroundDesertLocation = GenVars.UndergroundDesertLocation;
	// 		if (Main.tenthAnniversaryWorld)
	// 		{
	// 			int x = ((Rectangle)(ref undergroundDesertLocation)).Center.X;
	// 			int j = ((Rectangle)(ref undergroundDesertLocation)).Top - 10;
	// 			Pyramid(x, j);
	// 		}
	// 		for (int i = 0; i < GenVars.numPyr; i++)
	// 		{
	// 			int num = GenVars.PyrX[i];
	// 			int k = GenVars.PyrY[i];
	// 			if (num > 300 && num < Main.maxTilesX - 300 && (GenVars.dungeonSide >= 0 || !((double)num < (double)GenVars.dungeonX + (double)Main.maxTilesX * 0.15)) && (GenVars.dungeonSide <= 0 || !((double)num > (double)GenVars.dungeonX - (double)Main.maxTilesX * 0.15)) && (!Main.tenthAnniversaryWorld || !((Rectangle)(ref undergroundDesertLocation)).Contains(num, k)))
	// 			{
	// 				for (; !Main.tile[num, k].active() && (double)k < Main.worldSurface; k++)
	// 				{
	// 				}
	// 				if (!((double)k >= Main.worldSurface) && Main.tile[num, k].type == 53)
	// 				{
	// 					int num2 = Main.maxTilesX;
	// 					for (int l = 0; l < i; l++)
	// 					{
	// 						int num3 = Math.Abs(num - GenVars.PyrX[l]);
	// 						if (num3 < num2)
	// 						{
	// 							num2 = num3;
	// 						}
	// 					}
	// 					int num4 = 220;
	// 					if (drunkWorldGen)
	// 					{
	// 						num4 /= 2;
	// 					}
	// 					if (num2 >= num4)
	// 					{
	// 						k--;
	// 						Pyramid(num, k);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_064e: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0653: ldstr "Pyramids"
	IL_0658: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_39'
	IL_065d: dup
	IL_065e: brtrue.s IL_0677

	// (no C# code)
	IL_0660: pop
	IL_0661: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0666: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_39'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_066c: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0671: dup
	IL_0672: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_39'

	// 	AddGenerationPass("Dirt Rock Wall Runner", delegate
	// 	{
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			int num = genRand.Next(10, Main.maxTilesX - 10);
	// 			int num2 = genRand.Next(10, (int)Main.worldSurface);
	// 			if (Main.tile[num, num2].wall == 2)
	// 			{
	// 				DirtyRockRunner(num, num2);
	// 			}
	// 		}
	// 	});
	IL_0677: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_067c: ldstr "Dirt Rock Wall Runner"
	IL_0681: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_40'
	IL_0686: dup
	IL_0687: brtrue.s IL_06a0

	// (no C# code)
	IL_0689: pop
	IL_068a: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_068f: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_40'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0695: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_069a: dup
	IL_069b: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_40'

	// 	AddGenerationPass("Living Trees", delegate
	// 	{
	// 		int num = 200;
	// 		double num2 = (double)Main.maxTilesX / 4200.0;
	// 		int num3 = genRand.Next(0, (int)(2.0 * num2) + 1);
	// 		if (num3 == 0 && genRand.Next(2) == 0)
	// 		{
	// 			num3++;
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			num3 += (int)(2.0 * num2);
	// 		}
	// 		else if (Main.tenthAnniversaryWorld)
	// 		{
	// 			num3 += (int)(3.0 * num2);
	// 		}
	// 		else if (remixWorldGen)
	// 		{
	// 			num3 += (int)(2.0 * num2);
	// 		}
	// 		for (int i = 0; i < num3; i++)
	// 		{
	// 			bool flag = false;
	// 			int num4 = 0;
	// 			while (!flag)
	// 			{
	// 				num4++;
	// 				if (num4 > Main.maxTilesX / 2)
	// 				{
	// 					flag = true;
	// 				}
	// 				int num5 = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 				if (tenthAnniversaryWorldGen && !remixWorldGen)
	// 				{
	// 					num5 = genRand.Next((int)((double)Main.maxTilesX * 0.15), (int)((float)Main.maxTilesX * 0.85f));
	// 				}
	// 				if (num5 <= Main.maxTilesX / 2 - num || num5 >= Main.maxTilesX / 2 + num)
	// 				{
	// 					int j;
	// 					for (j = 0; !Main.tile[num5, j].active() && (double)j < Main.worldSurface; j++)
	// 					{
	// 					}
	// 					if (Main.tile[num5, j].type == 0)
	// 					{
	// 						j--;
	// 						if (j > 150)
	// 						{
	// 							bool flag2 = true;
	// 							for (int k = num5 - 50; k < num5 + 50; k++)
	// 							{
	// 								for (int l = j - 50; l < j + 50; l++)
	// 								{
	// 									if (Main.tile[k, l].active())
	// 									{
	// 										switch (Main.tile[k, l].type)
	// 										{
	// 										case 41:
	// 										case 43:
	// 										case 44:
	// 										case 189:
	// 										case 196:
	// 										case 460:
	// 										case 481:
	// 										case 482:
	// 										case 483:
	// 											flag2 = false;
	// 											break;
	// 										}
	// 									}
	// 								}
	// 							}
	// 							for (int m = 0; m < GenVars.numMCaves; m++)
	// 							{
	// 								if (num5 > GenVars.mCaveX[m] - 50 && num5 < GenVars.mCaveX[m] + 50)
	// 								{
	// 									flag2 = false;
	// 									break;
	// 								}
	// 							}
	// 							if (flag2)
	// 							{
	// 								flag = GrowLivingTree(num5, j);
	// 								if (flag)
	// 								{
	// 									for (int n = -1; n <= 1; n++)
	// 									{
	// 										if (n != 0)
	// 										{
	// 											int num6 = num5;
	// 											int num7 = genRand.Next(4);
	// 											if (drunkWorldGen || Main.tenthAnniversaryWorld)
	// 											{
	// 												num7 += genRand.Next(2, 5);
	// 											}
	// 											else if (remixWorldGen)
	// 											{
	// 												num7 += genRand.Next(1, 6);
	// 											}
	// 											for (int num8 = 0; num8 < num7; num8++)
	// 											{
	// 												num6 += genRand.Next(13, 31) * n;
	// 												if (num6 <= Main.maxTilesX / 2 - num || num6 >= Main.maxTilesX / 2 + num)
	// 												{
	// 													int num9 = j;
	// 													if (Main.tile[num6, num9].active())
	// 													{
	// 														while (Main.tile[num6, num9].active())
	// 														{
	// 															num9--;
	// 														}
	// 													}
	// 													else
	// 													{
	// 														for (; !Main.tile[num6, num9].active(); num9++)
	// 														{
	// 														}
	// 														num9--;
	// 													}
	// 													flag2 = true;
	// 													for (int num10 = num5 - 50; num10 < num5 + 50; num10++)
	// 													{
	// 														for (int num11 = j - 50; num11 < j + 50; num11++)
	// 														{
	// 															if (Main.tile[num10, num11].active())
	// 															{
	// 																switch (Main.tile[num10, num11].type)
	// 																{
	// 																case 41:
	// 																case 43:
	// 																case 44:
	// 																case 189:
	// 																case 196:
	// 																case 460:
	// 																case 481:
	// 																case 482:
	// 																case 483:
	// 																	flag2 = false;
	// 																	break;
	// 																}
	// 															}
	// 														}
	// 													}
	// 													if (flag2)
	// 													{
	// 														GrowLivingTree(num6, num9, patch: true);
	// 													}
	// 												}
	// 											}
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[192] = false;
	// 	});
	IL_06a0: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_06a5: ldstr "Living Trees"
	IL_06aa: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_41'
	IL_06af: dup
	IL_06b0: brtrue.s IL_06c9

	// (no C# code)
	IL_06b2: pop
	IL_06b3: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_06b8: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_41'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_06be: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_06c3: dup
	IL_06c4: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_41'

	// 	AddGenerationPass("Wood Tree Walls", delegate
	// 	{
	// 		for (int i = 25; i < Main.maxTilesX - 25; i++)
	// 		{
	// 			for (int j = 25; (double)j < Main.worldSurface; j++)
	// 			{
	// 				if (Main.tile[i, j].type == 191 || Main.tile[i, j - 1].type == 191 || Main.tile[i - 1, j].type == 191 || Main.tile[i + 1, j].type == 191 || Main.tile[i, j + 1].type == 191)
	// 				{
	// 					bool flag = true;
	// 					for (int k = i - 1; k <= i + 1; k++)
	// 					{
	// 						for (int l = j - 1; l <= j + 1; l++)
	// 						{
	// 							if (k != i && l != j && Main.tile[k, l].type != 191 && Main.tile[k, l].wall != 244)
	// 							{
	// 								flag = false;
	// 							}
	// 						}
	// 					}
	// 					if (flag)
	// 					{
	// 						Main.tile[i, j].wall = 244;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_06c9: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_06ce: ldstr "Wood Tree Walls"
	IL_06d3: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_42'
	IL_06d8: dup
	IL_06d9: brtrue.s IL_06f2

	// (no C# code)
	IL_06db: pop
	IL_06dc: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_06e1: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_42'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_06e7: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_06ec: dup
	IL_06ed: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_42'

	// 	AddGenerationPass("Altars", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
	// 		Main.tileSolid[484] = false;
	// 		progress.Message = Lang.gen[26].Value;
	// 		int num = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3.3E-06);
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 3;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			progress.Set((double)i / (double)num);
	// 			for (int j = 0; j < 10000; j++)
	// 			{
	// 				int num2 = genRand.Next(281, Main.maxTilesX - 3 - 280);
	// 				while ((double)num2 > (double)Main.maxTilesX * 0.45 && (double)num2 < (double)Main.maxTilesX * 0.55)
	// 				{
	// 					num2 = genRand.Next(281, Main.maxTilesX - 3 - 280);
	// 				}
	// 				int num3 = genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, (int)(Main.rockLayer + (double)((Main.maxTilesY - 350) * 2)) / 3);
	// 				if (remixWorldGen)
	// 				{
	// 					num3 = genRand.Next(100, (int)((double)Main.maxTilesY * 0.9));
	// 				}
	// 				while (oceanDepths(num2, num3) || Vector2D.Distance(new Vector2D((double)num2, (double)num3), GenVars.shimmerPosition) < (double)shimmerSafetyDistance)
	// 				{
	// 					num2 = genRand.Next(281, Main.maxTilesX - 3 - 280);
	// 					while ((double)num2 > (double)Main.maxTilesX * 0.45 && (double)num2 < (double)Main.maxTilesX * 0.55)
	// 					{
	// 						num2 = genRand.Next(281, Main.maxTilesX - 3 - 280);
	// 					}
	// 					num3 = genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, (int)(Main.rockLayer + (double)((Main.maxTilesY - 350) * 2)) / 3);
	// 					if (remixWorldGen)
	// 					{
	// 						num3 = genRand.Next(100, (int)((double)Main.maxTilesY * 0.9));
	// 					}
	// 				}
	// 				int style = (crimson ? 1 : 0);
	// 				if (drunkWorldGen)
	// 				{
	// 					style = ((GenVars.crimsonLeft ? (num2 < Main.maxTilesX / 2) : (num2 >= Main.maxTilesX / 2)) ? 1 : 0);
	// 				}
	// 				if (!IsTileNearby(num2, num3, 26, 3))
	// 				{
	// 					Place3x2(num2, num3, 26, style);
	// 				}
	// 				if (Main.tile[num2, num3].type == 26)
	// 				{
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_06f2: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_06f7: ldstr "Altars"
	IL_06fc: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_43'
	IL_0701: dup
	IL_0702: brtrue.s IL_071b

	// (no C# code)
	IL_0704: pop
	IL_0705: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_070a: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_43'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0710: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0715: dup
	IL_0716: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_43'

	// 	AddGenerationPass("Wet Jungle", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			for (int j = (int)GenVars.worldSurfaceLow; (double)j < Main.worldSurface - 1.0; j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					if (Main.tile[i, j].type == 60)
	// 					{
	// 						Main.tile[i, j - 1].liquid = byte.MaxValue;
	// 						Main.tile[i, j - 2].liquid = byte.MaxValue;
	// 					}
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_071b: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0720: ldstr "Wet Jungle"
	IL_0725: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_44'
	IL_072a: dup
	IL_072b: brtrue.s IL_0744

	// (no C# code)
	IL_072d: pop
	IL_072e: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0733: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_44'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0739: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_073e: dup
	IL_073f: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_44'

	// 	AddGenerationPass("Jungle Temple", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		int num = 0;
	// 		progress.Message = Lang.gen[70].Value;
	// 		long num2 = 0L;
	// 		double num3 = 0.25;
	// 		bool flag = false;
	// 		while (true)
	// 		{
	// 			int num4 = (int)Main.rockLayer;
	// 			int num5 = Main.maxTilesY - 500;
	// 			if (num4 > num5 - 1)
	// 			{
	// 				num4 = num5 - 1;
	// 			}
	// 			int num6 = genRand.Next(num4, num5);
	// 			int x = (int)(((genRand.NextDouble() * num3 + 0.1) * (double)(-GenVars.dungeonSide) + 0.5) * (double)Main.maxTilesX);
	// 			if (remixWorldGen)
	// 			{
	// 				if (notTheBees)
	// 				{
	// 					x = ((GenVars.dungeonSide <= 0) ? genRand.Next((int)((double)Main.maxTilesX * 0.6), (int)((double)Main.maxTilesX * 0.8)) : genRand.Next((int)((double)Main.maxTilesX * 0.2), (int)((double)Main.maxTilesX * 0.4)));
	// 				}
	// 				else
	// 				{
	// 					x = genRand.Next((int)((double)Main.maxTilesX * 0.2), (int)((double)Main.maxTilesX * 0.8));
	// 					while ((double)x > (double)Main.maxTilesX * 0.4 && (double)x < (double)Main.maxTilesX * 0.6)
	// 					{
	// 						x = genRand.Next((int)((double)Main.maxTilesX * 0.2), (int)((double)Main.maxTilesX * 0.8));
	// 					}
	// 				}
	// 				while (Main.tile[x, num6].active() || Main.tile[x, num6].wall > 0 || (double)num6 > Main.worldSurface - 5.0)
	// 				{
	// 					num6--;
	// 				}
	// 				num6++;
	// 				if (Main.tile[x, num6].active() && (Main.tile[x, num6].type == 60 || Main.tile[x, num6].type == 59))
	// 				{
	// 					int num7 = 10;
	// 					bool flag2 = false;
	// 					for (int i = x - num7; i <= i + num7; i++)
	// 					{
	// 						for (int j = num6 - num7; j < num7; j++)
	// 						{
	// 							if (Main.tile[i, j].type == 191 || Main.tileDungeon[Main.tile[i, j].type])
	// 							{
	// 								flag2 = true;
	// 							}
	// 						}
	// 					}
	// 					if (!flag2)
	// 					{
	// 						flag = true;
	// 						num6 -= 10 + genRand.Next(10);
	// 						makeTemple(x, num6);
	// 						break;
	// 					}
	// 				}
	// 			}
	// 			else if (Main.tile[x, num6].active() && Main.tile[x, num6].type == 60)
	// 			{
	// 				flag = true;
	// 				makeTemple(x, num6);
	// 				break;
	// 			}
	// 			if (num2++ > 2000000)
	// 			{
	// 				if (num3 == 0.35)
	// 				{
	// 					num++;
	// 					if (num > 10)
	// 					{
	// 						break;
	// 					}
	// 				}
	// 				num3 = Math.Min(0.35, num3 + 0.05);
	// 				num2 = 0L;
	// 			}
	// 		}
	// 		if (!flag)
	// 		{
	// 			int x2 = Main.maxTilesX - GenVars.dungeonX;
	// 			int y = (int)Main.rockLayer + 100;
	// 			if (remixWorldGen)
	// 			{
	// 				x2 = (notTheBees ? ((GenVars.dungeonSide > 0) ? ((int)((double)Main.maxTilesX * 0.3)) : ((int)((double)Main.maxTilesX * 0.7))) : ((GenVars.dungeonSide > 0) ? ((int)((double)Main.maxTilesX * 0.4)) : ((int)((double)Main.maxTilesX * 0.6))));
	// 			}
	// 			makeTemple(x2, y);
	// 		}
	// 	});
	IL_0744: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0749: ldstr "Jungle Temple"
	IL_074e: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_45'
	IL_0753: dup
	IL_0754: brtrue.s IL_076d

	// (no C# code)
	IL_0756: pop
	IL_0757: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_075c: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_45'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0762: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0767: dup
	IL_0768: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_45'

	// 	AddGenerationPass("Hives", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[71].Value;
	// 		double num = (double)Main.maxTilesX / 4200.0;
	// 		double num2 = 1 + genRand.Next((int)(5.0 * num), (int)(8.0 * num));
	// 		if (drunkWorldGen)
	// 		{
	// 			num2 *= 0.667;
	// 		}
	// 		int num3 = 10000;
	// 		HiveBiome hiveBiome = GenVars.configuration.CreateBiome<HiveBiome>();
	// 		HoneyPatchBiome honeyPatchBiome = GenVars.configuration.CreateBiome<HoneyPatchBiome>();
	// 		while (num2 > 0.0 && num3 > 0)
	// 		{
	// 			num3--;
	// 			Point val = RandomWorldPoint((int)(Main.worldSurface + Main.rockLayer) >> 1, 20, 300, 20);
	// 			if (drunkWorldGen)
	// 			{
	// 				RandomWorldPoint((int)Main.worldSurface, 20, 300, 20);
	// 			}
	// 			if (hiveBiome.Place(val, GenVars.structures))
	// 			{
	// 				num2 -= 1.0;
	// 				int num4 = genRand.Next(5);
	// 				int num5 = 0;
	// 				int num6 = 10000;
	// 				while (num5 < num4 && num6 > 0)
	// 				{
	// 					double num7 = genRand.NextDouble() * 60.0 + 30.0;
	// 					double num8 = genRand.NextDouble() * 6.2831854820251465;
	// 					int num9 = (int)(Math.Cos(num8) * num7) + val.X;
	// 					int num10 = (int)(Math.Sin(num8) * num7) + val.Y;
	// 					num6--;
	// 					if (num9 > 50 && num9 < Main.maxTilesX - 50 && honeyPatchBiome.Place(new Point(num9, num10), GenVars.structures))
	// 					{
	// 						num5++;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_076d: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0772: ldstr "Hives"
	IL_0777: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_46'
	IL_077c: dup
	IL_077d: brtrue.s IL_0796

	// (no C# code)
	IL_077f: pop
	IL_0780: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0785: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_46'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_078b: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0790: dup
	IL_0791: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_46'

	// 	AddGenerationPass("Jungle Chests", delegate
	// 	{
	// 		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
	// 		int num = genRand.Next(40, Main.maxTilesX - 40);
	// 		int num2 = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, Main.maxTilesY - 400);
	// 		double num3 = genRand.Next(7, 12);
	// 		num3 *= (double)Main.maxTilesX / 4200.0;
	// 		int num4 = 0;
	// 		Rectangle area = default(Rectangle);
	// 		for (int i = 0; (double)i < num3; i++)
	// 		{
	// 			bool flag = true;
	// 			while (flag)
	// 			{
	// 				num4++;
	// 				num = genRand.Next(40, Main.maxTilesX / 2 - 40);
	// 				if (GenVars.dungeonSide < 0)
	// 				{
	// 					num += Main.maxTilesX / 2;
	// 				}
	// 				num2 = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, Main.maxTilesY - 400);
	// 				int num5 = genRand.Next(2, 4);
	// 				int num6 = genRand.Next(2, 4);
	// 				((Rectangle)(ref area))..ctor(num - num5 - 1, num2 - num6 - 1, num5 + 1, num6 + 1);
	// 				if (Main.tile[num, num2].type == 60)
	// 				{
	// 					int num7 = 30;
	// 					flag = false;
	// 					for (int j = num - num7; j < num + num7; j += 3)
	// 					{
	// 						for (int k = num2 - num7; k < num2 + num7; k += 3)
	// 						{
	// 							if (Main.tile[j, k].active() && (Main.tile[j, k].type == 225 || Main.tile[j, k].type == 229 || Main.tile[j, k].type == 226 || Main.tile[j, k].type == 119 || Main.tile[j, k].type == 120))
	// 							{
	// 								flag = true;
	// 							}
	// 							if (Main.tile[j, k].wall == 86 || Main.tile[j, k].wall == 87)
	// 							{
	// 								flag = true;
	// 							}
	// 						}
	// 					}
	// 					if (!GenVars.structures.CanPlace(area, 1))
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 				if (!flag)
	// 				{
	// 					ushort num8 = 0;
	// 					if (GenVars.jungleHut == 119)
	// 					{
	// 						num8 = 23;
	// 					}
	// 					else if (GenVars.jungleHut == 120)
	// 					{
	// 						num8 = 24;
	// 					}
	// 					else if (GenVars.jungleHut == 158)
	// 					{
	// 						num8 = 42;
	// 					}
	// 					else if (GenVars.jungleHut == 175)
	// 					{
	// 						num8 = 45;
	// 					}
	// 					else if (GenVars.jungleHut == 45)
	// 					{
	// 						num8 = 10;
	// 					}
	// 					for (int l = num - num5 - 1; l <= num + num5 + 1; l++)
	// 					{
	// 						for (int m = num2 - num6 - 1; m <= num2 + num6 + 1; m++)
	// 						{
	// 							Main.tile[l, m].active(active: true);
	// 							Main.tile[l, m].type = GenVars.jungleHut;
	// 							Main.tile[l, m].liquid = 0;
	// 							Main.tile[l, m].lava(lava: false);
	// 						}
	// 					}
	// 					for (int n = num - num5; n <= num + num5; n++)
	// 					{
	// 						for (int num9 = num2 - num6; num9 <= num2 + num6; num9++)
	// 						{
	// 							Main.tile[n, num9].active(active: false);
	// 							Main.tile[n, num9].wall = num8;
	// 						}
	// 					}
	// 					bool flag2 = false;
	// 					int num10 = 0;
	// 					while (!flag2 && num10 < 100)
	// 					{
	// 						num10++;
	// 						int num11 = genRand.Next(num - num5, num + num5 + 1);
	// 						int num12 = genRand.Next(num2 - num6, num2 + num6 - 2);
	// 						PlaceTile(num11, num12, 4, mute: true, forced: false, -1, 3);
	// 						if (TileID.Sets.Torch[Main.tile[num11, num12].type])
	// 						{
	// 							flag2 = true;
	// 						}
	// 					}
	// 					for (int num13 = num - num5 - 1; num13 <= num + num5 + 1; num13++)
	// 					{
	// 						for (int num14 = num2 + num6 - 2; num14 <= num2 + num6; num14++)
	// 						{
	// 							Main.tile[num13, num14].active(active: false);
	// 						}
	// 					}
	// 					for (int num15 = num - num5 - 1; num15 <= num + num5 + 1; num15++)
	// 					{
	// 						for (int num16 = num2 + num6 - 2; num16 <= num2 + num6 - 1; num16++)
	// 						{
	// 							Main.tile[num15, num16].active(active: false);
	// 						}
	// 					}
	// 					for (int num17 = num - num5 - 1; num17 <= num + num5 + 1; num17++)
	// 					{
	// 						int num18 = 4;
	// 						int num19 = num2 + num6 + 2;
	// 						while (!Main.tile[num17, num19].active() && num19 < Main.maxTilesY && num18 > 0)
	// 						{
	// 							Main.tile[num17, num19].active(active: true);
	// 							Main.tile[num17, num19].type = 59;
	// 							num19++;
	// 							num18--;
	// 						}
	// 					}
	// 					num5 -= genRand.Next(1, 3);
	// 					int num20 = num2 - num6 - 2;
	// 					while (num5 > -1)
	// 					{
	// 						for (int num21 = num - num5 - 1; num21 <= num + num5 + 1; num21++)
	// 						{
	// 							Main.tile[num21, num20].active(active: true);
	// 							Main.tile[num21, num20].type = GenVars.jungleHut;
	// 						}
	// 						num5 -= genRand.Next(1, 3);
	// 						num20--;
	// 					}
	// 					GenVars.JChestX[GenVars.numJChests] = num;
	// 					GenVars.JChestY[GenVars.numJChests] = num2;
	// 					GenVars.structures.AddProtectedStructure(area);
	// 					GenVars.numJChests++;
	// 					num4 = 0;
	// 				}
	// 				else if (num4 > Main.maxTilesX * 10)
	// 				{
	// 					i++;
	// 					num4 = 0;
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[137] = false;
	// 	});
	IL_0796: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_079b: ldstr "Jungle Chests"
	IL_07a0: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_47'
	IL_07a5: dup
	IL_07a6: brtrue.s IL_07bf

	// (no C# code)
	IL_07a8: pop
	IL_07a9: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_07ae: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_47'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_07b4: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_07b9: dup
	IL_07ba: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_47'

	// 	AddGenerationPass("Settle Liquids", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[27].Value;
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 		}
	// 		Liquid.worldGenTilesIgnoreWater(ignoreSolids: true);
	// 		Liquid.QuickWater(3);
	// 		WaterCheck();
	// 		int num = 0;
	// 		Liquid.quickSettle = true;
	// 		int num2 = 10;
	// 		while (num < num2)
	// 		{
	// 			int num3 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
	// 			num++;
	// 			double num4 = 0.0;
	// 			int num5 = num3 * 5;
	// 			while (Liquid.numLiquid > 0)
	// 			{
	// 				num5--;
	// 				if (num5 < 0)
	// 				{
	// 					break;
	// 				}
	// 				double num6 = (double)(num3 - (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer)) / (double)num3;
	// 				if (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer > num3)
	// 				{
	// 					num3 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
	// 				}
	// 				if (num6 > num4)
	// 				{
	// 					num4 = num6;
	// 				}
	// 				else
	// 				{
	// 					num6 = num4;
	// 				}
	// 				if (num == 1)
	// 				{
	// 					progress.Set(num6 / 3.0 + 0.33);
	// 				}
	// 				int num7 = 10;
	// 				if (num > num7)
	// 				{
	// 					num7 = num;
	// 				}
	// 				Liquid.UpdateLiquid();
	// 			}
	// 			WaterCheck();
	// 			progress.Set((double)num * 0.1 / 3.0 + 0.66);
	// 		}
	// 		Liquid.quickSettle = false;
	// 		Liquid.worldGenTilesIgnoreWater(ignoreSolids: false);
	// 		Main.tileSolid[484] = false;
	// 	});
	IL_07bf: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_07c4: ldstr "Settle Liquids"
	IL_07c9: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_48'
	IL_07ce: dup
	IL_07cf: brtrue.s IL_07e8

	// (no C# code)
	IL_07d1: pop
	IL_07d2: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_07d7: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_48'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_07dd: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_07e2: dup
	IL_07e3: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_48'

	// 	AddGenerationPass("Remove Water From Sand", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 400; i < Main.maxTilesX - 400; i++)
	// 		{
	// 			for (int j = 100; (double)j < Main.worldSurface - 1.0; j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					ushort type = Main.tile[i, j].type;
	// 					if (type == 53 || type == 396 || type == 397 || type == 404 || type == 407 || type == 151)
	// 					{
	// 						int num = j;
	// 						while (num > 100)
	// 						{
	// 							num--;
	// 							if (Main.tile[i, num].active())
	// 							{
	// 								break;
	// 							}
	// 							Main.tile[i, num].liquid = 0;
	// 						}
	// 					}
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[192] = true;
	// 	});
	IL_07e8: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_07ed: ldstr "Remove Water From Sand"
	IL_07f2: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_49'
	IL_07f7: dup
	IL_07f8: brtrue.s IL_0811

	// (no C# code)
	IL_07fa: pop
	IL_07fb: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0800: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_49'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0806: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_080b: dup
	IL_080c: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_49'

	// 	AddGenerationPass("Oasis", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (!notTheBees)
	// 		{
	// 			progress.Set(1.0);
	// 			int num = Main.maxTilesX / 2100;
	// 			num += genRand.Next(2);
	// 			for (int i = 0; i < num; i++)
	// 			{
	// 				int num2 = beachDistance + 300;
	// 				int num3 = Main.maxTilesX * 2;
	// 				while (num3 > 0)
	// 				{
	// 					num3--;
	// 					int x = genRand.Next(num2, Main.maxTilesX - num2);
	// 					int y = genRand.Next(100, (int)Main.worldSurface);
	// 					if (PlaceOasis(x, y))
	// 					{
	// 						num3 = -1;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0811: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0816: ldstr "Oasis"
	IL_081b: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_50'
	IL_0820: dup
	IL_0821: brtrue.s IL_083a

	// (no C# code)
	IL_0823: pop
	IL_0824: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0829: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_50'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_082f: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0834: dup
	IL_0835: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_50'

	// 	AddGenerationPass("Shell Piles", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (dontStarveWorldGen)
	// 		{
	// 			int num = (int)(5.0 * ((double)Main.maxTilesX / 4200.0));
	// 			int num2 = 0;
	// 			int num3 = 100;
	// 			int num4 = Main.maxTilesX / 2;
	// 			int num5 = num4 - num3;
	// 			int num6 = num4 + num3;
	// 			for (int i = 0; i < 80; i++)
	// 			{
	// 				int num7 = genRand.Next(100, Main.maxTilesX - 100);
	// 				if (num7 >= num5 && num7 <= num6)
	// 				{
	// 					num7 = genRand.Next(100, Main.maxTilesX - 100);
	// 					if (num7 >= num5 && num7 <= num6)
	// 					{
	// 						continue;
	// 					}
	// 				}
	// 				int y = (int)Main.worldSurface / 2;
	// 				if (MarblePileWithStatues(num7, y))
	// 				{
	// 					num2++;
	// 					if (num2 >= num)
	// 					{
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		if (!notTheBees)
	// 		{
	// 			progress.Set(1.0);
	// 			if (genRand.Next(2) == 0)
	// 			{
	// 				int shellStartXLeft = GenVars.shellStartXLeft;
	// 				int shellStartYLeft = GenVars.shellStartYLeft;
	// 				for (int j = shellStartXLeft - 20; j <= shellStartXLeft + 20; j++)
	// 				{
	// 					for (int k = shellStartYLeft - 10; k <= shellStartYLeft + 10; k++)
	// 					{
	// 						if (Main.tile[j, k].active() && Main.tile[j, k].type == 53 && !Main.tile[j, k - 1].active() && Main.tile[j, k - 1].liquid == 0 && !Main.tile[j - 1, k].active() && Main.tile[j - 1, k].liquid > 0)
	// 						{
	// 							GenVars.shellStartXLeft = j;
	// 							GenVars.shellStartYLeft = k;
	// 						}
	// 					}
	// 				}
	// 				GenVars.shellStartYLeft -= 50;
	// 				GenVars.shellStartXLeft -= genRand.Next(5);
	// 				if (genRand.Next(2) == 0)
	// 				{
	// 					GenVars.shellStartXLeft -= genRand.Next(10);
	// 				}
	// 				if (genRand.Next(3) == 0)
	// 				{
	// 					GenVars.shellStartXLeft -= genRand.Next(15);
	// 				}
	// 				if (genRand.Next(4) != 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft, GenVars.shellStartYLeft);
	// 				}
	// 				int maxValue = genRand.Next(2, 4);
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft - genRand.Next(10, 35), GenVars.shellStartYLeft);
	// 				}
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft - genRand.Next(40, 65), GenVars.shellStartYLeft);
	// 				}
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft - genRand.Next(70, 95), GenVars.shellStartYLeft);
	// 				}
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft - genRand.Next(100, 125), GenVars.shellStartYLeft);
	// 				}
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXLeft + genRand.Next(10, 25), GenVars.shellStartYLeft);
	// 				}
	// 			}
	// 			if (genRand.Next(2) == 0)
	// 			{
	// 				int shellStartXRight = GenVars.shellStartXRight;
	// 				int shellStartYRight = GenVars.shellStartYRight;
	// 				for (int l = shellStartXRight - 20; l <= shellStartXRight + 20; l++)
	// 				{
	// 					for (int m = shellStartYRight - 10; m <= shellStartYRight + 10; m++)
	// 					{
	// 						if (Main.tile[l, m].active() && Main.tile[l, m].type == 53 && !Main.tile[l, m - 1].active() && Main.tile[l, m - 1].liquid == 0 && !Main.tile[l + 1, m].active() && Main.tile[l + 1, m].liquid > 0)
	// 						{
	// 							GenVars.shellStartXRight = l;
	// 							GenVars.shellStartYRight = m;
	// 						}
	// 					}
	// 				}
	// 				GenVars.shellStartYRight -= 50;
	// 				GenVars.shellStartXRight += genRand.Next(5);
	// 				if (genRand.Next(2) == 0)
	// 				{
	// 					GenVars.shellStartXLeft += genRand.Next(10);
	// 				}
	// 				if (genRand.Next(3) == 0)
	// 				{
	// 					GenVars.shellStartXLeft += genRand.Next(15);
	// 				}
	// 				if (genRand.Next(4) != 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight, GenVars.shellStartYRight);
	// 				}
	// 				int maxValue2 = genRand.Next(2, 4);
	// 				if (genRand.Next(maxValue2) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight + genRand.Next(10, 35), GenVars.shellStartYRight);
	// 				}
	// 				if (genRand.Next(maxValue2) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight + genRand.Next(40, 65), GenVars.shellStartYRight);
	// 				}
	// 				if (genRand.Next(maxValue2) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight + genRand.Next(70, 95), GenVars.shellStartYRight);
	// 				}
	// 				if (genRand.Next(maxValue2) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight + genRand.Next(100, 125), GenVars.shellStartYRight);
	// 				}
	// 				if (genRand.Next(maxValue2) == 0)
	// 				{
	// 					ShellPile(GenVars.shellStartXRight - genRand.Next(10, 25), GenVars.shellStartYRight);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_083a: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_083f: ldstr "Shell Piles"
	IL_0844: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_51'
	IL_0849: dup
	IL_084a: brtrue.s IL_0863

	// (no C# code)
	IL_084c: pop
	IL_084d: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0852: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_51'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0858: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_085d: dup
	IL_085e: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_51'

	// 	AddGenerationPass("Smooth World", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[60].Value;
	// 		Main.tileSolid[GenVars.crackedType] = true;
	// 		for (int i = 20; i < Main.maxTilesX - 20; i++)
	// 		{
	// 			double value = (double)i / (double)Main.maxTilesX;
	// 			progress.Set(value);
	// 			for (int j = 20; j < Main.maxTilesY - 20; j++)
	// 			{
	// 				if (Main.tile[i, j].type != 48 && Main.tile[i, j].type != 137 && Main.tile[i, j].type != 232 && Main.tile[i, j].type != 191 && Main.tile[i, j].type != 151 && Main.tile[i, j].type != 274)
	// 				{
	// 					if (!Main.tile[i, j - 1].active() && Main.tile[i - 1, j].type != 136 && Main.tile[i + 1, j].type != 136)
	// 					{
	// 						if (SolidTile(i, j) && TileID.Sets.CanBeClearedDuringGeneration[Main.tile[i, j].type])
	// 						{
	// 							if (!Main.tile[i - 1, j].halfBrick() && !Main.tile[i + 1, j].halfBrick() && Main.tile[i - 1, j].slope() == 0 && Main.tile[i + 1, j].slope() == 0)
	// 							{
	// 								if (SolidTile(i, j + 1))
	// 								{
	// 									if (!SolidTile(i - 1, j) && !Main.tile[i - 1, j + 1].halfBrick() && SolidTile(i - 1, j + 1) && SolidTile(i + 1, j) && !Main.tile[i + 1, j - 1].active())
	// 									{
	// 										if (genRand.Next(2) == 0)
	// 										{
	// 											SlopeTile(i, j, 2);
	// 										}
	// 										else
	// 										{
	// 											PoundTile(i, j);
	// 										}
	// 									}
	// 									else if (!SolidTile(i + 1, j) && !Main.tile[i + 1, j + 1].halfBrick() && SolidTile(i + 1, j + 1) && SolidTile(i - 1, j) && !Main.tile[i - 1, j - 1].active())
	// 									{
	// 										if (genRand.Next(2) == 0)
	// 										{
	// 											SlopeTile(i, j, 1);
	// 										}
	// 										else
	// 										{
	// 											PoundTile(i, j);
	// 										}
	// 									}
	// 									else if (SolidTile(i + 1, j + 1) && SolidTile(i - 1, j + 1) && !Main.tile[i + 1, j].active() && !Main.tile[i - 1, j].active())
	// 									{
	// 										PoundTile(i, j);
	// 									}
	// 									if (SolidTile(i, j))
	// 									{
	// 										if (SolidTile(i - 1, j) && SolidTile(i + 1, j + 2) && !Main.tile[i + 1, j].active() && !Main.tile[i + 1, j + 1].active() && !Main.tile[i - 1, j - 1].active())
	// 										{
	// 											KillTile(i, j);
	// 										}
	// 										else if (SolidTile(i + 1, j) && SolidTile(i - 1, j + 2) && !Main.tile[i - 1, j].active() && !Main.tile[i - 1, j + 1].active() && !Main.tile[i + 1, j - 1].active())
	// 										{
	// 											KillTile(i, j);
	// 										}
	// 										else if (!Main.tile[i - 1, j + 1].active() && !Main.tile[i - 1, j].active() && SolidTile(i + 1, j) && SolidTile(i, j + 2))
	// 										{
	// 											if (genRand.Next(5) == 0)
	// 											{
	// 												KillTile(i, j);
	// 											}
	// 											else if (genRand.Next(5) == 0)
	// 											{
	// 												PoundTile(i, j);
	// 											}
	// 											else
	// 											{
	// 												SlopeTile(i, j, 2);
	// 											}
	// 										}
	// 										else if (!Main.tile[i + 1, j + 1].active() && !Main.tile[i + 1, j].active() && SolidTile(i - 1, j) && SolidTile(i, j + 2))
	// 										{
	// 											if (genRand.Next(5) == 0)
	// 											{
	// 												KillTile(i, j);
	// 											}
	// 											else if (genRand.Next(5) == 0)
	// 											{
	// 												PoundTile(i, j);
	// 											}
	// 											else
	// 											{
	// 												SlopeTile(i, j, 1);
	// 											}
	// 										}
	// 									}
	// 								}
	// 								if (SolidTile(i, j) && !Main.tile[i - 1, j].active() && !Main.tile[i + 1, j].active())
	// 								{
	// 									KillTile(i, j);
	// 								}
	// 							}
	// 						}
	// 						else if (!Main.tile[i, j].active() && Main.tile[i, j + 1].type != 151 && Main.tile[i, j + 1].type != 274)
	// 						{
	// 							if (Main.tile[i + 1, j].type != 190 && Main.tile[i + 1, j].type != 48 && Main.tile[i + 1, j].type != 232 && SolidTile(i - 1, j + 1) && SolidTile(i + 1, j) && !Main.tile[i - 1, j].active() && !Main.tile[i + 1, j - 1].active())
	// 							{
	// 								if (Main.tile[i + 1, j].type == 495)
	// 								{
	// 									PlaceTile(i, j, Main.tile[i + 1, j].type);
	// 								}
	// 								else
	// 								{
	// 									PlaceTile(i, j, Main.tile[i, j + 1].type);
	// 								}
	// 								if (genRand.Next(2) == 0)
	// 								{
	// 									SlopeTile(i, j, 2);
	// 								}
	// 								else
	// 								{
	// 									PoundTile(i, j);
	// 								}
	// 							}
	// 							if (Main.tile[i - 1, j].type != 190 && Main.tile[i - 1, j].type != 48 && Main.tile[i - 1, j].type != 232 && SolidTile(i + 1, j + 1) && SolidTile(i - 1, j) && !Main.tile[i + 1, j].active() && !Main.tile[i - 1, j - 1].active())
	// 							{
	// 								if (Main.tile[i - 1, j].type == 495)
	// 								{
	// 									PlaceTile(i, j, Main.tile[i - 1, j].type);
	// 								}
	// 								else
	// 								{
	// 									PlaceTile(i, j, Main.tile[i, j + 1].type);
	// 								}
	// 								if (genRand.Next(2) == 0)
	// 								{
	// 									SlopeTile(i, j, 1);
	// 								}
	// 								else
	// 								{
	// 									PoundTile(i, j);
	// 								}
	// 							}
	// 						}
	// 					}
	// 					else if (!Main.tile[i, j + 1].active() && genRand.Next(2) == 0 && SolidTile(i, j) && !Main.tile[i - 1, j].halfBrick() && !Main.tile[i + 1, j].halfBrick() && Main.tile[i - 1, j].slope() == 0 && Main.tile[i + 1, j].slope() == 0 && SolidTile(i, j - 1))
	// 					{
	// 						if (SolidTile(i - 1, j) && !SolidTile(i + 1, j) && SolidTile(i - 1, j - 1))
	// 						{
	// 							SlopeTile(i, j, 3);
	// 						}
	// 						else if (SolidTile(i + 1, j) && !SolidTile(i - 1, j) && SolidTile(i + 1, j - 1))
	// 						{
	// 							SlopeTile(i, j, 4);
	// 						}
	// 					}
	// 					if (TileID.Sets.Conversion.Sand[Main.tile[i, j].type])
	// 					{
	// 						Tile.SmoothSlope(i, j, applyToNeighbors: false);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int k = 20; k < Main.maxTilesX - 20; k++)
	// 		{
	// 			for (int l = 20; l < Main.maxTilesY - 20; l++)
	// 			{
	// 				if (genRand.Next(2) == 0 && !Main.tile[k, l - 1].active() && Main.tile[k, l].type != 137 && Main.tile[k, l].type != 48 && Main.tile[k, l].type != 232 && Main.tile[k, l].type != 191 && Main.tile[k, l].type != 151 && Main.tile[k, l].type != 274 && Main.tile[k, l].type != 75 && Main.tile[k, l].type != 76 && SolidTile(k, l) && Main.tile[k - 1, l].type != 137 && Main.tile[k + 1, l].type != 137)
	// 				{
	// 					if (SolidTile(k, l + 1) && SolidTile(k + 1, l) && !Main.tile[k - 1, l].active())
	// 					{
	// 						SlopeTile(k, l, 2);
	// 					}
	// 					if (SolidTile(k, l + 1) && SolidTile(k - 1, l) && !Main.tile[k + 1, l].active())
	// 					{
	// 						SlopeTile(k, l, 1);
	// 					}
	// 				}
	// 				if (Main.tile[k, l].slope() == 1 && !SolidTile(k - 1, l))
	// 				{
	// 					SlopeTile(k, l);
	// 					PoundTile(k, l);
	// 				}
	// 				if (Main.tile[k, l].slope() == 2 && !SolidTile(k + 1, l))
	// 				{
	// 					SlopeTile(k, l);
	// 					PoundTile(k, l);
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[137] = true;
	// 		Main.tileSolid[190] = false;
	// 		Main.tileSolid[192] = false;
	// 		Main.tileSolid[GenVars.crackedType] = false;
	// 	});
	IL_0863: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0868: ldstr "Smooth World"
	IL_086d: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_52'
	IL_0872: dup
	IL_0873: brtrue.s IL_088c

	// (no C# code)
	IL_0875: pop
	IL_0876: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_087b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_52'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0881: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0886: dup
	IL_0887: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_52'

	// 	AddGenerationPass("Waterfalls", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[69].Value;
	// 		Main.tileSolid[191] = false;
	// 		for (int i = 20; i < Main.maxTilesX - 20; i++)
	// 		{
	// 			double num = (double)i / (double)Main.maxTilesX;
	// 			progress.Set(num * 0.5);
	// 			for (int j = 20; j < Main.maxTilesY - 20; j++)
	// 			{
	// 				if (SolidTile(i, j) && !Main.tile[i - 1, j].active() && SolidTile(i, j + 1) && !Main.tile[i + 1, j].active() && (Main.tile[i - 1, j].liquid > 0 || Main.tile[i + 1, j].liquid > 0))
	// 				{
	// 					bool flag = true;
	// 					int num2 = genRand.Next(8, 20);
	// 					int num3 = genRand.Next(8, 20);
	// 					num2 = j - num2;
	// 					num3 += j;
	// 					for (int k = num2; k <= num3; k++)
	// 					{
	// 						if (Main.tile[i, k].halfBrick())
	// 						{
	// 							flag = false;
	// 						}
	// 					}
	// 					if ((Main.tile[i, j].type == 75 || Main.tile[i, j].type == 76) && genRand.Next(10) != 0)
	// 					{
	// 						flag = false;
	// 					}
	// 					if (flag)
	// 					{
	// 						PoundTile(i, j);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int l = 20; l < Main.maxTilesX - 20; l++)
	// 		{
	// 			double num4 = (double)l / (double)Main.maxTilesX;
	// 			progress.Set(num4 * 0.5 + 0.5);
	// 			for (int m = 20; m < Main.maxTilesY - 20; m++)
	// 			{
	// 				if (Main.tile[l, m].type != 48 && Main.tile[l, m].type != 232 && SolidTile(l, m) && SolidTile(l, m + 1))
	// 				{
	// 					if (!SolidTile(l + 1, m) && Main.tile[l - 1, m].halfBrick() && Main.tile[l - 2, m].liquid > 0)
	// 					{
	// 						PoundTile(l, m);
	// 					}
	// 					if (!SolidTile(l - 1, m) && Main.tile[l + 1, m].halfBrick() && Main.tile[l + 2, m].liquid > 0)
	// 					{
	// 						PoundTile(l, m);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[191] = true;
	// 	});
	IL_088c: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0891: ldstr "Waterfalls"
	IL_0896: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_53'
	IL_089b: dup
	IL_089c: brtrue.s IL_08b5

	// (no C# code)
	IL_089e: pop
	IL_089f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_08a4: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_53'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_08aa: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_08af: dup
	IL_08b0: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_53'

	// 	AddGenerationPass("Ice", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 		}
	// 		progress.Set(1.0);
	// 		for (int i = 10; i < Main.maxTilesX - 10; i++)
	// 		{
	// 			for (int j = (int)Main.worldSurface; j < Main.maxTilesY - 100; j++)
	// 			{
	// 				if (Main.tile[i, j].liquid > 0 && (!Main.tile[i, j].lava() || remixWorldGen))
	// 				{
	// 					MakeWateryIceThing(i, j);
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[226] = false;
	// 		Main.tileSolid[162] = false;
	// 	});
	IL_08b5: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_08ba: ldstr "Ice"
	IL_08bf: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_54'
	IL_08c4: dup
	IL_08c5: brtrue.s IL_08de

	// (no C# code)
	IL_08c7: pop
	IL_08c8: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_08cd: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_54'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_08d3: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_08d8: dup
	IL_08d9: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_54'

	// 	AddGenerationPass("Wall Variety", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[79].Value;
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) / 5040000.0;
	// 		int num2 = (int)(300.0 * num);
	// 		int num3 = num2;
	// 		ShapeData shapeData = new ShapeData();
	// 		while (num2 > 0)
	// 		{
	// 			progress.Set(1.0 - (double)num2 / (double)num3);
	// 			Point val = RandomWorldPoint((int)GenVars.worldSurface, 2, 190, 2);
	// 			while (Vector2D.Distance(new Vector2D((double)val.X, (double)val.Y), GenVars.shimmerPosition) < (double)shimmerSafetyDistance)
	// 			{
	// 				val = RandomWorldPoint((int)GenVars.worldSurface, 2, 190, 2);
	// 			}
	// 			Tile tile = Main.tile[val.X, val.Y];
	// 			Tile tile2 = Main.tile[val.X, val.Y - 1];
	// 			ushort num4 = 0;
	// 			if (tile.type == 60)
	// 			{
	// 				num4 = (ushort)(204 + genRand.Next(4));
	// 			}
	// 			else if (tile.type == 1 && tile2.wall == 0)
	// 			{
	// 				num4 = ((!remixWorldGen) ? (((double)val.Y < GenVars.rockLayer) ? ((ushort)(196 + genRand.Next(4))) : ((val.Y >= GenVars.lavaLine) ? ((ushort)(208 + genRand.Next(4))) : ((ushort)(212 + genRand.Next(4))))) : (((double)val.Y > GenVars.rockLayer) ? ((ushort)(196 + genRand.Next(4))) : ((val.Y <= GenVars.lavaLine || genRand.Next(2) != 0) ? ((ushort)(212 + genRand.Next(4))) : ((ushort)(208 + genRand.Next(4))))));
	// 			}
	// 			if (tile.active() && num4 != 0 && !tile2.active())
	// 			{
	// 				bool foundInvalidTile = false;
	// 				bool flag = ((tile.type != 60) ? WorldUtils.Gen(new Point(val.X, val.Y - 1), new ShapeFloodFill(1000), Actions.Chain(new Modifiers.IsNotSolid(), new Actions.Blank().Output(shapeData), new Actions.ContinueWrapper(Actions.Chain(new Modifiers.IsTouching(true, 60, 147, 161, 396, 397, 70, 191), new Modifiers.IsTouching(true, 147, 161, 396, 397, 70, 191), new Actions.Custom(delegate
	// 				{
	// 					foundInvalidTile = true;
	// 					return true;
	// 				}))))) : WorldUtils.Gen(new Point(val.X, val.Y - 1), new ShapeFloodFill(1000), Actions.Chain(new Modifiers.IsNotSolid(), new Actions.Blank().Output(shapeData), new Actions.ContinueWrapper(Actions.Chain(new Modifiers.IsTouching(true, 147, 161, 396, 397, 70, 191), new Actions.Custom(delegate
	// 				{
	// 					foundInvalidTile = true;
	// 					return true;
	// 				}))))));
	// 				if (shapeData.Count > 50 && flag && !foundInvalidTile)
	// 				{
	// 					WorldUtils.Gen(new Point(val.X, val.Y), new ModShapes.OuterOutline(shapeData, useDiagonals: true, useInterior: true), Actions.Chain(new Modifiers.SkipWalls(87), new Actions.PlaceWall(num4)));
	// 					num2--;
	// 				}
	// 				shapeData.Clear();
	// 			}
	// 		}
	// 	});
	IL_08de: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_08e3: ldstr "Wall Variety"
	IL_08e8: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_55'
	IL_08ed: dup
	IL_08ee: brtrue.s IL_0907

	// (no C# code)
	IL_08f0: pop
	IL_08f1: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_08f6: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_55'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_08fc: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0901: dup
	IL_0902: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_55'

	// 	AddGenerationPass("Life Crystals", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (getGoodWorldGen)
	// 		{
	// 			Main.tileSolid[56] = false;
	// 		}
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 		}
	// 		progress.Message = Lang.gen[28].Value;
	// 		double num = (double)(Main.maxTilesX * Main.maxTilesY) * 2E-05;
	// 		if (tenthAnniversaryWorldGen)
	// 		{
	// 			num *= 1.2;
	// 		}
	// 		if (Main.starGame)
	// 		{
	// 			num *= Main.starGameMath(0.2);
	// 		}
	// 		for (int i = 0; i < (int)num; i++)
	// 		{
	// 			double value = (double)i / ((double)(Main.maxTilesX * Main.maxTilesY) * 2E-05);
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			int num2 = 0;
	// 			while (!flag)
	// 			{
	// 				int j = genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, Main.maxTilesY - 300);
	// 				if (remixWorldGen)
	// 				{
	// 					j = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 400);
	// 				}
	// 				if (AddLifeCrystal(genRand.Next(Main.offLimitBorderTiles, Main.maxTilesX - Main.offLimitBorderTiles), j))
	// 				{
	// 					flag = true;
	// 				}
	// 				else
	// 				{
	// 					num2++;
	// 					if (num2 >= 10000)
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[225] = false;
	// 	});
	IL_0907: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_090c: ldstr "Life Crystals"
	IL_0911: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_56'
	IL_0916: dup
	IL_0917: brtrue.s IL_0930

	// (no C# code)
	IL_0919: pop
	IL_091a: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_091f: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_56'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0925: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_092a: dup
	IL_092b: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_56'

	// 	AddGenerationPass("Statues", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[29].Value;
	// 		int num = 0;
	// 		double num2 = (double)Main.maxTilesX / 4200.0;
	// 		int num3 = (int)((double)(GenVars.statueList.Length * 2) * num2);
	// 		if (noTrapsWorldGen)
	// 		{
	// 			num3 *= 15;
	// 			if (tenthAnniversaryWorldGen || notTheBees)
	// 			{
	// 				num3 /= 5;
	// 			}
	// 		}
	// 		if (Main.starGame)
	// 		{
	// 			num3 = (int)((double)num3 * Main.starGameMath(0.2));
	// 		}
	// 		for (int i = 0; i < num3; i++)
	// 		{
	// 			if (num >= GenVars.statueList.Length)
	// 			{
	// 				num = 0;
	// 			}
	// 			int x = GenVars.statueList[num].X;
	// 			int y = GenVars.statueList[num].Y;
	// 			double value = i / num3;
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			int num4 = 0;
	// 			while (!flag)
	// 			{
	// 				int num5 = genRand.Next(20, Main.maxTilesX - 20);
	// 				int num6 = genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, Main.maxTilesY - 300);
	// 				if (remixWorldGen)
	// 				{
	// 					genRand.Next((int)Main.worldSurface, Main.maxTilesY - 400);
	// 				}
	// 				while (oceanDepths(num5, num6))
	// 				{
	// 					num5 = genRand.Next(20, Main.maxTilesX - 20);
	// 					num6 = genRand.Next((int)(Main.worldSurface * 2.0 + Main.rockLayer) / 3, Main.maxTilesY - 300);
	// 					if (remixWorldGen)
	// 					{
	// 						genRand.Next((int)Main.worldSurface, Main.maxTilesY - 400);
	// 					}
	// 				}
	// 				while (!Main.tile[num5, num6].active())
	// 				{
	// 					num6++;
	// 					if (num6 >= Main.maxTilesY)
	// 					{
	// 						break;
	// 					}
	// 				}
	// 				if (num6 < Main.maxTilesY)
	// 				{
	// 					num6--;
	// 					if (!Main.tile[num5, num6].shimmer())
	// 					{
	// 						PlaceTile(num5, num6, x, mute: true, forced: true, -1, y);
	// 					}
	// 					if (Main.tile[num5, num6].active() && Main.tile[num5, num6].type == x)
	// 					{
	// 						flag = true;
	// 						if (GenVars.StatuesWithTraps.Contains(num))
	// 						{
	// 							PlaceStatueTrap(num5, num6);
	// 						}
	// 						num++;
	// 					}
	// 					else
	// 					{
	// 						num4++;
	// 						if (num4 >= 10000)
	// 						{
	// 							flag = true;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0930: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0935: ldstr "Statues"
	IL_093a: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_57'
	IL_093f: dup
	IL_0940: brtrue.s IL_0959

	// (no C# code)
	IL_0942: pop
	IL_0943: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0948: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_57'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_094e: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0953: dup
	IL_0954: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_57'

	// 	AddGenerationPass("Buried Chests", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[30].Value;
	// 		Main.tileSolid[226] = true;
	// 		Main.tileSolid[162] = true;
	// 		Main.tileSolid[225] = true;
	// 		CaveHouseBiome caveHouseBiome = GenVars.configuration.CreateBiome<CaveHouseBiome>();
	// 		int random = passConfig.Get<WorldGenRange>("CaveHouseCount").GetRandom(genRand);
	// 		int random2 = passConfig.Get<WorldGenRange>("UnderworldChestCount").GetRandom(genRand);
	// 		int num = passConfig.Get<WorldGenRange>("CaveChestCount").GetRandom(genRand);
	// 		int random3 = passConfig.Get<WorldGenRange>("AdditionalDesertHouseCount").GetRandom(genRand);
	// 		if (Main.starGame)
	// 		{
	// 			num = (int)((double)num * Main.starGameMath(0.2));
	// 		}
	// 		int num2 = random + random2 + num + random3;
	// 		int num3 = 10000;
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			if (num3 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			progress.Set((double)i / (double)num2);
	// 			int num4 = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num5 = genRand.Next((int)((GenVars.worldSurfaceHigh + 20.0 + Main.rockLayer) / 2.0), Main.maxTilesY - 230);
	// 			if (remixWorldGen)
	// 			{
	// 				num5 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 400);
	// 			}
	// 			ushort wall = Main.tile[num4, num5].wall;
	// 			if (Main.wallDungeon[wall] || wall == 87 || oceanDepths(num4, num5) || !AddBuriedChest(num4, num5, 0, notNearOtherChests: false, -1, trySlope: false, 0))
	// 			{
	// 				num3--;
	// 				i--;
	// 			}
	// 		}
	// 		num3 = 10000;
	// 		for (int j = 0; j < random2; j++)
	// 		{
	// 			if (num3 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			progress.Set((double)(j + num) / (double)num2);
	// 			int num6 = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num7 = genRand.Next(Main.UnderworldLayer, Main.maxTilesY - 50);
	// 			if (Main.wallDungeon[Main.tile[num6, num7].wall] || !AddBuriedChest(num6, num7, 0, notNearOtherChests: false, -1, trySlope: false, 0))
	// 			{
	// 				num3--;
	// 				j--;
	// 			}
	// 		}
	// 		num3 = 10000;
	// 		for (int k = 0; k < random; k++)
	// 		{
	// 			if (num3 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			progress.Set((double)(k + num + random2) / (double)num2);
	// 			int num8 = genRand.Next(80, Main.maxTilesX - 80);
	// 			int num9 = genRand.Next((int)(GenVars.worldSurfaceHigh + 20.0), Main.maxTilesY - 230);
	// 			if (remixWorldGen)
	// 			{
	// 				num9 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 400);
	// 			}
	// 			if (oceanDepths(num8, num9) || !caveHouseBiome.Place(new Point(num8, num9), GenVars.structures))
	// 			{
	// 				num3--;
	// 				k--;
	// 			}
	// 		}
	// 		num3 = 10000;
	// 		Rectangle undergroundDesertHiveLocation = GenVars.UndergroundDesertHiveLocation;
	// 		if ((double)undergroundDesertHiveLocation.Y < Main.worldSurface + 26.0)
	// 		{
	// 			int num10 = (int)Main.worldSurface + 26 - undergroundDesertHiveLocation.Y;
	// 			undergroundDesertHiveLocation.Y += num10;
	// 			undergroundDesertHiveLocation.Height -= num10;
	// 		}
	// 		for (int l = 0; l < random3; l++)
	// 		{
	// 			if (num3 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			progress.Set((double)(l + num + random2 + random) / (double)num2);
	// 			if (!caveHouseBiome.Place(RandomRectanglePoint(undergroundDesertHiveLocation), GenVars.structures))
	// 			{
	// 				num3--;
	// 				l--;
	// 			}
	// 		}
	// 		Main.tileSolid[226] = false;
	// 		Main.tileSolid[162] = false;
	// 		Main.tileSolid[225] = false;
	// 	});
	IL_0959: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_095e: ldstr "Buried Chests"
	IL_0963: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_58'
	IL_0968: dup
	IL_0969: brtrue.s IL_0982

	// (no C# code)
	IL_096b: pop
	IL_096c: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0971: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_58'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0977: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_097c: dup
	IL_097d: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_58'

	// 	AddGenerationPass("Surface Chests", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[31].Value;
	// 		for (int i = 0; i < (int)((double)Main.maxTilesX * 0.005); i++)
	// 		{
	// 			double value = (double)i / ((double)Main.maxTilesX * 0.005);
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			int num = 0;
	// 			while (!flag)
	// 			{
	// 				int num2 = genRand.Next(200, Main.maxTilesX - 200);
	// 				int num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)Main.worldSurface);
	// 				if (remixWorldGen)
	// 				{
	// 					num3 = genRand.Next(Main.maxTilesY - 400, Main.maxTilesY - 150);
	// 				}
	// 				else
	// 				{
	// 					while (oceanDepths(num2, num3))
	// 					{
	// 						num2 = genRand.Next(300, Main.maxTilesX - 300);
	// 						num3 = genRand.Next((int)GenVars.worldSurfaceLow, (int)Main.worldSurface);
	// 					}
	// 				}
	// 				bool flag2 = false;
	// 				if (!Main.tile[num2, num3].active())
	// 				{
	// 					if (Main.tile[num2, num3].wall == 2 || Main.tile[num2, num3].wall == 59 || Main.tile[num2, num3].wall == 244 || remixWorldGen)
	// 					{
	// 						flag2 = true;
	// 					}
	// 				}
	// 				else
	// 				{
	// 					int num4 = 50;
	// 					int num5 = num2;
	// 					int num6 = num3;
	// 					int num7 = 1;
	// 					for (int j = num5 - num4; j <= num5 + num4; j += 2)
	// 					{
	// 						for (int k = num6 - num4; k <= num6 + num4; k += 2)
	// 						{
	// 							if ((double)k < Main.worldSurface && !Main.tile[j, k].active() && Main.tile[j, k].wall == 244 && genRand.Next(num7) == 0)
	// 							{
	// 								num7++;
	// 								flag2 = true;
	// 								num2 = j;
	// 								num3 = k;
	// 							}
	// 						}
	// 					}
	// 				}
	// 				if (flag2 && AddBuriedChest(num2, num3, 0, notNearOtherChests: true, -1, trySlope: false, 0))
	// 				{
	// 					flag = true;
	// 				}
	// 				else
	// 				{
	// 					num++;
	// 					if (num >= 2000)
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0982: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0987: ldstr "Surface Chests"
	IL_098c: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_59'
	IL_0991: dup
	IL_0992: brtrue.s IL_09ab

	// (no C# code)
	IL_0994: pop
	IL_0995: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_099a: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_59'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_09a0: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_09a5: dup
	IL_09a6: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_59'

	// 	AddGenerationPass("Jungle Chests Placement", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[32].Value;
	// 		for (int i = 0; i < GenVars.numJChests; i++)
	// 		{
	// 			double value = (double)i / (double)GenVars.numJChests;
	// 			progress.Set(value);
	// 			int nextJungleChestItem = GetNextJungleChestItem();
	// 			if (!AddBuriedChest(GenVars.JChestX[i] + genRand.Next(2), GenVars.JChestY[i], nextJungleChestItem, notNearOtherChests: false, 10, trySlope: false, 0))
	// 			{
	// 				for (int j = GenVars.JChestX[i] - 1; j <= GenVars.JChestX[i] + 1; j++)
	// 				{
	// 					for (int k = GenVars.JChestY[i]; k <= GenVars.JChestY[i] + 2; k++)
	// 					{
	// 						KillTile(j, k);
	// 					}
	// 				}
	// 				for (int l = GenVars.JChestX[i] - 1; l <= GenVars.JChestX[i] + 1; l++)
	// 				{
	// 					for (int m = GenVars.JChestY[i]; m <= GenVars.JChestY[i] + 3; m++)
	// 					{
	// 						if (m < Main.maxTilesY)
	// 						{
	// 							Main.tile[l, m].slope(0);
	// 							Main.tile[l, m].halfBrick(halfBrick: false);
	// 						}
	// 					}
	// 				}
	// 				AddBuriedChest(GenVars.JChestX[i], GenVars.JChestY[i], nextJungleChestItem, notNearOtherChests: false, 10, trySlope: false, 0);
	// 			}
	// 		}
	// 	});
	IL_09ab: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_09b0: ldstr "Jungle Chests Placement"
	IL_09b5: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_60'
	IL_09ba: dup
	IL_09bb: brtrue.s IL_09d4

	// (no C# code)
	IL_09bd: pop
	IL_09be: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_09c3: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_60'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_09c9: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_09ce: dup
	IL_09cf: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_60'

	// 	AddGenerationPass("Water Chests", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[33].Value;
	// 		for (int i = 0; i < GenVars.numOceanCaveTreasure; i++)
	// 		{
	// 			int contain = genRand.NextFromList(new short[5] { 863, 186, 277, 187, 4404 });
	// 			bool flag = false;
	// 			double num = 2.0;
	// 			while (!flag && num < 50.0)
	// 			{
	// 				num += 0.1;
	// 				int num2 = genRand.Next(GenVars.oceanCaveTreasure[i].X - (int)num, GenVars.oceanCaveTreasure[i].X + (int)num + 1);
	// 				int num3 = genRand.Next(GenVars.oceanCaveTreasure[i].Y - (int)num / 2, GenVars.oceanCaveTreasure[i].Y + (int)num / 2 + 1);
	// 				num2 = ((num2 >= Main.maxTilesX) ? ((int)((double)num2 + num / 2.0)) : ((int)((double)num2 - num / 2.0)));
	// 				if (Main.tile[num2, num3].liquid > 250 && (Main.tile[num2, num3].liquidType() == 0 || notTheBees || remixWorldGen))
	// 				{
	// 					flag = AddBuriedChest(num2, num3, contain, notNearOtherChests: false, 17, trySlope: true, 0);
	// 				}
	// 			}
	// 		}
	// 		int num4 = 0;
	// 		double num5 = (double)Main.maxTilesX / 4200.0;
	// 		for (int j = 0; (double)j < 9.0 * num5; j++)
	// 		{
	// 			double value = (double)j / (9.0 * num5);
	// 			progress.Set(value);
	// 			int num6 = 0;
	// 			num4++;
	// 			int maxValue = 10;
	// 			if (tenthAnniversaryWorldGen)
	// 			{
	// 				maxValue = 7;
	// 			}
	// 			if (genRand.Next(maxValue) == 0)
	// 			{
	// 				num6 = 863;
	// 			}
	// 			else
	// 			{
	// 				switch (num4)
	// 				{
	// 				case 1:
	// 					num6 = 186;
	// 					break;
	// 				case 2:
	// 					num6 = 4404;
	// 					break;
	// 				case 3:
	// 					num6 = 277;
	// 					break;
	// 				default:
	// 					num6 = 187;
	// 					num4 = 0;
	// 					break;
	// 				}
	// 			}
	// 			bool flag2 = false;
	// 			int num7 = 0;
	// 			while (!flag2)
	// 			{
	// 				int num8 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num9 = genRand.Next(1, Main.UnderworldLayer);
	// 				while (Main.tile[num8, num9].liquid < 250 || (Main.tile[num8, num9].liquidType() != 0 && !notTheBees && !remixWorldGen))
	// 				{
	// 					num8 = genRand.Next(50, Main.maxTilesX - 50);
	// 					num9 = genRand.Next(50, Main.UnderworldLayer);
	// 				}
	// 				flag2 = AddBuriedChest(num8, num9, num6, notNearOtherChests: false, 17, num8 < beachDistance || num8 > Main.maxTilesX - beachDistance, 0);
	// 				num7++;
	// 				if (num7 > 10000)
	// 				{
	// 					break;
	// 				}
	// 			}
	// 			flag2 = false;
	// 			num7 = 0;
	// 			while (!flag2)
	// 			{
	// 				int num10 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num11 = genRand.Next((int)Main.worldSurface, Main.UnderworldLayer);
	// 				while (Main.tile[num10, num11].liquid < 250 || (Main.tile[num10, num11].liquidType() != 0 && !notTheBees))
	// 				{
	// 					num10 = genRand.Next(50, Main.maxTilesX - 50);
	// 					num11 = genRand.Next((int)Main.worldSurface, Main.UnderworldLayer);
	// 				}
	// 				flag2 = AddBuriedChest(num10, num11, num6, notNearOtherChests: false, 17, num10 < beachDistance || num10 > Main.maxTilesX - beachDistance, 0);
	// 				num7++;
	// 				if (num7 > 10000)
	// 				{
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_09d4: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_09d9: ldstr "Water Chests"
	IL_09de: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_61'
	IL_09e3: dup
	IL_09e4: brtrue.s IL_09fd

	// (no C# code)
	IL_09e6: pop
	IL_09e7: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_09ec: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_61'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_09f2: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_09f7: dup
	IL_09f8: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_61'

	// 	AddGenerationPass("Spider Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[64].Value;
	// 		maxTileCount = 3500;
	// 		int num = Main.maxTilesX / 2;
	// 		int num2 = (int)((double)Main.maxTilesX * 0.005);
	// 		if (getGoodWorldGen)
	// 		{
	// 			num2 *= 3;
	// 		}
	// 		if (notTheBees)
	// 		{
	// 			Main.tileSolid[225] = true;
	// 		}
	// 		for (int i = 0; i < num2; i++)
	// 		{
	// 			double value = (double)i / ((double)Main.maxTilesX * 0.005);
	// 			progress.Set(value);
	// 			int num3 = 0;
	// 			int x = genRand.Next(200, Main.maxTilesX - 200);
	// 			int y = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, Main.maxTilesY - 230);
	// 			if (remixWorldGen)
	// 			{
	// 				y = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 			}
	// 			int num4 = countTiles(x, y, jungle: false, lavaOk: true);
	// 			while ((num4 >= 3500 || num4 < 500) && num3 < num)
	// 			{
	// 				num3++;
	// 				x = genRand.Next(200, Main.maxTilesX - 200);
	// 				y = genRand.Next((int)Main.rockLayer + 30, Main.maxTilesY - 230);
	// 				if (remixWorldGen)
	// 				{
	// 					y = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 				}
	// 				num4 = countTiles(x, y, jungle: false, lavaOk: true);
	// 				if (shroomCount > 1)
	// 				{
	// 					num4 = 0;
	// 				}
	// 			}
	// 			if (num3 < num)
	// 			{
	// 				Spread.Spider(x, y);
	// 			}
	// 		}
	// 		if (notTheBees)
	// 		{
	// 			Main.tileSolid[225] = false;
	// 		}
	// 		Main.tileSolid[162] = true;
	// 	});
	IL_09fd: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0a02: ldstr "Spider Caves"
	IL_0a07: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_62'
	IL_0a0c: dup
	IL_0a0d: brtrue.s IL_0a26

	// (no C# code)
	IL_0a0f: pop
	IL_0a10: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0a15: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_62'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0a1b: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0a20: dup
	IL_0a21: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_62'

	// 	AddGenerationPass("Gem Caves", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (!notTheBees)
	// 		{
	// 			progress.Message = Lang.gen[64].Value;
	// 			maxTileCount = 300;
	// 			double num = (double)Main.maxTilesX * 0.003;
	// 			if (tenthAnniversaryWorldGen)
	// 			{
	// 				num *= 1.5;
	// 			}
	// 			if (Main.starGame)
	// 			{
	// 				num *= Main.starGameMath(0.2);
	// 			}
	// 			for (int i = 0; (double)i < num; i++)
	// 			{
	// 				double value = (double)i / num;
	// 				progress.Set(value);
	// 				int num2 = 0;
	// 				int x = genRand.Next(200, Main.maxTilesX - 200);
	// 				int y = genRand.Next((int)Main.rockLayer + 30, Main.maxTilesY - 230);
	// 				if (remixWorldGen)
	// 				{
	// 					y = genRand.Next((int)Main.worldSurface + 30, (int)Main.rockLayer - 30);
	// 				}
	// 				int num3 = countTiles(x, y);
	// 				while ((num3 >= 300 || num3 < 50 || lavaCount > 0 || iceCount > 0 || rockCount == 0) && num2 < 1000)
	// 				{
	// 					num2++;
	// 					x = genRand.Next(200, Main.maxTilesX - 200);
	// 					y = genRand.Next((int)Main.rockLayer + 30, Main.maxTilesY - 230);
	// 					if (remixWorldGen)
	// 					{
	// 						y = genRand.Next((int)Main.worldSurface + 30, (int)Main.rockLayer - 30);
	// 					}
	// 					num3 = countTiles(x, y);
	// 				}
	// 				if (num2 < 1000)
	// 				{
	// 					gemCave(x, y);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0a26: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0a2b: ldstr "Gem Caves"
	IL_0a30: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_63'
	IL_0a35: dup
	IL_0a36: brtrue.s IL_0a4f

	// (no C# code)
	IL_0a38: pop
	IL_0a39: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0a3e: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_63'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0a44: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0a49: dup
	IL_0a4a: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_63'

	// 	AddGenerationPass("Moss", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
	// 		if (!notTheBees || remixWorldGen)
	// 		{
	// 			progress.Message = Lang.gen[61].Value;
	// 			randMoss();
	// 			int num = Main.maxTilesX / 2100;
	// 			if (remixWorldGen)
	// 			{
	// 				num = (int)((double)num * 1.5);
	// 			}
	// 			else if (tenthAnniversaryWorldGen)
	// 			{
	// 				num *= 2;
	// 			}
	// 			int num2 = 0;
	// 			int num3 = 0;
	// 			while (num3 < num)
	// 			{
	// 				int num4 = genRand.Next(100, Main.maxTilesX - 100);
	// 				if (remixWorldGen)
	// 				{
	// 					num4 = genRand.Next((int)((double)Main.maxTilesX * 0.3), (int)((double)Main.maxTilesX * 0.7));
	// 				}
	// 				else if (tenthAnniversaryWorldGen)
	// 				{
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						randMoss(justNeon: true);
	// 					}
	// 				}
	// 				else if (getGoodWorldGen)
	// 				{
	// 					while ((double)num4 > (double)Main.maxTilesX * 0.42 && (double)num4 < (double)Main.maxTilesX * 0.48)
	// 					{
	// 						num4 = genRand.Next(100, Main.maxTilesX - 100);
	// 					}
	// 				}
	// 				else if (!drunkWorldGen)
	// 				{
	// 					while ((double)num4 > (double)Main.maxTilesX * 0.38 && (double)num4 < (double)Main.maxTilesX * 0.62)
	// 					{
	// 						num4 = genRand.Next(100, Main.maxTilesX - 100);
	// 					}
	// 				}
	// 				int num5 = ((!remixWorldGen) ? genRand.Next((int)Main.rockLayer + 40, GenVars.lavaLine - 40) : genRand.Next((int)Main.worldSurface + 50, (int)Main.rockLayer - 50));
	// 				bool flag = false;
	// 				int num6 = 50;
	// 				for (int i = num4 - num6; i <= num4 + num6; i++)
	// 				{
	// 					for (int j = num5 - num6; j <= num5 + num6; j++)
	// 					{
	// 						if (Main.tile[i, j].active())
	// 						{
	// 							int type = Main.tile[i, j].type;
	// 							if (remixWorldGen)
	// 							{
	// 								if (type == 60 || type == 161 || type == 147 || Main.tileDungeon[type] || type == 25 || type == 203)
	// 								{
	// 									flag = true;
	// 									i = num4 + num6 + 1;
	// 									break;
	// 								}
	// 							}
	// 							else if (type == 70 || type == 60 || type == 367 || type == 368 || type == 161 || type == 147 || type == 396 || type == 397 || Main.tileDungeon[type])
	// 							{
	// 								flag = true;
	// 								i = num4 + num6 + 1;
	// 								break;
	// 							}
	// 						}
	// 					}
	// 				}
	// 				if (flag)
	// 				{
	// 					num2++;
	// 					if (num2 > Main.maxTilesX)
	// 					{
	// 						num3++;
	// 					}
	// 				}
	// 				else
	// 				{
	// 					num2 = 0;
	// 					num3++;
	// 					int maxY = GenVars.lavaLine;
	// 					if (remixWorldGen)
	// 					{
	// 						maxY = (int)Main.rockLayer + 50;
	// 					}
	// 					neonMossBiome(num4, num5, maxY);
	// 				}
	// 			}
	// 			maxTileCount = 2500;
	// 			for (int k = 0; k < (int)((double)Main.maxTilesX * 0.01); k++)
	// 			{
	// 				double value = (double)k / ((double)Main.maxTilesX * 0.01);
	// 				progress.Set(value);
	// 				int num7 = 0;
	// 				int num8 = genRand.Next(200, Main.maxTilesX - 200);
	// 				int num9 = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, GenVars.waterLine);
	// 				if (remixWorldGen)
	// 				{
	// 					num9 = genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
	// 				}
	// 				if (!(Vector2D.Distance(new Vector2D((double)num8, (double)num9), GenVars.shimmerPosition) < (double)shimmerSafetyDistance))
	// 				{
	// 					int num10 = countTiles(num8, num9);
	// 					while ((num10 >= 2500 || num10 < 10 || lavaCount > 0 || iceCount > 0 || rockCount == 0 || shroomCount > 0) && num7 < 1000)
	// 					{
	// 						num7++;
	// 						num8 = genRand.Next(200, Main.maxTilesX - 200);
	// 						num9 = genRand.Next((int)Main.rockLayer + 30, Main.maxTilesY - 230);
	// 						num10 = countTiles(num8, num9);
	// 					}
	// 					if (num7 < 1000)
	// 					{
	// 						setMoss(num8, num9);
	// 						Spread.Moss(num8, num9);
	// 					}
	// 				}
	// 			}
	// 			for (int l = 0; l < Main.maxTilesX; l++)
	// 			{
	// 				int num11 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num12 = ((!remixWorldGen) ? genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, GenVars.lavaLine) : genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300));
	// 				if (!(Vector2D.Distance(new Vector2D((double)num11, (double)num12), GenVars.shimmerPosition) < (double)shimmerSafetyDistance) && Main.tile[num11, num12].type == 1)
	// 				{
	// 					setMoss(num11, num12);
	// 					Main.tile[num11, num12].type = GenVars.mossTile;
	// 				}
	// 			}
	// 			double num13 = (double)Main.maxTilesX * 0.05;
	// 			while (num13 > 0.0)
	// 			{
	// 				int num14 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num15 = ((!remixWorldGen) ? genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, GenVars.lavaLine) : genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300));
	// 				if (!(Vector2D.Distance(new Vector2D((double)num14, (double)num15), GenVars.shimmerPosition) < (double)shimmerSafetyDistance) && Main.tile[num14, num15].type == 1 && (!Main.tile[num14 - 1, num15].active() || !Main.tile[num14 + 1, num15].active() || !Main.tile[num14, num15 - 1].active() || !Main.tile[num14, num15 + 1].active()))
	// 				{
	// 					setMoss(num14, num15);
	// 					Main.tile[num14, num15].type = GenVars.mossTile;
	// 					num13 -= 1.0;
	// 				}
	// 			}
	// 			num13 = (double)Main.maxTilesX * 0.065;
	// 			if (remixWorldGen)
	// 			{
	// 				num13 *= 2.0;
	// 			}
	// 			while (num13 > 0.0)
	// 			{
	// 				int num16 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num17 = ((!remixWorldGen) ? genRand.Next(GenVars.waterLine, Main.UnderworldLayer) : genRand.Next(GenVars.lavaLine, (int)Main.rockLayer + 50));
	// 				if (Main.tile[num16, num17].type == 1 && (!Main.tile[num16 - 1, num17].active() || !Main.tile[num16 + 1, num17].active() || !Main.tile[num16, num17 - 1].active() || !Main.tile[num16, num17 + 1].active()))
	// 				{
	// 					int num18 = 25;
	// 					int num19 = 0;
	// 					for (int m = num16 - num18; m < num16 + num18; m++)
	// 					{
	// 						for (int n = num17 - num18; n < num17 + num18; n++)
	// 						{
	// 							if (Main.tile[m, n].liquid > 0 && Main.tile[m, n].lava())
	// 							{
	// 								num19++;
	// 							}
	// 						}
	// 					}
	// 					if (num19 > 20)
	// 					{
	// 						Main.tile[num16, num17].type = 381;
	// 						num13 -= 1.0;
	// 					}
	// 					else
	// 					{
	// 						num13 -= 0.002;
	// 					}
	// 				}
	// 				num13 -= 0.001;
	// 			}
	// 			for (int num20 = 0; num20 < Main.maxTilesX; num20++)
	// 			{
	// 				for (int num21 = 0; num21 < Main.maxTilesY; num21++)
	// 				{
	// 					if (Main.tile[num20, num21].active() && Main.tileMoss[Main.tile[num20, num21].type])
	// 					{
	// 						for (int num22 = 0; num22 < 4; num22++)
	// 						{
	// 							int num23 = num20;
	// 							int num24 = num21;
	// 							if (num22 == 0)
	// 							{
	// 								num23--;
	// 							}
	// 							if (num22 == 1)
	// 							{
	// 								num23++;
	// 							}
	// 							if (num22 == 2)
	// 							{
	// 								num24--;
	// 							}
	// 							if (num22 == 3)
	// 							{
	// 								num24++;
	// 							}
	// 							try
	// 							{
	// 								grassSpread = 0;
	// 								SpreadGrass(num23, num24, 1, Main.tile[num20, num21].type);
	// 							}
	// 							catch
	// 							{
	// 								grassSpread = 0;
	// 								SpreadGrass(num23, num24, 1, Main.tile[num20, num21].type, repeat: false);
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0a4f: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0a54: ldstr "Moss"
	IL_0a59: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_64'
	IL_0a5e: dup
	IL_0a5f: brtrue.s IL_0a78

	// (no C# code)
	IL_0a61: pop
	IL_0a62: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0a67: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_64'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0a6d: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0a72: dup
	IL_0a73: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_64'

	// 	AddGenerationPass("Temple", delegate
	// 	{
	// 		Main.tileSolid[162] = false;
	// 		Main.tileSolid[226] = true;
	// 		templePart2();
	// 		Main.tileSolid[232] = false;
	// 	});
	IL_0a78: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0a7d: ldstr "Temple"
	IL_0a82: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_65'
	IL_0a87: dup
	IL_0a88: brtrue.s IL_0aa1

	// (no C# code)
	IL_0a8a: pop
	IL_0a8b: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0a90: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_65'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0a96: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0a9b: dup
	IL_0a9c: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_65'

	// 	AddGenerationPass("Cave Walls", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[63].Value;
	// 		maxTileCount = 1500;
	// 		for (int i = 0; i < (int)((double)Main.maxTilesX * 0.04); i++)
	// 		{
	// 			double num = (double)i / ((double)Main.maxTilesX * 0.04);
	// 			progress.Set(num * 0.66);
	// 			int num2 = 0;
	// 			int x = genRand.Next(200, Main.maxTilesX - 200);
	// 			int y = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, Main.maxTilesY - 220);
	// 			if (remixWorldGen)
	// 			{
	// 				y = genRand.Next((int)Main.worldSurface + 25, (int)Main.rockLayer);
	// 			}
	// 			int num3 = countTiles(x, y, jungle: false, lavaOk: true);
	// 			while ((num3 >= maxTileCount || num3 < 10) && num2 < 500)
	// 			{
	// 				num2++;
	// 				x = genRand.Next(200, Main.maxTilesX - 200);
	// 				y = genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, Main.maxTilesY - 220);
	// 				if (remixWorldGen)
	// 				{
	// 					y = genRand.Next((int)Main.worldSurface + 25, (int)Main.rockLayer);
	// 				}
	// 				num3 = countTiles(x, y, jungle: false, lavaOk: true);
	// 			}
	// 			if (num2 < 500)
	// 			{
	// 				int num4 = genRand.Next(2);
	// 				if ((double)shroomCount > (double)rockCount * 0.75)
	// 				{
	// 					num4 = 80;
	// 				}
	// 				else if (iceCount > 0)
	// 				{
	// 					switch (num4)
	// 					{
	// 					case 0:
	// 						num4 = 40;
	// 						break;
	// 					case 1:
	// 						num4 = 71;
	// 						break;
	// 					}
	// 				}
	// 				else if (lavaCount > 0)
	// 				{
	// 					num4 = 79;
	// 				}
	// 				else
	// 				{
	// 					num4 = genRand.Next(4);
	// 					switch (num4)
	// 					{
	// 					case 0:
	// 						num4 = 59;
	// 						break;
	// 					case 1:
	// 						num4 = 61;
	// 						break;
	// 					case 2:
	// 						num4 = 170;
	// 						break;
	// 					case 3:
	// 						num4 = 171;
	// 						break;
	// 					}
	// 				}
	// 				Spread.Wall(x, y, num4);
	// 			}
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			maxTileCount = 1500;
	// 			for (int j = 0; j < (int)((double)Main.maxTilesX * 0.04); j++)
	// 			{
	// 				double num5 = (double)j / ((double)Main.maxTilesX * 0.04);
	// 				progress.Set(num5 * 0.66);
	// 				int num6 = 0;
	// 				int x2 = genRand.Next(200, Main.maxTilesX - 200);
	// 				int y2 = genRand.Next((int)Main.rockLayer, Main.maxTilesY - 350);
	// 				int num7 = countTiles(x2, y2, jungle: false, lavaOk: true);
	// 				while ((num7 >= maxTileCount || num7 < 10) && num6 < 500)
	// 				{
	// 					num6++;
	// 					x2 = genRand.Next(200, Main.maxTilesX - 200);
	// 					y2 = genRand.Next((int)Main.rockLayer, Main.maxTilesY - 350);
	// 					num7 = countTiles(x2, y2, jungle: false, lavaOk: true);
	// 				}
	// 				if (num6 < 500 && iceCount == 0 && lavaCount == 0 && sandCount == 0)
	// 				{
	// 					int wallType = ((genRand.Next(2) != 0) ? 63 : 2);
	// 					Spread.Wall(x2, y2, wallType);
	// 				}
	// 			}
	// 		}
	// 		maxTileCount = 1500;
	// 		double num8 = (double)Main.maxTilesX * 0.02;
	// 		for (int k = 0; (double)k < num8; k++)
	// 		{
	// 			double num9 = (double)k / ((double)Main.maxTilesX * 0.02);
	// 			progress.Set(num9 * 0.33 + 0.66);
	// 			int num10 = 0;
	// 			int x3 = genRand.Next(200, Main.maxTilesX - 200);
	// 			int y3 = genRand.Next((int)Main.worldSurface, GenVars.lavaLine);
	// 			int num11 = 0;
	// 			if (Main.tile[x3, y3].wall == 64)
	// 			{
	// 				num11 = countTiles(x3, y3, jungle: true);
	// 			}
	// 			while ((num11 >= maxTileCount || num11 < 10) && num10 < 1000)
	// 			{
	// 				num10++;
	// 				x3 = genRand.Next(200, Main.maxTilesX - 200);
	// 				y3 = genRand.Next((int)Main.worldSurface, GenVars.lavaLine);
	// 				if (!Main.wallHouse[Main.tile[x3, y3].wall] && Main.tile[x3, y3].wall != 244)
	// 				{
	// 					num11 = ((Main.tile[x3, y3].wall == 64) ? countTiles(x3, y3, jungle: true) : 0);
	// 				}
	// 			}
	// 			if (num10 < 1000)
	// 			{
	// 				Spread.Wall2(x3, y3, 15);
	// 			}
	// 		}
	// 	});
	IL_0aa1: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0aa6: ldstr "Cave Walls"
	IL_0aab: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_66'
	IL_0ab0: dup
	IL_0ab1: brtrue.s IL_0aca

	// (no C# code)
	IL_0ab3: pop
	IL_0ab4: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0ab9: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_66'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0abf: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0ac4: dup
	IL_0ac5: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_66'

	// 	AddGenerationPass("Jungle Trees", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[83].Value;
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			progress.Set((double)i / (double)Main.maxTilesX);
	// 			for (int j = (int)Main.worldSurface - 1; j < Main.maxTilesY - 350; j++)
	// 			{
	// 				if (genRand.Next(10) == 0 || drunkWorldGen)
	// 				{
	// 					GrowUndergroundTree(i, j);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0aca: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0acf: ldstr "Jungle Trees"
	IL_0ad4: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_67'
	IL_0ad9: dup
	IL_0ada: brtrue.s IL_0af3

	// (no C# code)
	IL_0adc: pop
	IL_0add: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0ae2: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_67'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0ae8: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0aed: dup
	IL_0aee: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_67'

	// 	AddGenerationPass("Floating Island Houses", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < GenVars.numIslandHouses; i++)
	// 		{
	// 			if (!GenVars.skyLake[i])
	// 			{
	// 				IslandHouse(GenVars.floatingIslandHouseX[i], GenVars.floatingIslandHouseY[i], GenVars.floatingIslandStyle[i]);
	// 			}
	// 		}
	// 	});
	IL_0af3: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0af8: ldstr "Floating Island Houses"
	IL_0afd: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_68'
	IL_0b02: dup
	IL_0b03: brtrue.s IL_0b1c

	// (no C# code)
	IL_0b05: pop
	IL_0b06: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0b0b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_68'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0b11: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0b16: dup
	IL_0b17: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_68'

	// 	AddGenerationPass("Quick Cleanup", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 		}
	// 		Main.tileSolid[137] = false;
	// 		Main.tileSolid[130] = false;
	// 		for (int i = 20; i < Main.maxTilesX - 20; i++)
	// 		{
	// 			for (int j = 20; j < Main.maxTilesY - 20; j++)
	// 			{
	// 				if ((double)j < Main.worldSurface && oceanDepths(i, j) && Main.tile[i, j].type == 53 && Main.tile[i, j].active())
	// 				{
	// 					if (Main.tile[i, j].bottomSlope())
	// 					{
	// 						Main.tile[i, j].slope(0);
	// 					}
	// 					for (int k = j + 1; k < j + genRand.Next(4, 7) && (!Main.tile[i, k].active() || (Main.tile[i, k].type != 397 && Main.tile[i, k].type != 53)) && (!Main.tile[i, k + 1].active() || (Main.tile[i, k + 1].type != 397 && Main.tile[i, k + 1].type != 53 && Main.tile[i, k + 1].type != 495)) && (!Main.tile[i, k + 2].active() || (Main.tile[i, k + 2].type != 397 && Main.tile[i, k + 2].type != 53 && Main.tile[i, k + 2].type != 495)); k++)
	// 					{
	// 						Main.tile[i, k].type = 0;
	// 						Main.tile[i, k].active(active: true);
	// 						Main.tile[i, k].halfBrick(halfBrick: false);
	// 						Main.tile[i, k].slope(0);
	// 					}
	// 				}
	// 				if (Main.tile[i, j].wall == 187 || Main.tile[i, j].wall == 216)
	// 				{
	// 					if (Main.tile[i, j].type == 59 || Main.tile[i, j].type == 123 || Main.tile[i, j].type == 224)
	// 					{
	// 						Main.tile[i, j].type = 397;
	// 					}
	// 					if (Main.tile[i, j].type == 368 || Main.tile[i, j].type == 367)
	// 					{
	// 						Main.tile[i, j].type = 397;
	// 					}
	// 					if ((double)j <= Main.rockLayer)
	// 					{
	// 						Main.tile[i, j].liquid = 0;
	// 					}
	// 					else if (Main.tile[i, j].liquid > 0)
	// 					{
	// 						Main.tile[i, j].liquid = byte.MaxValue;
	// 						Main.tile[i, j].lava(lava: true);
	// 					}
	// 				}
	// 				if ((double)j < Main.worldSurface && Main.tile[i, j].active() && Main.tile[i, j].type == 53 && Main.tile[i, j + 1].wall == 0 && !SolidTile(i, j + 1))
	// 				{
	// 					ushort num = 0;
	// 					int num2 = 3;
	// 					for (int l = i - num2; l <= i + num2; l++)
	// 					{
	// 						for (int m = j - num2; m <= j + num2; m++)
	// 						{
	// 							if (Main.tile[l, m].wall > 0)
	// 							{
	// 								num = Main.tile[l, m].wall;
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					if (num > 0)
	// 					{
	// 						Main.tile[i, j + 1].wall = num;
	// 						if (Main.tile[i, j].wall == 0)
	// 						{
	// 							Main.tile[i, j].wall = num;
	// 						}
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type != 19 && TileID.Sets.CanBeClearedDuringGeneration[Main.tile[i, j].type])
	// 				{
	// 					if (Main.tile[i, j].topSlope() || Main.tile[i, j].halfBrick())
	// 					{
	// 						if (Main.tile[i, j].type != 225 || !Main.tile[i, j].halfBrick())
	// 						{
	// 							if (!SolidTile(i, j + 1))
	// 							{
	// 								Main.tile[i, j].active(active: false);
	// 							}
	// 							if (Main.tile[i + 1, j].type == 137 || Main.tile[i - 1, j].type == 137)
	// 							{
	// 								Main.tile[i, j].active(active: false);
	// 							}
	// 						}
	// 					}
	// 					else if (Main.tile[i, j].bottomSlope())
	// 					{
	// 						if (!SolidTile(i, j - 1))
	// 						{
	// 							Main.tile[i, j].active(active: false);
	// 						}
	// 						if (Main.tile[i + 1, j].type == 137 || Main.tile[i - 1, j].type == 137)
	// 						{
	// 							Main.tile[i, j].active(active: false);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0b1c: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0b21: ldstr "Quick Cleanup"
	IL_0b26: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_69'
	IL_0b2b: dup
	IL_0b2c: brtrue.s IL_0b45

	// (no C# code)
	IL_0b2e: pop
	IL_0b2f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0b34: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_69'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0b3a: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0b3f: dup
	IL_0b40: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_69'

	// 	AddGenerationPass("Pots", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		Main.tileSolid[137] = true;
	// 		Main.tileSolid[130] = true;
	// 		progress.Message = Lang.gen[35].Value;
	// 		if (noTrapsWorldGen)
	// 		{
	// 			Main.tileSolid[138] = true;
	// 			int num = (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0004);
	// 			if (remixWorldGen)
	// 			{
	// 				num /= 2;
	// 			}
	// 			for (int i = 0; i < num; i++)
	// 			{
	// 				int num2 = genRand.Next(50, Main.maxTilesX - 50);
	// 				int j;
	// 				for (j = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 250); !Main.tile[num2, j].active() && j < Main.maxTilesY - 250; j++)
	// 				{
	// 				}
	// 				j--;
	// 				if (!Main.tile[num2, j].shimmer())
	// 				{
	// 					PlaceTile(num2, j, 138, mute: true);
	// 					PlaceTile(num2 + 2, j, 138, mute: true);
	// 					PlaceTile(num2 + 1, j - 2, 138, mute: true);
	// 				}
	// 			}
	// 			Main.tileSolid[138] = false;
	// 		}
	// 		double num3 = (double)(Main.maxTilesX * Main.maxTilesY) * 0.0008;
	// 		if (Main.starGame)
	// 		{
	// 			num3 *= Main.starGameMath(0.2);
	// 		}
	// 		for (int k = 0; (double)k < num3; k++)
	// 		{
	// 			double num4 = (double)k / num3;
	// 			progress.Set(num4);
	// 			bool flag = false;
	// 			int num5 = 0;
	// 			while (!flag)
	// 			{
	// 				int num6 = genRand.Next((int)GenVars.worldSurfaceHigh, Main.maxTilesY - 10);
	// 				if (num4 > 0.93)
	// 				{
	// 					num6 = Main.maxTilesY - 150;
	// 				}
	// 				else if (num4 > 0.75)
	// 				{
	// 					num6 = (int)GenVars.worldSurfaceLow;
	// 				}
	// 				int x = genRand.Next(20, Main.maxTilesX - 20);
	// 				bool flag2 = false;
	// 				for (int l = num6; l < Main.maxTilesY - 20; l++)
	// 				{
	// 					if (!flag2)
	// 					{
	// 						if (Main.tile[x, l].active() && Main.tileSolid[Main.tile[x, l].type] && !Main.tile[x, l - 1].lava() && !Main.tile[x, l - 1].shimmer())
	// 						{
	// 							flag2 = true;
	// 						}
	// 					}
	// 					else if (!((double)l < Main.worldSurface) || Main.tile[x, l].wall != 0)
	// 					{
	// 						int style = genRand.Next(0, 4);
	// 						int num7 = 0;
	// 						int num8 = 0;
	// 						if (l < Main.maxTilesY - 5)
	// 						{
	// 							num7 = Main.tile[x, l + 1].type;
	// 							num8 = Main.tile[x, l].wall;
	// 						}
	// 						if (num7 == 147 || num7 == 161 || num7 == 162)
	// 						{
	// 							style = genRand.Next(4, 7);
	// 						}
	// 						if (num7 == 60)
	// 						{
	// 							style = genRand.Next(7, 10);
	// 						}
	// 						if (Main.wallDungeon[Main.tile[x, l].wall])
	// 						{
	// 							style = genRand.Next(10, 13);
	// 						}
	// 						if (num7 == 41 || num7 == 43 || num7 == 44 || num7 == 481 || num7 == 482 || num7 == 483)
	// 						{
	// 							style = genRand.Next(10, 13);
	// 						}
	// 						if (num7 == 22 || num7 == 23 || num7 == 25)
	// 						{
	// 							style = genRand.Next(16, 19);
	// 						}
	// 						if (num7 == 199 || num7 == 203 || num7 == 204 || num7 == 200)
	// 						{
	// 							style = genRand.Next(22, 25);
	// 						}
	// 						if (num7 == 367)
	// 						{
	// 							style = genRand.Next(31, 34);
	// 						}
	// 						if (num7 == 226)
	// 						{
	// 							style = genRand.Next(28, 31);
	// 						}
	// 						if (num8 == 187 || num8 == 216)
	// 						{
	// 							style = genRand.Next(34, 37);
	// 						}
	// 						if (l > Main.UnderworldLayer)
	// 						{
	// 							style = genRand.Next(13, 16);
	// 						}
	// 						if (!oceanDepths(x, l) && !Main.tile[x, l].shimmer() && PlacePot(x, l, 28, style))
	// 						{
	// 							flag = true;
	// 							break;
	// 						}
	// 						num5++;
	// 						if (num5 >= 10000)
	// 						{
	// 							flag = true;
	// 							break;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0b45: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0b4a: ldstr "Pots"
	IL_0b4f: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_70'
	IL_0b54: dup
	IL_0b55: brtrue.s IL_0b6e

	// (no C# code)
	IL_0b57: pop
	IL_0b58: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0b5d: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_70'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0b63: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0b68: dup
	IL_0b69: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_70'

	// 	AddGenerationPass("Hellforge", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[36].Value;
	// 		for (int i = 0; i < Main.maxTilesX / 200; i++)
	// 		{
	// 			double value = (double)i / (double)(Main.maxTilesX / 200);
	// 			progress.Set(value);
	// 			bool flag = false;
	// 			int num = 0;
	// 			while (!flag)
	// 			{
	// 				int num2 = genRand.Next(1, Main.maxTilesX);
	// 				int j = genRand.Next(Main.maxTilesY - 250, Main.maxTilesY - 30);
	// 				try
	// 				{
	// 					if (Main.tile[num2, j].wall == 13 || Main.tile[num2, j].wall == 14)
	// 					{
	// 						for (; !Main.tile[num2, j].active() && j < Main.maxTilesY - 20; j++)
	// 						{
	// 						}
	// 						j--;
	// 						PlaceTile(num2, j, 77);
	// 						if (Main.tile[num2, j].type == 77)
	// 						{
	// 							flag = true;
	// 						}
	// 						else
	// 						{
	// 							num++;
	// 							if (num >= 10000)
	// 							{
	// 								flag = true;
	// 							}
	// 						}
	// 					}
	// 				}
	// 				catch
	// 				{
	// 					num++;
	// 					if (num >= 10000)
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0b6e: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0b73: ldstr "Hellforge"
	IL_0b78: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_71'
	IL_0b7d: dup
	IL_0b7e: brtrue.s IL_0b97

	// (no C# code)
	IL_0b80: pop
	IL_0b81: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0b86: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_71'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0b8c: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0b91: dup
	IL_0b92: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_71'

	// 	AddGenerationPass("Spreading Grass", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (!notTheBees || remixWorldGen)
	// 		{
	// 			progress.Message = Lang.gen[37].Value;
	// 			for (int i = 50; i < Main.maxTilesX - 50; i++)
	// 			{
	// 				for (int j = 50; (double)j <= Main.worldSurface; j++)
	// 				{
	// 					if (Main.tile[i, j].active())
	// 					{
	// 						int type = Main.tile[i, j].type;
	// 						if (Main.tile[i, j].active() && type == 60)
	// 						{
	// 							for (int k = i - 1; k <= i + 1; k++)
	// 							{
	// 								for (int l = j - 1; l <= j + 1; l++)
	// 								{
	// 									if (Main.tile[k, l].active() && Main.tile[k, l].type == 0)
	// 									{
	// 										if (!Main.tile[k, l - 1].active())
	// 										{
	// 											Main.tile[k, l].type = 60;
	// 										}
	// 										else
	// 										{
	// 											Main.tile[k, l].type = 59;
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 						else if (type == 1 || type == 40 || TileID.Sets.Ore[type])
	// 						{
	// 							int num = 3;
	// 							bool flag = false;
	// 							ushort num2 = 0;
	// 							for (int m = i - num; m <= i + num; m++)
	// 							{
	// 								for (int n = j - num; n <= j + num; n++)
	// 								{
	// 									if (Main.tile[m, n].active())
	// 									{
	// 										if (Main.tile[m, n].type == 53 || num2 == 53)
	// 										{
	// 											num2 = 53;
	// 										}
	// 										else if (Main.tile[m, n].type == 59 || Main.tile[m, n].type == 60 || Main.tile[m, n].type == 147 || Main.tile[m, n].type == 161 || Main.tile[m, n].type == 199 || Main.tile[m, n].type == 23)
	// 										{
	// 											num2 = Main.tile[m, n].type;
	// 										}
	// 									}
	// 									else if (n < j && Main.tile[m, n].wall == 0)
	// 									{
	// 										flag = true;
	// 									}
	// 								}
	// 							}
	// 							if (flag)
	// 							{
	// 								switch (num2)
	// 								{
	// 								case 23:
	// 								case 199:
	// 									if (Main.tile[i, j - 1].active())
	// 									{
	// 										num2 = 0;
	// 									}
	// 									break;
	// 								case 59:
	// 								case 60:
	// 									if (i >= GenVars.jungleMinX && i <= GenVars.jungleMaxX)
	// 									{
	// 										num2 = (ushort)(Main.tile[i, j - 1].active() ? 59u : 60u);
	// 									}
	// 									break;
	// 								}
	// 								Main.tile[i, j].type = num2;
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 			for (int num3 = 10; num3 < Main.maxTilesX - 10; num3++)
	// 			{
	// 				bool flag2 = true;
	// 				for (int num4 = 0; (double)num4 < Main.worldSurface - 1.0; num4++)
	// 				{
	// 					if (Main.tile[num3, num4].active())
	// 					{
	// 						if (flag2 && Main.tile[num3, num4].type == 0)
	// 						{
	// 							try
	// 							{
	// 								grassSpread = 0;
	// 								SpreadGrass(num3, num4);
	// 							}
	// 							catch
	// 							{
	// 								grassSpread = 0;
	// 								SpreadGrass(num3, num4, 0, 2, repeat: false);
	// 							}
	// 						}
	// 						if ((double)num4 > GenVars.worldSurfaceHigh)
	// 						{
	// 							break;
	// 						}
	// 						flag2 = false;
	// 					}
	// 					else if (Main.tile[num3, num4].wall == 0)
	// 					{
	// 						flag2 = true;
	// 					}
	// 				}
	// 			}
	// 			if (remixWorldGen)
	// 			{
	// 				for (int num5 = 5; num5 < Main.maxTilesX - 5; num5++)
	// 				{
	// 					for (int num6 = (int)GenVars.rockLayerLow + genRand.Next(-1, 2); num6 < Main.maxTilesY - 200; num6++)
	// 					{
	// 						if (Main.tile[num5, num6].type == 0 && Main.tile[num5, num6].active() && (!Main.tile[num5 - 1, num6 - 1].active() || !Main.tile[num5, num6 - 1].active() || !Main.tile[num5 + 1, num6 - 1].active() || !Main.tile[num5 - 1, num6].active() || !Main.tile[num5 + 1, num6].active() || !Main.tile[num5 - 1, num6 + 1].active() || !Main.tile[num5, num6 + 1].active() || !Main.tile[num5 + 1, num6 + 1].active()))
	// 						{
	// 							Main.tile[num5, num6].type = 2;
	// 						}
	// 					}
	// 				}
	// 				for (int num7 = 5; num7 < Main.maxTilesX - 5; num7++)
	// 				{
	// 					for (int num8 = (int)GenVars.rockLayerLow + genRand.Next(-1, 2); num8 < Main.maxTilesY - 200; num8++)
	// 					{
	// 						if (Main.tile[num7, num8].type == 2 && !Main.tile[num7, num8 - 1].active() && genRand.Next(20) == 0)
	// 						{
	// 							PlaceTile(num7, num8 - 1, 27, mute: true);
	// 						}
	// 					}
	// 				}
	// 				int conversionType = 1;
	// 				if (crimson)
	// 				{
	// 					conversionType = 4;
	// 				}
	// 				int num9 = Main.maxTilesX / 7;
	// 				for (int num10 = 10; num10 < Main.maxTilesX - 10; num10++)
	// 				{
	// 					for (int num11 = 10; num11 < Main.maxTilesY - 10; num11++)
	// 					{
	// 						if ((double)num11 < Main.worldSurface + (double)genRand.Next(3) || num10 < num9 + genRand.Next(3) || num10 >= Main.maxTilesX - num9 - genRand.Next(3))
	// 						{
	// 							if (drunkWorldGen)
	// 							{
	// 								if (GenVars.crimsonLeft)
	// 								{
	// 									if (num10 < Main.maxTilesX / 2 + genRand.Next(-2, 3))
	// 									{
	// 										Convert(num10, num11, 4, 1);
	// 									}
	// 									else
	// 									{
	// 										Convert(num10, num11, 1, 1);
	// 									}
	// 								}
	// 								else if (num10 < Main.maxTilesX / 2 + genRand.Next(-2, 3))
	// 								{
	// 									Convert(num10, num11, 1, 1);
	// 								}
	// 								else
	// 								{
	// 									Convert(num10, num11, 4, 1);
	// 								}
	// 							}
	// 							else
	// 							{
	// 								Convert(num10, num11, conversionType, 1);
	// 							}
	// 							Main.tile[num10, num11].color(0);
	// 							Main.tile[num10, num11].wallColor(0);
	// 						}
	// 					}
	// 				}
	// 				if (remixWorldGen)
	// 				{
	// 					Main.tileSolid[225] = true;
	// 					int num12 = (int)((double)Main.maxTilesX * 0.31);
	// 					int num13 = (int)((double)Main.maxTilesX * 0.69);
	// 					_ = Main.maxTilesY;
	// 					int num14 = Main.maxTilesY - 135;
	// 					_ = Main.maxTilesY;
	// 					Liquid.QuickWater(-2);
	// 					for (int num15 = num12; num15 < num13 + 15; num15++)
	// 					{
	// 						for (int num16 = Main.maxTilesY - 200; num16 < num14; num16++)
	// 						{
	// 							Main.tile[num15, num16].liquid = 0;
	// 						}
	// 					}
	// 					Main.tileSolid[225] = false;
	// 					Main.tileSolid[484] = false;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0b97: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0b9c: ldstr "Spreading Grass"
	IL_0ba1: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_72'
	IL_0ba6: dup
	IL_0ba7: brtrue.s IL_0bc0

	// (no C# code)
	IL_0ba9: pop
	IL_0baa: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0baf: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_72'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0bb5: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0bba: dup
	IL_0bbb: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_72'

	// 	AddGenerationPass("Surface Ore and Stone", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		int num = genRand.Next(Main.maxTilesX * 5 / 4200, Main.maxTilesX * 10 / 4200);
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			int num2 = Main.maxTilesX / 420;
	// 			while (num2 > 0)
	// 			{
	// 				num2--;
	// 				int num3 = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 				while ((double)num3 >= (double)Main.maxTilesX * 0.48 && (double)num3 <= (double)Main.maxTilesX * 0.52)
	// 				{
	// 					num3 = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 				}
	// 				int y = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurface);
	// 				bool flag = false;
	// 				for (int j = 0; j < GenVars.numOrePatch; j++)
	// 				{
	// 					if (Math.Abs(num3 - GenVars.orePatchX[j]) < 200)
	// 					{
	// 						flag = true;
	// 					}
	// 				}
	// 				if (!flag && OrePatch(num3, y))
	// 				{
	// 					if (GenVars.numOrePatch < GenVars.maxOrePatch - 1)
	// 					{
	// 						GenVars.orePatchX[GenVars.numOrePatch] = num3;
	// 						GenVars.numOrePatch++;
	// 					}
	// 					break;
	// 				}
	// 			}
	// 		}
	// 		num = genRand.Next(1, Main.maxTilesX * 7 / 4200);
	// 		for (int k = 0; k < num; k++)
	// 		{
	// 			int num4 = Main.maxTilesX / 420;
	// 			while (num4 > 0)
	// 			{
	// 				num4--;
	// 				int num5 = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 				while ((double)num5 >= (double)Main.maxTilesX * 0.47 && (double)num5 <= (double)Main.maxTilesX * 0.53)
	// 				{
	// 					num5 = genRand.Next(beachDistance, Main.maxTilesX - beachDistance);
	// 				}
	// 				int y2 = genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurface);
	// 				bool flag2 = false;
	// 				for (int l = 0; l < GenVars.numOrePatch; l++)
	// 				{
	// 					if (Math.Abs(num5 - GenVars.orePatchX[l]) < 100)
	// 					{
	// 						flag2 = true;
	// 					}
	// 				}
	// 				if (!flag2 && StonePatch(num5, y2))
	// 				{
	// 					break;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0bc0: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0bc5: ldstr "Surface Ore and Stone"
	IL_0bca: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_73'
	IL_0bcf: dup
	IL_0bd0: brtrue.s IL_0be9

	// (no C# code)
	IL_0bd2: pop
	IL_0bd3: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0bd8: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_73'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0bde: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0be3: dup
	IL_0be4: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_73'

	// 	AddGenerationPass("Place Fallen Log", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[85].Value;
	// 		int num = Main.maxTilesX / 2100;
	// 		num = ((!remixWorldGen) ? (num + genRand.Next(-1, 2)) : (num + genRand.Next(0, 2)));
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			progress.Set((double)i / (double)num);
	// 			int num2 = beachDistance + 20;
	// 			int num3 = 50000;
	// 			int num4 = 5000;
	// 			while (num3 > 0)
	// 			{
	// 				num3--;
	// 				int num5 = genRand.Next(num2, Main.maxTilesX - num2);
	// 				int j = genRand.Next(10, (int)Main.worldSurface);
	// 				if (remixWorldGen)
	// 				{
	// 					j = genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY - 350);
	// 				}
	// 				bool flag = false;
	// 				if (num3 < num4)
	// 				{
	// 					flag = true;
	// 				}
	// 				if (num3 > num4 / 2)
	// 				{
	// 					while ((double)num5 > (double)Main.maxTilesX * 0.4 && (double)num5 < (double)Main.maxTilesX * 0.6)
	// 					{
	// 						num5 = genRand.Next(num2, Main.maxTilesX - num2);
	// 					}
	// 				}
	// 				if (!Main.tile[num5, j].active() && Main.tile[num5, j].wall == 0)
	// 				{
	// 					bool flag2 = true;
	// 					if (remixWorldGen)
	// 					{
	// 						for (; !Main.tile[num5, j].active() && Main.tile[num5, j].wall == 0 && j <= Main.maxTilesY - 350; j++)
	// 						{
	// 						}
	// 					}
	// 					else
	// 					{
	// 						for (; !Main.tile[num5, j].active() && Main.tile[num5, j].wall == 0 && (double)j <= Main.worldSurface; j++)
	// 						{
	// 						}
	// 					}
	// 					if ((double)j > Main.worldSurface - 10.0 && !remixWorldGen)
	// 					{
	// 						flag2 = false;
	// 					}
	// 					else if (!flag)
	// 					{
	// 						int num6 = 50;
	// 						for (int k = num5 - num6; k < num5 + num6; k++)
	// 						{
	// 							if (k > 10 && k < Main.maxTilesX - 10)
	// 							{
	// 								for (int l = j - num6; l < j + num6; l++)
	// 								{
	// 									if (l > 10 && l < Main.maxTilesY - 10)
	// 									{
	// 										int type = Main.tile[k, l].type;
	// 										switch (type)
	// 										{
	// 										case 189:
	// 											flag2 = false;
	// 											break;
	// 										case 53:
	// 											flag2 = false;
	// 											break;
	// 										default:
	// 											if (Main.tileDungeon[type])
	// 											{
	// 												flag2 = false;
	// 											}
	// 											else if (TileID.Sets.Crimson[type])
	// 											{
	// 												flag2 = false;
	// 											}
	// 											else if (TileID.Sets.Corrupt[type])
	// 											{
	// 												flag2 = false;
	// 											}
	// 											break;
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 						if (flag2)
	// 						{
	// 							int num7 = 10;
	// 							int num8 = 10;
	// 							for (int m = num5 - num7; m < num5 + num7; m++)
	// 							{
	// 								for (int n = j - num8; n < j - 1; n++)
	// 								{
	// 									if (Main.tile[m, n].active() && Main.tileSolid[Main.tile[m, n].type])
	// 									{
	// 										flag2 = false;
	// 									}
	// 									if (Main.tile[m, n].wall != 0)
	// 									{
	// 										flag2 = false;
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if (flag2 && (Main.tile[num5, j - 1].liquid == 0 || num3 < num4 / 5) && (Main.tile[num5, j].type == 2 || (notTheBees && Main.tile[num5, j].type == 60)) && (Main.tile[num5 - 1, j].type == 2 || (notTheBees && Main.tile[num5 - 1, j].type == 60)) && (Main.tile[num5 + 1, j].type == 2 || (notTheBees && Main.tile[num5 + 1, j].type == 60)))
	// 					{
	// 						j--;
	// 						PlaceTile(num5, j, 488);
	// 						if (Main.tile[num5, j].active() && Main.tile[num5, j].type == 488)
	// 						{
	// 							if (genRand.Next(2) == 0)
	// 							{
	// 								GenVars.logX = num5;
	// 								GenVars.logY = j;
	// 							}
	// 							num3 = -1;
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0be9: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0bee: ldstr "Place Fallen Log"
	IL_0bf3: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_74'
	IL_0bf8: dup
	IL_0bf9: brtrue.s IL_0c12

	// (no C# code)
	IL_0bfb: pop
	IL_0bfc: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0c01: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_74'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0c07: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0c0c: dup
	IL_0c0d: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_74'

	// 	AddGenerationPass("Traps", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (!notTheBees || noTrapsWorldGen || remixWorldGen)
	// 		{
	// 			placingTraps = true;
	// 			progress.Message = Lang.gen[34].Value;
	// 			if (noTrapsWorldGen)
	// 			{
	// 				progress.Message = Lang.gen[91].Value;
	// 			}
	// 			double num = (double)Main.maxTilesX * 0.05;
	// 			if (noTrapsWorldGen)
	// 			{
	// 				num = ((!tenthAnniversaryWorldGen && !notTheBees) ? (num * 100.0) : (num * 5.0));
	// 			}
	// 			else if (getGoodWorldGen)
	// 			{
	// 				num *= 1.5;
	// 			}
	// 			if (Main.starGame)
	// 			{
	// 				num *= Main.starGameMath(0.2);
	// 			}
	// 			for (int i = 0; (double)i < num; i++)
	// 			{
	// 				progress.Set((double)i / num / 2.0);
	// 				for (int j = 0; j < 1150; j++)
	// 				{
	// 					if (noTrapsWorldGen)
	// 					{
	// 						int num2 = genRand.Next(50, Main.maxTilesX - 50);
	// 						int num3 = genRand.Next(50, Main.maxTilesY - 50);
	// 						if (remixWorldGen)
	// 						{
	// 							num3 = genRand.Next(50, Main.maxTilesY - 210);
	// 						}
	// 						if (((double)num3 > Main.worldSurface || Main.tile[num2, num3].wall > 0) && placeTrap(num2, num3))
	// 						{
	// 							break;
	// 						}
	// 					}
	// 					else
	// 					{
	// 						int num4 = genRand.Next(200, Main.maxTilesX - 200);
	// 						int num5 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 210);
	// 						while (oceanDepths(num4, num5))
	// 						{
	// 							num4 = genRand.Next(200, Main.maxTilesX - 200);
	// 							num5 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 210);
	// 						}
	// 						if (Main.tile[num4, num5].wall == 0 && placeTrap(num4, num5))
	// 						{
	// 							break;
	// 						}
	// 					}
	// 				}
	// 			}
	// 			if (noTrapsWorldGen)
	// 			{
	// 				num = Main.maxTilesX * 3;
	// 				if (Main.remixWorld)
	// 				{
	// 					num = Main.maxTilesX / 3;
	// 				}
	// 				if (Main.starGame)
	// 				{
	// 					num *= Main.starGameMath(0.2);
	// 				}
	// 				for (int k = 0; (double)k < num; k++)
	// 				{
	// 					if (Main.remixWorld)
	// 					{
	// 						placeTNTBarrel(genRand.Next(50, Main.maxTilesX - 50), genRand.Next((int)Main.worldSurface, (int)((double)(Main.maxTilesY - 350) + Main.rockLayer) / 2));
	// 					}
	// 					else
	// 					{
	// 						placeTNTBarrel(genRand.Next(50, Main.maxTilesX - 50), genRand.Next((int)Main.rockLayer, Main.maxTilesY - 200));
	// 					}
	// 				}
	// 			}
	// 			num = (double)Main.maxTilesX * 0.003;
	// 			if (noTrapsWorldGen)
	// 			{
	// 				num *= 5.0;
	// 			}
	// 			else if (getGoodWorldGen)
	// 			{
	// 				num *= 1.5;
	// 			}
	// 			for (int l = 0; (double)l < num; l++)
	// 			{
	// 				progress.Set((double)l / num / 2.0 + 0.5);
	// 				for (int m = 0; m < 20000; m++)
	// 				{
	// 					int num6 = genRand.Next((int)((double)Main.maxTilesX * 0.15), (int)((double)Main.maxTilesX * 0.85));
	// 					int num7 = genRand.Next((int)Main.worldSurface + 20, Main.maxTilesY - 210);
	// 					if (Main.tile[num6, num7].wall == 187 && PlaceSandTrap(num6, num7))
	// 					{
	// 						break;
	// 					}
	// 				}
	// 			}
	// 			if (drunkWorldGen && !noTrapsWorldGen && !notTheBees)
	// 			{
	// 				for (int n = 0; n < 8; n++)
	// 				{
	// 					progress.Message = Lang.gen[34].Value;
	// 					num = 100.0;
	// 					for (int num8 = 0; (double)num8 < num; num8++)
	// 					{
	// 						progress.Set((double)num8 / num);
	// 						Thread.Sleep(10);
	// 					}
	// 				}
	// 			}
	// 			if (noTrapsWorldGen)
	// 			{
	// 				Main.tileSolid[138] = true;
	// 			}
	// 			placingTraps = false;
	// 		}
	// 	});
	IL_0c12: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0c17: ldstr "Traps"
	IL_0c1c: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_75'
	IL_0c21: dup
	IL_0c22: brtrue.s IL_0c3b

	// (no C# code)
	IL_0c24: pop
	IL_0c25: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0c2a: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_75'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0c30: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0c35: dup
	IL_0c36: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_75'

	// 	AddGenerationPass("Piles", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[89].Value;
	// 		Main.tileSolid[229] = false;
	// 		Main.tileSolid[190] = false;
	// 		Main.tileSolid[196] = false;
	// 		Main.tileSolid[189] = false;
	// 		Main.tileSolid[202] = false;
	// 		Main.tileSolid[460] = false;
	// 		Main.tileSolid[484] = false;
	// 		if (noTrapsWorldGen)
	// 		{
	// 			Main.tileSolid[138] = false;
	// 		}
	// 		for (int i = 0; (double)i < (double)Main.maxTilesX * 0.06; i++)
	// 		{
	// 			int num = Main.maxTilesX / 2;
	// 			bool flag = false;
	// 			while (!flag && num > 0)
	// 			{
	// 				num--;
	// 				int num2 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int j = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300);
	// 				while (oceanDepths(num2, j))
	// 				{
	// 					num2 = genRand.Next(25, Main.maxTilesX - 25);
	// 					j = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300);
	// 				}
	// 				if (!Main.tile[num2, j].active())
	// 				{
	// 					int num3 = 186;
	// 					for (; !Main.tile[num2, j + 1].active() && j < Main.maxTilesY - 5; j++)
	// 					{
	// 					}
	// 					int num4 = genRand.Next(22);
	// 					if (num4 >= 16 && num4 <= 22)
	// 					{
	// 						num4 = genRand.Next(22);
	// 					}
	// 					if ((Main.tile[num2, j + 1].type == 0 || Main.tile[num2, j + 1].type == 1 || Main.tileMoss[Main.tile[num2, j + 1].type]) && genRand.Next(5) == 0)
	// 					{
	// 						num4 = genRand.Next(23, 29);
	// 						num3 = 187;
	// 					}
	// 					if (j > Main.maxTilesY - 300 || Main.wallDungeon[Main.tile[num2, j].wall] || Main.tile[num2, j + 1].type == 30 || Main.tile[num2, j + 1].type == 19 || Main.tile[num2, j + 1].type == 25 || Main.tile[num2, j + 1].type == 203)
	// 					{
	// 						num4 = genRand.Next(7);
	// 						num3 = 186;
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 147 || Main.tile[num2, j + 1].type == 161 || Main.tile[num2, j + 1].type == 162)
	// 					{
	// 						num4 = genRand.Next(26, 32);
	// 						num3 = 186;
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 60)
	// 					{
	// 						num3 = 187;
	// 						num4 = genRand.Next(6);
	// 					}
	// 					if ((Main.tile[num2, j + 1].type == 57 || Main.tile[num2, j + 1].type == 58) && genRand.Next(3) < 2)
	// 					{
	// 						num3 = 187;
	// 						num4 = genRand.Next(6, 9);
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 226)
	// 					{
	// 						num3 = 187;
	// 						num4 = genRand.Next(18, 23);
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 70)
	// 					{
	// 						num4 = genRand.Next(32, 35);
	// 						num3 = 186;
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 396 || Main.tile[num2, j + 1].type == 397 || Main.tile[num2, j + 1].type == 404)
	// 					{
	// 						num4 = genRand.Next(29, 35);
	// 						num3 = 187;
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 368)
	// 					{
	// 						num4 = genRand.Next(35, 41);
	// 						num3 = 187;
	// 					}
	// 					if (Main.tile[num2, j + 1].type == 367)
	// 					{
	// 						num4 = genRand.Next(41, 47);
	// 						num3 = 187;
	// 					}
	// 					if (num3 == 186 && num4 >= 7 && num4 <= 15 && genRand.Next(75) == 0)
	// 					{
	// 						num3 = 187;
	// 						num4 = 17;
	// 					}
	// 					if (Main.wallDungeon[Main.tile[num2, j].wall] && genRand.Next(3) != 0)
	// 					{
	// 						flag = true;
	// 					}
	// 					else
	// 					{
	// 						if (!Main.tile[num2, j].shimmer())
	// 						{
	// 							PlaceTile(num2, j, num3, mute: true, forced: false, -1, num4);
	// 						}
	// 						if (Main.tile[num2, j].type == 186 || Main.tile[num2, j].type == 187)
	// 						{
	// 							flag = true;
	// 						}
	// 						if (flag && num3 == 186 && num4 <= 7)
	// 						{
	// 							int num5 = genRand.Next(1, 5);
	// 							for (int k = 0; k < num5; k++)
	// 							{
	// 								int num6 = num2 + genRand.Next(-10, 11);
	// 								int l = j - genRand.Next(5);
	// 								if (!Main.tile[num6, l].active())
	// 								{
	// 									for (; !Main.tile[num6, l + 1].active() && l < Main.maxTilesY - 5; l++)
	// 									{
	// 									}
	// 									int x = genRand.Next(12, 36);
	// 									PlaceSmallPile(num6, l, x, 0, 185);
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int m = 0; (double)m < (double)Main.maxTilesX * 0.01; m++)
	// 		{
	// 			int num7 = Main.maxTilesX / 2;
	// 			bool flag2 = false;
	// 			while (!flag2 && num7 > 0)
	// 			{
	// 				num7--;
	// 				int num8 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int n = genRand.Next(Main.maxTilesY - 300, Main.maxTilesY - 10);
	// 				if (!Main.tile[num8, n].active())
	// 				{
	// 					int num9 = 186;
	// 					for (; !Main.tile[num8, n + 1].active() && n < Main.maxTilesY - 5; n++)
	// 					{
	// 					}
	// 					int num10 = genRand.Next(22);
	// 					if (num10 >= 16 && num10 <= 22)
	// 					{
	// 						num10 = genRand.Next(22);
	// 					}
	// 					if (n > Main.maxTilesY - 300 || Main.wallDungeon[Main.tile[num8, n].wall] || Main.tile[num8, n + 1].type == 30 || Main.tile[num8, n + 1].type == 19)
	// 					{
	// 						num10 = genRand.Next(7);
	// 					}
	// 					if ((Main.tile[num8, n + 1].type == 57 || Main.tile[num8, n + 1].type == 58) && genRand.Next(3) < 2)
	// 					{
	// 						num9 = 187;
	// 						num10 = genRand.Next(6, 9);
	// 					}
	// 					if (Main.tile[num8, n + 1].type == 147 || Main.tile[num8, n + 1].type == 161 || Main.tile[num8, n + 1].type == 162)
	// 					{
	// 						num10 = genRand.Next(26, 32);
	// 					}
	// 					PlaceTile(num8, n, num9, mute: true, forced: false, -1, num10);
	// 					if (Main.tile[num8, n].type == 186 || Main.tile[num8, n].type == 187)
	// 					{
	// 						flag2 = true;
	// 					}
	// 					if (flag2 && num9 == 186 && num10 <= 7)
	// 					{
	// 						int num11 = genRand.Next(1, 5);
	// 						for (int num12 = 0; num12 < num11; num12++)
	// 						{
	// 							int num13 = num8 + genRand.Next(-10, 11);
	// 							int num14 = n - genRand.Next(5);
	// 							if (!Main.tile[num13, num14].active())
	// 							{
	// 								for (; !Main.tile[num13, num14 + 1].active() && num14 < Main.maxTilesY - 5; num14++)
	// 								{
	// 								}
	// 								int x2 = genRand.Next(12, 36);
	// 								PlaceSmallPile(num13, num14, x2, 0, 185);
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num15 = 0; (double)num15 < (double)Main.maxTilesX * 0.003; num15++)
	// 		{
	// 			int num16 = Main.maxTilesX / 2;
	// 			bool flag3 = false;
	// 			while (!flag3 && num16 > 0)
	// 			{
	// 				num16--;
	// 				int num17 = 186;
	// 				int num18 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int num19 = genRand.Next(10, (int)Main.worldSurface);
	// 				while (oceanDepths(num18, num19))
	// 				{
	// 					num18 = genRand.Next(25, Main.maxTilesX - 25);
	// 					num19 = genRand.Next(10, (int)Main.worldSurface);
	// 				}
	// 				if (!Main.tile[num18, num19].active())
	// 				{
	// 					for (; !Main.tile[num18, num19 + 1].active() && num19 < Main.maxTilesY - 5; num19++)
	// 					{
	// 					}
	// 					int num20 = genRand.Next(7, 13);
	// 					if (num19 > Main.maxTilesY - 300 || Main.wallDungeon[Main.tile[num18, num19].wall] || Main.tile[num18, num19 + 1].type == 30 || Main.tile[num18, num19 + 1].type == 19 || Main.tile[num18, num19 + 1].type == 25 || Main.tile[num18, num19 + 1].type == 203 || Main.tile[num18, num19 + 1].type == 234 || Main.tile[num18, num19 + 1].type == 112)
	// 					{
	// 						num20 = -1;
	// 					}
	// 					if (Main.tile[num18, num19 + 1].type == 147 || Main.tile[num18, num19 + 1].type == 161 || Main.tile[num18, num19 + 1].type == 162)
	// 					{
	// 						num20 = genRand.Next(26, 32);
	// 					}
	// 					if (Main.tile[num18, num19 + 1].type == 53)
	// 					{
	// 						num17 = 187;
	// 						num20 = genRand.Next(52, 55);
	// 					}
	// 					if (Main.tile[num18, num19 + 1].type == 2 || Main.tile[num18 - 1, num19 + 1].type == 2 || Main.tile[num18 + 1, num19 + 1].type == 2)
	// 					{
	// 						num17 = 187;
	// 						num20 = genRand.Next(14, 17);
	// 					}
	// 					if (Main.tile[num18, num19 + 1].type == 151 || Main.tile[num18, num19 + 1].type == 274)
	// 					{
	// 						num17 = 186;
	// 						num20 = genRand.Next(7);
	// 					}
	// 					if (num20 >= 0)
	// 					{
	// 						PlaceTile(num18, num19, num17, mute: true, forced: false, -1, num20);
	// 					}
	// 					if (Main.tile[num18, num19].type == num17)
	// 					{
	// 						flag3 = true;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num21 = 0; (double)num21 < (double)Main.maxTilesX * 0.0035; num21++)
	// 		{
	// 			int num22 = Main.maxTilesX / 2;
	// 			bool flag4 = false;
	// 			while (!flag4 && num22 > 0)
	// 			{
	// 				num22--;
	// 				int num23 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int num24 = genRand.Next(10, (int)Main.worldSurface);
	// 				if (!Main.tile[num23, num24].active() && Main.tile[num23, num24].wall > 0)
	// 				{
	// 					int num25 = 186;
	// 					for (; !Main.tile[num23, num24 + 1].active() && num24 < Main.maxTilesY - 5; num24++)
	// 					{
	// 					}
	// 					int num26 = genRand.Next(7, 13);
	// 					if (num24 > Main.maxTilesY - 300 || Main.wallDungeon[Main.tile[num23, num24].wall] || Main.tile[num23, num24 + 1].type == 30 || Main.tile[num23, num24 + 1].type == 19)
	// 					{
	// 						num26 = -1;
	// 					}
	// 					if (Main.tile[num23, num24 + 1].type == 25)
	// 					{
	// 						num26 = genRand.Next(7);
	// 					}
	// 					if (Main.tile[num23, num24 + 1].type == 147 || Main.tile[num23, num24 + 1].type == 161 || Main.tile[num23, num24 + 1].type == 162)
	// 					{
	// 						num26 = genRand.Next(26, 32);
	// 					}
	// 					if (Main.tile[num23, num24 + 1].type == 2 || Main.tile[num23 - 1, num24 + 1].type == 2 || Main.tile[num23 + 1, num24 + 1].type == 2)
	// 					{
	// 						num25 = 187;
	// 						num26 = genRand.Next(14, 17);
	// 					}
	// 					if (Main.tile[num23, num24 + 1].type == 151 || Main.tile[num23, num24 + 1].type == 274)
	// 					{
	// 						num25 = 186;
	// 						num26 = genRand.Next(7);
	// 					}
	// 					if (num26 >= 0)
	// 					{
	// 						PlaceTile(num23, num24, num25, mute: true, forced: false, -1, num26);
	// 					}
	// 					if (Main.tile[num23, num24].type == num25)
	// 					{
	// 						flag4 = true;
	// 					}
	// 					if (flag4 && num26 <= 7)
	// 					{
	// 						int num27 = genRand.Next(1, 5);
	// 						for (int num28 = 0; num28 < num27; num28++)
	// 						{
	// 							int num29 = num23 + genRand.Next(-10, 11);
	// 							int num30 = num24 - genRand.Next(5);
	// 							if (!Main.tile[num29, num30].active())
	// 							{
	// 								for (; !Main.tile[num29, num30 + 1].active() && num30 < Main.maxTilesY - 5; num30++)
	// 								{
	// 								}
	// 								int x3 = genRand.Next(12, 36);
	// 								PlaceSmallPile(num29, num30, x3, 0, 185);
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num31 = 0; (double)num31 < (double)Main.maxTilesX * 0.6; num31++)
	// 		{
	// 			int num32 = Main.maxTilesX / 2;
	// 			bool flag5 = false;
	// 			while (!flag5 && num32 > 0)
	// 			{
	// 				num32--;
	// 				int num33 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int num34 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 20);
	// 				if (Main.tile[num33, num34].wall == 87 && genRand.Next(2) == 0)
	// 				{
	// 					num33 = genRand.Next(25, Main.maxTilesX - 25);
	// 					num34 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 20);
	// 				}
	// 				while (oceanDepths(num33, num34))
	// 				{
	// 					num33 = genRand.Next(25, Main.maxTilesX - 25);
	// 					num34 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 20);
	// 				}
	// 				if (!Main.tile[num33, num34].active())
	// 				{
	// 					for (; !Main.tile[num33, num34 + 1].active() && num34 < Main.maxTilesY - 5; num34++)
	// 					{
	// 					}
	// 					int num35 = genRand.Next(2);
	// 					int num36 = genRand.Next(36);
	// 					if (num36 >= 28 && num36 <= 35)
	// 					{
	// 						num36 = genRand.Next(36);
	// 					}
	// 					if (num35 == 1)
	// 					{
	// 						num36 = genRand.Next(25);
	// 						if (num36 >= 16 && num36 <= 24)
	// 						{
	// 							num36 = genRand.Next(25);
	// 						}
	// 					}
	// 					if (num34 > Main.maxTilesY - 300)
	// 					{
	// 						if (num35 == 0)
	// 						{
	// 							num36 = genRand.Next(12, 28);
	// 						}
	// 						if (num35 == 1)
	// 						{
	// 							num36 = genRand.Next(6, 16);
	// 						}
	// 					}
	// 					if (Main.wallDungeon[Main.tile[num33, num34].wall] || Main.tile[num33, num34 + 1].type == 30 || Main.tile[num33, num34 + 1].type == 19 || Main.tile[num33, num34 + 1].type == 25 || Main.tile[num33, num34 + 1].type == 203 || Main.tile[num33, num34].wall == 87)
	// 					{
	// 						if (num35 == 0 && num36 < 12)
	// 						{
	// 							num36 += 12;
	// 						}
	// 						if (num35 == 1 && num36 < 6)
	// 						{
	// 							num36 += 6;
	// 						}
	// 						if (num35 == 1 && num36 >= 17)
	// 						{
	// 							num36 -= 10;
	// 						}
	// 					}
	// 					if (Main.tile[num33, num34 + 1].type == 147 || Main.tile[num33, num34 + 1].type == 161 || Main.tile[num33, num34 + 1].type == 162)
	// 					{
	// 						if (num35 == 0 && num36 < 12)
	// 						{
	// 							num36 += 36;
	// 						}
	// 						if (num35 == 1 && num36 >= 20)
	// 						{
	// 							num36 += 6;
	// 						}
	// 						if (num35 == 1 && num36 < 6)
	// 						{
	// 							num36 += 25;
	// 						}
	// 					}
	// 					if (Main.tile[num33, num34 + 1].type == 151 || Main.tile[num33, num34 + 1].type == 274)
	// 					{
	// 						if (num35 == 0)
	// 						{
	// 							num36 = genRand.Next(12, 28);
	// 						}
	// 						if (num35 == 1)
	// 						{
	// 							num36 = genRand.Next(12, 19);
	// 						}
	// 					}
	// 					if (Main.tile[num33, num34 + 1].type == 368)
	// 					{
	// 						if (num35 == 0)
	// 						{
	// 							num36 = genRand.Next(60, 66);
	// 						}
	// 						if (num35 == 1)
	// 						{
	// 							num36 = genRand.Next(47, 53);
	// 						}
	// 					}
	// 					if (Main.tile[num33, num34 + 1].type == 367)
	// 					{
	// 						if (num35 == 0)
	// 						{
	// 							num36 = genRand.Next(66, 72);
	// 						}
	// 						if (num35 == 1)
	// 						{
	// 							num36 = genRand.Next(53, 59);
	// 						}
	// 					}
	// 					if (Main.wallDungeon[Main.tile[num33, num34].wall] && genRand.Next(3) != 0)
	// 					{
	// 						flag5 = true;
	// 					}
	// 					else if (!Main.tile[num33, num34].shimmer())
	// 					{
	// 						flag5 = PlaceSmallPile(num33, num34, num36, num35, 185);
	// 					}
	// 					if (flag5 && num35 == 1 && num36 >= 6 && num36 <= 15)
	// 					{
	// 						int num37 = genRand.Next(1, 5);
	// 						for (int num38 = 0; num38 < num37; num38++)
	// 						{
	// 							int num39 = num33 + genRand.Next(-10, 11);
	// 							int num40 = num34 - genRand.Next(5);
	// 							if (!Main.tile[num39, num40].active())
	// 							{
	// 								for (; !Main.tile[num39, num40 + 1].active() && num40 < Main.maxTilesY - 5; num40++)
	// 								{
	// 								}
	// 								int x4 = genRand.Next(12, 36);
	// 								PlaceSmallPile(num39, num40, x4, 0, 185);
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num41 = 0; (double)num41 < (double)Main.maxTilesX * 0.02; num41++)
	// 		{
	// 			int num42 = Main.maxTilesX / 2;
	// 			bool flag6 = false;
	// 			while (!flag6 && num42 > 0)
	// 			{
	// 				num42--;
	// 				int num43 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int num44 = genRand.Next(15, (int)Main.worldSurface);
	// 				while (oceanDepths(num43, num44))
	// 				{
	// 					num43 = genRand.Next(25, Main.maxTilesX - 25);
	// 					num44 = genRand.Next(15, (int)Main.worldSurface);
	// 				}
	// 				if (!Main.tile[num43, num44].active())
	// 				{
	// 					for (; !Main.tile[num43, num44 + 1].active() && num44 < Main.maxTilesY - 5; num44++)
	// 					{
	// 					}
	// 					int num45 = genRand.Next(2);
	// 					int num46 = genRand.Next(11);
	// 					if (num45 == 1)
	// 					{
	// 						num46 = genRand.Next(5);
	// 					}
	// 					if (Main.tile[num43, num44 + 1].type == 147 || Main.tile[num43, num44 + 1].type == 161 || Main.tile[num43, num44 + 1].type == 162)
	// 					{
	// 						if (num45 == 0 && num46 < 12)
	// 						{
	// 							num46 += 36;
	// 						}
	// 						if (num45 == 1 && num46 >= 20)
	// 						{
	// 							num46 += 6;
	// 						}
	// 						if (num45 == 1 && num46 < 6)
	// 						{
	// 							num46 += 25;
	// 						}
	// 					}
	// 					if (Main.tile[num43, num44 + 1].type == 2 && num45 == 1)
	// 					{
	// 						num46 = genRand.Next(38, 41);
	// 					}
	// 					if (Main.tile[num43, num44 + 1].type == 151 || Main.tile[num43, num44 + 1].type == 274)
	// 					{
	// 						if (num45 == 0)
	// 						{
	// 							num46 = genRand.Next(12, 28);
	// 						}
	// 						if (num45 == 1)
	// 						{
	// 							num46 = genRand.Next(12, 19);
	// 						}
	// 					}
	// 					if (!Main.wallDungeon[Main.tile[num43, num44].wall] && Main.tile[num43, num44 + 1].type != 30 && Main.tile[num43, num44 + 1].type != 19 && Main.tile[num43, num44 + 1].type != 41 && Main.tile[num43, num44 + 1].type != 43 && Main.tile[num43, num44 + 1].type != 44 && Main.tile[num43, num44 + 1].type != 481 && Main.tile[num43, num44 + 1].type != 482 && Main.tile[num43, num44 + 1].type != 483 && Main.tile[num43, num44 + 1].type != 45 && Main.tile[num43, num44 + 1].type != 46 && Main.tile[num43, num44 + 1].type != 47 && Main.tile[num43, num44 + 1].type != 175 && Main.tile[num43, num44 + 1].type != 176 && Main.tile[num43, num44 + 1].type != 177 && Main.tile[num43, num44 + 1].type != 53 && Main.tile[num43, num44 + 1].type != 25 && Main.tile[num43, num44 + 1].type != 203)
	// 					{
	// 						flag6 = PlaceSmallPile(num43, num44, num46, num45, 185);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num47 = 0; (double)num47 < (double)Main.maxTilesX * 0.15; num47++)
	// 		{
	// 			int num48 = Main.maxTilesX / 2;
	// 			bool flag7 = false;
	// 			while (!flag7 && num48 > 0)
	// 			{
	// 				num48--;
	// 				int num49 = genRand.Next(25, Main.maxTilesX - 25);
	// 				int num50 = genRand.Next(15, (int)Main.worldSurface);
	// 				if (!Main.tile[num49, num50].active() && (Main.tile[num49, num50].wall == 2 || Main.tile[num49, num50].wall == 40))
	// 				{
	// 					for (; !Main.tile[num49, num50 + 1].active() && num50 < Main.maxTilesY - 5; num50++)
	// 					{
	// 					}
	// 					int num51 = genRand.Next(2);
	// 					int num52 = genRand.Next(11);
	// 					if (num51 == 1)
	// 					{
	// 						num52 = genRand.Next(5);
	// 					}
	// 					if (Main.tile[num49, num50 + 1].type == 147 || Main.tile[num49, num50 + 1].type == 161 || Main.tile[num49, num50 + 1].type == 162)
	// 					{
	// 						if (num51 == 0 && num52 < 12)
	// 						{
	// 							num52 += 36;
	// 						}
	// 						if (num51 == 1 && num52 >= 20)
	// 						{
	// 							num52 += 6;
	// 						}
	// 						if (num51 == 1 && num52 < 6)
	// 						{
	// 							num52 += 25;
	// 						}
	// 					}
	// 					if (Main.tile[num49, num50 + 1].type == 2 && num51 == 1)
	// 					{
	// 						num52 = genRand.Next(38, 41);
	// 					}
	// 					if (Main.tile[num49, num50 + 1].type == 151 || Main.tile[num49, num50 + 1].type == 274)
	// 					{
	// 						if (num51 == 0)
	// 						{
	// 							num52 = genRand.Next(12, 28);
	// 						}
	// 						if (num51 == 1)
	// 						{
	// 							num52 = genRand.Next(12, 19);
	// 						}
	// 					}
	// 					if ((Main.tile[num49, num50].liquid != byte.MaxValue || Main.tile[num49, num50 + 1].type != 53 || Main.tile[num49, num50].wall != 0) && !Main.wallDungeon[Main.tile[num49, num50].wall] && Main.tile[num49, num50 + 1].type != 30 && Main.tile[num49, num50 + 1].type != 19 && Main.tile[num49, num50 + 1].type != 41 && Main.tile[num49, num50 + 1].type != 43 && Main.tile[num49, num50 + 1].type != 44 && Main.tile[num49, num50 + 1].type != 481 && Main.tile[num49, num50 + 1].type != 482 && Main.tile[num49, num50 + 1].type != 483 && Main.tile[num49, num50 + 1].type != 45 && Main.tile[num49, num50 + 1].type != 46 && Main.tile[num49, num50 + 1].type != 47 && Main.tile[num49, num50 + 1].type != 175 && Main.tile[num49, num50 + 1].type != 176 && Main.tile[num49, num50 + 1].type != 177 && Main.tile[num49, num50 + 1].type != 25 && Main.tile[num49, num50 + 1].type != 203)
	// 					{
	// 						flag7 = PlaceSmallPile(num49, num50, num52, num51, 185);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		Main.tileSolid[190] = true;
	// 		Main.tileSolid[192] = true;
	// 		Main.tileSolid[196] = true;
	// 		Main.tileSolid[189] = true;
	// 		Main.tileSolid[202] = true;
	// 		Main.tileSolid[225] = true;
	// 		Main.tileSolid[460] = true;
	// 		Main.tileSolid[138] = true;
	// 	});
	IL_0c3b: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0c40: ldstr "Piles"
	IL_0c45: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_76'
	IL_0c4a: dup
	IL_0c4b: brtrue.s IL_0c64

	// (no C# code)
	IL_0c4d: pop
	IL_0c4e: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0c53: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_76'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0c59: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0c5e: dup
	IL_0c5f: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_76'

	// 	AddGenerationPass("Spawn Point", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		int num = 5;
	// 		bool flag = true;
	// 		int num2 = Main.maxTilesX / 2;
	// 		if (Main.tenthAnniversaryWorld && !remixWorldGen)
	// 		{
	// 			int num3 = GenVars.beachBordersWidth + 15;
	// 			num2 = ((genRand.Next(2) != 0) ? (Main.maxTilesX - num3) : num3);
	// 		}
	// 		while (flag)
	// 		{
	// 			int num4 = num2 + genRand.Next(-num, num + 1);
	// 			for (int i = 0; i < Main.maxTilesY; i++)
	// 			{
	// 				if (Main.tile[num4, i].active())
	// 				{
	// 					Main.spawnTileX = num4;
	// 					Main.spawnTileY = i;
	// 					break;
	// 				}
	// 			}
	// 			flag = false;
	// 			num++;
	// 			if ((double)Main.spawnTileY > Main.worldSurface)
	// 			{
	// 				flag = true;
	// 			}
	// 			if (Main.tile[Main.spawnTileX, Main.spawnTileY - 1].liquid > 0)
	// 			{
	// 				flag = true;
	// 			}
	// 		}
	// 		int num5 = 10;
	// 		while ((double)Main.spawnTileY > Main.worldSurface)
	// 		{
	// 			int num6 = genRand.Next(num2 - num5, num2 + num5);
	// 			for (int j = 0; j < Main.maxTilesY; j++)
	// 			{
	// 				if (Main.tile[num6, j].active())
	// 				{
	// 					Main.spawnTileX = num6;
	// 					Main.spawnTileY = j;
	// 					break;
	// 				}
	// 			}
	// 			num5++;
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			int num7 = Main.maxTilesY - 10;
	// 			while (SolidTile(Main.spawnTileX, num7))
	// 			{
	// 				num7--;
	// 			}
	// 			Main.spawnTileY = num7 + 1;
	// 		}
	// 	});
	IL_0c64: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0c69: ldstr "Spawn Point"
	IL_0c6e: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_77'
	IL_0c73: dup
	IL_0c74: brtrue.s IL_0c8d

	// (no C# code)
	IL_0c76: pop
	IL_0c77: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0c7c: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_77'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0c82: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0c87: dup
	IL_0c88: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_77'

	// 	AddGenerationPass("Grass Wall", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		maxTileCount = 3500;
	// 		progress.Set(1.0);
	// 		for (int i = 50; i < Main.maxTilesX - 50; i++)
	// 		{
	// 			for (int j = 0; (double)j < Main.worldSurface - 10.0; j++)
	// 			{
	// 				if (genRand.Next(4) == 0)
	// 				{
	// 					bool flag = false;
	// 					int num = -1;
	// 					int num2 = -1;
	// 					if (Main.tile[i, j].active() && Main.tile[i, j].type == 2 && (Main.tile[i, j].wall == 2 || Main.tile[i, j].wall == 63))
	// 					{
	// 						for (int k = i - 1; k <= i + 1; k++)
	// 						{
	// 							for (int l = j - 1; l <= j + 1; l++)
	// 							{
	// 								if (Main.tile[k, l].wall == 0 && !SolidTile(k, l))
	// 								{
	// 									flag = true;
	// 								}
	// 							}
	// 						}
	// 						if (flag)
	// 						{
	// 							for (int m = i - 1; m <= i + 1; m++)
	// 							{
	// 								for (int n = j - 1; n <= j + 1; n++)
	// 								{
	// 									if ((Main.tile[m, n].wall == 2 || Main.tile[m, n].wall == 15) && !SolidTile(m, n))
	// 									{
	// 										num = m;
	// 										num2 = n;
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if (flag && num > -1 && num2 > -1 && countDirtTiles(num, num2) < maxTileCount)
	// 					{
	// 						try
	// 						{
	// 							ushort wallType = 63;
	// 							if (dontStarveWorldGen && genRand.Next(3) != 0)
	// 							{
	// 								wallType = 62;
	// 							}
	// 							Spread.Wall2(num, num2, wallType);
	// 						}
	// 						catch
	// 						{
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int num3 = 5; num3 < Main.maxTilesX - 5; num3++)
	// 		{
	// 			for (int num4 = 10; (double)num4 < Main.worldSurface - 1.0; num4++)
	// 			{
	// 				if (Main.tile[num3, num4].wall == 63 && genRand.Next(10) == 0)
	// 				{
	// 					Main.tile[num3, num4].wall = 65;
	// 				}
	// 				if (Main.tile[num3, num4].active() && Main.tile[num3, num4].type == 0)
	// 				{
	// 					bool flag2 = false;
	// 					for (int num5 = num3 - 1; num5 <= num3 + 1; num5++)
	// 					{
	// 						for (int num6 = num4 - 1; num6 <= num4 + 1; num6++)
	// 						{
	// 							if (Main.tile[num5, num6].wall == 63 || Main.tile[num5, num6].wall == 65)
	// 							{
	// 								flag2 = true;
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					if (flag2)
	// 					{
	// 						SpreadGrass(num3, num4);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0c8d: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0c92: ldstr "Grass Wall"
	IL_0c97: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_78'
	IL_0c9c: dup
	IL_0c9d: brtrue.s IL_0cb6

	// (no C# code)
	IL_0c9f: pop
	IL_0ca0: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0ca5: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_78'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0cab: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0cb0: dup
	IL_0cb1: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_78'

	// 	AddGenerationPass("Guide", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Set(1.0);
	// 		if (Main.tenthAnniversaryWorld)
	// 		{
	// 			BirthdayParty.GenuineParty = true;
	// 			BirthdayParty.PartyDaysOnCooldown = 5;
	// 			if (getGoodWorldGen)
	// 			{
	// 				Main.afterPartyOfDoom = true;
	// 			}
	// 			int num;
	// 			if (remixWorldGen)
	// 			{
	// 				num = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 441);
	// 				NPC.savedTaxCollector = true;
	// 			}
	// 			else
	// 			{
	// 				num = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 22);
	// 			}
	// 			Main.npc[num].homeTileX = Main.spawnTileX;
	// 			Main.npc[num].homeTileY = Main.spawnTileY;
	// 			Main.npc[num].direction = 1;
	// 			Main.npc[num].homeless = true;
	// 			Main.npc[num].GivenName = Language.GetTextValue("GuideNames.Andrew");
	// 			BirthdayParty.CelebratingNPCs.Add(num);
	// 			Point adjustedFloorPosition = GetAdjustedFloorPosition(Main.spawnTileX + 2, Main.spawnTileY);
	// 			num = NPC.NewNPC(new EntitySource_WorldGen(), adjustedFloorPosition.X * 16, adjustedFloorPosition.Y * 16, 178);
	// 			Main.npc[num].homeTileX = adjustedFloorPosition.X;
	// 			Main.npc[num].homeTileY = adjustedFloorPosition.Y;
	// 			Main.npc[num].direction = -1;
	// 			Main.npc[num].homeless = true;
	// 			Main.npc[num].GivenName = Language.GetTextValue("SteampunkerNames.Whitney");
	// 			BirthdayParty.CelebratingNPCs.Add(num);
	// 			adjustedFloorPosition = GetAdjustedFloorPosition(Main.spawnTileX - 2, Main.spawnTileY);
	// 			num = NPC.NewNPC(new EntitySource_WorldGen(), adjustedFloorPosition.X * 16, adjustedFloorPosition.Y * 16, 663);
	// 			Main.npc[num].homeTileX = adjustedFloorPosition.X;
	// 			Main.npc[num].homeTileY = adjustedFloorPosition.Y;
	// 			Main.npc[num].direction = 1;
	// 			Main.npc[num].homeless = true;
	// 			Main.npc[num].GivenName = Language.GetTextValue("PrincessNames.Yorai");
	// 			BirthdayParty.CelebratingNPCs.Add(num);
	// 			NPC.unlockedPrincessSpawn = true;
	// 			adjustedFloorPosition = GetAdjustedFloorPosition(Main.spawnTileX + 4, Main.spawnTileY);
	// 			num = NPC.NewNPC(new EntitySource_WorldGen(), adjustedFloorPosition.X * 16, adjustedFloorPosition.Y * 16, 208);
	// 			Main.npc[num].homeTileX = adjustedFloorPosition.X;
	// 			Main.npc[num].homeTileY = adjustedFloorPosition.Y;
	// 			Main.npc[num].direction = -1;
	// 			Main.npc[num].homeless = true;
	// 			Main.npc[num].GivenName = Language.GetTextValue("PartyGirlNames.Amanda");
	// 			BirthdayParty.CelebratingNPCs.Add(num);
	// 			NPC.unlockedPartyGirlSpawn = true;
	// 			adjustedFloorPosition = GetAdjustedFloorPosition(Main.spawnTileX - 4, Main.spawnTileY);
	// 			if (Main.remixWorld)
	// 			{
	// 				num = NPC.NewNPC(new EntitySource_WorldGen(), adjustedFloorPosition.X * 16, adjustedFloorPosition.Y * 16, 681);
	// 				Main.npc[num].GivenName = Language.GetTextValue("SlimeNames_Rainbow.Slimestar");
	// 				NPC.unlockedSlimeRainbowSpawn = true;
	// 			}
	// 			else
	// 			{
	// 				num = NPC.NewNPC(new EntitySource_WorldGen(), adjustedFloorPosition.X * 16, adjustedFloorPosition.Y * 16, 656);
	// 				NPC.boughtBunny = true;
	// 				Main.npc[num].townNpcVariationIndex = 1;
	// 			}
	// 			Main.npc[num].homeTileX = adjustedFloorPosition.X;
	// 			Main.npc[num].homeTileY = adjustedFloorPosition.Y;
	// 			Main.npc[num].direction = 1;
	// 			Main.npc[num].homeless = true;
	// 		}
	// 		else if (remixWorldGen)
	// 		{
	// 			int num2 = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 441);
	// 			Main.npc[num2].homeTileX = Main.spawnTileX;
	// 			Main.npc[num2].homeTileY = Main.spawnTileY;
	// 			Main.npc[num2].direction = 1;
	// 			Main.npc[num2].homeless = true;
	// 			NPC.savedTaxCollector = true;
	// 		}
	// 		else if (notTheBees)
	// 		{
	// 			int num3 = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 17);
	// 			Main.npc[num3].homeTileX = Main.spawnTileX;
	// 			Main.npc[num3].homeTileY = Main.spawnTileY;
	// 			Main.npc[num3].direction = 1;
	// 			Main.npc[num3].homeless = true;
	// 			NPC.unlockedMerchantSpawn = true;
	// 		}
	// 		else if (drunkWorldGen)
	// 		{
	// 			int num4 = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 208);
	// 			Main.npc[num4].homeTileX = Main.spawnTileX;
	// 			Main.npc[num4].homeTileY = Main.spawnTileY;
	// 			Main.npc[num4].direction = 1;
	// 			Main.npc[num4].homeless = true;
	// 			NPC.unlockedPartyGirlSpawn = true;
	// 		}
	// 		else if (getGoodWorldGen)
	// 		{
	// 			int num5 = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 38);
	// 			Main.npc[num5].homeTileX = Main.spawnTileX;
	// 			Main.npc[num5].homeTileY = Main.spawnTileY;
	// 			Main.npc[num5].direction = 1;
	// 			Main.npc[num5].homeless = true;
	// 			NPC.unlockedDemolitionistSpawn = true;
	// 		}
	// 		else
	// 		{
	// 			int num6 = NPC.NewNPC(new EntitySource_WorldGen(), Main.spawnTileX * 16, Main.spawnTileY * 16, 22);
	// 			Main.npc[num6].homeTileX = Main.spawnTileX;
	// 			Main.npc[num6].homeTileY = Main.spawnTileY;
	// 			Main.npc[num6].direction = 1;
	// 			Main.npc[num6].homeless = true;
	// 		}
	// 	});
	IL_0cb6: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0cbb: ldstr "Guide"
	IL_0cc0: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_79'
	IL_0cc5: dup
	IL_0cc6: brtrue.s IL_0cdf

	// (no C# code)
	IL_0cc8: pop
	IL_0cc9: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0cce: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_79'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0cd4: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0cd9: dup
	IL_0cda: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_79'

	// 	AddGenerationPass("Sunflowers", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[39].Value;
	// 		double num = (double)Main.maxTilesX * 0.002;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			progress.Set((double)i / num);
	// 			int num2 = 0;
	// 			int num3 = 0;
	// 			_ = Main.maxTilesX / 2;
	// 			int num4 = genRand.Next(Main.maxTilesX);
	// 			num2 = num4 - genRand.Next(10) - 7;
	// 			num3 = num4 + genRand.Next(10) + 7;
	// 			if (num2 < 0)
	// 			{
	// 				num2 = 0;
	// 			}
	// 			if (num3 > Main.maxTilesX - 1)
	// 			{
	// 				num3 = Main.maxTilesX - 1;
	// 			}
	// 			int num5 = 1;
	// 			int num6 = (int)Main.worldSurface - 1;
	// 			for (int j = num2; j < num3; j++)
	// 			{
	// 				for (int k = num5; k < num6; k++)
	// 				{
	// 					if (Main.tile[j, k].type == 2 && Main.tile[j, k].active() && !Main.tile[j, k - 1].active())
	// 					{
	// 						PlaceTile(j, k - 1, 27, mute: true);
	// 					}
	// 					if (Main.tile[j, k].active())
	// 					{
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0cdf: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0ce4: ldstr "Sunflowers"
	IL_0ce9: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_80'
	IL_0cee: dup
	IL_0cef: brtrue.s IL_0d08

	// (no C# code)
	IL_0cf1: pop
	IL_0cf2: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0cf7: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_80'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0cfd: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0d02: dup
	IL_0d03: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_80'

	// 	AddGenerationPass("Planting Trees", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[40].Value;
	// 		if (!drunkWorldGen && !Main.tenthAnniversaryWorld)
	// 		{
	// 			for (int i = 0; (double)i < (double)Main.maxTilesX * 0.003; i++)
	// 			{
	// 				progress.Set((double)i / ((double)Main.maxTilesX * 0.003));
	// 				int num = genRand.Next(50, Main.maxTilesX - 50);
	// 				int num2 = genRand.Next(25, 50);
	// 				for (int j = num - num2; j < num + num2; j++)
	// 				{
	// 					for (int k = 20; (double)k < Main.worldSurface; k++)
	// 					{
	// 						GrowEpicTree(j, k);
	// 					}
	// 				}
	// 			}
	// 		}
	// 		AddTrees();
	// 	});
	IL_0d08: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0d0d: ldstr "Planting Trees"
	IL_0d12: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_81'
	IL_0d17: dup
	IL_0d18: brtrue.s IL_0d31

	// (no C# code)
	IL_0d1a: pop
	IL_0d1b: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0d20: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_81'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0d26: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0d2b: dup
	IL_0d2c: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_81'

	// 	AddGenerationPass("Herbs", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		double num = (double)Main.maxTilesX * 1.7;
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 5.0;
	// 		}
	// 		progress.Message = Lang.gen[41].Value;
	// 		for (int i = 0; (double)i < num; i++)
	// 		{
	// 			progress.Set((double)i / num);
	// 			PlantAlch();
	// 		}
	// 	});
	IL_0d31: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0d36: ldstr "Herbs"
	IL_0d3b: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_82'
	IL_0d40: dup
	IL_0d41: brtrue.s IL_0d5a

	// (no C# code)
	IL_0d43: pop
	IL_0d44: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0d49: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_82'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0d4f: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0d54: dup
	IL_0d55: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_82'

	// 	AddGenerationPass("Dye Plants", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			plantDye(genRand.Next(100, Main.maxTilesX - 100), genRand.Next(100, Main.UnderworldLayer));
	// 		}
	// 		MatureTheHerbPlants();
	// 		GrowGlowTulips();
	// 	});
	IL_0d5a: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0d5f: ldstr "Dye Plants"
	IL_0d64: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_83'
	IL_0d69: dup
	IL_0d6a: brtrue.s IL_0d83

	// (no C# code)
	IL_0d6c: pop
	IL_0d6d: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0d72: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_83'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0d78: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0d7d: dup
	IL_0d7e: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_83'

	// 	AddGenerationPass("Webs And Honey", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 100; i < Main.maxTilesX - 100; i++)
	// 		{
	// 			int num = (int)Main.worldSurface;
	// 			if (dontStarveWorldGen)
	// 			{
	// 				num = 50;
	// 			}
	// 			for (int j = num; j < Main.maxTilesY - 100; j++)
	// 			{
	// 				if (Main.tile[i, j].wall == 86)
	// 				{
	// 					if (Main.tile[i, j].liquid > 0)
	// 					{
	// 						Main.tile[i, j].honey(honey: true);
	// 					}
	// 					if (genRand.Next(3) == 0)
	// 					{
	// 						PlaceTight(i, j);
	// 					}
	// 				}
	// 				if (Main.tile[i, j].wall == 62)
	// 				{
	// 					Main.tile[i, j].liquid = 0;
	// 					Main.tile[i, j].lava(lava: false);
	// 				}
	// 				if (Main.tile[i, j].wall == 62 && !Main.tile[i, j].active() && genRand.Next(10) != 0)
	// 				{
	// 					int num2 = genRand.Next(2, 5);
	// 					int num3 = i - num2;
	// 					int num4 = i + num2;
	// 					int num5 = j - num2;
	// 					int num6 = j + num2;
	// 					bool flag = false;
	// 					for (int k = num3; k <= num4; k++)
	// 					{
	// 						for (int l = num5; l <= num6; l++)
	// 						{
	// 							if (SolidTile(k, l))
	// 							{
	// 								flag = true;
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					if (flag)
	// 					{
	// 						PlaceTile(i, j, 51, mute: true);
	// 						TileFrame(i, j);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0d83: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0d88: ldstr "Webs And Honey"
	IL_0d8d: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_84'
	IL_0d92: dup
	IL_0d93: brtrue.s IL_0dac

	// (no C# code)
	IL_0d95: pop
	IL_0d96: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0d9b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_84'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0da1: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0da6: dup
	IL_0da7: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_84'

	// 	AddGenerationPass("Weeds", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[42].Value;
	// 		if (Main.halloween)
	// 		{
	// 			for (int i = 40; i < Main.maxTilesX - 40; i++)
	// 			{
	// 				for (int j = 50; (double)j < Main.worldSurface; j++)
	// 				{
	// 					if (Main.tile[i, j].active() && Main.tile[i, j].type == 2 && genRand.Next(15) == 0)
	// 					{
	// 						PlacePumpkin(i, j - 1);
	// 						int num = genRand.Next(5);
	// 						for (int k = 0; k < num; k++)
	// 						{
	// 							GrowPumpkin(i, j - 1, 254);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 		for (int l = 0; l < Main.maxTilesX; l++)
	// 		{
	// 			progress.Set((double)l / (double)Main.maxTilesX);
	// 			for (int m = 1; m < Main.maxTilesY; m++)
	// 			{
	// 				if (Main.tile[l, m].type == 2 && Main.tile[l, m].nactive())
	// 				{
	// 					if (!Main.tile[l, m - 1].active())
	// 					{
	// 						PlaceTile(l, m - 1, 3, mute: true);
	// 						Main.tile[l, m - 1].CopyPaintAndCoating(Main.tile[l, m]);
	// 					}
	// 				}
	// 				else if (Main.tile[l, m].type == 23 && Main.tile[l, m].nactive())
	// 				{
	// 					if (!Main.tile[l, m - 1].active())
	// 					{
	// 						PlaceTile(l, m - 1, 24, mute: true);
	// 					}
	// 				}
	// 				else if (Main.tile[l, m].type == 199 && Main.tile[l, m].nactive())
	// 				{
	// 					if (!Main.tile[l, m - 1].active())
	// 					{
	// 						PlaceTile(l, m - 1, 201, mute: true);
	// 					}
	// 				}
	// 				else if (Main.tile[l, m].type == 633 && Main.tile[l, m].nactive() && !Main.tile[l, m - 1].active())
	// 				{
	// 					PlaceTile(l, m - 1, 637, mute: true);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0dac: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0db1: ldstr "Weeds"
	IL_0db6: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_85'
	IL_0dbb: dup
	IL_0dbc: brtrue.s IL_0dd5

	// (no C# code)
	IL_0dbe: pop
	IL_0dbf: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0dc4: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_85'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0dca: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0dcf: dup
	IL_0dd0: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_85'

	// 	AddGenerationPass("Glowing Mushrooms and Jungle Plants", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			for (int j = 0; j < Main.maxTilesY; j++)
	// 			{
	// 				if (Main.tile[i, j].active())
	// 				{
	// 					if (j >= (int)Main.worldSurface && Main.tile[i, j].type == 70 && !Main.tile[i, j - 1].active())
	// 					{
	// 						GrowTree(i, j);
	// 						if (!Main.tile[i, j - 1].active())
	// 						{
	// 							GrowTree(i, j);
	// 							if (!Main.tile[i, j - 1].active())
	// 							{
	// 								GrowTree(i, j);
	// 								if (!Main.tile[i, j - 1].active())
	// 								{
	// 									PlaceTile(i, j - 1, 71, mute: true);
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if (Main.tile[i, j].type == 60 && !Main.tile[i, j - 1].active())
	// 					{
	// 						PlaceTile(i, j - 1, 61, mute: true);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0dd5: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0dda: ldstr "Glowing Mushrooms and Jungle Plants"
	IL_0ddf: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_86'
	IL_0de4: dup
	IL_0de5: brtrue.s IL_0dfe

	// (no C# code)
	IL_0de7: pop
	IL_0de8: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0ded: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_86'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0df3: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0df8: dup
	IL_0df9: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_86'

	// 	AddGenerationPass("Jungle Plants", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < Main.maxTilesX * 100; i++)
	// 		{
	// 			int num = genRand.Next(40, Main.maxTilesX / 2 - 40);
	// 			if (GenVars.dungeonSide < 0)
	// 			{
	// 				num += Main.maxTilesX / 2;
	// 			}
	// 			int j;
	// 			for (j = genRand.Next(Main.maxTilesY - 300); !Main.tile[num, j].active() && j < Main.maxTilesY - 300; j++)
	// 			{
	// 			}
	// 			if (Main.tile[num, j].active() && Main.tile[num, j].type == 60)
	// 			{
	// 				j--;
	// 				PlaceJunglePlant(num, j, 233, genRand.Next(8), 0);
	// 				if (Main.tile[num, j].type != 233)
	// 				{
	// 					PlaceJunglePlant(num, j, 233, genRand.Next(12), 1);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0dfe: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0e03: ldstr "Jungle Plants"
	IL_0e08: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_87'
	IL_0e0d: dup
	IL_0e0e: brtrue.s IL_0e27

	// (no C# code)
	IL_0e10: pop
	IL_0e11: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0e16: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_87'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0e1c: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0e21: dup
	IL_0e22: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_87'

	// 	AddGenerationPass("Vines", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[43].Value;
	// 		for (int i = 5; i < Main.maxTilesX - 5; i++)
	// 		{
	// 			progress.Set((double)i / (double)Main.maxTilesX);
	// 			int num = 0;
	// 			ushort num2 = 52;
	// 			int num3 = (int)Main.worldSurface;
	// 			if (remixWorldGen)
	// 			{
	// 				num3 = Main.maxTilesY - 200;
	// 			}
	// 			for (int j = 0; j < num3; j++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, j].active())
	// 				{
	// 					Main.tile[i, j].active(active: true);
	// 					Main.tile[i, j].type = num2;
	// 					Main.tile[i, j].CopyPaintAndCoating(Main.tile[i, j - 1]);
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, j].active() && !Main.tile[i, j].bottomSlope() && (Main.tile[i, j].type == 2 || (Main.tile[i, j].type == 192 && genRand.Next(4) == 0)) && GrowMoreVines(i, j))
	// 				{
	// 					num2 = 52;
	// 					if (Main.tile[i, j].wall == 68 || Main.tile[i, j].wall == 65 || Main.tile[i, j].wall == 66 || Main.tile[i, j].wall == 63)
	// 					{
	// 						num2 = 382;
	// 					}
	// 					else if (Main.tile[i, j + 1].wall == 68 || Main.tile[i, j + 1].wall == 65 || Main.tile[i, j + 1].wall == 66 || Main.tile[i, j + 1].wall == 63)
	// 					{
	// 						num2 = 382;
	// 					}
	// 					if (remixWorldGen && genRand.Next(5) == 0)
	// 					{
	// 						num2 = 382;
	// 					}
	// 					if (genRand.Next(5) < 3)
	// 					{
	// 						num = genRand.Next(1, 10);
	// 					}
	// 				}
	// 			}
	// 			num = 0;
	// 			for (int k = 5; k < Main.maxTilesY - 5; k++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, k].active())
	// 				{
	// 					Main.tile[i, k].active(active: true);
	// 					Main.tile[i, k].type = 62;
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, k].active() && Main.tile[i, k].type == 60 && !Main.tile[i, k].bottomSlope() && GrowMoreVines(i, k))
	// 				{
	// 					if (notTheBees && k < Main.maxTilesY - 10 && Main.tile[i, k - 1].active() && !Main.tile[i, k - 1].bottomSlope() && Main.tile[i + 1, k - 1].active() && !Main.tile[i + 1, k - 1].bottomSlope() && (Main.tile[i, k - 1].type == 60 || Main.tile[i, k - 1].type == 444 || Main.tile[i, k - 1].type == 230))
	// 					{
	// 						bool flag = true;
	// 						for (int l = i; l < i + 2; l++)
	// 						{
	// 							for (int m = k + 1; m < k + 3; m++)
	// 							{
	// 								if (Main.tile[l, m].active() && (!Main.tileCut[Main.tile[l, m].type] || Main.tile[l, m].type == 444))
	// 								{
	// 									flag = false;
	// 									break;
	// 								}
	// 								if (Main.tile[l, m].liquid > 0 || Main.wallHouse[Main.tile[l, m].wall])
	// 								{
	// 									flag = false;
	// 									break;
	// 								}
	// 							}
	// 							if (!flag)
	// 							{
	// 								break;
	// 							}
	// 						}
	// 						if (flag && CountNearBlocksTypes(i, k, genRand.Next(3, 10), 1, 444) > 0)
	// 						{
	// 							flag = false;
	// 						}
	// 						if (flag)
	// 						{
	// 							for (int n = i; n < i + 2; n++)
	// 							{
	// 								for (int num4 = k + 1; num4 < k + 3; num4++)
	// 								{
	// 									KillTile(n, num4);
	// 								}
	// 							}
	// 							for (int num5 = i; num5 < i + 2; num5++)
	// 							{
	// 								for (int num6 = k + 1; num6 < k + 3; num6++)
	// 								{
	// 									Main.tile[num5, num6].active(active: true);
	// 									Main.tile[num5, num6].type = 444;
	// 									Main.tile[num5, num6].frameX = (short)((num5 - i) * 18);
	// 									Main.tile[num5, num6].frameY = (short)((num6 - k - 1) * 18);
	// 								}
	// 							}
	// 							continue;
	// 						}
	// 					}
	// 					else if (i < Main.maxTilesX - 1 && k < Main.maxTilesY - 2 && Main.tile[i + 1, k].active() && Main.tile[i + 1, k].type == 60 && !Main.tile[i + 1, k].bottomSlope() && genRand.Next(40) == 0)
	// 					{
	// 						bool flag2 = true;
	// 						for (int num7 = i; num7 < i + 2; num7++)
	// 						{
	// 							for (int num8 = k + 1; num8 < k + 3; num8++)
	// 							{
	// 								if (Main.tile[num7, num8].active() && (!Main.tileCut[Main.tile[num7, num8].type] || Main.tile[num7, num8].type == 444))
	// 								{
	// 									flag2 = false;
	// 									break;
	// 								}
	// 								if (Main.tile[num7, num8].liquid > 0 || Main.wallHouse[Main.tile[num7, num8].wall])
	// 								{
	// 									flag2 = false;
	// 									break;
	// 								}
	// 							}
	// 							if (!flag2)
	// 							{
	// 								break;
	// 							}
	// 						}
	// 						if (flag2 && CountNearBlocksTypes(i, k, 20, 1, 444) > 0)
	// 						{
	// 							flag2 = false;
	// 						}
	// 						if (flag2)
	// 						{
	// 							for (int num9 = i; num9 < i + 2; num9++)
	// 							{
	// 								for (int num10 = k + 1; num10 < k + 3; num10++)
	// 								{
	// 									KillTile(num9, num10);
	// 								}
	// 							}
	// 							for (int num11 = i; num11 < i + 2; num11++)
	// 							{
	// 								for (int num12 = k + 1; num12 < k + 3; num12++)
	// 								{
	// 									Main.tile[num11, num12].active(active: true);
	// 									Main.tile[num11, num12].type = 444;
	// 									Main.tile[num11, num12].frameX = (short)((num11 - i) * 18);
	// 									Main.tile[num11, num12].frameY = (short)((num12 - k - 1) * 18);
	// 								}
	// 							}
	// 							continue;
	// 						}
	// 					}
	// 					if (genRand.Next(5) < 3)
	// 					{
	// 						num = genRand.Next(1, 10);
	// 					}
	// 				}
	// 			}
	// 			num = 0;
	// 			for (int num13 = 0; num13 < Main.maxTilesY; num13++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, num13].active())
	// 				{
	// 					Main.tile[i, num13].active(active: true);
	// 					Main.tile[i, num13].type = 528;
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, num13].active() && Main.tile[i, num13].type == 70 && genRand.Next(5) == 0 && !Main.tile[i, num13].bottomSlope() && GrowMoreVines(i, num13) && genRand.Next(5) < 3)
	// 				{
	// 					num = genRand.Next(1, 10);
	// 				}
	// 			}
	// 			num = 0;
	// 			for (int num14 = 0; num14 < Main.maxTilesY; num14++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, num14].active())
	// 				{
	// 					Main.tile[i, num14].active(active: true);
	// 					Main.tile[i, num14].type = 636;
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, num14].active() && !Main.tile[i, num14].bottomSlope() && Main.tile[i, num14].type == 23 && GrowMoreVines(i, num14) && genRand.Next(5) < 3)
	// 				{
	// 					num = genRand.Next(1, 10);
	// 				}
	// 			}
	// 			num = 0;
	// 			for (int num15 = 0; num15 < Main.maxTilesY; num15++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, num15].active())
	// 				{
	// 					Main.tile[i, num15].active(active: true);
	// 					Main.tile[i, num15].type = 205;
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, num15].active() && !Main.tile[i, num15].bottomSlope() && Main.tile[i, num15].type == 199 && GrowMoreVines(i, num15) && genRand.Next(5) < 3)
	// 				{
	// 					num = genRand.Next(1, 10);
	// 				}
	// 			}
	// 			num = 0;
	// 			for (int num16 = 0; num16 < Main.maxTilesY; num16++)
	// 			{
	// 				if (num > 0 && !Main.tile[i, num16].active())
	// 				{
	// 					Main.tile[i, num16].active(active: true);
	// 					Main.tile[i, num16].type = 638;
	// 					num--;
	// 				}
	// 				else
	// 				{
	// 					num = 0;
	// 				}
	// 				if (Main.tile[i, num16].active() && !Main.tile[i, num16].bottomSlope() && Main.tile[i, num16].type == 633 && GrowMoreVines(i, num16) && genRand.Next(5) < 3)
	// 				{
	// 					num = genRand.Next(1, 10);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0e27: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0e2c: ldstr "Vines"
	IL_0e31: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_88'
	IL_0e36: dup
	IL_0e37: brtrue.s IL_0e50

	// (no C# code)
	IL_0e39: pop
	IL_0e3a: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0e3f: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_88'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0e45: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0e4a: dup
	IL_0e4b: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_88'

	// 	AddGenerationPass("Flowers", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[44].Value;
	// 		int num = (int)((double)Main.maxTilesX * 0.004);
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 6;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			progress.Set((double)i / (double)num);
	// 			int num2 = genRand.Next(100, Main.maxTilesX - 100);
	// 			int num3 = genRand.Next(15, 30);
	// 			int num4 = genRand.Next(15, 30);
	// 			if (remixWorldGen)
	// 			{
	// 				num3 = genRand.Next(15, 45);
	// 				num4 = genRand.Next(15, 45);
	// 				int num5 = genRand.Next((int)Main.rockLayer, Main.maxTilesY - 350);
	// 				if (GenVars.logX >= 0)
	// 				{
	// 					num2 = GenVars.logX;
	// 					num5 = GenVars.logY;
	// 					GenVars.logX = -1;
	// 				}
	// 				int num6 = genRand.NextFromList<int>(21, 24, 27, 30, 33, 36, 39, 42);
	// 				for (int j = num2 - num3; j < num2 + num3; j++)
	// 				{
	// 					for (int k = num5 - num4; k < num5 + num4; k++)
	// 					{
	// 						if (Main.tile[j, k].type != 488 && !Main.tileSolid[Main.tile[j, k].type])
	// 						{
	// 							if (Main.tile[j, k].type == 3)
	// 							{
	// 								Main.tile[j, k].frameX = (short)((num6 + genRand.Next(3)) * 18);
	// 								if (genRand.Next(3) != 0)
	// 								{
	// 									Main.tile[j, k].type = 73;
	// 								}
	// 							}
	// 							else if (Main.tile[j, k + 1].wall == 0 && (Main.tile[j, k + 1].type == 2 || ((Main.tile[j, k + 1].type == 40 || Main.tile[j, k + 1].type == 1 || TileID.Sets.Ore[Main.tile[j, k + 1].type]) && !Main.tile[j, k].active())) && (!Main.tile[j, k].active() || Main.tile[j, k].type == 185 || Main.tile[j, k].type == 186 || Main.tile[j, k].type == 187 || (Main.tile[j, k].type == 5 && (double)j < (double)Main.maxTilesX * 0.48) || (double)j > (double)Main.maxTilesX * 0.52))
	// 							{
	// 								if (Main.tile[j, k + 1].type == 40 || Main.tile[j, k + 1].type == 1 || TileID.Sets.Ore[Main.tile[j, k + 1].type])
	// 								{
	// 									Main.tile[j, k + 1].type = 2;
	// 									if (Main.tile[j, k + 2].type == 40 || Main.tile[j, k + 2].type == 1 || TileID.Sets.Ore[Main.tile[j, k + 2].type])
	// 									{
	// 										Main.tile[j, k + 2].type = 2;
	// 									}
	// 								}
	// 								KillTile(j, k);
	// 								if (genRand.Next(2) == 0)
	// 								{
	// 									Main.tile[j, k + 1].slope(0);
	// 									Main.tile[j, k + 1].halfBrick(halfBrick: false);
	// 								}
	// 								PlaceTile(j, k, 3);
	// 								if (Main.tile[j, k].active() && Main.tile[j, k].type == 3)
	// 								{
	// 									Main.tile[j, k].frameX = (short)((num6 + genRand.Next(3)) * 18);
	// 									if (genRand.Next(3) != 0)
	// 									{
	// 										Main.tile[j, k].type = 73;
	// 									}
	// 								}
	// 								if (Main.tile[j, k + 2].type == 40 || Main.tile[j, k + 2].type == 1 || TileID.Sets.Ore[Main.tile[j, k + 2].type])
	// 								{
	// 									Main.tile[j, k + 2].type = 0;
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 			else
	// 			{
	// 				for (int l = num4; (double)l < Main.worldSurface - (double)num4 - 1.0; l++)
	// 				{
	// 					if (Main.tile[num2, l].active())
	// 					{
	// 						if (GenVars.logX >= 0)
	// 						{
	// 							num2 = GenVars.logX;
	// 							l = GenVars.logY;
	// 							GenVars.logX = -1;
	// 						}
	// 						int num7 = genRand.NextFromList<int>(21, 24, 27, 30, 33, 36, 39, 42);
	// 						for (int m = num2 - num3; m < num2 + num3; m++)
	// 						{
	// 							for (int n = l - num4; n < l + num4; n++)
	// 							{
	// 								if (Main.tile[m, n].type != 488 && !Main.tileSolid[Main.tile[m, n].type])
	// 								{
	// 									if (Main.tile[m, n].type == 3)
	// 									{
	// 										Main.tile[m, n].frameX = (short)((num7 + genRand.Next(3)) * 18);
	// 										if (genRand.Next(3) != 0)
	// 										{
	// 											Main.tile[m, n].type = 73;
	// 										}
	// 									}
	// 									else if (Main.tile[m, n + 1].wall == 0 && (Main.tile[m, n + 1].type == 2 || ((Main.tile[m, n + 1].type == 40 || Main.tile[m, n + 1].type == 1 || TileID.Sets.Ore[Main.tile[m, n + 1].type]) && !Main.tile[m, n].active())) && (!Main.tile[m, n].active() || Main.tile[m, n].type == 185 || Main.tile[m, n].type == 186 || Main.tile[m, n].type == 187 || (Main.tile[m, n].type == 5 && (double)m < (double)Main.maxTilesX * 0.48) || (double)m > (double)Main.maxTilesX * 0.52))
	// 									{
	// 										if (Main.tile[m, n + 1].type == 40 || Main.tile[m, n + 1].type == 1 || TileID.Sets.Ore[Main.tile[m, n + 1].type])
	// 										{
	// 											Main.tile[m, n + 1].type = 2;
	// 											if (Main.tile[m, n + 2].type == 40 || Main.tile[m, n + 2].type == 1 || TileID.Sets.Ore[Main.tile[m, n + 2].type])
	// 											{
	// 												Main.tile[m, n + 2].type = 2;
	// 											}
	// 										}
	// 										KillTile(m, n);
	// 										if (genRand.Next(2) == 0)
	// 										{
	// 											Main.tile[m, n + 1].slope(0);
	// 											Main.tile[m, n + 1].halfBrick(halfBrick: false);
	// 										}
	// 										PlaceTile(m, n, 3);
	// 										if (Main.tile[m, n].active() && Main.tile[m, n].type == 3)
	// 										{
	// 											Main.tile[m, n].frameX = (short)((num7 + genRand.Next(3)) * 18);
	// 											if (genRand.Next(3) != 0)
	// 											{
	// 												Main.tile[m, n].type = 73;
	// 											}
	// 										}
	// 										if (Main.tile[m, n + 2].type == 40 || Main.tile[m, n + 2].type == 1 || TileID.Sets.Ore[Main.tile[m, n + 2].type])
	// 										{
	// 											Main.tile[m, n + 2].type = 0;
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0e50: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0e55: ldstr "Flowers"
	IL_0e5a: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_89'
	IL_0e5f: dup
	IL_0e60: brtrue.s IL_0e79

	// (no C# code)
	IL_0e62: pop
	IL_0e63: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0e68: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_89'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0e6e: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0e73: dup
	IL_0e74: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_89'

	// 	AddGenerationPass("Mushrooms", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[45].Value;
	// 		int num = (int)((double)Main.maxTilesX * 0.002);
	// 		if (remixWorldGen)
	// 		{
	// 			num *= 9;
	// 		}
	// 		for (int i = 0; i < num; i++)
	// 		{
	// 			progress.Set((double)i / (double)num);
	// 			int num2 = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num3 = genRand.Next(4, 10);
	// 			int num4 = genRand.Next(15, 30);
	// 			if (remixWorldGen)
	// 			{
	// 				num3 = genRand.Next(8, 17);
	// 				num4 = genRand.Next(8, 17);
	// 				int num5 = genRand.Next((int)Main.rockLayer, Main.maxTilesY - 350);
	// 				if (Main.tile[num2, num5].active())
	// 				{
	// 					for (int j = num2 - num3; j < num2 + num3; j++)
	// 					{
	// 						for (int k = num5 - num4; k < num5 + num4; k++)
	// 						{
	// 							if (j < 10)
	// 							{
	// 								break;
	// 							}
	// 							if (k < 0)
	// 							{
	// 								break;
	// 							}
	// 							if (j > Main.maxTilesX - 10)
	// 							{
	// 								break;
	// 							}
	// 							if (k > Main.maxTilesY - 10)
	// 							{
	// 								break;
	// 							}
	// 							if (Main.tile[j, k].type == 3 || Main.tile[j, k].type == 24)
	// 							{
	// 								Main.tile[j, k].frameX = 144;
	// 							}
	// 							else if (Main.tile[j, k].type == 201)
	// 							{
	// 								Main.tile[j, k].frameX = 270;
	// 							}
	// 						}
	// 					}
	// 				}
	// 			}
	// 			else
	// 			{
	// 				for (int l = 1; (double)l < Main.worldSurface - 1.0; l++)
	// 				{
	// 					if (Main.tile[num2, l].active())
	// 					{
	// 						for (int m = num2 - num3; m < num2 + num3; m++)
	// 						{
	// 							for (int n = l - num4; n < l + num4; n++)
	// 							{
	// 								if (m < 10)
	// 								{
	// 									break;
	// 								}
	// 								if (n < 0)
	// 								{
	// 									break;
	// 								}
	// 								if (m > Main.maxTilesX - 10)
	// 								{
	// 									break;
	// 								}
	// 								if (n > Main.maxTilesY - 10)
	// 								{
	// 									break;
	// 								}
	// 								if (Main.tile[m, n].type == 3 || Main.tile[m, n].type == 24)
	// 								{
	// 									Main.tile[m, n].frameX = 144;
	// 								}
	// 								else if (Main.tile[m, n].type == 201)
	// 								{
	// 									Main.tile[m, n].frameX = 270;
	// 								}
	// 							}
	// 						}
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0e79: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0e7e: ldstr "Mushrooms"
	IL_0e83: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_90'
	IL_0e88: dup
	IL_0e89: brtrue.s IL_0ea2

	// (no C# code)
	IL_0e8b: pop
	IL_0e8c: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0e91: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_90'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0e97: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0e9c: dup
	IL_0e9d: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_90'

	// 	AddGenerationPass("Gems In Ice Biome", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; (double)i < (double)Main.maxTilesX * 0.25; i++)
	// 		{
	// 			int num = ((!remixWorldGen) ? genRand.Next((int)(Main.worldSurface + Main.rockLayer) / 2, GenVars.lavaLine) : genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300));
	// 			int num2 = genRand.Next(GenVars.snowMinX[num], GenVars.snowMaxX[num]);
	// 			if (Main.tile[num2, num].active() && (Main.tile[num2, num].type == 147 || Main.tile[num2, num].type == 161 || Main.tile[num2, num].type == 162 || Main.tile[num2, num].type == 224))
	// 			{
	// 				int num3 = genRand.Next(1, 4);
	// 				int num4 = genRand.Next(1, 4);
	// 				int num5 = genRand.Next(1, 4);
	// 				int num6 = genRand.Next(1, 4);
	// 				int num7 = genRand.Next(12);
	// 				int num8 = 0;
	// 				num8 = ((num7 >= 3) ? ((num7 < 6) ? 1 : ((num7 < 8) ? 2 : ((num7 < 10) ? 3 : ((num7 >= 11) ? 5 : 4)))) : 0);
	// 				for (int j = num2 - num3; j < num2 + num4; j++)
	// 				{
	// 					for (int k = num - num5; k < num + num6; k++)
	// 					{
	// 						if (!Main.tile[j, k].active())
	// 						{
	// 							PlaceTile(j, k, 178, mute: true, forced: false, -1, num8);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0ea2: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0ea7: ldstr "Gems In Ice Biome"
	IL_0eac: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_91'
	IL_0eb1: dup
	IL_0eb2: brtrue.s IL_0ecb

	// (no C# code)
	IL_0eb4: pop
	IL_0eb5: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0eba: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_91'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0ec0: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0ec5: dup
	IL_0ec6: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_91'

	// 	AddGenerationPass("Random Gems", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			int num = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num2 = genRand.Next((int)Main.rockLayer, Main.maxTilesY - 300);
	// 			if (!Main.tile[num, num2].active() && !Main.tile[num, num2].lava() && !Main.wallDungeon[Main.tile[num, num2].wall] && Main.tile[num, num2].wall != 27)
	// 			{
	// 				int num3 = genRand.Next(12);
	// 				int num4 = 0;
	// 				num4 = ((num3 >= 3) ? ((num3 < 6) ? 1 : ((num3 < 8) ? 2 : ((num3 < 10) ? 3 : ((num3 >= 11) ? 5 : 4)))) : 0);
	// 				PlaceTile(num, num2, 178, mute: true, forced: false, -1, num4);
	// 			}
	// 		}
	// 		for (int j = 0; j < Main.maxTilesX; j++)
	// 		{
	// 			int num5 = genRand.Next(20, Main.maxTilesX - 20);
	// 			int num6 = genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300);
	// 			if (!Main.tile[num5, num6].active() && !Main.tile[num5, num6].lava() && (Main.tile[num5, num6].wall == 216 || Main.tile[num5, num6].wall == 187))
	// 			{
	// 				int num7 = genRand.Next(1, 4);
	// 				int num8 = genRand.Next(1, 4);
	// 				int num9 = genRand.Next(1, 4);
	// 				int num10 = genRand.Next(1, 4);
	// 				for (int k = num5 - num7; k < num5 + num8; k++)
	// 				{
	// 					for (int l = num6 - num9; l < num6 + num10; l++)
	// 					{
	// 						if (!Main.tile[k, l].active())
	// 						{
	// 							PlaceTile(k, l, 178, mute: true, forced: false, -1, 6);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0ecb: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0ed0: ldstr "Random Gems"
	IL_0ed5: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_92'
	IL_0eda: dup
	IL_0edb: brtrue.s IL_0ef4

	// (no C# code)
	IL_0edd: pop
	IL_0ede: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0ee3: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_92'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0ee9: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0eee: dup
	IL_0eef: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_92'

	// 	AddGenerationPass("Moss Grass", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 5; i < Main.maxTilesX - 5; i++)
	// 		{
	// 			for (int j = 5; j < Main.maxTilesY - 5; j++)
	// 			{
	// 				if (Main.tile[i, j].active() && Main.tileMoss[Main.tile[i, j].type])
	// 				{
	// 					for (int k = 0; k < 4; k++)
	// 					{
	// 						int num = i;
	// 						int num2 = j;
	// 						if (k == 0)
	// 						{
	// 							num--;
	// 						}
	// 						if (k == 1)
	// 						{
	// 							num++;
	// 						}
	// 						if (k == 2)
	// 						{
	// 							num2--;
	// 						}
	// 						if (k == 3)
	// 						{
	// 							num2++;
	// 						}
	// 						if (!Main.tile[num, num2].active())
	// 						{
	// 							PlaceTile(num, num2, 184, mute: true);
	// 						}
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0ef4: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0ef9: ldstr "Moss Grass"
	IL_0efe: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_93'
	IL_0f03: dup
	IL_0f04: brtrue.s IL_0f1d

	// (no C# code)
	IL_0f06: pop
	IL_0f07: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0f0c: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_93'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0f12: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0f17: dup
	IL_0f18: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_93'

	// 	AddGenerationPass("Muds Walls In Jungle", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		int num = 0;
	// 		int num2 = 0;
	// 		bool flag = false;
	// 		for (int i = 5; i < Main.maxTilesX - 5; i++)
	// 		{
	// 			for (int j = 0; (double)j < Main.worldSurface + 20.0; j++)
	// 			{
	// 				if (Main.tile[i, j].active() && Main.tile[i, j].type == 60)
	// 				{
	// 					num = i;
	// 					flag = true;
	// 					break;
	// 				}
	// 			}
	// 			if (flag)
	// 			{
	// 				break;
	// 			}
	// 		}
	// 		flag = false;
	// 		for (int num3 = Main.maxTilesX - 5; num3 > 5; num3--)
	// 		{
	// 			for (int k = 0; (double)k < Main.worldSurface + 20.0; k++)
	// 			{
	// 				if (Main.tile[num3, k].active() && Main.tile[num3, k].type == 60)
	// 				{
	// 					num2 = num3;
	// 					flag = true;
	// 					break;
	// 				}
	// 			}
	// 			if (flag)
	// 			{
	// 				break;
	// 			}
	// 		}
	// 		GenVars.jungleMinX = num;
	// 		GenVars.jungleMaxX = num2;
	// 		for (int l = num; l <= num2; l++)
	// 		{
	// 			for (int m = 0; (double)m < Main.worldSurface + 20.0; m++)
	// 			{
	// 				if (((l >= num + 2 && l <= num2 - 2) || genRand.Next(2) != 0) && ((l >= num + 3 && l <= num2 - 3) || genRand.Next(3) != 0) && (Main.tile[l, m].wall == 2 || Main.tile[l, m].wall == 59))
	// 				{
	// 					Main.tile[l, m].wall = 15;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0f1d: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0f22: ldstr "Muds Walls In Jungle"
	IL_0f27: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_94'
	IL_0f2c: dup
	IL_0f2d: brtrue.s IL_0f46

	// (no C# code)
	IL_0f2f: pop
	IL_0f30: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0f35: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_94'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0f3b: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0f40: dup
	IL_0f41: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_94'

	// 	AddGenerationPass("Larva", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		Main.tileSolid[229] = true;
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < GenVars.numLarva; i++)
	// 		{
	// 			int num = GenVars.larvaX[i];
	// 			int num2 = GenVars.larvaY[i];
	// 			for (int j = num - 1; j <= num + 1; j++)
	// 			{
	// 				for (int k = num2 - 2; k <= num2 + 1; k++)
	// 				{
	// 					if (k != num2 + 1)
	// 					{
	// 						Main.tile[j, k].active(active: false);
	// 					}
	// 					else
	// 					{
	// 						Main.tile[j, k].active(active: true);
	// 						Main.tile[j, k].type = 225;
	// 						Main.tile[j, k].slope(0);
	// 						Main.tile[j, k].halfBrick(halfBrick: false);
	// 					}
	// 				}
	// 			}
	// 			PlaceTile(num, num2, 231, mute: true);
	// 		}
	// 		Main.tileSolid[232] = true;
	// 		Main.tileSolid[162] = true;
	// 	});
	IL_0f46: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0f4b: ldstr "Larva"
	IL_0f50: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_95'
	IL_0f55: dup
	IL_0f56: brtrue.s IL_0f6f

	// (no C# code)
	IL_0f58: pop
	IL_0f59: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0f5e: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_95'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0f64: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0f69: dup
	IL_0f6a: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_95'

	// 	AddGenerationPass("Settle Liquids Again", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		if (getGoodWorldGen)
	// 		{
	// 			Main.tileSolid[56] = true;
	// 		}
	// 		progress.Message = Lang.gen[27].Value;
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 		}
	// 		Liquid.worldGenTilesIgnoreWater(ignoreSolids: true);
	// 		Liquid.QuickWater(3);
	// 		WaterCheck();
	// 		int num = 0;
	// 		Liquid.quickSettle = true;
	// 		int num2 = 10;
	// 		while (num < num2)
	// 		{
	// 			int num3 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
	// 			num++;
	// 			double num4 = 0.0;
	// 			int num5 = num3 * 5;
	// 			while (Liquid.numLiquid > 0)
	// 			{
	// 				num5--;
	// 				if (num5 < 0)
	// 				{
	// 					break;
	// 				}
	// 				double num6 = (double)(num3 - (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer)) / (double)num3;
	// 				if (Liquid.numLiquid + LiquidBuffer.numLiquidBuffer > num3)
	// 				{
	// 					num3 = Liquid.numLiquid + LiquidBuffer.numLiquidBuffer;
	// 				}
	// 				if (num6 > num4)
	// 				{
	// 					num4 = num6;
	// 				}
	// 				else
	// 				{
	// 					num6 = num4;
	// 				}
	// 				if (num == 1)
	// 				{
	// 					progress.Set(num6 / 3.0 + 0.33);
	// 				}
	// 				Liquid.UpdateLiquid();
	// 			}
	// 			WaterCheck();
	// 			progress.Set((double)num / (double)num2 / 3.0 + 0.66);
	// 		}
	// 		Liquid.quickSettle = false;
	// 		Liquid.worldGenTilesIgnoreWater(ignoreSolids: false);
	// 		Main.tileSolid[484] = false;
	// 	});
	IL_0f6f: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0f74: ldstr "Settle Liquids Again"
	IL_0f79: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_96'
	IL_0f7e: dup
	IL_0f7f: brtrue.s IL_0f98

	// (no C# code)
	IL_0f81: pop
	IL_0f82: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0f87: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_96'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0f8d: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0f92: dup
	IL_0f93: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_96'

	// 	AddGenerationPass("Cactus, Palm Trees, & Coral", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[38].Value;
	// 		int num = 8;
	// 		if (remixWorldGen)
	// 		{
	// 			num = 2;
	// 		}
	// 		int num2 = 400;
	// 		int num3 = genRand.Next(3, 13);
	// 		int num4 = genRand.Next(3, 13);
	// 		genRand.Next(2, 6);
	// 		genRand.Next(2, 6);
	// 		int num5 = 380;
	// 		for (int i = 0; i < GenVars.numOasis; i++)
	// 		{
	// 			int num6 = (int)((double)GenVars.oasisWidth[i] * 1.5);
	// 			for (int j = GenVars.oasisPosition[i].X - num6; j <= GenVars.oasisPosition[i].X + num6; j++)
	// 			{
	// 				for (int k = GenVars.oasisPosition[i].Y - GenVars.oasisHeight; k <= GenVars.oasisPosition[i].Y + GenVars.oasisHeight; k++)
	// 				{
	// 					double num7 = 1.0;
	// 					int num8 = 8;
	// 					for (int l = j - num8; l <= j + num8; l++)
	// 					{
	// 						for (int m = k - num8; m <= k + num8; m++)
	// 						{
	// 							if (InWorld(l, m) && Main.tile[l, m] != null && Main.tile[l, m].active() && Main.tile[l, m].type == 323)
	// 							{
	// 								num7 = 0.13;
	// 							}
	// 						}
	// 					}
	// 					if (genRand.NextDouble() < num7)
	// 					{
	// 						GrowPalmTree(j, k);
	// 					}
	// 					if (PlantSeaOat(j, k))
	// 					{
	// 						if (genRand.Next(2) == 0)
	// 						{
	// 							GrowSeaOat(j, k);
	// 						}
	// 						if (genRand.Next(2) == 0)
	// 						{
	// 							GrowSeaOat(j, k);
	// 						}
	// 					}
	// 					PlaceOasisPlant(j, k, 530);
	// 				}
	// 			}
	// 		}
	// 		for (int n = 0; n < 3; n++)
	// 		{
	// 			progress.Set((double)n / 3.0);
	// 			int num9;
	// 			int num10;
	// 			bool flag;
	// 			int maxValue;
	// 			switch (n)
	// 			{
	// 			default:
	// 				num9 = 5;
	// 				num10 = num5;
	// 				flag = false;
	// 				maxValue = num3;
	// 				break;
	// 			case 1:
	// 				num9 = num2;
	// 				num10 = Main.maxTilesX - num2;
	// 				flag = true;
	// 				maxValue = num;
	// 				break;
	// 			case 2:
	// 				num9 = Main.maxTilesX - num5;
	// 				num10 = Main.maxTilesX - 5;
	// 				flag = false;
	// 				maxValue = num4;
	// 				break;
	// 			}
	// 			double num11 = Main.worldSurface - 1.0;
	// 			if (remixWorldGen)
	// 			{
	// 				num11 = Main.maxTilesY - 50;
	// 			}
	// 			for (int num12 = num9; num12 < num10; num12++)
	// 			{
	// 				if (genRand.Next(maxValue) == 0)
	// 				{
	// 					for (int num13 = 0; (double)num13 < num11; num13++)
	// 					{
	// 						Tile tile = Main.tile[num12, num13];
	// 						if (tile.active() && (tile.type == 53 || tile.type == 112 || tile.type == 234))
	// 						{
	// 							Tile tile2 = Main.tile[num12, num13 - 1];
	// 							if (!tile2.active() && tile2.wall == 0)
	// 							{
	// 								if (flag)
	// 								{
	// 									if (remixWorldGen)
	// 									{
	// 										if ((double)num13 > Main.worldSurface)
	// 										{
	// 											if (SolidTile(num12, num13) && Main.tile[num12, num13 + 1].type == 53 && Main.tile[num12, num13 + 2].type == 53)
	// 											{
	// 												int maxValue2 = 3;
	// 												GrowPalmTree(num12, num13);
	// 												if (!Main.tile[num12, num13 - 1].active() && genRand.Next(maxValue2) == 0)
	// 												{
	// 													PlantCactus(num12, num13);
	// 												}
	// 											}
	// 										}
	// 										else
	// 										{
	// 											int num14 = 0;
	// 											for (int num15 = num12 - cactusWaterWidth; num15 < num12 + cactusWaterWidth; num15++)
	// 											{
	// 												for (int num16 = num13 - cactusWaterHeight; num16 < num13 + cactusWaterHeight; num16++)
	// 												{
	// 													num14 += Main.tile[num15, num16].liquid;
	// 												}
	// 											}
	// 											if (num14 / 255 > cactusWaterLimit)
	// 											{
	// 												int maxValue3 = 4;
	// 												if (genRand.Next(maxValue3) == 0)
	// 												{
	// 													GrowPalmTree(num12, num13);
	// 												}
	// 											}
	// 											else
	// 											{
	// 												PlantCactus(num12, num13);
	// 											}
	// 										}
	// 									}
	// 									else
	// 									{
	// 										int num17 = 0;
	// 										for (int num18 = num12 - cactusWaterWidth; num18 < num12 + cactusWaterWidth; num18++)
	// 										{
	// 											for (int num19 = num13 - cactusWaterHeight; num19 < num13 + cactusWaterHeight; num19++)
	// 											{
	// 												num17 += Main.tile[num18, num19].liquid;
	// 											}
	// 										}
	// 										if (num17 / 255 > cactusWaterLimit)
	// 										{
	// 											int maxValue4 = 4;
	// 											if (genRand.Next(maxValue4) == 0)
	// 											{
	// 												GrowPalmTree(num12, num13);
	// 											}
	// 										}
	// 										else
	// 										{
	// 											PlantCactus(num12, num13);
	// 										}
	// 									}
	// 								}
	// 								else
	// 								{
	// 									if (Main.tile[num12, num13 - 2].liquid == byte.MaxValue && Main.tile[num12, num13 - 3].liquid == byte.MaxValue && Main.tile[num12, num13 - 4].liquid == byte.MaxValue)
	// 									{
	// 										if (genRand.Next(2) == 0)
	// 										{
	// 											PlaceTile(num12, num13 - 1, 81, mute: true);
	// 										}
	// 										else
	// 										{
	// 											PlaceTile(num12, num13 - 1, 324, mute: true, forced: false, -1, RollRandomSeaShellStyle());
	// 										}
	// 										break;
	// 									}
	// 									if (Main.tile[num12, num13 - 2].liquid == 0 && (double)num13 < Main.worldSurface)
	// 									{
	// 										PlaceTile(num12, num13 - 1, 324, mute: true, forced: false, -1, RollRandomSeaShellStyle());
	// 										break;
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 				else
	// 				{
	// 					for (int num20 = 0; (double)num20 < num11; num20++)
	// 					{
	// 						if (PlantSeaOat(num12, num20))
	// 						{
	// 							if (genRand.Next(2) == 0)
	// 							{
	// 								GrowSeaOat(num12, num20);
	// 							}
	// 							if (genRand.Next(2) == 0)
	// 							{
	// 								GrowSeaOat(num12, num20);
	// 							}
	// 						}
	// 						PlaceOasisPlant(num12, num20, 530);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0f98: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0f9d: ldstr "Cactus, Palm Trees, & Coral"
	IL_0fa2: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_97'
	IL_0fa7: dup
	IL_0fa8: brtrue.s IL_0fc1

	// (no C# code)
	IL_0faa: pop
	IL_0fab: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0fb0: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_97'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0fb6: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0fbb: dup
	IL_0fbc: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_97'

	// 	AddGenerationPass("Tile Cleanup", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Message = Lang.gen[84].Value;
	// 		for (int i = 40; i < Main.maxTilesX - 40; i++)
	// 		{
	// 			progress.Set((double)(i - 40) / (double)(Main.maxTilesX - 80));
	// 			for (int j = 40; j < Main.maxTilesY - 40; j++)
	// 			{
	// 				if (Main.tile[i, j].active() && Main.tile[i, j].topSlope() && ((Main.tile[i, j].leftSlope() && Main.tile[i + 1, j].halfBrick()) || (Main.tile[i, j].rightSlope() && Main.tile[i - 1, j].halfBrick())))
	// 				{
	// 					Main.tile[i, j].slope(0);
	// 					Main.tile[i, j].halfBrick(halfBrick: true);
	// 				}
	// 				if (Main.tile[i, j].active() && Main.tile[i, j].liquid > 0 && TileID.Sets.SlowlyDiesInWater[Main.tile[i, j].type])
	// 				{
	// 					KillTile(i, j);
	// 				}
	// 				if (!Main.tile[i, j].active() && Main.tile[i, j].liquid == 0 && genRand.Next(3) != 0 && SolidTile(i, j - 1))
	// 				{
	// 					int num = genRand.Next(15, 21);
	// 					for (int num2 = j - 2; num2 >= j - num; num2--)
	// 					{
	// 						if (Main.tile[i, num2].liquid >= 128 && !Main.tile[i, num2].shimmer())
	// 						{
	// 							int num3 = 373;
	// 							if (Main.tile[i, num2].lava())
	// 							{
	// 								num3 = 374;
	// 							}
	// 							else if (Main.tile[i, num2].honey())
	// 							{
	// 								num3 = 375;
	// 							}
	// 							int maxValue = j - num2;
	// 							if (genRand.Next(maxValue) <= 1)
	// 							{
	// 								if (Main.tile[i, j].wall == 86)
	// 								{
	// 									num3 = 375;
	// 								}
	// 								Main.tile[i, j].type = (ushort)num3;
	// 								Main.tile[i, j].frameX = 0;
	// 								Main.tile[i, j].frameY = 0;
	// 								Main.tile[i, j].active(active: true);
	// 								break;
	// 							}
	// 						}
	// 					}
	// 					if (!Main.tile[i, j].active())
	// 					{
	// 						num = genRand.Next(3, 11);
	// 						for (int k = j + 1; k <= j + num; k++)
	// 						{
	// 							if (Main.tile[i, k].liquid >= 200 && !Main.tile[i, k].shimmer())
	// 							{
	// 								int num4 = 373;
	// 								if (Main.tile[i, k].lava())
	// 								{
	// 									num4 = 374;
	// 								}
	// 								else if (Main.tile[i, k].honey())
	// 								{
	// 									num4 = 375;
	// 								}
	// 								int num5 = k - j;
	// 								if (genRand.Next(num5 * 3) <= 1)
	// 								{
	// 									Main.tile[i, j].type = (ushort)num4;
	// 									Main.tile[i, j].frameX = 0;
	// 									Main.tile[i, j].frameY = 0;
	// 									Main.tile[i, j].active(active: true);
	// 									break;
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if (!Main.tile[i, j].active() && genRand.Next(4) == 0)
	// 					{
	// 						Tile tile = Main.tile[i, j - 1];
	// 						if (TileID.Sets.Conversion.Sandstone[tile.type] || TileID.Sets.Conversion.HardenedSand[tile.type])
	// 						{
	// 							Main.tile[i, j].type = 461;
	// 							Main.tile[i, j].frameX = 0;
	// 							Main.tile[i, j].frameY = 0;
	// 							Main.tile[i, j].active(active: true);
	// 						}
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 137)
	// 				{
	// 					int num6 = Main.tile[i, j].frameY / 18;
	// 					if (num6 <= 2 || num6 == 5)
	// 					{
	// 						int num7 = -1;
	// 						if (Main.tile[i, j].frameX >= 18)
	// 						{
	// 							num7 = 1;
	// 						}
	// 						if (Main.tile[i + num7, j].halfBrick() || Main.tile[i + num7, j].slope() != 0)
	// 						{
	// 							Main.tile[i + num7, j].active(active: false);
	// 						}
	// 					}
	// 				}
	// 				else if (Main.tile[i, j].type == 162 && Main.tile[i, j + 1].liquid == 0 && CanKillTile(i, j))
	// 				{
	// 					Main.tile[i, j].active(active: false);
	// 				}
	// 				if (Main.tile[i, j].wall == 13 || Main.tile[i, j].wall == 14)
	// 				{
	// 					Main.tile[i, j].liquid = 0;
	// 				}
	// 				if (Main.tile[i, j].type == 31)
	// 				{
	// 					int num8 = Main.tile[i, j].frameX / 18;
	// 					int num9 = 0;
	// 					int num10 = i;
	// 					num9 += num8 / 2;
	// 					num9 = (((!drunkWorldGen) ? crimson : (Main.tile[i, j].wall == 83)) ? 1 : 0);
	// 					num8 %= 2;
	// 					num10 -= num8;
	// 					int num11 = Main.tile[i, j].frameY / 18;
	// 					int num12 = 0;
	// 					int num13 = j;
	// 					num12 += num11 / 2;
	// 					num11 %= 2;
	// 					num13 -= num11;
	// 					for (int l = 0; l < 2; l++)
	// 					{
	// 						for (int m = 0; m < 2; m++)
	// 						{
	// 							int x = num10 + l;
	// 							int y = num13 + m;
	// 							Main.tile[x, y].active(active: true);
	// 							Main.tile[x, y].slope(0);
	// 							Main.tile[x, y].halfBrick(halfBrick: false);
	// 							Main.tile[x, y].type = 31;
	// 							Main.tile[x, y].frameX = (short)(l * 18 + 36 * num9);
	// 							Main.tile[x, y].frameY = (short)(m * 18 + 36 * num12);
	// 						}
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 12)
	// 				{
	// 					int num14 = Main.tile[i, j].frameX / 18;
	// 					int num15 = 0;
	// 					int num16 = i;
	// 					num15 += num14 / 2;
	// 					num14 %= 2;
	// 					num16 -= num14;
	// 					int num17 = Main.tile[i, j].frameY / 18;
	// 					int num18 = 0;
	// 					int num19 = j;
	// 					num18 += num17 / 2;
	// 					num17 %= 2;
	// 					num19 -= num17;
	// 					for (int n = 0; n < 2; n++)
	// 					{
	// 						for (int num20 = 0; num20 < 2; num20++)
	// 						{
	// 							int x2 = num16 + n;
	// 							int y2 = num19 + num20;
	// 							Main.tile[x2, y2].active(active: true);
	// 							Main.tile[x2, y2].slope(0);
	// 							Main.tile[x2, y2].halfBrick(halfBrick: false);
	// 							Main.tile[x2, y2].type = 12;
	// 							Main.tile[x2, y2].frameX = (short)(n * 18 + 36 * num15);
	// 							Main.tile[x2, y2].frameY = (short)(num20 * 18 + 36 * num18);
	// 						}
	// 						if (!Main.tile[n, j + 2].active())
	// 						{
	// 							Main.tile[n, j + 2].active(active: true);
	// 							if (!Main.tileSolid[Main.tile[n, j + 2].type] || Main.tileSolidTop[Main.tile[n, j + 2].type])
	// 							{
	// 								Main.tile[n, j + 2].type = 0;
	// 							}
	// 						}
	// 						Main.tile[n, j + 2].slope(0);
	// 						Main.tile[n, j + 2].halfBrick(halfBrick: false);
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 639)
	// 				{
	// 					int num21 = Main.tile[i, j].frameX / 18;
	// 					int num22 = 0;
	// 					int num23 = i;
	// 					num22 += num21 / 2;
	// 					num21 %= 2;
	// 					num23 -= num21;
	// 					int num24 = Main.tile[i, j].frameY / 18;
	// 					int num25 = 0;
	// 					int num26 = j;
	// 					num25 += num24 / 2;
	// 					num24 %= 2;
	// 					num26 -= num24;
	// 					for (int num27 = 0; num27 < 2; num27++)
	// 					{
	// 						for (int num28 = 0; num28 < 2; num28++)
	// 						{
	// 							int x3 = num23 + num27;
	// 							int y3 = num26 + num28;
	// 							Main.tile[x3, y3].active(active: true);
	// 							Main.tile[x3, y3].slope(0);
	// 							Main.tile[x3, y3].halfBrick(halfBrick: false);
	// 							Main.tile[x3, y3].type = 639;
	// 							Main.tile[x3, y3].frameX = (short)(num27 * 18 + 36 * num22);
	// 							Main.tile[x3, y3].frameY = (short)(num28 * 18 + 36 * num25);
	// 						}
	// 						if (!Main.tile[num27, j + 2].active())
	// 						{
	// 							Main.tile[num27, j + 2].active(active: true);
	// 							if (!Main.tileSolid[Main.tile[num27, j + 2].type] || Main.tileSolidTop[Main.tile[num27, j + 2].type])
	// 							{
	// 								Main.tile[num27, j + 2].type = 0;
	// 							}
	// 						}
	// 						Main.tile[num27, j + 2].slope(0);
	// 						Main.tile[num27, j + 2].halfBrick(halfBrick: false);
	// 					}
	// 				}
	// 				if (TileID.Sets.BasicChest[Main.tile[i, j].type])
	// 				{
	// 					int num29 = Main.tile[i, j].frameX / 18;
	// 					int num30 = 0;
	// 					ushort num31 = 21;
	// 					int num32 = i;
	// 					int num33 = j - Main.tile[i, j].frameY / 18;
	// 					if (Main.tile[i, j].type == 467)
	// 					{
	// 						num31 = 467;
	// 					}
	// 					if (TileID.Sets.BasicChest[Main.tile[i, j].type])
	// 					{
	// 						num31 = Main.tile[i, j].type;
	// 					}
	// 					while (num29 >= 2)
	// 					{
	// 						num30++;
	// 						num29 -= 2;
	// 					}
	// 					num32 -= num29;
	// 					int num34 = Chest.FindChest(num32, num33);
	// 					if (num34 != -1)
	// 					{
	// 						switch (Main.chest[num34].item[0].type)
	// 						{
	// 						case 1156:
	// 							num30 = 23;
	// 							break;
	// 						case 1571:
	// 							num30 = 24;
	// 							break;
	// 						case 1569:
	// 							num30 = 25;
	// 							break;
	// 						case 1260:
	// 							num30 = 26;
	// 							break;
	// 						case 1572:
	// 							num30 = 27;
	// 							break;
	// 						}
	// 					}
	// 					for (int num35 = 0; num35 < 2; num35++)
	// 					{
	// 						for (int num36 = 0; num36 < 2; num36++)
	// 						{
	// 							int x4 = num32 + num35;
	// 							int y4 = num33 + num36;
	// 							Main.tile[x4, y4].active(active: true);
	// 							Main.tile[x4, y4].slope(0);
	// 							Main.tile[x4, y4].halfBrick(halfBrick: false);
	// 							Main.tile[x4, y4].type = num31;
	// 							Main.tile[x4, y4].frameX = (short)(num35 * 18 + 36 * num30);
	// 							Main.tile[x4, y4].frameY = (short)(num36 * 18);
	// 						}
	// 						if (!Main.tile[num35, j + 2].active())
	// 						{
	// 							Main.tile[num35, j + 2].active(active: true);
	// 							if (!Main.tileSolid[Main.tile[num35, j + 2].type] || Main.tileSolidTop[Main.tile[num35, j + 2].type])
	// 							{
	// 								Main.tile[num35, j + 2].type = 0;
	// 							}
	// 						}
	// 						Main.tile[num35, j + 2].slope(0);
	// 						Main.tile[num35, j + 2].halfBrick(halfBrick: false);
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 28)
	// 				{
	// 					int num37 = Main.tile[i, j].frameX / 18;
	// 					int num38 = 0;
	// 					int num39 = i;
	// 					while (num37 >= 2)
	// 					{
	// 						num38++;
	// 						num37 -= 2;
	// 					}
	// 					num39 -= num37;
	// 					int num40 = Main.tile[i, j].frameY / 18;
	// 					int num41 = 0;
	// 					int num42 = j;
	// 					while (num40 >= 2)
	// 					{
	// 						num41++;
	// 						num40 -= 2;
	// 					}
	// 					num42 -= num40;
	// 					for (int num43 = 0; num43 < 2; num43++)
	// 					{
	// 						for (int num44 = 0; num44 < 2; num44++)
	// 						{
	// 							int x5 = num39 + num43;
	// 							int y5 = num42 + num44;
	// 							Main.tile[x5, y5].active(active: true);
	// 							Main.tile[x5, y5].slope(0);
	// 							Main.tile[x5, y5].halfBrick(halfBrick: false);
	// 							Main.tile[x5, y5].type = 28;
	// 							Main.tile[x5, y5].frameX = (short)(num43 * 18 + 36 * num38);
	// 							Main.tile[x5, y5].frameY = (short)(num44 * 18 + 36 * num41);
	// 						}
	// 						if (!Main.tile[num43, j + 2].active())
	// 						{
	// 							Main.tile[num43, j + 2].active(active: true);
	// 							if (!Main.tileSolid[Main.tile[num43, j + 2].type] || Main.tileSolidTop[Main.tile[num43, j + 2].type])
	// 							{
	// 								Main.tile[num43, j + 2].type = 0;
	// 							}
	// 						}
	// 						Main.tile[num43, j + 2].slope(0);
	// 						Main.tile[num43, j + 2].halfBrick(halfBrick: false);
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 26)
	// 				{
	// 					int num45 = Main.tile[i, j].frameX / 18;
	// 					int num46 = 0;
	// 					int num47 = i;
	// 					int num48 = j - Main.tile[i, j].frameY / 18;
	// 					while (num45 >= 3)
	// 					{
	// 						num46++;
	// 						num45 -= 3;
	// 					}
	// 					num47 -= num45;
	// 					num46 = ((drunkWorldGen ? (Main.tile[i, j].wall == 83) : crimson) ? 1 : 0);
	// 					for (int num49 = 0; num49 < 3; num49++)
	// 					{
	// 						for (int num50 = 0; num50 < 2; num50++)
	// 						{
	// 							int x6 = num47 + num49;
	// 							int y6 = num48 + num50;
	// 							Main.tile[x6, y6].active(active: true);
	// 							Main.tile[x6, y6].slope(0);
	// 							Main.tile[x6, y6].halfBrick(halfBrick: false);
	// 							Main.tile[x6, y6].type = 26;
	// 							Main.tile[x6, y6].frameX = (short)(num49 * 18 + 54 * num46);
	// 							Main.tile[x6, y6].frameY = (short)(num50 * 18);
	// 						}
	// 						if (!Main.tile[num47 + num49, num48 + 2].active() || !Main.tileSolid[Main.tile[num47 + num49, num48 + 2].type] || Main.tileSolidTop[Main.tile[num47 + num49, num48 + 2].type])
	// 						{
	// 							Main.tile[num47 + num49, num48 + 2].active(active: true);
	// 							if (!TileID.Sets.Platforms[Main.tile[num47 + num49, num48 + 2].type])
	// 							{
	// 								if (Main.tile[num47 + num49, num48 + 2].type == 484)
	// 								{
	// 									Main.tile[num47 + num49, num48 + 2].type = 397;
	// 								}
	// 								else if (TileID.Sets.Boulders[Main.tile[num47 + num49, num48 + 2].type] || !Main.tileSolid[Main.tile[num47 + num49, num48 + 2].type] || Main.tileSolidTop[Main.tile[num47 + num49, num48 + 2].type])
	// 								{
	// 									Main.tile[num47 + num49, num48 + 2].type = 0;
	// 								}
	// 							}
	// 						}
	// 						Main.tile[num47 + num49, num48 + 2].slope(0);
	// 						Main.tile[num47 + num49, num48 + 2].halfBrick(halfBrick: false);
	// 						if (Main.tile[num47 + num49, num48 + 3].type == 28 && Main.tile[num47 + num49, num48 + 3].frameY % 36 >= 18)
	// 						{
	// 							Main.tile[num47 + num49, num48 + 3].type = 0;
	// 							Main.tile[num47 + num49, num48 + 3].active(active: false);
	// 						}
	// 					}
	// 					for (int num51 = 0; num51 < 3; num51++)
	// 					{
	// 						if ((Main.tile[num47 - 1, num48 + num51].type == 28 || Main.tile[num47 - 1, num48 + num51].type == 12 || Main.tile[num47 - 1, num48 + num51].type == 639) && Main.tile[num47 - 1, num48 + num51].frameX % 36 < 18)
	// 						{
	// 							Main.tile[num47 - 1, num48 + num51].type = 0;
	// 							Main.tile[num47 - 1, num48 + num51].active(active: false);
	// 						}
	// 						if ((Main.tile[num47 + 3, num48 + num51].type == 28 || Main.tile[num47 + 3, num48 + num51].type == 12 || Main.tile[num47 - 1, num48 + num51].type == 639) && Main.tile[num47 + 3, num48 + num51].frameX % 36 >= 18)
	// 						{
	// 							Main.tile[num47 + 3, num48 + num51].type = 0;
	// 							Main.tile[num47 + 3, num48 + num51].active(active: false);
	// 						}
	// 					}
	// 				}
	// 				if (Main.tile[i, j].type == 237 && Main.tile[i, j + 1].type == 232)
	// 				{
	// 					Main.tile[i, j + 1].type = 226;
	// 				}
	// 				if (Main.tile[i, j].wall == 87)
	// 				{
	// 					Main.tile[i, j].liquid = 0;
	// 				}
	// 			}
	// 		}
	// 	});
	IL_0fc1: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0fc6: ldstr "Tile Cleanup"
	IL_0fcb: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_98'
	IL_0fd0: dup
	IL_0fd1: brtrue.s IL_0fea

	// (no C# code)
	IL_0fd3: pop
	IL_0fd4: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_0fd9: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_98'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_0fdf: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_0fe4: dup
	IL_0fe5: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_98'

	// 	AddGenerationPass("Lihzahrd Altars", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 0; i < 3; i++)
	// 		{
	// 			for (int j = 0; j < 2; j++)
	// 			{
	// 				int x = GenVars.lAltarX + i;
	// 				int y = GenVars.lAltarY + j;
	// 				Main.tile[x, y].active(active: true);
	// 				Main.tile[x, y].type = 237;
	// 				Main.tile[x, y].frameX = (short)(i * 18);
	// 				Main.tile[x, y].frameY = (short)(j * 18);
	// 			}
	// 			Main.tile[GenVars.lAltarX + i, GenVars.lAltarY + 2].active(active: true);
	// 			Main.tile[GenVars.lAltarX + i, GenVars.lAltarY + 2].slope(0);
	// 			Main.tile[GenVars.lAltarX + i, GenVars.lAltarY + 2].halfBrick(halfBrick: false);
	// 			Main.tile[GenVars.lAltarX + i, GenVars.lAltarY + 2].type = 226;
	// 		}
	// 		for (int k = 0; k < 3; k++)
	// 		{
	// 			for (int l = 0; l < 2; l++)
	// 			{
	// 				int i2 = GenVars.lAltarX + k;
	// 				int j2 = GenVars.lAltarY + l;
	// 				SquareTileFrame(i2, j2);
	// 			}
	// 		}
	// 	});
	IL_0fea: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_0fef: ldstr "Lihzahrd Altars"
	IL_0ff4: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_99'
	IL_0ff9: dup
	IL_0ffa: brtrue.s IL_1013

	// (no C# code)
	IL_0ffc: pop
	IL_0ffd: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_1002: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_99'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_1008: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_100d: dup
	IL_100e: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_99'

	// 	AddGenerationPass("Micro Biomes", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[76].Value + "..Dead Man's Chests";
	// 		_ = (double)(Main.maxTilesX * Main.maxTilesY) / 5040000.0;
	// 		double num = 10.0;
	// 		if (getGoodWorldGen || noTrapsWorldGen)
	// 		{
	// 			num *= 3.0;
	// 		}
	// 		DeadMansChestBiome deadMansChestBiome = GenVars.configuration.CreateBiome<DeadMansChestBiome>();
	// 		List<int> possibleChestsToTrapify = deadMansChestBiome.GetPossibleChestsToTrapify(GenVars.structures);
	// 		int random = passConfig.Get<WorldGenRange>("DeadManChests").GetRandom(genRand);
	// 		int num2 = 0;
	// 		int num3 = 3000;
	// 		Point origin = default(Point);
	// 		while (num2 < random && possibleChestsToTrapify.Count > 0)
	// 		{
	// 			num3--;
	// 			if (num3 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			int num4 = possibleChestsToTrapify[genRand.Next(possibleChestsToTrapify.Count)];
	// 			((Point)(ref origin))..ctor(Main.chest[num4].x, Main.chest[num4].y);
	// 			deadMansChestBiome.Place(origin, GenVars.structures);
	// 			num2++;
	// 			possibleChestsToTrapify.Remove(num4);
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Thin Ice";
	// 		progress.Set(1.0 / num);
	// 		if (!notTheBees || remixWorldGen)
	// 		{
	// 			ThinIceBiome thinIceBiome = GenVars.configuration.CreateBiome<ThinIceBiome>();
	// 			int random2 = passConfig.Get<WorldGenRange>("ThinIcePatchCount").GetRandom(genRand);
	// 			int num5 = 0;
	// 			int num6 = 1000;
	// 			int num7 = 0;
	// 			while (num7 < random2)
	// 			{
	// 				if (thinIceBiome.Place(RandomWorldPoint((int)Main.worldSurface + 20, 50, 200, 50), GenVars.structures))
	// 				{
	// 					num7++;
	// 					num5 = 0;
	// 				}
	// 				else
	// 				{
	// 					num5++;
	// 					if (num5 > num6)
	// 					{
	// 						num7++;
	// 						num5 = 0;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Sword Shrines";
	// 		progress.Set(0.1);
	// 		progress.Set(2.0 / num);
	// 		EnchantedSwordBiome enchantedSwordBiome = GenVars.configuration.CreateBiome<EnchantedSwordBiome>();
	// 		int num8 = passConfig.Get<WorldGenRange>("SwordShrineAttempts").GetRandom(genRand);
	// 		double num9 = passConfig.Get<double>("SwordShrinePlacementChance");
	// 		if (tenthAnniversaryWorldGen)
	// 		{
	// 			num8 *= 2;
	// 			num9 /= 2.0;
	// 		}
	// 		Point origin2 = default(Point);
	// 		for (int i = 0; i < num8; i++)
	// 		{
	// 			if ((i == 0 && tenthAnniversaryWorldGen) || !(genRand.NextDouble() > num9))
	// 			{
	// 				int num10 = 0;
	// 				while (num10++ <= Main.maxTilesX)
	// 				{
	// 					origin2.Y = (int)GenVars.worldSurface + genRand.Next(50, 100);
	// 					if (genRand.Next(2) == 0)
	// 					{
	// 						origin2.X = genRand.Next(50, (int)((double)Main.maxTilesX * 0.3));
	// 					}
	// 					else
	// 					{
	// 						origin2.X = genRand.Next((int)((double)Main.maxTilesX * 0.7), Main.maxTilesX - 50);
	// 					}
	// 					if (enchantedSwordBiome.Place(origin2, GenVars.structures))
	// 					{
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Campsites";
	// 		progress.Set(0.2);
	// 		progress.Set(3.0 / num);
	// 		if (!notTheBees || remixWorldGen)
	// 		{
	// 			CampsiteBiome campsiteBiome = GenVars.configuration.CreateBiome<CampsiteBiome>();
	// 			int random3 = passConfig.Get<WorldGenRange>("CampsiteCount").GetRandom(genRand);
	// 			num3 = 1000;
	// 			int num11 = 0;
	// 			while (num11 < random3)
	// 			{
	// 				num3--;
	// 				if (num3 <= 0)
	// 				{
	// 					break;
	// 				}
	// 				if (campsiteBiome.Place(RandomWorldPoint((int)Main.worldSurface, beachDistance, 200, beachDistance), GenVars.structures))
	// 				{
	// 					num11++;
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Explosive Traps";
	// 		progress.Set(4.0 / num);
	// 		if (!notTheBees || remixWorldGen)
	// 		{
	// 			MiningExplosivesBiome miningExplosivesBiome = GenVars.configuration.CreateBiome<MiningExplosivesBiome>();
	// 			int num12 = passConfig.Get<WorldGenRange>("ExplosiveTrapCount").GetRandom(genRand);
	// 			if ((getGoodWorldGen || noTrapsWorldGen) && !notTheBees)
	// 			{
	// 				num12 = (int)((double)num12 * 1.5);
	// 			}
	// 			num3 = 3000;
	// 			int num13 = 0;
	// 			while (num13 < num12)
	// 			{
	// 				num3--;
	// 				if (num3 <= 0)
	// 				{
	// 					break;
	// 				}
	// 				if (remixWorldGen)
	// 				{
	// 					if (miningExplosivesBiome.Place(RandomWorldPoint((int)Main.worldSurface, beachDistance, (int)GenVars.rockLayer, beachDistance), GenVars.structures))
	// 					{
	// 						num13++;
	// 					}
	// 				}
	// 				else if (miningExplosivesBiome.Place(RandomWorldPoint((int)GenVars.rockLayer, beachDistance, 200, beachDistance), GenVars.structures))
	// 				{
	// 					num13++;
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Living Trees";
	// 		progress.Set(0.3);
	// 		progress.Set(5.0 / num);
	// 		MahoganyTreeBiome mahoganyTreeBiome = GenVars.configuration.CreateBiome<MahoganyTreeBiome>();
	// 		int random4 = passConfig.Get<WorldGenRange>("LivingTreeCount").GetRandom(genRand);
	// 		int num14 = 0;
	// 		int num15 = 0;
	// 		while (num14 < random4 && num15 < 20000)
	// 		{
	// 			if (mahoganyTreeBiome.Place(RandomWorldPoint((int)Main.worldSurface + 50, 50, 500, 50), GenVars.structures))
	// 			{
	// 				num14++;
	// 			}
	// 			num15++;
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Long Minecart Tracks";
	// 		progress.Set(0.4);
	// 		progress.Set(6.0 / num);
	// 		progress.Set(7.0 / num);
	// 		TrackGenerator trackGenerator = new TrackGenerator();
	// 		int random5 = passConfig.Get<WorldGenRange>("LongTrackCount").GetRandom(genRand);
	// 		WorldGenRange worldGenRange = passConfig.Get<WorldGenRange>("LongTrackLength");
	// 		int maxTilesX = Main.maxTilesX;
	// 		int num16 = 0;
	// 		int num17 = 0;
	// 		while (num17 < random5)
	// 		{
	// 			if (trackGenerator.Place(RandomWorldPoint((int)Main.worldSurface, 10, 200, 10), worldGenRange.ScaledMinimum, worldGenRange.ScaledMaximum))
	// 			{
	// 				num17++;
	// 				num16 = 0;
	// 			}
	// 			else
	// 			{
	// 				num16++;
	// 				if (num16 > maxTilesX)
	// 				{
	// 					num17++;
	// 					num16 = 0;
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Standard Minecart Tracks";
	// 		progress.Set(8.0 / num);
	// 		random5 = passConfig.Get<WorldGenRange>("StandardTrackCount").GetRandom(genRand);
	// 		worldGenRange = passConfig.Get<WorldGenRange>("StandardTrackLength");
	// 		num16 = 0;
	// 		int num18 = 0;
	// 		while (num18 < random5)
	// 		{
	// 			if (trackGenerator.Place(RandomWorldPoint((int)Main.worldSurface, 10, 200, 10), worldGenRange.ScaledMinimum, worldGenRange.ScaledMaximum))
	// 			{
	// 				num18++;
	// 				num16 = 0;
	// 			}
	// 			else
	// 			{
	// 				num16++;
	// 				if (num16 > maxTilesX)
	// 				{
	// 					num18++;
	// 					num16 = 0;
	// 				}
	// 			}
	// 		}
	// 		progress.Message = Lang.gen[76].Value + "..Lava Traps";
	// 		progress.Set(9.0 / num);
	// 		if (!notTheBees)
	// 		{
	// 			double num19 = (double)Main.maxTilesX * 0.02;
	// 			if (noTrapsWorldGen)
	// 			{
	// 				num *= 5.0;
	// 			}
	// 			else if (getGoodWorldGen)
	// 			{
	// 				num *= 2.0;
	// 			}
	// 			for (int j = 0; (double)j < num19; j++)
	// 			{
	// 				for (int k = 0; k < 10150; k++)
	// 				{
	// 					int x = genRand.Next(200, Main.maxTilesX - 200);
	// 					int y = genRand.Next(GenVars.lavaLine - 100, Main.maxTilesY - 210);
	// 					if (placeLavaTrap(x, y))
	// 					{
	// 						break;
	// 					}
	// 				}
	// 			}
	// 		}
	// 		progress.Set(1.0);
	// 	});
	IL_1013: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_1018: ldstr "Micro Biomes"
	IL_101d: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_100'
	IL_1022: dup
	IL_1023: brtrue.s IL_103c

	// (no C# code)
	IL_1025: pop
	IL_1026: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_102b: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_100'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_1031: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_1036: dup
	IL_1037: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_100'

	// 	AddGenerationPass("Water Plants", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
	// 		progress.Message = Lang.gen[88].Value;
	// 		int num = (int)Main.worldSurface;
	// 		if (remixWorldGen)
	// 		{
	// 			num = Main.maxTilesY - 200;
	// 		}
	// 		for (int i = 20; i < Main.maxTilesX - 20; i++)
	// 		{
	// 			progress.Set((double)i / (double)Main.maxTilesX);
	// 			for (int j = 1; j < num; j++)
	// 			{
	// 				if (genRand.Next(5) == 0 && Main.tile[i, j].liquid > 0)
	// 				{
	// 					if (!Main.tile[i, j].active())
	// 					{
	// 						if (genRand.Next(2) == 0)
	// 						{
	// 							PlaceLilyPad(i, j);
	// 						}
	// 						else
	// 						{
	// 							Point val = PlaceCatTail(i, j);
	// 							if (InWorld(val.X, val.Y))
	// 							{
	// 								int num2 = genRand.Next(14);
	// 								for (int k = 0; k < num2; k++)
	// 								{
	// 									GrowCatTail(val.X, val.Y);
	// 								}
	// 								SquareTileFrame(val.X, val.Y);
	// 							}
	// 						}
	// 					}
	// 					if ((!Main.tile[i, j].active() || Main.tile[i, j].type == 61 || Main.tile[i, j].type == 74) && PlaceBamboo(i, j))
	// 					{
	// 						int num3 = genRand.Next(10, 20);
	// 						for (int l = 0; l < num3 && PlaceBamboo(i, j - l); l++)
	// 						{
	// 						}
	// 					}
	// 				}
	// 			}
	// 			int num4 = Main.UnderworldLayer;
	// 			while ((double)num4 > Main.worldSurface)
	// 			{
	// 				if (Main.tile[i, num4].type == 53 && genRand.Next(3) != 0)
	// 				{
	// 					GrowCheckSeaweed(i, num4);
	// 				}
	// 				else if (Main.tile[i, num4].type == 549)
	// 				{
	// 					GrowCheckSeaweed(i, num4);
	// 				}
	// 				num4--;
	// 			}
	// 		}
	// 	});
	IL_103c: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_1041: ldstr "Water Plants"
	IL_1046: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_101'
	IL_104b: dup
	IL_104c: brtrue.s IL_1065

	// (no C# code)
	IL_104e: pop
	IL_104f: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_1054: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_101'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_105a: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_105f: dup
	IL_1060: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_101'

	// 	AddGenerationPass("Stalac", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		progress.Set(1.0);
	// 		for (int i = 20; i < Main.maxTilesX - 20; i++)
	// 		{
	// 			for (int j = (int)Main.worldSurface; j < Main.maxTilesY - 20; j++)
	// 			{
	// 				if ((Main.tenthAnniversaryWorld || drunkWorldGen || genRand.Next(5) == 0) && Main.tile[i, j - 1].liquid == 0)
	// 				{
	// 					int num = genRand.Next(7);
	// 					int treeTileType = 0;
	// 					switch (num)
	// 					{
	// 					case 0:
	// 						treeTileType = 583;
	// 						break;
	// 					case 1:
	// 						treeTileType = 584;
	// 						break;
	// 					case 2:
	// 						treeTileType = 585;
	// 						break;
	// 					case 3:
	// 						treeTileType = 586;
	// 						break;
	// 					case 4:
	// 						treeTileType = 587;
	// 						break;
	// 					case 5:
	// 						treeTileType = 588;
	// 						break;
	// 					case 6:
	// 						treeTileType = 589;
	// 						break;
	// 					}
	// 					TryGrowingTreeByType(treeTileType, i, j);
	// 				}
	// 				if (!oceanDepths(i, j) && !Main.tile[i, j].active() && genRand.Next(5) == 0)
	// 				{
	// 					if ((Main.tile[i, j - 1].type == 1 || Main.tile[i, j - 1].type == 147 || Main.tile[i, j - 1].type == 161 || Main.tile[i, j - 1].type == 25 || Main.tile[i, j - 1].type == 203 || Main.tileStone[Main.tile[i, j - 1].type] || Main.tileMoss[Main.tile[i, j - 1].type]) && !Main.tile[i, j].active() && !Main.tile[i, j + 1].active())
	// 					{
	// 						Main.tile[i, j - 1].slope(0);
	// 					}
	// 					if ((Main.tile[i, j + 1].type == 1 || Main.tile[i, j + 1].type == 147 || Main.tile[i, j + 1].type == 161 || Main.tile[i, j + 1].type == 25 || Main.tile[i, j + 1].type == 203 || Main.tileStone[Main.tile[i, j + 1].type] || Main.tileMoss[Main.tile[i, j + 1].type]) && !Main.tile[i, j].active() && !Main.tile[i, j - 1].active())
	// 					{
	// 						Main.tile[i, j + 1].slope(0);
	// 					}
	// 					PlaceTight(i, j);
	// 				}
	// 			}
	// 			for (int k = 5; k < (int)Main.worldSurface; k++)
	// 			{
	// 				if ((Main.tile[i, k - 1].type == 147 || Main.tile[i, k - 1].type == 161) && genRand.Next(5) == 0)
	// 				{
	// 					if (!Main.tile[i, k].active() && !Main.tile[i, k + 1].active())
	// 					{
	// 						Main.tile[i, k - 1].slope(0);
	// 					}
	// 					PlaceTight(i, k);
	// 				}
	// 				if ((Main.tile[i, k - 1].type == 25 || Main.tile[i, k - 1].type == 203) && genRand.Next(5) == 0)
	// 				{
	// 					if (!Main.tile[i, k].active() && !Main.tile[i, k + 1].active())
	// 					{
	// 						Main.tile[i, k - 1].slope(0);
	// 					}
	// 					PlaceTight(i, k);
	// 				}
	// 				if ((Main.tile[i, k + 1].type == 25 || Main.tile[i, k + 1].type == 203) && genRand.Next(5) == 0)
	// 				{
	// 					if (!Main.tile[i, k].active() && !Main.tile[i, k - 1].active())
	// 					{
	// 						Main.tile[i, k + 1].slope(0);
	// 					}
	// 					PlaceTight(i, k);
	// 				}
	// 			}
	// 		}
	// 	});
	IL_1065: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_106a: ldstr "Stalac"
	IL_106f: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_102'
	IL_1074: dup
	IL_1075: brtrue.s IL_108e

	// (no C# code)
	IL_1077: pop
	IL_1078: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_107d: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_102'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_1083: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_1088: dup
	IL_1089: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_102'

	// 	AddGenerationPass("Remove Broken Traps", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
	// 		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
	// 		if (!noTrapsWorldGen || tenthAnniversaryWorldGen || notTheBees)
	// 		{
	// 			progress.Message = Lang.gen[82].Value;
	// 			List<Point> list = new List<Point>();
	// 			int num = 50;
	// 			for (int i = num; i < Main.maxTilesX - num; i++)
	// 			{
	// 				double value = (double)(i - num) / (double)(Main.maxTilesX - num * 2);
	// 				progress.Set(value);
	// 				for (int j = 50; j < Main.maxTilesY - 50; j++)
	// 				{
	// 					if (Main.tile[i, j].wire() && !list.Contains(new Point(i, j)))
	// 					{
	// 						ClearBrokenTraps(new Point(i, j), list);
	// 					}
	// 				}
	// 			}
	// 		}
	// 	});
	IL_108e: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_1093: ldstr "Remove Broken Traps"
	IL_1098: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_103'
	IL_109d: dup
	IL_109e: brtrue.s IL_10b7

	// (no C# code)
	IL_10a0: pop
	IL_10a1: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_10a6: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_103'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_10ac: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_10b1: dup
	IL_10b2: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_103'

	// 	AddGenerationPass("Final Cleanup", delegate(GenerationProgress progress, GameConfiguration passConfig)
	// 	{
	// 		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
	// 		Main.tileSolid[484] = false;
	// 		FillWallHolesInArea(new Rectangle(0, 0, Main.maxTilesX, (int)Main.worldSurface));
	// 		progress.Message = Lang.gen[86].Value;
	// 		for (int i = 0; i < Main.maxTilesX; i++)
	// 		{
	// 			progress.Set((double)i / (double)Main.maxTilesX);
	// 			int num = 0;
	// 			while (num < Main.maxTilesY)
	// 			{
	// 				Tile tile = Main.tile[i, num];
	// 				if (tile.active() && !SolidTile(i, num + 1))
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type != 53)
	// 					{
	// 						tile = Main.tile[i, num];
	// 						if (tile.type != 112)
	// 						{
	// 							tile = Main.tile[i, num];
	// 							if (tile.type != 234)
	// 							{
	// 								tile = Main.tile[i, num];
	// 								if (tile.type != 224)
	// 								{
	// 									tile = Main.tile[i, num];
	// 									if (tile.type != 123)
	// 									{
	// 										goto IL_06be;
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 					if ((double)num < Main.worldSurface + 10.0)
	// 					{
	// 						tile = Main.tile[i, num + 1];
	// 						if (!tile.active())
	// 						{
	// 							tile = Main.tile[i, num + 1];
	// 							if (tile.wall != 191 && !oceanDepths(i, num))
	// 							{
	// 								int num2 = 10;
	// 								int num3 = num + 1;
	// 								for (int j = num3; j < num3 + 10; j++)
	// 								{
	// 									tile = Main.tile[i, j];
	// 									if (tile.active())
	// 									{
	// 										tile = Main.tile[i, j];
	// 										if (tile.type == 314)
	// 										{
	// 											num2 = 0;
	// 											break;
	// 										}
	// 									}
	// 								}
	// 								while (true)
	// 								{
	// 									tile = Main.tile[i, num3];
	// 									if (tile.active() || num2 <= 0 || num3 >= Main.maxTilesY - 50)
	// 									{
	// 										break;
	// 									}
	// 									tile = Main.tile[i, num3 - 1];
	// 									tile.slope(0);
	// 									tile = Main.tile[i, num3 - 1];
	// 									tile.halfBrick(halfBrick: false);
	// 									tile = Main.tile[i, num3];
	// 									tile.active(active: true);
	// 									tile = Main.tile[i, num3];
	// 									ref ushort type = ref tile.type;
	// 									tile = Main.tile[i, num];
	// 									type = tile.type;
	// 									tile = Main.tile[i, num3];
	// 									tile.slope(0);
	// 									tile = Main.tile[i, num3];
	// 									tile.halfBrick(halfBrick: false);
	// 									num3++;
	// 									num2--;
	// 								}
	// 								if (num2 == 0)
	// 								{
	// 									tile = Main.tile[i, num3];
	// 									if (!tile.active())
	// 									{
	// 										tile = Main.tile[i, num];
	// 										switch (tile.type)
	// 										{
	// 										case 53:
	// 											tile = Main.tile[i, num3];
	// 											tile.type = 397;
	// 											tile = Main.tile[i, num3];
	// 											tile.active(active: true);
	// 											break;
	// 										case 112:
	// 											tile = Main.tile[i, num3];
	// 											tile.type = 398;
	// 											tile = Main.tile[i, num3];
	// 											tile.active(active: true);
	// 											break;
	// 										case 234:
	// 											tile = Main.tile[i, num3];
	// 											tile.type = 399;
	// 											tile = Main.tile[i, num3];
	// 											tile.active(active: true);
	// 											break;
	// 										case 224:
	// 											tile = Main.tile[i, num3];
	// 											tile.type = 147;
	// 											tile = Main.tile[i, num3];
	// 											tile.active(active: true);
	// 											break;
	// 										case 123:
	// 											tile = Main.tile[i, num3];
	// 											tile.type = 1;
	// 											tile = Main.tile[i, num3];
	// 											tile.active(active: true);
	// 											break;
	// 										}
	// 										goto IL_0690;
	// 									}
	// 								}
	// 								tile = Main.tile[i, num3];
	// 								if (tile.active())
	// 								{
	// 									bool[] tileSolid = Main.tileSolid;
	// 									tile = Main.tile[i, num3];
	// 									if (tileSolid[tile.type])
	// 									{
	// 										bool[] tileSolidTop = Main.tileSolidTop;
	// 										tile = Main.tile[i, num3];
	// 										if (!tileSolidTop[tile.type])
	// 										{
	// 											tile = Main.tile[i, num3];
	// 											tile.slope(0);
	// 											tile = Main.tile[i, num3];
	// 											tile.halfBrick(halfBrick: false);
	// 										}
	// 									}
	// 								}
	// 								goto IL_0690;
	// 							}
	// 						}
	// 					}
	// 					bool[] tileSolid2 = Main.tileSolid;
	// 					tile = Main.tile[i, num + 1];
	// 					if (tileSolid2[tile.type])
	// 					{
	// 						bool[] tileSolidTop2 = Main.tileSolidTop;
	// 						tile = Main.tile[i, num + 1];
	// 						if (!tileSolidTop2[tile.type])
	// 						{
	// 							tile = Main.tile[i, num + 1];
	// 							if (!tile.topSlope())
	// 							{
	// 								tile = Main.tile[i, num + 1];
	// 								if (!tile.halfBrick())
	// 								{
	// 									goto IL_05aa;
	// 								}
	// 							}
	// 							tile = Main.tile[i, num + 1];
	// 							tile.slope(0);
	// 							tile = Main.tile[i, num + 1];
	// 							tile.halfBrick(halfBrick: false);
	// 							goto IL_0690;
	// 						}
	// 					}
	// 					goto IL_05aa;
	// 				}
	// 				goto IL_06be;
	// 				IL_05aa:
	// 				tile = Main.tile[i, num];
	// 				switch (tile.type)
	// 				{
	// 				case 53:
	// 					tile = Main.tile[i, num];
	// 					tile.type = 397;
	// 					break;
	// 				case 112:
	// 					tile = Main.tile[i, num];
	// 					tile.type = 398;
	// 					break;
	// 				case 234:
	// 					tile = Main.tile[i, num];
	// 					tile.type = 399;
	// 					break;
	// 				case 224:
	// 					tile = Main.tile[i, num];
	// 					tile.type = 147;
	// 					break;
	// 				case 123:
	// 					tile = Main.tile[i, num];
	// 					tile.type = 1;
	// 					break;
	// 				}
	// 				goto IL_0690;
	// 				IL_0753:
	// 				tile = Main.tile[i, num];
	// 				if (tile.type != 485)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type != 187)
	// 					{
	// 						tile = Main.tile[i, num];
	// 						if (tile.type != 165)
	// 						{
	// 							goto IL_07bb;
	// 						}
	// 					}
	// 				}
	// 				TileFrame(i, num);
	// 				goto IL_07bb;
	// 				IL_0825:
	// 				tile = Main.tile[i, num];
	// 				if (tile.type == 26)
	// 				{
	// 					TileFrame(i, num);
	// 				}
	// 				bool[] isATreeTrunk = TileID.Sets.IsATreeTrunk;
	// 				tile = Main.tile[i, num];
	// 				if (!isATreeTrunk[tile.type])
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type != 323)
	// 					{
	// 						goto IL_0896;
	// 					}
	// 				}
	// 				TileFrame(i, num);
	// 				goto IL_0896;
	// 				IL_0690:
	// 				tile = Main.tile[i, num - 1];
	// 				if (tile.type == 323)
	// 				{
	// 					TileFrame(i, num - 1);
	// 				}
	// 				goto IL_06be;
	// 				IL_07bb:
	// 				tile = Main.tile[i, num];
	// 				if (tile.type == 28)
	// 				{
	// 					TileFrame(i, num);
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.type != 10)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type != 11)
	// 					{
	// 						goto IL_0825;
	// 					}
	// 				}
	// 				TileFrame(i, num);
	// 				goto IL_0825;
	// 				IL_0896:
	// 				tile = Main.tile[i, num];
	// 				if (tile.type == 137)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					tile.slope(0);
	// 					tile = Main.tile[i, num];
	// 					tile.halfBrick(halfBrick: false);
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.active())
	// 				{
	// 					bool[] boulders = TileID.Sets.Boulders;
	// 					tile = Main.tile[i, num];
	// 					if (boulders[tile.type])
	// 					{
	// 						tile = Main.tile[i, num];
	// 						int num4 = tile.frameX / 18;
	// 						int num5 = i;
	// 						num5 -= num4;
	// 						tile = Main.tile[i, num];
	// 						int num6 = tile.frameY / 18;
	// 						int num7 = num;
	// 						num7 -= num6;
	// 						bool flag = false;
	// 						for (int k = 0; k < 2; k++)
	// 						{
	// 							Tile tile2 = Main.tile[num5 + k, num7 - 1];
	// 							if (tile2 != null && tile2.active() && tile2.type == 26)
	// 							{
	// 								flag = true;
	// 								break;
	// 							}
	// 							for (int l = 0; l < 2; l++)
	// 							{
	// 								int x = num5 + k;
	// 								int y = num7 + l;
	// 								tile = Main.tile[x, y];
	// 								tile.active(active: true);
	// 								tile = Main.tile[x, y];
	// 								tile.slope(0);
	// 								tile = Main.tile[x, y];
	// 								tile.halfBrick(halfBrick: false);
	// 								tile = Main.tile[x, y];
	// 								ref ushort type2 = ref tile.type;
	// 								tile = Main.tile[i, num];
	// 								type2 = tile.type;
	// 								tile = Main.tile[x, y];
	// 								tile.frameX = (short)(k * 18);
	// 								tile = Main.tile[x, y];
	// 								tile.frameY = (short)(l * 18);
	// 							}
	// 						}
	// 						if (flag)
	// 						{
	// 							ushort num8 = 0;
	// 							tile = Main.tile[i, num];
	// 							if (tile.type == 484)
	// 							{
	// 								num8 = 397;
	// 							}
	// 							for (int m = 0; m < 2; m++)
	// 							{
	// 								for (int n = 0; n < 2; n++)
	// 								{
	// 									int x2 = num5 + m;
	// 									int y2 = num7 + n;
	// 									tile = Main.tile[x2, y2];
	// 									tile.active(active: true);
	// 									tile = Main.tile[x2, y2];
	// 									tile.slope(0);
	// 									tile = Main.tile[x2, y2];
	// 									tile.halfBrick(halfBrick: false);
	// 									tile = Main.tile[x2, y2];
	// 									tile.type = num8;
	// 									tile = Main.tile[x2, y2];
	// 									tile.frameX = 0;
	// 									tile = Main.tile[x2, y2];
	// 									tile.frameY = 0;
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.type == 323)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.liquid > 0)
	// 					{
	// 						KillTile(i, num);
	// 					}
	// 				}
	// 				bool[] wallDungeon = Main.wallDungeon;
	// 				tile = Main.tile[i, num];
	// 				if (wallDungeon[tile.wall])
	// 				{
	// 					tile = Main.tile[i, num];
	// 					tile.lava(lava: false);
	// 					tile = Main.tile[i, num];
	// 					if (tile.active())
	// 					{
	// 						tile = Main.tile[i, num];
	// 						if (tile.type == 56)
	// 						{
	// 							KillTile(i, num);
	// 							tile = Main.tile[i, num];
	// 							tile.lava(lava: false);
	// 							tile = Main.tile[i, num];
	// 							tile.liquid = byte.MaxValue;
	// 						}
	// 					}
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.active())
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type == 314)
	// 					{
	// 						int num9 = 15;
	// 						int num10 = 1;
	// 						int num11 = num;
	// 						while (num - num11 < num9)
	// 						{
	// 							tile = Main.tile[i, num11];
	// 							tile.liquid = 0;
	// 							num11--;
	// 						}
	// 						for (num11 = num; num11 - num < num10; num11++)
	// 						{
	// 							tile = Main.tile[i, num11];
	// 							tile.liquid = 0;
	// 						}
	// 					}
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.active())
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.type == 332)
	// 					{
	// 						tile = Main.tile[i, num + 1];
	// 						if (!tile.active())
	// 						{
	// 							tile = Main.tile[i, num + 1];
	// 							tile.ClearEverything();
	// 							tile = Main.tile[i, num + 1];
	// 							tile.active(active: true);
	// 							tile = Main.tile[i, num + 1];
	// 							tile.type = 332;
	// 						}
	// 					}
	// 				}
	// 				if (i > beachDistance && i < Main.maxTilesX - beachDistance && (double)num < Main.worldSurface)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.liquid > 0)
	// 					{
	// 						tile = Main.tile[i, num];
	// 						if (tile.liquid < byte.MaxValue)
	// 						{
	// 							tile = Main.tile[i - 1, num];
	// 							if (tile.liquid < byte.MaxValue)
	// 							{
	// 								tile = Main.tile[i + 1, num];
	// 								if (tile.liquid < byte.MaxValue)
	// 								{
	// 									tile = Main.tile[i, num + 1];
	// 									if (tile.liquid < byte.MaxValue)
	// 									{
	// 										bool[] clouds = TileID.Sets.Clouds;
	// 										tile = Main.tile[i - 1, num];
	// 										if (!clouds[tile.type])
	// 										{
	// 											bool[] clouds2 = TileID.Sets.Clouds;
	// 											tile = Main.tile[i + 1, num];
	// 											if (!clouds2[tile.type])
	// 											{
	// 												bool[] clouds3 = TileID.Sets.Clouds;
	// 												tile = Main.tile[i, num + 1];
	// 												if (!clouds3[tile.type])
	// 												{
	// 													tile = Main.tile[i, num];
	// 													tile.liquid = 0;
	// 												}
	// 											}
	// 										}
	// 									}
	// 								}
	// 							}
	// 						}
	// 					}
	// 				}
	// 				num++;
	// 				continue;
	// 				IL_06be:
	// 				tile = Main.tile[i, num];
	// 				if (tile.wall != 187)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					if (tile.wall != 216)
	// 					{
	// 						goto IL_0753;
	// 					}
	// 				}
	// 				tile = Main.tile[i, num];
	// 				if (tile.liquid > 0 && !remixWorldGen)
	// 				{
	// 					tile = Main.tile[i, num];
	// 					tile.liquid = byte.MaxValue;
	// 					tile = Main.tile[i, num];
	// 					tile.lava(lava: true);
	// 				}
	// 				goto IL_0753;
	// 			}
	// 		}
	// 		int num12 = 0;
	// 		int num13 = 3;
	// 		num13 = GetWorldSize() switch
	// 		{
	// 			1 => 6, 
	// 			2 => 9, 
	// 			_ => 3, 
	// 		};
	// 		if (tenthAnniversaryWorldGen)
	// 		{
	// 			num13 *= 5;
	// 		}
	// 		int num14 = 50;
	// 		int minValue = num14;
	// 		int minValue2 = num14;
	// 		int maxValue = Main.maxTilesX - num14;
	// 		int maxValue2 = Main.maxTilesY - 200;
	// 		int num15 = 3000;
	// 		while (num12 < num13)
	// 		{
	// 			num15--;
	// 			if (num15 <= 0)
	// 			{
	// 				break;
	// 			}
	// 			int x3 = genRand.Next(minValue, maxValue);
	// 			int y3 = genRand.Next(minValue2, maxValue2);
	// 			Tile tile3 = Main.tile[x3, y3];
	// 			if (tile3.active() && tile3.type >= 0)
	// 			{
	// 				bool flag2 = TileID.Sets.Dirt[tile3.type];
	// 				if (notTheBees)
	// 				{
	// 					flag2 = flag2 || TileID.Sets.Mud[tile3.type];
	// 				}
	// 				if (flag2)
	// 				{
	// 					num12++;
	// 					tile3.ClearTile();
	// 					tile3.active(active: true);
	// 					tile3.type = 668;
	// 				}
	// 			}
	// 		}
	// 		if (noTrapsWorldGen)
	// 		{
	// 			FinishNoTraps();
	// 		}
	// 		if (Main.tenthAnniversaryWorld)
	// 		{
	// 			FinishTenthAnniversaryWorld();
	// 		}
	// 		if (drunkWorldGen)
	// 		{
	// 			FinishDrunkGen();
	// 		}
	// 		if (notTheBees)
	// 		{
	// 			NotTheBees();
	// 			FinishNotTheBees();
	// 		}
	// 		if (getGoodWorldGen)
	// 		{
	// 			FinishGetGoodWorld();
	// 		}
	// 		if (remixWorldGen)
	// 		{
	// 			FinishRemixWorld();
	// 		}
	// 		ShimmerCleanUp();
	// 		notTheBees = false;
	// 		getGoodWorldGen = false;
	// 		noTileActions = false;
	// 		Main.tileSolid[659] = true;
	// 		Main.tileSolid[GenVars.crackedType] = true;
	// 		Main.tileSolid[484] = true;
	// 		gen = false;
	// 		Main.AnglerQuestSwap();
	// 		skipFramingDuringGen = false;
	// 		progress.Message = Lang.gen[87].Value;
	// 	});
	IL_10b7: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_10bc: ldstr "Final Cleanup"
	IL_10c1: ldsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_104'
	IL_10c6: dup
	IL_10c7: brtrue.s IL_10e0

	// (no C# code)
	IL_10c9: pop
	IL_10ca: ldsfld class Terraria.WorldGen/'<>c' Terraria.WorldGen/'<>c'::'<>9'
	IL_10cf: ldftn instance void Terraria.WorldGen/'<>c'::'<AddGenPasses>b__288_104'(class Terraria.WorldBuilding.GenerationProgress, class Terraria.IO.GameConfiguration)
	IL_10d5: newobj instance void Terraria.GameContent.Generation.WorldGenLegacyMethod::.ctor(object, native int)
	IL_10da: dup
	IL_10db: stsfld class Terraria.GameContent.Generation.WorldGenLegacyMethod Terraria.WorldGen/'<>c'::'<>9__288_104'

	// }
	IL_10e0: call void Terraria.WorldGen::AddGenerationPass(string, class Terraria.GameContent.Generation.WorldGenLegacyMethod)
	IL_10e5: ret
} // end of method WorldGen::AddGenPasses

```