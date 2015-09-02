using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class SavingThorwTests
    {
        [Test]
        public void Level1BardReturns0()
        {
            SavingThrows Fort = new SavingThrows();
            int expected = 0;
            int actual = Fort.GetFort(1, "Bard");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level20PaladinReturns12()
        {
            SavingThrows Fort = new SavingThrows();
            int expected = 12;
            int actual = Fort.GetFort(20, "Paladin");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BadDataReturnsError()
        {
            SavingThrows Fort = new SavingThrows();
            int expected = -999;
            int actual = Fort.GetFort(21, "Paladin");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level1BardReturns2Reflex()
        {
            SavingThrows reflex = new SavingThrows();
            int expected = 2;
            int actual = reflex.GetReflex(1, "Bard");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level20PaladinReturns6Reflex()
        {
            SavingThrows reflex = new SavingThrows();
            int expected = 6;
            int actual = reflex.GetReflex(20, "Paladin");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BadDataReturnsErrorReflex()
        {
            SavingThrows reflex = new SavingThrows();
            int expected = -999;
            int actual = reflex.GetReflex(21, "Paladin");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Level1BardReturns0Will()
        {
            SavingThrows will = new SavingThrows();
            int expected = 2;
            int actual = will.GetWill(1, "Bard");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level20PaladinReturns12Will()
        {
            SavingThrows will = new SavingThrows();
            int expected = 6;
            int actual = will.GetWill(20, "Paladin");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BadDataReturnsErrorWill()
        {
            SavingThrows will = new SavingThrows();
            int expected = -999;
            int actual = will.GetWill(21, "Paladin");
            Assert.AreEqual(expected, actual);
        }
    }
}
