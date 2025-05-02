using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using Humanizer;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using SteelSeries.GameSense;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace EndlessTR.UI
{
    public class DifferentTypeWorldSelection : UIState
    {
        public UIPanel mainPanel;
        public static bool Visible = false;

        private string _WorldName;
        private string _WorldSeed;

        private UICharacterNameButton _worldNameButton;
        private UICharacterNameButton _worldSeedButton;

        public override void OnInitialize()
        {
            mainPanel = new UIPanel();
            mainPanel.SetPadding(5);
            mainPanel.Width.Set(400f, 0f);
            mainPanel.Height.Set(300f, 0f);
            mainPanel.HAlign = 0.5f;
            mainPanel.VAlign = 0.5f;


            // 添加正上方标题
            UITextPanel<string> titlePanel = new UITextPanel<string>("Create your endless world!", 1.5f);
            titlePanel.Width.Set(0f, 1f);     // 宽度占满父容器
            titlePanel.Height.Set(40f, 0f);   // 高度 40 像素
            titlePanel.BackgroundColor = new Color(0, 0, 100, 200); // 半透明黑色背景
            titlePanel.HAlign = 0.5f;         // 水平居中
            mainPanel.Append(titlePanel);

            // 添加世界名称和种子
            MakeNameAndSeedButtons(mainPanel);

            // 添加返回和创建按钮
            MakeBackAndCreatebuttons(mainPanel);

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

        private void MakeBackAndCreatebuttons(UIElement outerContainer)
        {
            UITextPanel<LocalizedText> uITextPanel = new UITextPanel<LocalizedText>(Language.GetText("UI.Back"), 0.5f, large: true)
            {
                Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f),
                Height = StyleDimension.FromPixels(50f),
                VAlign = 1f,
                HAlign = 0f,
            };

            uITextPanel.OnMouseOver += FadedMouseOver;
            uITextPanel.OnMouseOut += FadedMouseOut;
            uITextPanel.OnLeftMouseDown += Click_GoBack;
            uITextPanel.SetSnapPoint("Back", 0);
            outerContainer.Append(uITextPanel);
            UITextPanel<LocalizedText> uITextPanel2 = new UITextPanel<LocalizedText>(Language.GetText("UI.Create"), 0.5f, large: true)
            {
                Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f),
                Height = StyleDimension.FromPixels(50f),
                VAlign = 1f,
                HAlign = 1f,
            };

            uITextPanel2.OnMouseOver += FadedMouseOver;
            uITextPanel2.OnMouseOut += FadedMouseOut;
            // uITextPanel2.OnLeftMouseDown += Click_NamingAndCreating;
            uITextPanel2.SetSnapPoint("Create", 0);
            outerContainer.Append(uITextPanel2);
        }

        private void MakeNameAndSeedButtons(UIElement outerContainer)
        {
            UICharacterNameButton uICharacterNameButton = new UICharacterNameButton(Language.GetText("UI.WorldCreationName"), Language.GetText("UI.WorldCreationNameEmpty"), Language.GetText("UI.WorldDescriptionName"))
            {
                Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
                HAlign = 0f,
                VAlign = 0.3f,
                Left = new StyleDimension(0f, 0f),
                Top = StyleDimension.FromPixelsAndPercent(0.3f, 0f)
            };

            uICharacterNameButton.OnLeftMouseDown += ClickSetName;
            uICharacterNameButton.OnMouseOver += FadedMouseOver;
            uICharacterNameButton.OnMouseOut += FadedMouseOut;
            uICharacterNameButton.SetSnapPoint("Name", 0);
            mainPanel.Append(uICharacterNameButton);
            _worldNameButton = uICharacterNameButton;

            UICharacterNameButton uICharacterNameButton2 = new UICharacterNameButton(Language.GetText("UI.WorldCreationSeed"), Language.GetText("UI.WorldCreationSeedEmpty"), Language.GetText("UI.WorldDescriptionSeed"))
            {
                Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
                HAlign = 0f,
                VAlign = 0.6f,
                Left = new StyleDimension(0f, 0f),
                Top = StyleDimension.FromPixelsAndPercent(0f, 0f),
                DistanceFromTitleToOption = 29f
            };

            uICharacterNameButton2.OnLeftMouseDown += ClickSetSeed;
            uICharacterNameButton2.OnMouseOver += FadedMouseOver;
            uICharacterNameButton2.OnMouseOut += FadedMouseOut;
            uICharacterNameButton2.SetSnapPoint("Seed", 0);
            mainPanel.Append(uICharacterNameButton2);
            _worldSeedButton = uICharacterNameButton2;

        }

        private void ClickSetName(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
            Main.clrInput();
            UIVirtualKeyboard uIVirtualKeyboard = new UIVirtualKeyboard(Lang.menu[48].Value, "", OnFinishedSettingName, GoBackHere, 0, allowEmpty: true);
            uIVirtualKeyboard.SetMaxInputLength(27);
            Main.MenuUI.SetState(uIVirtualKeyboard);

        }

        private void ClickSetSeed(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
            Main.clrInput();
            UIVirtualKeyboard uIVirtualKeyboard = new UIVirtualKeyboard(Language.GetTextValue("UI.EnterSeed"), "", OnFinishedSettingSeed, GoBackHere, 0, allowEmpty: true);
            uIVirtualKeyboard.SetMaxInputLength(40);
            Main.MenuUI.SetState(uIVirtualKeyboard);
        }
        private void OnFinishedSettingName(string name)
        {
            _WorldName = name.Trim();
            UpdateInputFields();
            GoBackHere();
        }

        private void OnFinishedSettingSeed(string seed)
        {
            _WorldSeed = seed.Trim();
            // ProcessSeed(out var processedSeed);
            // _optionSeed = processedSeed;
            UpdateInputFields();
            // UpdateSliders();
            // UpdatePreviewPlate();
            GoBackHere();
        }

        private void UpdateInputFields()
        {
            _worldNameButton.SetContents(_WorldName);
            _worldNameButton.Recalculate();
            _worldNameButton.TrimDisplayIfOverElementDimensions(27);
            _worldNameButton.Recalculate();
            _worldSeedButton.SetContents(_WorldSeed);
            _worldSeedButton.Recalculate();
            _worldSeedButton.TrimDisplayIfOverElementDimensions(40);
            _worldSeedButton.Recalculate();
        }
        private void GoBackHere()
        {
            Main.MenuUI.SetState(this);
        }

        private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
            Main.OpenWorldSelectUI();
        }

        private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuOpen);
        }

        private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuClose);
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
                        if (DifferentTypeWorldSelection.Visible)
                        {
                            _interface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI
                ));
            }
        }
    }
}