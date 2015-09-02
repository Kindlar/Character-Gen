using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class ClericUnitTests
    {
        public Cleric Cleric { get; set; }

        [SetUp]
        public void Init()
        {
            Cleric = new Cleric();
        }

        [Test]
        public void GivenACleric_IsCreate_ChosenClassisAssigned()
        {
            string actual = Cleric.ChosenClass;
            string expectd = "Cleric";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenACleric_ClericIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Cleric.ClassAlignments;
            string[] expected = { "Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenACleric_ClericIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Cleric.ClassArmor;
            object[] expected = { "Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail", "Breastplate", "Splint mail",
                "Banded mail", "Half-plate", "Full plate", "Padded", "Leather", "Hide" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenACleric_ClericIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Cleric.ClassShields;
            object[] expected = { "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenACleric_ClericIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Cleric.ClassWeapons;
            object[] expected = { "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle", "Club", "Mace, heavy",
                "Morningstar", "Shortspear", "Longspear", "Quarterstaff","Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin"
                , "Sling", "Bullets, sling (10)" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveACleric_ClericIsCreate_GoldIsCalculated()
        {
            double actual = Cleric.Gold;
            //Assert
            Assert.IsTrue(actual >= 50 && actual <= 200);
        }
    }
}
