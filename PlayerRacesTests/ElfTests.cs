using NUnit.Framework;
using ZachsCharacterGenerater.Classes;

namespace PlayerRacesTests
{
    [TestFixture]
    public class ElfTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player player = new Player("Elrond", "Wizard", "Elf", 1);
            Player = player;
        }

        [Test]
        public void GetStrRacialMod()
        {
            int actual = Player.Race.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetConRacialMod()
        {
            int actual = Player.Race.ConRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetDexRacialMod()
        {
            int actual = Player.Race.DexRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetIntRacialMod()
        {
            int actual = Player.Race.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWisRacialMod()
        {
            int actual = Player.Race.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetChaRacialMod()
        {
            int actual = Player.Race.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGroundSpeed()
        {
            int actual = Player.Race.RacialGroundSpeed;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRaceSkills()
        {
            string[] actual = Player.Race.RaceSkills;
            string[] expected = {"Immunity to magic sleep", "Low-light vision", "+2 to Listen, Search, and Spot", "Hidden door or portal sense"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRaceName()
        {
            string actual = Player.Race.RaceName;
            string expected = "Elf";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSizeMod()
        {
            int actual = Player.Race.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRacialFeats()
        {
            int actual = Player.Race.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}