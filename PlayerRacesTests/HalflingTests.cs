using NUnit.Framework;
using ZachsCharacterGenerater.Classes;

namespace PlayerRacesTests
{
    [TestFixture]
    public class HalflingTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player player = new Player("Arrow", "Rogue", "Halfing", 1);
            Player = player;
        }

        [Test]
        public void GetStrMod()
        {
            int actual = Player.Race.StrRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetConMod()
        {
            int actual = Player.Race.ConRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetDexMod()
        {
            int actual = Player.Race.DexRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetIntMod()
        {
            int actual = Player.Race.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWisMod()
        {
            int actual = Player.Race.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetChaMod()
        {
            int actual = Player.Race.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSizeMod()
        {
            int actual = Player.Race.SizeMod;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGroundSpeed()
        {
            int actual = Player.Race.RacialGroundSpeed;
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRaceName()
        {
            string actual = Player.Race.RaceName;
            string expected = "Halfing";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRaceSkills()
        {
            string[] actual = Player.Race.RaceSkills;
            string[] expected = {"+2 on Climb, Jump, Listen, and Move Silently", "Orc Blood", "+1 on all saving throws","+2 moral bonus on saving throw",
                "+1 on thrown weapons or sling attack rolls"};
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