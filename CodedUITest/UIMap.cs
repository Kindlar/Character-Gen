//namespace CodedUITest
//{
//    using System;
//    using System.Collections.Generic;
//    using System.CodeDom.Compiler;
//    using Microsoft.VisualStudio.TestTools.UITest.Extension;
//    using Microsoft.VisualStudio.TestTools.UITesting;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;
//    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
//    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
//    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
//    using MouseButtons = System.Windows.Forms.MouseButtons;
//    using System.Drawing;
//    using System.Windows.Input;
//    using System.Text.RegularExpressions;


//    public partial class UIMap
//    {
//        public void LaunchZachsCharacterGenerator()
//        {
//            ApplicationUnderTest zachsCharacterGeneraterApplication = ApplicationUnderTest.Launch(this.LaunchZachsCharacterGeneratorParams.ExePath, this.LaunchZachsCharacterGeneratorParams.AlternateExePath);
//        }

//        public void AssertZachsCharacterGeneratorIsLaunch()
//        {
//            #region Variable Declarations
//            WinTitleBar uIZachsCharacterGeneraTitleBar = this.UIZachsCharacterGeneraWindow.UIZachsCharacterGeneraTitleBar;
//            #endregion

//            Assert.AreEqual(this.AssertZachsCharacterGeneratorIsLaunchExpectedValues.UIZachsCharacterGeneraTitleBarControlType, uIZachsCharacterGeneraTitleBar.ControlType.ToString());
//        }

//        public void CloseZachsCharacterGenerator()
//        {
//            WinButton uICloseButton = this.UIZachsCharacterGeneraWindow.UIZachsCharacterGeneraTitleBar.UICloseButton;
//            Mouse.Click(uICloseButton, new Point(18, 4));
//        }

//        public void SelectRaceDwarf()
//        {
//            #region Variable Declarations
//            WinComboBox uIRaceComboBox = this.UIZachsCharacterGeneraWindow.UIRaceComboBoxWindow.RaceComboBox;
//            #endregion

//            uIRaceComboBox.SelectedItem = this.SelectRaveDwarfParams.UIRaceComboBoxComboBoxSelectedItem;
//        }

//        public void SelectClassBarbarian()
//        {
//            WinComboBox uiClassComboBox = this.UIZachsCharacterGeneraWindow.UIClassComboBoxWindow.ClassComboBox;
//            uiClassComboBox.SelectedItem = this.SelectClassBarbarianParams.UiClassComboBoxComboBoxSelectedItem;
//        }

//        public void AssertConRacialModifierIs2()
//        {
          
//            WinEdit uIConRacialModifierTexEdit = this.UIZachsCharacterGeneraWindow.UIConRacialModifierTexWindow.UIConRacialModifierTexEdit;
//            Assert.AreEqual(this.AssertConRacialModiferIs2ExpectedValues.UIConRacialModifierTexEditControlType, uIConRacialModifierTexEdit.ControlType.ToString());
//        }

//        public virtual LaunchZachsCharacterGeneratorParams LaunchZachsCharacterGeneratorParams
//        {
//            get
//            {
//                if ((this.mLaunchZachsCharacterGeneratorParams == null))
//                {
//                    this.mLaunchZachsCharacterGeneratorParams = new LaunchZachsCharacterGeneratorParams();
//                }
//                return this.mLaunchZachsCharacterGeneratorParams;
//            }
//        }

//        public virtual AssertZachsCharacterGeneratorIsLaunchExpectedValues AssertZachsCharacterGeneratorIsLaunchExpectedValues
//        {
//            get
//            {
//                if ((this.mAssertZachsCharacterGeneratorIsLaunchExpectedValues == null))
//                {
//                    this.mAssertZachsCharacterGeneratorIsLaunchExpectedValues = new AssertZachsCharacterGeneratorIsLaunchExpectedValues();
//                }
//                return this.mAssertZachsCharacterGeneratorIsLaunchExpectedValues;
//            }
//        }

//        public virtual SelectRaceDwarfParams SelectRaveDwarfParams
//        {
//            get
//            {
//                if ((this.mSelectRaveDwarfParams == null))
//                {
//                    this.mSelectRaveDwarfParams = new SelectRaceDwarfParams();
//                }
//                return this.mSelectRaveDwarfParams;
//            }
//        }

//        public virtual SelectClassBarbarianParams SelectClassBarbarianParams
//        {
//            get
//            {
//                if ((this.mSelectClassBarbarianParams == null))
//                {
//                    this.mSelectClassBarbarianParams = new SelectClassBarbarianParams();
//                }
//                return this.mSelectClassBarbarianParams;
//            }
//        }

//        public virtual AssertConRacialModiferIs2ExpectedValues AssertConRacialModiferIs2ExpectedValues
//        {
//            get
//            {
//                if ((this.mAssertConRacialModiferIs2ExpectedValues == null))
//                {
//                    this.mAssertConRacialModiferIs2ExpectedValues = new AssertConRacialModiferIs2ExpectedValues();
//                }
//                return this.mAssertConRacialModiferIs2ExpectedValues;
//            }
//        }

//        public UIZachsCharacterGeneraWindow UIZachsCharacterGeneraWindow
//        {
//            get
//            {
//                if ((this.mUIZachsCharacterGeneraWindow == null))
//                {
//                    this.mUIZachsCharacterGeneraWindow = new UIZachsCharacterGeneraWindow();
//                }
//                return this.mUIZachsCharacterGeneraWindow;
//            }
//        }

//        private LaunchZachsCharacterGeneratorParams mLaunchZachsCharacterGeneratorParams;

//        private AssertZachsCharacterGeneratorIsLaunchExpectedValues mAssertZachsCharacterGeneratorIsLaunchExpectedValues;

//        private SelectRaceDwarfParams mSelectRaveDwarfParams;

//        private SelectClassBarbarianParams mSelectClassBarbarianParams;

//        private AssertConRacialModiferIs2ExpectedValues mAssertConRacialModiferIs2ExpectedValues;

//        private UIZachsCharacterGeneraWindow mUIZachsCharacterGeneraWindow;
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class LaunchZachsCharacterGeneratorParams
//    {

//        #region Fields
//        public string ExePath = "E:\\CharacterGen\\ZachsCharacterGenerater.exe";

//        public string AlternateExePath = "E:\\CharacterGen\\ZachsCharacterGenerater.exe";
//        #endregion
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class AssertZachsCharacterGeneratorIsLaunchExpectedValues
//    {
//        public string UIZachsCharacterGeneraTitleBarControlType = "TitleBar";
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class SelectRaceDwarfParams
//    {

//        public string UIRaceComboBoxComboBoxSelectedItem = "Dwarf";
//    }

//    public class SelectClassBarbarianParams
//    {
//        public string UiClassComboBoxComboBoxSelectedItem = "Barbarian";
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class AssertConRacialModiferIs2ExpectedValues
//    {

//        public string UIConRacialModifierTexEditControlType = "Edit";
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class UIZachsCharacterGeneraWindow : WinWindow
//    {

//        public UIZachsCharacterGeneraWindow()
//        {
//            this.SearchProperties[WinWindow.PropertyNames.Name] = "Zach\'s Character Generator";
//            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
//            this.WindowTitles.Add("Zach\'s Character Generator");
//        }

//        public UIZachsCharacterGeneraTitleBar UIZachsCharacterGeneraTitleBar
//        {
//            get
//            {
//                if ((this.mUIZachsCharacterGeneraTitleBar == null))
//                {
//                    this.mUIZachsCharacterGeneraTitleBar = new UIZachsCharacterGeneraTitleBar(this);
//                }
//                return this.mUIZachsCharacterGeneraTitleBar;
//            }
//        }

//        public UIRaceComboBoxWindow UIRaceComboBoxWindow
//        {
//            get
//            {
//                if ((this.mUIRaceComboBoxWindow == null))
//                {
//                    this.mUIRaceComboBoxWindow = new UIRaceComboBoxWindow(this);
//                }
//                return this.mUIRaceComboBoxWindow;
//            }
//        }

//        public UIClassComboBoxWindow UIClassComboBoxWindow
//        {
//            get
//            {
//                if ((this.mUIClassComboBoxWindow == null))
//                {
//                    this.mUIClassComboBoxWindow = new UIClassComboBoxWindow(this);
//                }
//                return this.mUIClassComboBoxWindow;
//            }
//        }

//        public UIConRacialModifierTexWindow UIConRacialModifierTexWindow
//        {
//            get
//            {
//                if ((this.mUIConRacialModifierTexWindow == null))
//                {
//                    this.mUIConRacialModifierTexWindow = new UIConRacialModifierTexWindow(this);
//                }
//                return this.mUIConRacialModifierTexWindow;
//            }
//        }

//        private UIZachsCharacterGeneraTitleBar mUIZachsCharacterGeneraTitleBar;

//        private UIRaceComboBoxWindow mUIRaceComboBoxWindow;

//        private UIClassComboBoxWindow mUIClassComboBoxWindow;

//        private UIConRacialModifierTexWindow mUIConRacialModifierTexWindow;
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class UIZachsCharacterGeneraTitleBar : WinTitleBar
//    {

//        public UIZachsCharacterGeneraTitleBar(UITestControl searchLimitContainer) :
//            base(searchLimitContainer)
//        {
//            this.WindowTitles.Add("Zach\'s Character Generator");
//        }

//        public WinButton UICloseButton
//        {
//            get
//            {
//                if ((this.mUICloseButton == null))
//                {
//                    this.mUICloseButton = new WinButton(this);
//                    #region Search Criteria
//                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
//                    this.mUICloseButton.WindowTitles.Add("Zach\'s Character Generator");
//                    #endregion
//                }
//                return this.mUICloseButton;
//            }
//        }

//        private WinButton mUICloseButton;
//    }

//    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//    public class UIRaceComboBoxWindow : WinWindow
//    {

//        public UIRaceComboBoxWindow(UITestControl searchLimitContainer) :
//            base(searchLimitContainer)
//        {
//            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "raceComboBox";
//            this.WindowTitles.Add("Zach\'s Character Generator");
//        }

//        public WinComboBox RaceComboBox
//        {
//            get
//            {
//                if ((this.mRaceComboBox == null))
//                {
//                    this.mRaceComboBox = new WinComboBox(this);
//                    #region Search Criteria
//                    this.mRaceComboBox.WindowTitles.Add("Zach\'s Character Generator");
//                    #endregion
//                }
//                return this.mRaceComboBox;
//            }
//        }
//        private WinComboBox mRaceComboBox;
//    }
//        public class UIClassComboBoxWindow : WinWindow
//        {

//            public UIClassComboBoxWindow(UITestControl searchLimitContainer) :
//                base(searchLimitContainer)
//            {
//                this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ClassComboBox";
//                this.WindowTitles.Add("Zach\'s Character Generator");
//            }

//            public WinComboBox RaceComboBox
//            {
//                get
//                {
//                    if ((this.mRaceComboBox == null))
//                    {
//                        this.mRaceComboBox = new WinComboBox(this);
//                        #region Search Criteria
//                        this.mRaceComboBox.WindowTitles.Add("Zach\'s Character Generator");
//                        #endregion
//                    }
//                    return this.mRaceComboBox;
//                }
//            }
//            private WinComboBox mRaceComboBox;

//            public WinComboBox ClassComboBox
//            {
//                get
//                {
//                    if ((this.mClassComboBox == null))
//                    {
//                        this.mClassComboBox = new WinComboBox(this);
//                        this.mClassComboBox.WindowTitles.Add("Zach\'s Character Generator");
//                    }
//                    return this.mClassComboBox;
//                }
//            }

//            private WinComboBox mClassComboBox;
//        }

//        [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
//        public class UIConRacialModifierTexWindow : WinWindow
//        {

//            public UIConRacialModifierTexWindow(UITestControl searchLimitContainer) :
//                base(searchLimitContainer)
//            {
//                this.SearchProperties[WinWindow.PropertyNames.ControlName] = "conRacialModifierTextBox";
//                this.WindowTitles.Add("Zach\'s Character Generator");
//            }

//            public WinEdit UIConRacialModifierTexEdit
//            {
//                get
//                {
//                    if ((this.mUIConRacialModifierTexEdit == null))
//                    {
//                        this.mUIConRacialModifierTexEdit = new WinEdit(this);
//                        #region Search Criteria
//                        this.mUIConRacialModifierTexEdit.WindowTitles.Add("Zach\'s Character Generator");
//                        #endregion
//                    }
//                    return this.mUIConRacialModifierTexEdit;
//                }
//            }

//            private WinEdit mUIConRacialModifierTexEdit;
//        }
//    }
