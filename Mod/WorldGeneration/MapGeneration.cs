using SharpNoise;
using SharpNoise.Builders;
using SharpNoise.Modules;
using System;
using Terraria;
using Terraria.ID;

namespace EndlessTR.WorldGeneration;

public class MapGeneration
{
    const int Width = 8400;
    const int Height = 1200;
    static Tile[,] tilemap = new Tile[Width, Height];


    static public void GenerateAll()
    {
        GenerateHeightMap();

    }
    // 生成一维噪声图, 用于地形生成
    static public NoiseMap Generate1DNoiseMap(int width)
    {
        var noiseSource = new Perlin
        {
            Seed = new Random().Next(),
        };

        var noiseMap = new NoiseMap();
        var noiseMapBuilder = new PlaneNoiseMapBuilder
        {
            DestNoiseMap = noiseMap,
            SourceModule = noiseSource,
        };

        noiseMapBuilder.SetDestSize(width, 1);
        noiseMapBuilder.SetBounds(-10, 10, -10, 10);

        noiseMapBuilder.Build();

        return noiseMap;
    }

    // 根据生成的一维噪声图用土块填充基本的地形轮廓
    static public void GenerateHeightMap()
    {
        var heightMap = Generate1DNoiseMap(Width);

        for (int x = 0; x < heightMap.Width; x++)
        {
            int h = (int)Math.Clamp(Math.Round(heightMap[x, 0]), 0, 8400);
            for (int y = h; y < Height; ++y)
            {
                tilemap[x, y].TileType = TileID.Dirt;
            }  
        }

    }
    
}
