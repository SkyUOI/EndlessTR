using Mono.Cecil.Cil;
using MonoMod.Cil;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace EndlessTR.Player;

public class PlayerHacker
{
    public static void Hack()
    {
        HackBordersMovement();
        HackCameraUpdate();
    }

    private static void HackBordersMovement()
    {
        var flag = BindingFlags.Public | BindingFlags.Instance;
        var method = typeof(Terraria.Player).GetMethod("BordersMovement", flag);
        if (method is null)
        {
            throw new System.Exception("BordersMovement");
        }
        MonoModHooks.Modify(method, BordersMovementIL);
    }

    private static void HackCameraUpdate() {
        var flag = BindingFlags.NonPublic | BindingFlags.Instance;
        var method = typeof(Terraria.Main).GetMethod("DoDraw_UpdateCameraPosition", flag);
        if (method is null)
        {
            throw new System.Exception("DoDraw_UpdateCameraPosition");
        }
    }

    private static void BordersMovementIL(ILContext il)
    {
        var cursor = new ILCursor(il);
        cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0(), i => i.MatchLdflda(out var t) && t.Name == "position", i => i.MatchLdfld(out var t) && t.Name == "Y");
        var label = cursor.MarkLabel();
        cursor.Index = 0;
        cursor.EmitBr(label);
    }
}