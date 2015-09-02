using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class RangerTests
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
        public void GivenARangerLevel_SpellArrayIsReturned(int level, int[] expectedSpells)
        {
            PlayerClass player = new Ranger();
            player.AssignLevel(level);
            player.GetClassSpellsPerDay();
            int[] actual = player.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expectedSpells, actual);
        }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            // Arrange
            Player player = new Player("NewName", "Ranger", "Human", 4);

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
            PlayerClass pc = new Ranger();

            // Act
            pc.GetSpellDifficultyClass();
            int[] actual = pc.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }

        [Test]
        public void BonusSpells()
        {
            Player player = new Player("NewName", "Ranger", "Human",1);
            player.PlayerClass.AssignBaseStats(16, 16, 16, 16, 16, 16);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.GetBonusSpells();
            int[] actual = player.PlayerClass.Magic.BonusSpells;
            int[] expected = { 1, 1, 1 };
            Assert.AreEqual(expected, actual);
        }
    }
}