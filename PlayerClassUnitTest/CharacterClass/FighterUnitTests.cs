using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    internal class FighterUnitTests
    {
        public Fighter Fighter { get; set; }

        [SetUp]
        public void Init()
        {
            Fighter = new Fighter();
        }

        [Test]
        public void GivenAFighter_IsCreate_ChosenClassisAssigned()
        {
            string actual = Fighter.ChosenClass;
            string expectd = "Fighter";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenAFighter_FighterIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Fighter.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAFighter_FighterIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Fighter.ClassArmor;
            object[] expected = {"Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail", "Breastplate", "Splint mail",
                "Banded mail", "Half-plate", "Full plate", "Padded", "Leather", "Hide"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAFighter_FighterIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Fighter.ClassShields;
            object[] expected = {"Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel", "Shield, tower"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAFighter_FighterIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Fighter.ClassWeapons;
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
        public void GiveAFighter_FighterIsCreated_GoldIsCalculated()
        {
            double actual = Fighter.Gold;
            Assert.IsTrue(actual >= 60 && actual <= 240);
        }
    }
}