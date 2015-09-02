using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class WizardTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player player = new Player("NewName", "Wizard", "Human", 1);
            Player = player;
        }

        [TestCase(1, new[] { 3, 1 })]
        [TestCase(2, new[] { 4, 2 })]
        [TestCase(3, new[] { 4, 2, 1 })]
        [TestCase(4, new[] { 4, 3, 2 })]
        [TestCase(5, new[] { 4, 3, 2, 1 })]
        [TestCase(6, new[] { 4, 3, 3, 2 })]
        [TestCase(7, new[] { 4, 4, 3, 2, 1 })]
        [TestCase(8, new[] { 4, 4, 3, 3, 2 })]
        [TestCase(9, new[] { 4, 4, 4, 3, 2, 1 })]
        [TestCase(10, new[] { 4, 4, 4, 3, 3, 2 })]
        [TestCase(11, new[] { 4, 4, 4, 4, 3, 2, 1 })]
        [TestCase(12, new[] { 4, 4, 4, 4, 3, 3, 2 })]
        [TestCase(13, new[] { 4, 4, 4, 4, 4, 3, 2, 1 })]
        [TestCase(14, new[] { 4, 4, 4, 4, 4, 3, 3, 2 })]
        [TestCase(15, new[] { 4, 4, 4, 4, 4, 4, 3, 2, 1 })]
        [TestCase(16, new[] { 4, 4, 4, 4, 4, 4, 3, 3, 2 })]
        [TestCase(17, new[] { 4, 4, 4, 4, 4, 4, 4, 3, 2, 1 })]
        [TestCase(18, new[] { 4, 4, 4, 4, 4, 4, 4, 3, 3, 2 })]
        [TestCase(19, new[] { 4, 4, 4, 4, 4, 4, 4, 4, 3, 3 })]
        [TestCase(20, new[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 })]
        public void GivenAWizardLevel_SpellArrayIsReturned(int level, int[] expectedSpells)
        {
            PlayerClass player = new Wizard();
            player.AssignLevel(level);
            player.GetClassSpellsPerDay();
            int[] actual = player.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expectedSpells, actual);
        }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            // Arrange
            Player Player = new Player("NewName", "Wizard", "Human", 4);

            // Act
            Player.PlayerClass.AssignBaseStats(18, 18, 18, 18, 18, 18);
            Player.CalculateTotalScore();
            Player.PlayerClass.CalculateAbilityMods();
            Player.PlayerClass.GetClassSpellsPerDay();
            Player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = Player.PlayerClass.Magic.SpellDC;
            int[] expected = { 14, 15, 16 };

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenBadData_NullReturned()
        {
            // Act
            Player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = Player.PlayerClass.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }

        [Test]
        public void BonusSpells()
        {
            Player.PlayerClass.AssignBaseStats(16, 16, 16, 16, 16, 16);
            Player.CalculateTotalScore();
            Player.PlayerClass.CalculateAbilityMods();
            Player.PlayerClass.GetBonusSpells();
            int[] actual = Player.PlayerClass.Magic.BonusSpells;
            int[] expected = { 1, 1, 1 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WizardAssignSkills()
        {
            Player.PlayerClass.AssignClassSkills();
            string[] actual = Player.PlayerClass.ClassSkills;
            string[] expected =
            {
                "conentrationCheckBox", "craftCheckBox", "decipherScriptCheckBox", "knowledgeArcanaCheckBox",
                "knowledgeArchitectureAndEngineeringCheckBox", "knowledgeDungeoneeringCheckBox",
                "knowledgeGeographyCheckBox", "knowledgeHistoryCheckBox", "knowledgeLocalCheckBox",
                "knowledgeNobilityAndRoyaltyCheckBox", "knowledgeReligionCheckBox", "knowledgeThePlanesCheckBox",
                "professionCheckBox", "spellcraftCheckBox"
            };
            Assert.AreEqual(expected, actual);
        }
    }
}