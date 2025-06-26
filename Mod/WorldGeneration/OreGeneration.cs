using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace EndlessTR.WorldGeneration
{
    internal class OreGeneration
    {
        public static void Hack()
        {
            HackInitialGeneration();
        }

        private static void HackInitialGeneration()
        {
            WorldGen.DetourPass((PassLegacy)WorldGen.VanillaGenPasses["Shinies"], OnOreGeneration);
        }

        private static void OnOreGeneration(WorldGen.orig_GenPassDetour orig, object self, GenerationProgress progress, GameConfiguration configuration)
        {
            WorldGen.drunkWorldGen = true;
            orig(self, progress, configuration);
            WorldGen.drunkWorldGen = false;
        }
    }
}