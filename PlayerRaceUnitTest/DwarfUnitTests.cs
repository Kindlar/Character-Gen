using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class DwarfUnitTests
    {
        Dwarf Dwarf { get; set; }

        [SetUp]
        public void Init()
        {
            Dwarf dwarf = new Dwarf();
            Dwarf = dwarf;
        }

        [Test]
        public void Dwarf_DwarfCreated_GetsAName()
        {
            string actual = Dwarf.RaceName;
            string expected = "Dwarf";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_StrengthIsAssigned()
        {
            int actual = Dwarf.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_ConIsAssigned()
        {
            int actual = Dwarf.ConRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_DexIsAssigned()
        {
            int actual = Dwarf.DexRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_IntIsAssigned()
        {
            int actual = Dwarf.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_WisIsAssigned()
        {
            int actual = Dwarf.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_ChaIsAssigned()
        {
            int actual = Dwarf.ChaRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_GroundSpeedIsAssigned()
        {
            int actual = Dwarf.RacialGroundSpeed;
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_FeatsAreAssigned()
        {
            int actual = Dwarf.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_RaceSkillsAreAssigned()
        {
            string[] actual = Dwarf.RaceSkills;
            string[] expected = { "Stone cunning", "Darkvision", "Stability", "+4 dodge against giant type",
                "+2 racial bonus on Appraise checks that are related to stone or metal items",
                "+1 racial bonus to attack rolls against orcs and goblinoids",
                "+2 racial bonus on saving throws against poison"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Dwarf_DwarfCreated_SizeModAssigned()
        {
            int actual = Dwarf.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
