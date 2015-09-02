using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class BardUnitTests
    {
        public Bard Bard { get; set; }

        [SetUp]
        public void Init()
        {
            Bard = new Bard();
        }

        [Test]
        public void GivenABard_IsCreate_ChosenClassisAssigned()
        {
            string actual = Bard.ChosenClass;
            string expectd = "Bard";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenABard_BardIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Bard.ClassAlignments;
            string[] expected = { "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenABard_BardIsCreated_ClassArmorAreAssigned()
        {
            object[] actual = Bard.ClassArmor;
            object[] expected = { "Padded", "Leather", "Studded leather", "Chain shirt" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenABard_BardIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Bard.ClassShields;
            object[] expected = { "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenABard_BardIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Bard.ClassWeapons;
            object[] expected = { "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle", "Club", "Mace, heavy",
                "Morningstar", "Shortspear", "Longspear", "Quarterstaff","Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin"
                , "Sling", "Bullets, sling (10)", "Longsword", "Rapier", "Sap", "Sword, short", "Shortbow", "Whip" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenABard_IsCreated_GoldIsCalculated()
        {
            double actual = Bard.Gold;
            Assert.IsTrue(actual >= 40 && actual <= 160);
        }
    }
}
