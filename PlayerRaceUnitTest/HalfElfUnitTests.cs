using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class HalfElfUnitTests
    {
        HalfElf HalfElf { get; set; }

        [SetUp]
        public void Init()
        {
            HalfElf elf = new HalfElf();
            HalfElf = elf;
        }

        [Test]
        public void HalfElf_HalfElfCreated_GetsAName()
        {
            string actual = HalfElf.RaceName;
            string expected = "HalfElf";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_StrengthIsAssigned()
        {
            int actual = HalfElf.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_ConIsAssigned()
        {
            int actual = HalfElf.ConRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_DexIsAssigned()
        {
            int actual = HalfElf.DexRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_IntIsAssigned()
        {
            int actual = HalfElf.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_WisIsAssigned()
        {
            int actual = HalfElf.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_ChaIsAssigned()
        {
            int actual = HalfElf.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_GroundSpeedIsAssigned()
        {
            int actual = HalfElf.RacialGroundSpeed;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_FeatsAreAssigned()
        {
            int actual = HalfElf.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_RaceSkillsAreAssigned()
        {
            string[] actual = HalfElf.RaceSkills;
            string[] expected = { "Low-light vision", "+1 on Listen, Search and Spot", "+2 on Diplomacy and Gather Information", "Elven-Blood" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElf_HalfElfCreated_SizeModAssigned()
        {
            int actual = HalfElf.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
