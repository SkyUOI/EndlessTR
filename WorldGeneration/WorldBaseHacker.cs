using MonoMod.Cil;
using System;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace EndlessTR.WorldGeneration;

public class Hacker
{
    public static void HackAllFunc()
    {
        HackInWorld();
        ModifyConsts();
    }

    private static void HackInWorld()
    {
        var flag = BindingFlags.Public | BindingFlags.Static;
        var method = typeof(WorldGen).GetMethod("InWorld", flag);
        if (method is null)
        {
            throw new Exception("InWorld");
        }
        MonoModHooks.Modify(method, InWorldIL);
    }

    private static void InWorldIL(ILContext il)
    {
        var cursor = new ILCursor(il);
        cursor.EmitLdarg0();
        cursor.EmitLdarg1();
        cursor.EmitLdarg2();
        cursor.EmitDelegate((int x, int y, int fluff) =>
        {
            if (!Main.mapInit)
            {
                // 初次生成，按照正常逻辑
                if (x < fluff || x >= Main.maxTilesX - fluff || y < fluff || y >= Main.maxTilesY - fluff)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        });
        cursor.EmitRet();
    }

    private static void HackEvilGneeration() {

    }

    private static void ModifyConsts()
    {
        Main.rightWorld = float.MinValue;
        Main.leftWorld = float.MaxValue;
    }
}
