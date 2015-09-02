using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class DruidUnitTests
    {
        public Druid Druid { get; set; }

        [SetUp]
        public void Init()
        {
            Druid = new Druid();
        }

        [Test]
        public void GivenADruid_IsCreate_ChosenClassisAssigned()
        {
            string actual = Druid.ChosenClass;
            string expectd = "Druid";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenADruid_DruidIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Druid.ClassAlignments;
            string[] expected = { "Lawful Neutral", "Neutral Good", "True Neutral", "Neutral Evil", "Chaotic Neutral" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenADruid_DruidIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Druid.ClassArmor;
            object[] expected = { "Padded", "Leather", "Hide" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenADruid_DruidIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Druid.ClassShields;
            object[] expected = { "Shield, light wooden", "Shield, heavy wooden" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenADruid_DruidIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Druid.ClassWeapons;
            object[] expected = { "Club", "Dagger", "Dart", "QuarterStaff", "Scimitar", "Sickle", "Shortspear", "Sling","Spear" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenADruid_DruidIsCreated_GoldIsCalculated()
        {
            double actual = Druid.Gold;
            //Assert
            Assert.IsTrue(actual >= 20 && actual <= 80);
        }
    }
}
