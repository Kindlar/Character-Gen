using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    internal class BarbarianUnitTests
    {
        public Barbarian Barbarian { get; set; }

        [SetUp]
        public void Init()
        {
            Barbarian = new Barbarian();
        }

        [Test]
        public void GivenABarbarian_IsCreate_ChosenClassisAssigned()
        {
            string actual = Barbarian.ChosenClass;
            string expectd = "Barbarian";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenABarbarian_IsCreate_ClassArmorIsAssigned()
        {
            object[] actual = Barbarian.ClassArmor;
            object[] expectd =
            {
                "Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail",
                "Breastplate"
            };
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenABarbarian_IsCreate_ClassShieldsAreAssigned()
        {
            object[] actual = Barbarian.ClassShields;
            object[] expectd =
            {
                "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"
            };
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenABarbarian_IsCreated_ClassAlignmentsAreAssigned()
        {
            string[] actual = Barbarian.ClassAlignments;
            string[] expected =
            {
                "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenABarbarian_IsCreate_ClassWeaponsAreAssigned()
        {
            object[] actual = Barbarian.ClassWeapons;
            object[] expectd =
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle",
                "Club", "Mace, heavy",
                "Morningstar", "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                "Bolts, crossbow (10)",
                "Dart", "Javelin", "Sling", "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri",
                "Pick, light", "Sap", "Sword, short",
                "Battleaxe", "Flail", "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer",
                "Falchion", "Glaive", "Greataxe", "Greatclub",
                "Flail, heavy", "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow",
                "Longbow, composite", "Shortbow",
                "Shortbow, composite", "Arrows (20)"
            };
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenABarbarian_IsCreated_GoldIsCalculated()
        {
            double actual = Barbarian.Gold;
            Assert.IsTrue(actual >= 40 && actual <= 160);
        }
    }
}
