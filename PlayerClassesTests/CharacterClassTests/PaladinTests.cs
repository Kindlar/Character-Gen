using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class PaladinTests
    {
        [TestCase(1, new int[] { })]
        [TestCase(2, new int[] { })]
        [TestCase(3, new int[] { })]
        [TestCase(4, new[] { 0 })]
        [TestCase(5, new[] { 0 })]
        [TestCase(6, new[] { 1 })]
        [TestCase(7, new[] { 1 })]
        [TestCase(8, new[] { 1, 0 })]
        [TestCase(9, new[] { 1, 0 })]
        [TestCase(10, new[] { 1, 1 })]
        [TestCase(11, new[] { 1, 1, 0 })]
        [TestCase(12, new[] { 1, 1, 1 })]
        [TestCase(13, new[] { 1, 1, 1 })]
        [TestCase(14, new[] { 2, 1, 1, 0 })]
        [TestCase(15, new[] { 2, 1, 1, 1 })]
        [TestCase(16, new[] { 2, 2, 1, 1 })]
        [TestCase(17, new[] { 2, 2, 2, 1 })]
        [TestCase(18, new[] { 3, 2, 2, 1 })]
        [TestCase(19, new[] { 3, 3, 3, 2 })]
        [TestCase(20, new[] { 3, 3, 3, 3 })]
        public void GivenAPladinLevel_SpellArrayIsReturned(int level, int[] expectedSpells)
        {
            PlayerClass player = new Paladin();
            player.AssignLevel(level);
            player.GetClassSpellsPerDay();
            int[] actual = player.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expectedSpells, actual);
        }

        [Test]
        public void PaladinReturnAlignments()
        {
            PlayerClass player = new Paladin();
            string[] expected = {"Lawful Good"};
            string[] actual = player.ClassAlignments;
            Assert.AreEqual(expected,actual);
        }

        [TestCase(1, new[] { "Aura of good", "detect evil", "smite evil 1/day" })]
        [TestCase(2, new[] { "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands" })]
        [TestCase(3, new[] { "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands", "aura of courage",
            "divine health" })]
        [TestCase(4, new[] { "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead" })]
        [TestCase(5, new[] { "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands", "aura of courage",
            "divine health","turn undead","special mount" })]
        [TestCase(6, new[] { "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 1/week" })]
        [TestCase(7, new[] { "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands", "aura of courage",
            "divine health", "turn undead","special mount", "remove disease 1/week"})]
        [TestCase(8, new[] { "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands", "aura of courage",
            "divine health", "turn undead","special mount", "remove disease 1/week"})]
        [TestCase(9, new[] { "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands", "aura of courage",
            "divine health", "turn undead","special mount", "remove disease 2/week"})]
        [TestCase(10, new[] { "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 2/week"})]
        [TestCase(11, new[] { "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 2/week"})]
        [TestCase(12, new[] { "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 3/week"})]
        [TestCase(13, new[] { "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 3/week"})]
        [TestCase(14, new[] { "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands", "aura of courage",
            "divine health", "turn undead","special mount", "remove disease 3/week"})]
        [TestCase(15, new[] { "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 4/week"})]
        [TestCase(16, new[] { "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 4/week"})]
        [TestCase(17, new[] { "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 4/week"})]
        [TestCase(18, new[] { "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 5/week"})]
        [TestCase(19, new[] { "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands", "aura of courage", 
            "divine health", "turn undead","special mount", "remove disease 5/week"})]
        [TestCase(20, new[] { "Aura of good", "detect evil", "smite evil 5/day", "divine grace", "lay on hands", "aura of courage",
            "divine health", "turn undead","special mount", "remove disease 5/week"})]
        public void GivenALevel_ArrayOfClassSkillsReturned(int level, string[] expected)
        {
            PlayerClass pc = new Paladin();
            pc.AssignLevel(level);
            pc.AssignClassAbilties();
            string[] actual = pc.ClassAbilities;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            Player player = new Player("NewName", "Paladin", "Human", 4);
            // Arrange

            // Act
            player.PlayerClass.AssignBaseStats(18, 18, 18, 18, 18, 18);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.GetClassSpellsPerDay();
            player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = player.PlayerClass.Magic.SpellDC;
            int[] expected = { 14 };

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Given_Then_Returned()
        {
            // Arrange
            PlayerClass pc = new Paladin();

            // Act
            pc.GetSpellDifficultyClass();
            int[] actual = pc.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }
    }
}