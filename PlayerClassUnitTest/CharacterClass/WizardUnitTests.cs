using NUnit.Framework;
using PlayerClasses.CharacterClasses;

namespace PlayerClassUnitTest.CharacterClass
{
    [TestFixture]
    class WizardUnitTests
    {
        Wizard Wizard { get; set; }

        [SetUp]
        public void Init()
        {
            Wizard = new Wizard();
        }

        [Test]
        public void GivenAWizard_IsCreate_ChosenClassisAssigned()
        {
            string actual = Wizard.ChosenClass;
            string expectd = "Wizard";
            Assert.AreEqual(expectd, actual);
        }

        [Test]
        public void GivenAWizard_WizardIsCreated_ClassAllignmentsAreAssigned()
        {
            string[] actual = Wizard.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAWizard_WizardIsCreated_ClassArmorIsAssigned()
        {
            object[] actual = Wizard.ClassArmor;
            object[] expected = { "No trained armor" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAWizard_WizardIsCreated_ClassShieldsAreAssigned()
        {
            object[] actual = Wizard.ClassShields;
            object[] expected = { };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenAWizard_WizardIsCreated_ClassWeaponsAreAssigned()
        {
            object[] actual = Wizard.ClassWeapons;
            object[] expected =
            {
               "Club", "Dagger", "Crossbow, heavy", "Crossbow, light", "Quarterstaff"
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveAWizard_WizardIsCreate_GoldIsCalculated()
        {
            double actual = Wizard.Gold;
            //Assert
            Assert.IsTrue(actual >= 30 && actual <= 120);
        }
    }
}
