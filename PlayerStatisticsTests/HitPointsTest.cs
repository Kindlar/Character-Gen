using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class HitPointsTest
    {
        [Test]
        public void Returns4()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 4;
            int actual = hitPoints.D4HitDice();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Returns6()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 6;
            int actual = hitPoints.D6HitDice();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Returns8()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 8;
            int actual = hitPoints.D8HitDice();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Returns10()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 10;
            int actual = hitPoints.D10HitDice();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Returns12()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 12;
            int actual = hitPoints.D12HitDice();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof4Returns6()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 6;
            int actual = hitPoints.GetLevel1HitPointsD4(2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConModNeg4HitDiceof4Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel1HitPointsD4(-4);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof6Returns8()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 8;
            int actual = hitPoints.GetLevel1HitPointsD6(2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConModNeg6HitDiceof6Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel1HitPointsD6(-6);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof8Returns10()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 10;
            int actual = hitPoints.GetLevel1HitPointsD8(2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConModNeg8HitDiceof8Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel1HitPointsD8(-8);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ConMod2HitDiceof10Returns12()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 12;
            int actual = hitPoints.GetLevel1HitPointsD10(2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConModNeg10HitDiceof10Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel1HitPointsD10(-10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof12Returns14()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 14;
            int actual = hitPoints.GetLevel1HitPointsD12(2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConModNeg12HitDiceof12Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel1HitPointsD12(-12);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof4ReturnsBetween3And6()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetLevel2AndUpHitPontsD4(2);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 6);
        }

        [Test]
        public void ConModNeg5HitDiceof4Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel2AndUpHitPontsD4(-5);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof6ReturnsBetween3And8()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetLevel2AndUpHitPontsD6(2);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 8);
        }

        [Test]
        public void ConModNeg7HitDiceof6Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel2AndUpHitPontsD6(-7);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof8ReturnsBetween3And10()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetLevel2AndUpHitPontsD8(2);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 10);
        }

        [Test]
        public void ConModNeg9HitDiceof8Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel2AndUpHitPontsD8(-9);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof10ReturnsBetween3And12()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetLevel2AndUpHitPontsD10(2);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 12);
        }

        [Test]
        public void ConModNeg11HitDiceof10Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel2AndUpHitPontsD10(-11);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2HitDiceof12ReturnsBetween3And14()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetLevel2AndUpHitPontsD12(2);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 14);
        }

        [Test]
        public void ConModNeg13HitDiceof12Returns1()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 1;
            int actual = hitPoints.GetLevel2AndUpHitPontsD12(-13);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2Level2HitDiceof4ReturnsBetween9And12()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD4(2, 2);
            //Assert
            Assert.IsTrue(actual >= 9 && actual <= 12);
        }


        [Test]
        public void ConMod2Level2HitDiceof6ReturnsBetween11And16()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD6(2,2);
            //Assert
            Assert.IsTrue(actual >= 11 && actual <= 16);
        }

        [Test]
        public void ConMod2Level2HitDiceof8ReturnsBetween13And20()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD8(2, 2);
            //Assert
            Assert.IsTrue(actual >= 13 && actual <= 20);
        }

        [Test]
        public void ConMod2Level2HitDiceof10ReturnsBetween15And24()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD10(2, 2);
            //Assert
            Assert.IsTrue(actual >= 15 && actual <= 24);
        }

        [Test]
        public void ConMod2Level2HitDiceof12ReturnsBetween17And26()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD12(2, 2);
            //Assert
            Assert.IsTrue(actual >= 17 && actual <= 28);
        }

        [Test]
        public void ConMod2Level3HitDiceof6ReturnsBetween12And24()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitpointsD6(2, 3);
            //Assert
            Assert.IsTrue(actual >= 12 && actual <= 24);
        }

        [Test]
        public void ConModNeg4Level3HitDiceof4ReturnsBetween()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 3;
            int actual = hitPoints.GetTotalHitpointsD4(-3, 3);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConMod2Level3WizardHitDiceof4ReturnsBetween12And18()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitPoints(2, 3, "Wizard");
            //Assert
            Assert.IsTrue(actual >= 12 && actual <= 18);
        }

        [Test]
        public void ConMod2Level3BardHitDiceof6ReturnsBetween12And24()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitPoints(2, 3, "Bard");
            //Assert
            Assert.IsTrue(actual >= 12 && actual <= 24);
        }

        [Test]
        public void ConMod2Level3DruidHitDiceof8ReturnsBetween12And24()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitPoints(2, 3, "Druid");
            //Assert
            Assert.IsTrue(actual >= 15 && actual <= 30);
        }

        [Test]
        public void ConMod2Level3FighterHitDiceof10ReturnsBetween16And30()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitPoints(2, 3, "Fighter");
            //Assert
            Assert.IsTrue(actual >= 18 && actual <= 36);
        }

        [Test]
        public void ConMod2Level3BarbarianHitDiceof12ReturnsBetween21And42()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int actual = hitPoints.GetTotalHitPoints(2, 3, "Barbarian");
            //Assert
            Assert.IsTrue(actual >= 21 && actual <= 42);
        }

        [Test]
        public void ConModNeg4Level3Wizard()
        {
            //Arrange
            HitPoints hitPoints = new HitPoints();
            //Act
            int expected = 3;
            int actual = hitPoints.GetTotalHitPoints(-4, 3, "Wizard");
            //Assert
            Assert.AreEqual(expected, actual);
           
        }
    }
}
