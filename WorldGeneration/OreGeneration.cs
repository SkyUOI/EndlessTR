using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;

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
            WorldGen.ModifyPass((PassLegacy)WorldGen.VanillaGenPasses["Shinies"], ILInitialGeneration);
        }

        private static void ILInitialGeneration(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.EmitDelegate(() =>
            {
                WorldGen.drunkWorldGen = true;
            });
            cursor.Index = cursor.Instrs.Count - 1;
            cursor.EmitDelegate(() =>
            {
                WorldGen.drunkWorldGen = false;
            });
        }
    }
}