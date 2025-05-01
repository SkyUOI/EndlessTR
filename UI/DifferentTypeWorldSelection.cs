using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using SteelSeries.GameSense;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;
using Terraria.UI;

namespace EndlessTR.UI
{
    public class DifferentTypeWorldSelection : UIState
    {
        public UIPanel mainPanel;

        public override void OnInitialize()
        {
            mainPanel = new UIPanel();
            mainPanel.SetPadding(5);
            mainPanel.Width.Set(400f, 0f);
            mainPanel.Height.Set(200f, 0f);
            mainPanel.HAlign = 0.5f;
            mainPanel.VAlign = 0.5f;


            // 添加正上方标题
            UITextPanel<string> titlePanel = new UITextPanel<string>("Welcome to EndlessTR!");
            titlePanel.Width.Set(0f, 1f);     // 宽度占满父容器
            titlePanel.Height.Set(40f, 0f);   // 高度 40 像素
            titlePanel.BackgroundColor = new Color(0, 0, 0, 200); // 半透明黑色背景
            titlePanel.HAlign = 0.5f;         // 水平居中
            mainPanel.Append(titlePanel);

            Append(mainPanel);
        }

        static public void hook_to_load(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.TryGotoNext(MoveType.Before, i => i.MatchLdsfld(out var field) && field.DeclaringType.FullName == "Terraria.Main" && field.Name == "MenuUI");
            cursor.EmitDelegate(() =>
            {
                Main.MenuUI.SetState(new DifferentTypeWorldSelection());
            });
            cursor.EmitRet();
        }
    }

    public class DifferentTypeWorldSelectionSystem : ModSystem
    {
        private UserInterface _interface;
        public DifferentTypeWorldSelection UI;

        public override void Load()
        {
            if (!Main.dedServ)
            {
                UI = new DifferentTypeWorldSelection();
                _interface = new UserInterface();
                _interface.SetState(UI);
            }
        }

        public override void Unload()
        {
            UI = null;
            _interface = null;
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name == "Vanilla: Mouse Text");
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "EndlessTR: DifferentTypeWorldSelection",
                    () =>
                    {
                        _interface.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI
                ));
            }
        }
    }
}