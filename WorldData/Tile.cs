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
using Terraria.ModLoader;

namespace EndlessTR.WorldData
{
    internal class TileHack
    {
        public static void Hack()
        {
            HackTileMapGet();
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
            var stacktrace = new StackTrace(2, false);
            // 检查调用者的方法所属的类型是否为 WorldGen 类
            return stacktrace.GetFrame(0).GetMethod().DeclaringType == typeof(WorldGen);
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

            // 保存当前光标下一条指令的引用，后续用于跳转回来
            var tmp = cursor.Next;

            // 将光标移动到原有代码之后
            cursor.Goto(cursor.Instrs.Count - 1, MoveType.After);

            // 插入一个空操作指令（NOP），用于标记位置
            cursor.EmitNop();

            // 将光标移动到上一个 NOP 指令之前
            cursor.GotoPrev(MoveType.Before, i => i.MatchNop());

            // 标记当前位置，创建一个标签，指示WorldGen相关代码的起始位置
            var label_now = cursor.MarkLabel();

            // 将光标移动到else分支里面，原有代码的前面
            cursor.Goto(tmp, MoveType.Before);

            // 如果是WorldGen的调用，则跳转到WorldGen相关的代码
            cursor.EmitBrtrue(label_now);

            // 移动到原有代码的后面，即新的WorldGen逻辑开头
            cursor.Goto(cursor.Instrs.Count - 1, MoveType.After);

            // 接下来是WorldGen相关的新逻辑
            // 加载方法的 x 坐标到栈上
            cursor.EmitLdarg1();
            // 加载方法的 y 坐标到栈上
            cursor.EmitLdarg2();

            // 该委托根据 WorldData.nowGenerating、x 和 y 坐标从 WorldData.MapData 中获取 Tile 数据
            cursor.EmitDelegate((int x, int y) =>
            {
                return WorldData.MapData[WorldData.nowGenerating, x, y];
            });

            // 发射返回指令，将栈顶的值作为方法的返回值返回
            cursor.EmitRet();
            // 打印 IL 代码的反编译结果，用于调试
            // throw new Exception(il.ToString());
        }
    }
}