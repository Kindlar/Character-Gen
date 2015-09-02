using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    public class GnomeUnitTests
    {

        Gnome Gnome { get; set; }

        [SetUp]
        public void Init()
        {
            Gnome gnome = new Gnome();
            Gnome = gnome;
        }

        [Test]
        public void Gnome_GnomeCreated_GetsAName()
        {
            string actual = Gnome.RaceName;
            string expected = "Gnome";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_StrengthIsAssigned()
        {
            int actual = Gnome.StrRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_ConIsAssigned()
        {
            int actual = Gnome.ConRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_DexIsAssigned()
        {
            int actual = Gnome.DexRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_IntIsAssigned()
        {
            int actual = Gnome.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_WisIsAssigned()
        {
            int actual = Gnome.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_ChaIsAssigned()
        {
            int actual = Gnome.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_GroundSpeedIsAssigned()
        {
            int actual = Gnome.RacialGroundSpeed;
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_FeatsAreAssigned()
        {
            int actual = Gnome.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_RaceSkillsAreAssigned()
        {
            string[] actual = Gnome.RaceSkills;
            string[] expected = { "Low-light vision", "+2 versus illusions", "+4 against giant types", "1/day: Speak with animals(burrowing)",
                "1/day dancing lights","1/day ghost sounds", "prestidigitation" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Gnome_GnomeCreated_SizeModAssigned()
        {
            int actual = Gnome.SizeMod;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}