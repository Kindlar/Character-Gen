using NUnit.Framework;
using PlayerRaces;

namespace PlayerRaceUnitTest
{
    [TestFixture]
    class HumanUnitTests
    {
        Human Human { get; set; }

        [SetUp]
        public void Init()
        {
            Human human = new Human();
            Human = human;
        }

        [Test]
        public void Human_HumanCreated_GetsAName()
        {
            string actual = Human.RaceName;
            string expected = "Human";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_StrengthIsAssigned()
        {
            int actual = Human.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_ConIsAssigned()
        {
            int actual = Human.ConRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_DexIsAssigned()
        {
            int actual = Human.DexRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_IntIsAssigned()
        {
            int actual = Human.IntRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_WisIsAssigned()
        {
            int actual = Human.WisRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_ChaIsAssigned()
        {
            int actual = Human.ChaRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_GroundSpeedIsAssigned()
        {
            int actual = Human.RacialGroundSpeed;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_FeatsAreAssigned()
        {
            int actual = Human.RaceBonusFeats;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Human_HumanCreated_RaceSkillsAreAssigned()
        {
            string[] actual = Human.RaceSkills;
            Assert.IsNull(actual);
        }

        [Test]
        public void Human_HumanCreated_SizeModAssigned()
        {
            int actual = Human.SizeMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
