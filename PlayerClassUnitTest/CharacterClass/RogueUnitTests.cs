using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class RogueUnitTests
    {
        public Rogue Rogue { get; set; }

        [SetUp]
        public void Init()
        {
            Rogue = new Rogue();
        }

        [Test]
        public void GivenARogue_IsCreate_ChosenClassisAssigned()
        {
            string actual = Rogue.ChosenClass;
            string expectd = "Rogue";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenARogue_RogueIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Rogue.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARogue_RogueIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Rogue.ClassArmor;
            object[] expected = { "Padded", "Leather", "Studded leather", "Chain shirt" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARogue_RogueIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Rogue.ClassShields;
            object[] expected = {"Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARogue_RogueIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Rogue.ClassWeapons;
            object[] expected =
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light" , "Sickle", "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Hand Crossbow", "Rapier", "Sap", "Shortbow", "Sword, short"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveARogue_RogueIsCreate_GoldIsCalculated()
        {
            double actual = Rogue.Gold;
            //Assert
            Assert.IsTrue(actual >= 50 && actual <= 200);
        }
    }
}
