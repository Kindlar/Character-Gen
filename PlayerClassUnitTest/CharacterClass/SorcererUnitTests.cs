using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class SorcererUnitTests
    {
        Sorcerer Sorcerer { get; set; }

        [SetUp]
        public void Init()
        {
            Sorcerer = new Sorcerer();
        }

        [Test]
        public void GivenASorcerer_IsCreate_ChosenClassisAssigned()
        {
            string actual = Sorcerer.ChosenClass;
            string expectd = "Sorcerer";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenASorcerer_SorcererIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Sorcerer.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenASorcerer_SorcererIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Sorcerer.ClassArmor;
            object[] expected = { "No trained armor" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenASorcerer_SorcererIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Sorcerer.ClassShields;
            object[] expected = {};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenASorcerer_SorcererIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Sorcerer.ClassWeapons;
            object[] expected =
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle", "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff","Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveASorcerer_SorcererIsCreate_GoldIsCalculated()
        {
            double actual = Sorcerer.Gold;
            //Assert
            Assert.IsTrue(actual >= 30 && actual <= 120);
        }
    }
}
