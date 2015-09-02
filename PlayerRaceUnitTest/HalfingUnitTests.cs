using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class HalfingUnitTests
    {
        Halfing Halfing { get; set; }

        [SetUp]
        public void Init()
        {
            Halfing halfing = new Halfing();
            Halfing = halfing;
        }

        [Test]
        public void Halfing_HalfingCreated_GetsAName()
        {
            string actual = Halfing.RaceName;
            string expected = "Halfing";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_StrengthIsAssigned()
        {
            int actual = Halfing.StrRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_ConIsAssigned()
        {
            int actual = Halfing.ConRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_DexIsAssigned()
        {
            int actual = Halfing.DexRacialMod;
            int expected = +2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_IntIsAssigned()
        {
            int actual = Halfing.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_WisIsAssigned()
        {
            int actual = Halfing.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_ChaIsAssigned()
        {
            int actual = Halfing.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_GroundSpeedIsAssigned()
        {
            int actual = Halfing.RacialGroundSpeed;
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_FeatsAreAssigned()
        {
            int actual = Halfing.RaceBonusFeats;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_RaceSkillsAreAssigned()
        {
            string[] actual = Halfing.RaceSkills;
            string[] expected = { "+2 on Climb, Jump, Listen, and Move Silently", "Orc Blood", "+1 on all saving throws","+2 moral bonus on saving throw",
                "+1 on thrown weapons or sling attack rolls" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Halfing_HalfingCreated_SizeModAssigned()
        {
            int actual = Halfing.SizeMod;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
