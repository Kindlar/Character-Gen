using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class HalfOrcUnitTests
    {
        HalfOrc HalfOrc { get; set; }

        [SetUp]
        public void Init()
        {
            HalfOrc halforc = new HalfOrc();
            HalfOrc = halforc;
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_GetsAName()
        {
            string actual = HalfOrc.RaceName;
            string expected = "HalfOrc";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_StrengthIsAssigned()
        {
            int actual = HalfOrc.StrRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_ConIsAssigned()
        {
            int actual = HalfOrc.ConRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_DexIsAssigned()
        {
            int actual = HalfOrc.DexRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_IntIsAssigned()
        {
            int actual = HalfOrc.IntRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_WisIsAssigned()
        {
            int actual = HalfOrc.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_ChaIsAssigned()
        {
            int actual = HalfOrc.ChaRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_GroundSpeedIsAssigned()
        {
            int actual = HalfOrc.RacialGroundSpeed;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_FeatsAreAssigned()
        {
            int actual = HalfOrc.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_RaceSkillsAreAssigned()
        {
            string[] actual = HalfOrc.RaceSkills;
            string[] expected = { "Dark vision", "Orc Blood" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrc_HalfOrcCreated_SizeModAssigned()
        {
            int actual = HalfOrc.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
