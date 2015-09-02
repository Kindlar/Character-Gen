using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class DiceRollTests
    {
        [Test]
        public void ReturnsRandomNumberD4()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D4();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD6()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D6();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD8()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D8();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD10()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D10();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD12()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D12();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD20()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D20();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberD100()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.D100();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ReturnsRandomNumberBaseStat()
        {
            DiceRoll dice = new DiceRoll();
            int actual = dice.BaseStat();
            Assert.IsNotNull(actual);
        }
    }
}
