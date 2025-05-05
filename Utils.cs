using System;
using System.Collections.Generic;
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
    }
}