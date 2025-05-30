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

    private static void BordersMovementIL(ILContext il)
    {
        var cursor = new ILCursor(il);
        cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0(), i => i.MatchLdflda(out var t) && t.Name == "position", i => i.MatchLdfld(out var t) && t.Name == "Y");
        var label = cursor.MarkLabel();
        cursor.Index = 0;
        cursor.EmitBr(label);
    }
}