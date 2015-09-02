using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class ElfUnitTests
    {
        Elf Elf { get; set; }

        [SetUp]
        public void Init()
        {
            Elf elf = new Elf();
            Elf = elf;
        }

        [Test]
        public void Elf_ElfCreated_GetsAName()
        {
            string actual = Elf.RaceName;
            string expected = "Elf";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_StrengthIsAssigned()
        {
            int actual = Elf.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_ConIsAssigned()
        {
            int actual = Elf.ConRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_DexIsAssigned()
        {
            int actual = Elf.DexRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_IntIsAssigned()
        {
            int actual = Elf.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_WisIsAssigned()
        {
            int actual = Elf.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_ChaIsAssigned()
        {
            int actual = Elf.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_GroundSpeedIsAssigned()
        {
            int actual = Elf.RacialGroundSpeed;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_FeatsAreAssigned()
        {
            int actual = Elf.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_RaceSkillsAreAssigned()
        {
            string[] actual = Elf.RaceSkills;
            string[] expected = { "Immunity to magic sleep", "Low-light vision", "+2 to Listen, Search, and Spot", "Hidden door or portal sense" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Elf_ElfCreated_SizeModAssigned()
        {
            int actual = Elf.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
