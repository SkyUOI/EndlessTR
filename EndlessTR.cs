using EndlessTR.UI;
using EndlessTR.WorldGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;

namespace EndlessTR
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class EndlessTR : Mod
    {
        public override void Load()
        {
            base.Load();
            EndlessSelection.Hack();
            Hacker.HackAllFunc();
            Player.PlayerHacker.Hack();
            WorldData.TileHack.Hack();
            WorldData.WorldData.Hack();
        }

        public override void Unload()
        {
            base.Unload();
        }


    }
}