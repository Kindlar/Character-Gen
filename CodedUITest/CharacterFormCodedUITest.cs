//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using System.Windows.Input;
//using System.Windows.Forms;
//using System.Drawing;
//using Microsoft.VisualStudio.TestTools.UITesting;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VisualStudio.TestTools.UITest.Extension;
//using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


//namespace CodedUITest
//{
//    [CodedUITest]
//    public class CharactFormCodedUITest
//    {
//        public CharactFormCodedUITest()
//        {
//        }

//        [TestMethod]
//        public void WhenRaceIsSelectedDataIspopulatedCorrectly()
//        {

//            UIMap.SelectRaceDwarf();
//            UIMap.SelectClassBarbarian();
//            //UIMap.AssertStrRacialModifieris0();
          
//            UIMap.AssertConRacialModifierIs2();

//        }

//        #region Additional test attributes
 
//        [TestInitialize()]
//        public void MyTestInitialize()
//        {
//            UIMap.LaunchZachsCharacterGenerator();
//            UIMap.AssertZachsCharacterGeneratorIsLaunch();
//        }

//        [TestCleanup()]
//        public void MyTestCleanup()
//        {
//            UIMap.CloseZachsCharacterGenerator();
//        }

//        #endregion

//        public TestContext TestContext
//        {
//            get
//            {
//                return testContextInstance;
//            }
//            set
//            {
//                testContextInstance = value;
//            }
//        }
//        private TestContext testContextInstance;

//        public UIMap UIMap
//        {
//            get
//            {
//                if ((this.map == null))
//                {
//                    this.map = new UIMap();
//                }

//                return this.map;
//            }
//        }

//        private UIMap map;
//    }
//}
