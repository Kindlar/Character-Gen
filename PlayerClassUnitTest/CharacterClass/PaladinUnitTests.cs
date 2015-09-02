using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class PaladinUnitTests
    {
        public Paladin Paladin { get; set; }

        [SetUp]
        public void Init()
        {
            Paladin = new Paladin();
        }

        [Test]
        public void GivenAPaladin_IsCreate_ChosenClassisAssigned()
        {
            string actual = Paladin.ChosenClass;
            string expectd = "Paladin";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenAPaladin_PaladinIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Paladin.ClassAlignments;
            string[] expected = {"Lawful Good"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAPaladin_PaladinIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Paladin.ClassArmor;
            object[] expected = {"Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail", "Breastplate", "Splint mail",
                "Banded mail", "Half-plate", "Full plate", "Padded", "Leather", "Hide"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAPaladin_PaladinIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Paladin.ClassShields;
            object[] expected = {"Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAPaladin_PaladinIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Paladin.ClassWeapons;
            object[] expected =
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle",
                "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri", "Pick, light", "Sap",
                "Sword, short", "Battleaxe", "Flail",
                "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer", "Falchion", "Glaive",
                "Greataxe", "Greatclub", "Flail, heavy",
                "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow", "Longbow, composite",
                "Shortbow", "Shortbow, composite", "Arrows (20)"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveAPaladin_PaladinIsCreated_GoldIsCalculated()
        {
            double actual = Paladin.Gold;
            Assert.IsTrue(actual >= 60 && actual <= 240);
        }
    }
}
