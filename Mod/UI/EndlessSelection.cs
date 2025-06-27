using Microsoft.CodeAnalysis.CSharp.Syntax;
using MonoMod.Cil;
using System;
using System.Reflection;
using Terraria;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;

namespace EndlessTR.UI
{
    class EndlessSelection
    {
        public static void Hack()
        {
            HackGetWorldPathFromName();
            HackWorldMigrate();
            HackWorldList();
            if (Main.dedServ)
            {
                return;
            }
            HackWorldCreation();
        }

        private static void HackGetWorldPathFromName()
        {
            var flag = BindingFlags.Public | BindingFlags.Static;
            var GetWorldPathFromName = typeof(Main).GetMethod("GetWorldPathFromName", flag);
            MonoModHooks.Modify(GetWorldPathFromName, ILGetWorldPathFromName);
        }

        private static void ILGetWorldPathFromName(ILContext il)
        {
            var cursor = new ILCursor(il);
            for (int i = 1; i <= 4; ++i)
            {
                cursor.GotoNext(MoveType.Before, i => i.MatchLdstr(out var s) && s == ".wld");
                cursor.Remove();
                cursor.EmitLdstr(".ewld");
            }
        }

        private static void HackWorldMigrate()
        {
            var flag = BindingFlags.NonPublic | BindingFlags.Instance;
            var WorldMigrate = typeof(UIWorldSelect).GetMethod("AddAutomaticWorldMigrationButtons", flag);
            MonoModHooks.Modify(WorldMigrate, ILWorldMigrate);
        }

        private static void ILWorldMigrate(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.GotoNext(MoveType.Before, i => i.MatchLdstr(out var s) && s == "tModLoader.MigrateWorldsMessage");
            cursor.Remove();
            cursor.EmitLdstr("Mods.EndlessTR.UI.WorldSelection.MigrateWorldsMessage");
        }

        private static void HackWorldCreation()
        {
            var flag = BindingFlags.NonPublic | BindingFlags.Instance;
            var newWorldClick = typeof(UIWorldSelect).GetMethod("NewWorldClick", flag);
            if (newWorldClick is null)
            {
                throw new Exception("Hacking NewWorldCLick");
            }
            MonoModHooks.Modify(newWorldClick, DifferentTypeWorldSelection.hook_to_load);
        }

        private static void HackWorldList()
        {
            var flag = BindingFlags.Public | BindingFlags.Static;
            var main = typeof(Main);
            var loadWorlds = main.GetMethod("LoadWorlds", flag);
            MonoModHooks.Modify(loadWorlds, ILLoadWorlds);

            flag = BindingFlags.NonPublic;
            var lambda = main.GetNestedType("<>c", flag);
            if (lambda is null)
            {
                throw new Exception($"Hacking LoadWorlds's lambda type. Lists: {main.GetNestedTypes(flag)}");
            }
            flag = BindingFlags.Instance | BindingFlags.NonPublic;
            var func = lambda.GetMethod("<LoadWorlds>b__1298_0", flag);
            if (func is null)
            {
                throw new Exception("Hacking LoadWorlds's lambda func");
            }
            MonoModHooks.Modify(func, ILLoadWorldsLambda);
        }

        private static void ILLoadWorlds(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.GotoNext(MoveType.Before, i => i.MatchLdstr(out var d) && d == "*.wld");
            cursor.Remove();
            cursor.EmitLdstr("*.ewld");
        }


        private static void ILLoadWorldsLambda(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.GotoNext(MoveType.Before, i => i.MatchLdstr(out var d) && d == ".wld");
            cursor.Remove();
            cursor.EmitLdstr(".ewld");
        }
    }
}