using Microsoft.Extensions.Logging;
using Mono.Cecil;
using MonoMod.Cil;
using Stubble.Core.Contexts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace EndlessTR.WorldData
{
    internal class TileHack
    {

        public static void Hack()
        {
            // HackTileMapGet();
            HackTileMap();
        }

        private static void HackTileMap()
        {
            // 修改WorldGen, WorldFile中的Main.tile
            HackWorldGen();

            HackWorldFile();
        }

        /// <summary>
        /// 由原有的命名空间获取独立出的数据所处的命名空间
        /// Terraria.SomeClass  -> EndlessTR.WorldData.WorldGenState.SomeClass
        /// </summary>
        /// <param name="declaringType"> 原有的命名空间名 </param>
        /// <returns> 独立出的数据所处的命名空间名 </returns>
        private static string GetDeclaringType(string declaringType)
        {
            return "EndlessTR.WorldData.WorldGenState" + declaringType[8..];
        }

        /// <summary>
        /// 获取一个类中所有的方法, 包括嵌套类中的
        /// </summary>
        /// <param name="className"> 类的名称 </param>
        /// <returns> 方法的数组 </returns>
        private static MethodInfo[] DfsGetAllMethods(Type fType)
        {
            // 用于标识一个类是否被获取过
            Dictionary<Type, bool> methodMap = [];


            MethodInfo[] dfs(Type type)
            {
                if (methodMap.ContainsKey(type)) return [];
                if (type == null)
                {

                    throw new Exception("DfsGetAllMethods: type");
                }

                methodMap.Add(type, true);

                // 获取该类下直接的方法 
                IEnumerable<MethodInfo> methods = type.GetMethods();

                // 获取该类下的类
                var types = type.GetNestedTypes().ToArray();

                foreach (var sonType in types)
                {
                    // 获取嵌套类中的方法
                    // EndlessTR.Log.Debug($"DfsGetAllMethods: {type.FullName} -> {sonType.FullName}");
                    methods = methods.Concat(dfs(sonType));
                }

                return methods.ToArray();
            }

            return dfs(fType);
        }

        /// <summary>
        /// 将WorldFile类下的所有方法的get_Item替换
        /// </summary>
        private static void HackWorldFile()
        {
            var methods = DfsGetAllMethods(typeof(WorldFile)).Where(MethodValid);

            var WorldFileGetTile = typeof(GetTile).GetMethod("WorldFileGetTile");
            foreach (var method in methods)
            {
                try
                {
                    MonoModHooks.Modify(method, il =>
                    {
                        // EndlessTR.Log.Info($"Hack WorldFile method: {method.DeclaringType.FullName}.{method.Name}");
                        ILCursor cursor = new(il);
                        ReplaceMethod(cursor, ("Terraria.Tilemap", "get_Item", WorldFileGetTile));
                    });
                }
                catch
                {
                    throw new Exception($"HackWorldFile: methodName: {method.DeclaringType.FullName}.{method.Name}");
                }

            }
        }

        private static bool MethodValid(MethodInfo method)
        {
            return !method.DeclaringType.FullName.StartsWith("System") && !method.DeclaringType.FullName.StartsWith("Object")
                && !method.DeclaringType.FullName.StartsWith("Terraria.WorldGen+Hooks")
                && !method.IsAbstract
                && !method.IsVirtual;
        }

        private static void ReplaceMethod(ILCursor cursor, (string declaringType, string name, MethodInfo newMethod) method)
        {
            cursor.Index = 0;
            int cnt = 0;
            if (method.newMethod == null)
            {
                var EndlessTR = typeof(EndlessTR).Assembly;
                if (EndlessTR == null)
                {
                    throw new Exception("EndlessTR");
                }
                var type = EndlessTR.GetType(GetDeclaringType(method.declaringType));
                if (type == null)
                {
                    throw new Exception($" {GetDeclaringType(method.declaringType)}type");
                }
                method.newMethod = type.GetMethod(method.name, BindingFlags.Public | BindingFlags.Static);
                if (method.newMethod == null)
                {
                    throw new Exception($"ReplaceMethod: {GetDeclaringType(method.declaringType)}.{method.name}");
                }
            }
            while (cursor.TryGotoNext(i => i.MatchCall(out var t)
                            && t.DeclaringType.FullName == method.declaringType && t.Name == method.name))
            {
                ++cnt;
                cursor.Remove();
                cursor.EmitCall(method.newMethod);
            }
            // EndlessTR.Log.Info($"   finish replacing {cnt} {method.declaringType}.{method.name} with {method.newMethod.DeclaringType.FullName}.{method.newMethod.Name} in the method");
        }

        /// <summary>
        /// 对WorldGen中的所有方法进行il编辑, 替换某些字段和方法
        /// </summary>
        private static void HackWorldGen()
        {
            var methods = DfsGetAllMethods(typeof(WorldGen)).Where(MethodValid);
            var WorldGenGetTile = typeof(GetTile).GetMethod("WorldGenGetTile", BindingFlags.Static | BindingFlags.Public);
            foreach (var method in methods)
            {
                try
                {
                    // EndlessTR.Log.Info($"Hack WorldGen method: {method.DeclaringType.FullName}.{method.Name}");
                    MonoModHooks.Modify(method, il =>
                    {
                        ILCursor cursor = new ILCursor(il);
                        ReplaceMethods(cursor, [
                            ("Terraria.Tilemap", "get_Item", WorldGenGetTile),
                            ("Terraria.NPC", "ResetBadgerHatTime", null),
                            ("Terraria.Main", "ResetWindCounter", null),
                            ("Terraria.NPC", "ResetKillCount", null),
                            ("Terraria.Main", "checkXMas", null),
                            ("Terraria.Main", "checkHalloween", null),
                            ]);
                        // 修改世界生成时用到的各种变量
                        ReplaceVars(cursor,
                        [
                            ("Terraria.Main", "ladyBugRainBoost"),
                            ("Terraria.Main", "getGoodWorld"),
                            ("Terraria.Main", "drunkWorld"),
                            ("Terraria.Main", "tenthAnniversaryWorld"),
                            ("Terraria.Main", "dontStarveWorld"),
                            ("Terraria.Main", "notTheBeesWorld"),
                            ("Terraria.Main", "remixWorld"),
                            ("Terraria.Main", "noTrapsWorld"),
                            ("Terraria.Main", "zenithWorld"),
                            ("Terraria.Main", "afterPartyOfDoom"),
                            ("Terraria.Main", "shimmerAlpha"),
                            ("Terraria.Main", "shimmerDarken"),
                            ("Terraria.Main", "shimmerBrightenDelay"),
                            ("Terraria.NPC", "freeCake"),
                            ("Terraria.NPC", "mechQueen"),
                            ("Terraria.Main", "mapDelay"),
                            ("Terraria.Main", "waterStyle"),
                            ("Terraria.Main", "mapDelay"),
                            ("Terraria.Main", "waterStyle"),
                            ("Terraria.NPC", "EoCKilledToday"),
                            ("Terraria.NPC", "WoFKilledToday"),
                            ("Terraria.Main", "windCounter"),
                            ("Terraria.Main", "extremeWindCounter"),
                            ("Terraria.NPC", "killCount"),
                            ("Terraria.Main", "instance"),
                            ("Terraria.Main", "mapReady"),
                            ("Terraria.Main", "Map"),
                            ("Terraria.Main", "statusText"),
                            ("Terraria.Main", "ParticleSystem_World_OverPlayers"),
                            ("Terraria.Main", "ParticleSystem_World_BehindPlayers"),
                            ("Terraria.Main", "pumpkinMoon"),
                            ("Terraria.Main", "clearMap"),
                            ("Terraria.Main", "mapTime"),
                            ("Terraria.Main", "updateMap"),
                            ("Terraria.Main", "refreshMap"),
                            ("Terraria.Main", "eclipse"),
                            ("Terraria.Main", "slimeRain"),
                            ("Terraria.Main", "slimeRainTime"),
                            ("Terraria.Main", "slimeWarningTime"),
                            ("Terraria.Main", "sundialCooldown"),
                            ("Terraria.Main", "moondialCooldown"),
                            ("Terraria.Main", "fastForwardTimeToDawn"),
                            ("Terraria.Main", "fastForwardTimeToDusk"),
                            ("Terraria.NPC", "MoonLordCountdown"),
                            ("Terraria.NPC", "RevengeManager"),

                        ]);
                    });
                }
                catch
                {
                    throw new Exception($"HackWorldGen: methodName: {method.DeclaringType.Name}.{method.Name}");
                }

            }
        }

        private static void ReplaceMethods(ILCursor cursor, (string, string, MethodInfo)[] methods)
        {
            foreach ((string, string, MethodInfo) tuple3 in methods)
            {
                ReplaceMethod(cursor, tuple3);
            }
        }

        private static void ReplaceVar(ILCursor cursor, (string declaringType, string Name) var)
        {
            // EndlessTR.Log.Info($"replace var {var.declaringType}.{var.Name}");
            var type = typeof(EndlessTR).Assembly.GetType(GetDeclaringType(var.declaringType));
            if (type == null)
            {
                throw new Exception($"replaceVar: {GetDeclaringType(var.declaringType)} type");
            }

            var field = type.GetField(var.Name);
            if (field == null)
            {
                throw new Exception($"ReplaceVar {var.declaringType}.{var.Name}: field");
            }

            try
            {
                cursor.Index = 0;
                while (cursor.TryGotoNext(i => i.MatchStfld(out var t)
                            && t.DeclaringType.FullName == var.declaringType && t.Name == var.Name))
                {
                    cursor.Remove();
                    cursor.EmitStfld(field);
                }
            }
            catch
            {
                throw new Exception($"TileHack.ReplaceVars Hack stfld {var.declaringType}.{var.Name} Error");
            }

            try
            {
                cursor.Index = 0;
                while (cursor.TryGotoNext(i => i.MatchStfld(out var t)
                            && t.DeclaringType.FullName == var.declaringType && t.Name == var.Name))
                {
                    cursor.Remove();
                    cursor.EmitStfld(field);
                }
            }
            catch
            {
                throw new Exception($"TileHack.ReplaceVars Hack ldfld {var.declaringType}.{var.Name} Error");
            }
        }

        private static void ReplaceVars(ILCursor cursor, (string, string)[] vars)
        {
            foreach ((string, string) pair in vars)
            {
                ReplaceVar(cursor, pair);
            }
        }

        private static void HackTileMapGet()
        {
            var flag = BindingFlags.Public | BindingFlags.Instance;
            var method = typeof(Tilemap).GetMethod("get_Item", flag, [typeof(int), typeof(int)]);
            MonoModHooks.Modify(method, ILTileMapGet);
        }

        private static bool CheckIsCalledByworldGen()
        {
            if (WorldData.nowGenerating == 0)
            {
                return false;
            }
            // throw new Exception("Invalid nowGenerating");
            // 获取调用栈信息，跳过当前方法和调用当前方法的方法
            var stackframe = new StackFrame(1, false);
            // 检查调用者的方法所属的类型是否为 WorldGen 类
            return stackframe.GetMethod().DeclaringType == typeof(WorldGen);
        }

        /// <summary>
        /// 对 Tilemap 的 get_Item 方法进行 IL（中间语言）修改的方法。
        /// 根据 WorldData.nowGenerating 的值以及调用者是否为 WorldGen 类，决定返回不同的 Tile 数据。
        /// </summary>
        /// <param name="il">IL 上下文对象，用于操作中间语言指令。</param>
        private static void ILTileMapGet(ILContext il)
        {
            // 创建一个 ILCursor 实例，用于在 IL 代码中移动和插入指令
            var cursor = new ILCursor(il);

            // 检查是否由 WorldGen 类调用，如果是，则返回 true，否则返回 false
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            cursor.EmitCall(typeof(TileHack).GetMethod("CheckIsCalledByworldGen", flag));
            cursor.EmitDelegate<Action<bool>>(x => { return; });

            // 保存当前光标下一条指令的引用，后续用于跳转回来
            var tmp = cursor.Next;

            // 将光标移动到原有代码之后
            // cursor.Goto(cursor.Instrs.Count - 1, MoveType.After);

            // 插入一个空操作指令（NOP），用于标记位置
            // cursor.EmitNop();

            // 将光标移动到上一个 NOP 指令之前
            // cursor.GotoPrev(MoveType.Before, i => i.MatchNop());

            // 标记当前位置，创建一个标签，指示WorldGen相关代码的起始位置
            // var label_now = cursor.MarkLabel();

            // 将光标移动到else分支里面，原有代码的前面
            // cursor.Goto(tmp, MoveType.Before);

            // 如果是WorldGen的调用，则跳转到WorldGen相关的代码
            // cursor.EmitBrtrue(label_now);

            // 移动到原有代码的后面，即新的WorldGen逻辑开头
            // cursor.Goto(cursor.Instrs.Count - 1, MoveType.After);

            // 接下来是WorldGen相关的新逻辑
            // 加载方法的 x 坐标到栈上
            // cursor.EmitLdarg1();
            // // 加载方法的 y 坐标到栈上
            // cursor.EmitLdarg2();

            // // 该委托根据 WorldData.nowGenerating、x 和 y 坐标从 WorldData.MapData 中获取 Tile 数据
            // cursor.EmitDelegate((int x, int y) =>
            // {
            //     return WorldData.MapData[WorldData.nowGenerating, x, y];
            // });

            // // 发射返回指令，将栈顶的值作为方法的返回值返回
            // cursor.EmitRet();
            // 打印 IL 代码的反编译结果，用于调试
            // throw new Exception(il.ToString());
        }
    }
}