using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EndlessTR.UI;
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
            HookWorldCreation();
            WorldGeneration.Hacker.HackAllFunc();
        }

        public override void Unload()
        {
            base.Unload();
        }

        private void HookWorldCreation()
        {
            if (Main.dedServ)
            {
                return;
            }
            var flag = BindingFlags.NonPublic | BindingFlags.Instance;
            var newWorldClick = typeof(UIWorldSelect).GetMethod("NewWorldClick", flag);
            if (newWorldClick is null)
            {
                throw new Exception("Hacking NewWorldCLick");
            }
            MonoModHooks.Modify(newWorldClick, DifferentTypeWorldSelection.hook_to_load);
        }

        private void HackWorldRelativeFuncs()
        {

        }
    }
}
