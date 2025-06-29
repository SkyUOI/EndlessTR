using EndlessTR.WorldGeneration;

var noiseMap = MapGeneration.Generate1DNoiseMap(8400);

for (int y = 0; y < noiseMap.Height; y++)
{
    Console.WriteLine(noiseMap[0, y]);
}