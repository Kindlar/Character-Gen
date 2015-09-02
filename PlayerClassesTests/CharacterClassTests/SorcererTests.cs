using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class SorcererTests
    {
        [TestCase(1, new[] { 5, 3 })]
        [TestCase(2, new[] { 6, 4 })]
        [TestCase(3, new[] { 6, 5 })]
        [TestCase(4, new[] { 6, 6, 3 })]
        [TestCase(5, new[] { 6, 6, 4 })]
        [TestCase(6, new[] { 6, 6, 5, 3 })]
        [TestCase(7, new[] { 6, 6, 6, 4 })]
        [TestCase(8, new[] { 6, 6, 6, 5, 3 })]
        [TestCase(9, new[] { 6, 6, 6, 6, 4 })]
        [TestCase(10, new[] { 6, 6, 6, 6, 5, 3 })]
        [TestCase(11, new[] { 6, 6, 6, 6, 6, 4 })]
        [TestCase(12, new[] { 6, 6, 6, 6, 6, 5, 3 })]
        [TestCase(13, new[] { 6, 6, 6, 6, 6, 6, 4 })]
        [TestCase(14, new[] { 6, 6, 6, 6, 6, 6, 5, 3 })]
        [TestCase(15, new[] { 6, 6, 6, 6, 6, 6, 6, 4 })]
        [TestCase(16, new[] { 6, 6, 6, 6, 6, 6, 6, 5, 3 })]
        [TestCase(17, new[] { 6, 6, 6, 6, 6, 6, 6, 6, 4 })]
        [TestCase(18, new[] { 6, 6, 6, 6, 6, 6, 6, 6, 5, 3 })]
        [TestCase(19, new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 4 })]
        [TestCase(20, new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 })]
        public void GivenASorcerorLevel_SpellArrayIsReturned(int level, int[] expectedSpells)
        {
            PlayerClass player = new Sorcerer();
            player.AssignLevel(level);
            player.GetClassSpellsPerDay();
            int[] actual = player.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expectedSpells, actual);
        }

        [TestCase(1, new[] { 4, 2 })]
        [TestCase(2, new[] { 5, 2 })]
        [TestCase(3, new[] { 5, 3 })]
        [TestCase(4, new[] { 6, 3, 1 })]
        [TestCase(5, new[] { 6, 4, 2 })]
        [TestCase(6, new[] { 7, 4, 2, 1 })]
        [TestCase(7, new[] { 7, 5, 3, 2 })]
        [TestCase(8, new[] { 8, 5, 3, 2, 1 })]
        [TestCase(9, new[] { 8, 5, 4, 3, 2 })]
        [TestCase(10, new[] { 9, 5, 4, 3, 2, 1 })]
        [TestCase(11, new[] { 9, 5, 5, 4, 3, 2 })]
        [TestCase(12, new[] { 9, 5, 5, 4, 3, 2, 1 })]
        [TestCase(13, new[] { 9, 5, 5, 4, 4, 3, 2 })]
        [TestCase(14, new[] { 9, 5, 5, 4, 4, 3, 2, 1 })]
        [TestCase(15, new[] { 9, 5, 5, 4, 4, 4, 3, 2 })]
        [TestCase(16, new[] { 9, 5, 5, 4, 4, 4, 3, 2, 1 })]
        [TestCase(17, new[] { 9, 5, 5, 4, 4, 4, 3, 3, 2 })]
        [TestCase(18, new[] { 9, 5, 5, 4, 4, 4, 3, 3, 2, 1 })]
        [TestCase(19, new[] { 9, 5, 5, 4, 4, 4, 3, 3, 3, 2 })]
        [TestCase(20, new[] { 9, 5, 5, 4, 4, 4, 3, 3, 3, 3 })]
        public void GivenASorcererLevel_KnownSpellArrayIsReturned(int level, int[] expectedSpells)
        {
            PlayerClass player = new Sorcerer();
            player.AssignLevel(level);
            player.GetClassKnownSpells();
            int[] actual = player.Magic.SpellsKnown;
            Assert.AreEqual(expectedSpells, actual);
        }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            // Arrange
            Player player = new Player("NewName", "Sorcerer", "Human", 4);

            // Act
            player.PlayerClass.AssignBaseStats(18, 18, 18, 18, 18, 18);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.GetClassSpellsPerDay();
            player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = player.PlayerClass.Magic.SpellDC;
            int[] expected = { 14, 15, 16 };

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Given_Then_Returned()
        {
            // Arrange
            PlayerClass pc = new Sorcerer();

            // Act
            pc.GetSpellDifficultyClass();
            int[] actual = pc.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }

        [Test]
        public void BonusSpells()
        {
            Player player = new Player("NewName", "Sorcerer", "Human",1);
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