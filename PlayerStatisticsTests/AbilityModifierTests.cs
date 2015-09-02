using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class AbilityModifierUnitTests
    {
        [TestCase(0, "-999")]
        [TestCase(1, "-5")]
        [TestCase(2, "-4")]
        [TestCase(4, "-3")]
        [TestCase(6, "-2")]
        [TestCase(8, "-1")]
        [TestCase(10, "0")]
        [TestCase(12, "1")]
        [TestCase(14, "2")]
        [TestCase(16, "3")]
        [TestCase(18, "4")]
        [TestCase(20, "5")]
        [TestCase(22, "6")]
        [TestCase(24, "7")]
        [TestCase(999, "-999")]
        public void GivenATotalScore_StringIsReturned(int totalScore, string expected)
        {
            AbilityModifier ability = new AbilityModifier();
            string actual = ability.Calculate(totalScore).ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
