using EndlessTR.UI;
using EndlessTR.WorldGeneration;
using log4net;
using Terraria.ModLoader;


namespace EndlessTR
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class EndlessTR : Mod
    {
        private static Mod mod;

        public static ILog Log
        {
            get
            {
                return mod.Logger;
            }
        }
        public override void Load()
        {
            mod = this;
            base.Load();
            ObjectHack.MainClone.Init();
            EndlessSelection.Hack();
            Hacker.HackAllFunc();
            Player.PlayerHacker.Hack();
            WorldData.TileHack.Hack();
            WorldData.WorldData.Hack();
            WorldData.Ewld.Hack();
        }

        public override void Unload()
        {
            base.Unload();
        }
    }
}
