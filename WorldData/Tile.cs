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

        /// <summary>
        /// 对 Tilemap 的 get_Item 方法进行 IL（中间语言）修改的方法。
        /// 根据 WorldData.nowGenerating 的值决定返回不同的 Tile 数据。
        /// </summary>
        /// <param name="il">IL 上下文对象，用于操作中间语言指令。</param>
        private static void ILTileMapGet(ILContext il)
        {
            // 创建一个 ILCursor 实例，用于在 IL 代码中移动和插入指令
            var cursor = new ILCursor(il);
            cursor.EmitNop();
            var label_now = cursor.MarkLabel();
            cursor.GotoPrev(MoveType.Before, i => i.MatchNop());

            // 发射一个委托调用指令，执行委托方法并将返回值压入栈中
            // 该委托检查 WorldData.nowGenerating 是否等于 0
            cursor.EmitDelegate(() =>
            {
                if (WorldData.nowGenerating == 0)
                {
                    return false;
                }
                var stacktrace = new StackTrace(2, false);
                return stacktrace.GetFrame(0).GetType() == typeof(WorldGen);
            });
            cursor.EmitBrfalse(label_now);

            // 加载方法的 x 坐标到栈上
            cursor.EmitLdarg1();
            // 加载方法的 y 坐标到栈上
            cursor.EmitLdarg2();

            // 发射一个委托调用指令，执行委托方法并将返回值压入栈中
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
