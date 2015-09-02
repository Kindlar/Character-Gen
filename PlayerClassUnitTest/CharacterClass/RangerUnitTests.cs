using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class RangerUnitTests
    {
        public Ranger Ranger { get; set; }

        [SetUp]
        public void Init()
        {
            Ranger = new Ranger();
        }

        [Test]
        public void GivenARanger_IsCreate_ChosenClassisAssigned()
        {
            string actual = Ranger.ChosenClass;
            string expectd = "Ranger";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenARanger_RangerIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Ranger.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARanger_RangerIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Ranger.ClassArmor;
            object[] expected = {"Padded", "Leather", "Studded leather", "Chain shirt"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARanger_RangerIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Ranger.ClassShields;
            object[] expected = {"Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenARanger_RangerIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Ranger.ClassWeapons;
            object[] expected =
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle","Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light","Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri", "Pick, light", "Sap","Sword, short", "Battleaxe", "Flail",
                "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer", "Falchion", "Glaive", "Greataxe", "Greatclub", "Flail, heavy",
                "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow", "Longbow, composite",
                "Shortbow", "Shortbow, composite", "Arrows (20)"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveARanger_RangerIsCreated_GoldIsCalculated()
        {
            double actual = Ranger.Gold;
            Assert.IsTrue(actual >= 60 && actual <= 240);
        }

    }
}
