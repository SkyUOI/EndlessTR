using Humanizer;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using SteelSeries.GameSense;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Social;
using Terraria.UI;

namespace EndlessTR.UI
{
    public class DifferentTypeWorldSelection : UIState
    {
        private enum WorldDifficultyId
        {
            Normal,
            Expert,
            Master,
            Creative
        }
        public UIPanel mainPanel;
        public static bool Visible = false;

        private string _WorldName;
        private string _WorldSeed;
        private WorldDifficultyId _optionDifficulty;

        private GroupOptionButton<WorldDifficultyId>[] _difficultyButtons;

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
            UITextPanel<string> titlePanel = new UITextPanel<string>(Language.GetTextValue("Mods.EndlessTR.UI.WorldCreate.Title"), 1.5f);
            titlePanel.Width.Set(0f, 1f);     // 宽度占满父容器
            titlePanel.Height.Set(40f, 0f);   // 高度 40 像素
            titlePanel.BackgroundColor = new Color(0, 0, 100, 200); // 半透明黑色背景
            titlePanel.HAlign = 0.5f;         // 水平居中
            mainPanel.Append(titlePanel);

            // 添加世界名称和种子
            MakeNameAndSeedButtons(mainPanel);

            // 添加返回和创建按钮
            MakeBackAndCreatebuttons(mainPanel);

            // 添加难度选择按钮
            MakeWorldDifficultyOptions(mainPanel);

            Append(mainPanel);
        }

        private void MakeWorldDifficultyOptions(UIElement outerContainer)
        {
            WorldDifficultyId[] array = [
                WorldDifficultyId.Creative,
                WorldDifficultyId.Normal,
                WorldDifficultyId.Expert,
                WorldDifficultyId.Master
            ];

            LocalizedText[] array2 = [
                Language.GetText("UI.Creative"),
                Language.GetText("UI.Normal"),
                Language.GetText("UI.Expert"),
                Language.GetText("UI.Master")
            ];

            LocalizedText[] array3 = [
                Language.GetText("UI.WorldDescriptionCreative"),
                Language.GetText("UI.WorldDescriptionNormal"),
                Language.GetText("UI.WorldDescriptionExpert"),
                Language.GetText("UI.WorldDescriptionMaster")
            ];

            Color[] array4 = [
                Main.creativeModeColor,
                Color.White,
                Main.mcColor,
                Main.hcColor
            ];

            string[] array5 = [
                "Images/UI/WorldCreation/IconDifficultyCreative",
                "Images/UI/WorldCreation/IconDifficultyNormal",
                "Images/UI/WorldCreation/IconDifficultyExpert",
                "Images/UI/WorldCreation/IconDifficultyMaster"
            ];
            float usableWidthPercent = 1f;
            GroupOptionButton<WorldDifficultyId>[] array6 = new GroupOptionButton<WorldDifficultyId>[array.Length];
            for (int i = 0; i < array6.Length; i++)
            {
                GroupOptionButton<WorldDifficultyId> groupOptionButton = new GroupOptionButton<WorldDifficultyId>(array[i], array2[i], array3[i], array4[i], array5[i], 1f, 1f, 16f);
                groupOptionButton.Width = StyleDimension.FromPixelsAndPercent(-1 * (array6.Length - 1), 1f / (float)array6.Length * usableWidthPercent);
                groupOptionButton.Left = StyleDimension.FromPercent(1f - usableWidthPercent);
                groupOptionButton.HAlign = (float)i / (float)(array6.Length - 1);
                groupOptionButton.Top.Set(0f, 0.6f);
                groupOptionButton.OnLeftMouseDown += ClickDifficultyOption;
                groupOptionButton.SetSnapPoint("difficulty", i);
                outerContainer.Append(groupOptionButton);
                array6[i] = groupOptionButton;
            }

            _difficultyButtons = array6;

            SetDefaultOption();
        }

        private void SetDefaultOption()
        {
            GroupOptionButton<WorldDifficultyId>[] difficultyButtons = _difficultyButtons;
            for (int i = 0; i < difficultyButtons.Length; i++)
            {
                difficultyButtons[i].SetCurrentOption(WorldDifficultyId.Normal);
            }

            _optionDifficulty = WorldDifficultyId.Normal;

        }

        private void ClickDifficultyOption(UIMouseEvent evt, UIElement listeningElement)
        {
            GroupOptionButton<WorldDifficultyId> groupOptionButton = (GroupOptionButton<WorldDifficultyId>)listeningElement;
            _optionDifficulty = groupOptionButton.OptionValue;
            GroupOptionButton<WorldDifficultyId>[] difficultyButtons = _difficultyButtons;
            for (int i = 0; i < difficultyButtons.Length; i++)
            {
                difficultyButtons[i].SetCurrentOption(groupOptionButton.OptionValue);
            }

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
            uITextPanel2.OnLeftMouseDown += Click_NamingAndCreating;
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
            uICharacterNameButton.SetSnapPoint("Name", 0);
            mainPanel.Append(uICharacterNameButton);
            _worldNameButton = uICharacterNameButton;

            UICharacterNameButton uICharacterNameButton2 = new UICharacterNameButton(Language.GetText("UI.WorldCreationSeed"), Language.GetText("UI.WorldCreationSeedEmpty"), Language.GetText("UI.WorldDescriptionSeed"))
            {
                Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
                HAlign = 0f,
                VAlign = 0.5f,
                Left = new StyleDimension(0f, 0f),
                Top = StyleDimension.FromPixelsAndPercent(0f, 0f),
                DistanceFromTitleToOption = 29f
            };

            uICharacterNameButton2.OnLeftMouseDown += ClickSetSeed;
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

        private void Click_NamingAndCreating(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuOpen);
            if (string.IsNullOrEmpty(_WorldName))
            {
                _WorldName = "";
                Main.clrInput();
                UIVirtualKeyboard uIVirtualKeyboard = new UIVirtualKeyboard(Lang.menu[48].Value, "", OnFinishedNamingAndCreating, GoBackHere);
                uIVirtualKeyboard.SetMaxInputLength(27);
                Main.MenuUI.SetState(uIVirtualKeyboard);
            }
            else
            {
                FinishCreatingWorld();
            }
        }

        private void OnFinishedNamingAndCreating(string name)
        {
            OnFinishedSettingName(name);
            FinishCreatingWorld();
        }

        private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
            ((UIPanel)evt.Target).BackgroundColor = new Color(73, 94, 171);
            ((UIPanel)evt.Target).BorderColor = Colors.FancyUIFatButtonMouseOver;
        }

        private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
        {
            ((UIPanel)evt.Target).BackgroundColor = new Color(63, 82, 151) * 0.8f;
            ((UIPanel)evt.Target).BorderColor = Color.Black;
        }

        private void FinishCreatingWorld()
        {
            if (_WorldSeed == null)
            {
                _WorldSeed = "";
            }
            // large world size
            Main.maxTilesX = 8400;
            Main.maxTilesY = 2400;

            WorldGen.setWorldSize();
            switch (_optionDifficulty)
            {
                case WorldDifficultyId.Creative:
                    Main.GameMode = 3;
                    break;
                case WorldDifficultyId.Normal:
                    Main.GameMode = 0;
                    break;
                case WorldDifficultyId.Expert:
                    Main.GameMode = 1;
                    break;
                case WorldDifficultyId.Master:
                    Main.GameMode = 2;
                    break;
            }

            Main.ActiveWorldFileData = WorldFile.CreateMetadata(Main.worldName = _WorldName.Trim(), SocialAPI.Cloud != null && SocialAPI.Cloud.EnabledByDefault, Main.GameMode);
            if (_WorldSeed.Length == 0)
                Main.ActiveWorldFileData.SetSeedToRandom();
            else
                Main.ActiveWorldFileData.SetSeed(_WorldSeed);

            Main.menuMode = 10;
            WorldGen.CreateNewWorld();
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