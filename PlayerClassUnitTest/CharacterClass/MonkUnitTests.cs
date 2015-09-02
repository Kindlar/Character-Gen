using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class MonkUnitTests
    {
        public Monk Monk { get; set; }

        [SetUp]
        public void Init()
        {
            Monk = new Monk();
        }

        [Test]
        public void GivenAMonk_IsCreate_ChosenClassisAssigned()
        {
            string actual = Monk.ChosenClass;
            string expectd = "Monk";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenAMonk_MonkIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Monk.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAMonk_MonkIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Monk.ClassArmor;
            object[] expected = { "No trained armor" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAMonk_MonkIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Monk.ClassShields;
            object[] expected = {};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAMonk_MonkIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Monk.ClassWeapons;
            object[] expected =
            {
              "Club", "Crossbow, light", "Crossbow, heavy", "Dagger", "Handaxe", "Javelin", "Kama", "Nunchaki", "Quarterstaff", "Sai", "Shuriken", "Saingham",
              "Sling"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveAFighter_FighterIsCreated_GoldIsCalculated()
        {
            double actual = Monk.Gold;
            Assert.IsTrue(actual >= 5 && actual <= 20);
        }
    }
}
