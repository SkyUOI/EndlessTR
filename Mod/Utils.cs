using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;

namespace EndlessTR
{
    internal class Utils
    {
        public static bool IsCrimsonHeart(Tile block)
        {
            if (block.TileType == TileID.ShadowOrbs)
            {
                return (block.TileFrameX >= 36);
            }
            return false;
        }

        public class GetPath
        {
            public static string GetDirPath()
            {
                return Path.Combine(Path.GetDirectoryName(Main.worldPathName),
                                     Path.GetFileNameWithoutExtension(Main.worldPathName));
            }

            public static string GetWldPath(int i)
            {
                return Path.Combine(GetDirPath(), $"{Main.worldName}{i}.wld");
            }

            public static string GetWldBakPath(int i)
            {
                return Path.ChangeExtension(GetWldPath(i), "bak");
            }
        }
    }

}