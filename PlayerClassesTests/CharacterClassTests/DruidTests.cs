using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class DruidTests
    {
        [Test]
        public void BonusSpells()
        {
            Player player = new Player("NewName", "Druid", "Human",1);
            player.PlayerClass.AssignBaseStats(16, 16, 16, 16, 16, 16);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.GetBonusSpells();
            int[] actual = player.PlayerClass.Magic.BonusSpells;
            int[] expected = { 1, 1, 1 };
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new[] { 3, 1 })]
        [TestCase(2, new[] { 4, 2 })]
        [TestCase(3, new[] { 4, 2, 1 })]
        [TestCase(4, new[] { 5, 3, 2 })]
        [TestCase(5, new[] { 5, 3, 2, 1 })]
        [TestCase(6, new[] { 5, 3, 3, 2 })]
        [TestCase(7, new[] { 6, 4, 3, 2, 1 })]
        [TestCase(8, new[] { 6, 4, 3, 3, 2 })]
        [TestCase(9, new[] { 6, 4, 4, 3, 2, 1 })]
        [TestCase(10, new[] { 6, 4, 4, 3, 3, 2 })]
        [TestCase(11, new[] { 6, 5, 4, 4, 3, 2, 1 })]
        [TestCase(12, new[] { 6, 5, 4, 4, 3, 3, 2 })]
        [TestCase(13, new[] { 6, 5, 5, 4, 4, 3, 2, 1 })]
        [TestCase(14, new[] { 6, 5, 5, 4, 4, 3, 3, 2 })]
        [TestCase(15, new[] { 6, 5, 5, 5, 4, 4, 3, 2, 1 })]
        [TestCase(16, new[] { 6, 5, 5, 5, 4, 4, 3, 3, 2 })]
        [TestCase(17, new[] { 6, 5, 5, 5, 5, 4, 4, 3, 2, 1 })]
        [TestCase(18, new[] { 6, 5, 5, 5, 5, 4, 4, 3, 3, 2 })]
        [TestCase(19, new[] { 6, 5, 5, 5, 5, 5, 4, 4, 3, 3 })]
        [TestCase(20, new[] { 6, 5, 5, 5, 5, 5, 4, 4, 4, 4 })]
        public void GetClassSpellsLevel1(int level, int[] expected)
        {
            Player player = new Player("NewName", "Druid", "Human", level);
            player.PlayerClass.GetClassSpellsPerDay();
            int[] actual = player.PlayerClass.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            // Arrange
            Player player = new Player("NewName", "Druid", "Human", 1);

            // Act
            player.PlayerClass.AssignLevel(4);
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
            Player player = new Player("NewName", "Druid", "Human", 1);


            // Act
            player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = player.PlayerClass.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }
    }
}