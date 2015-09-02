using NUnit.Framework;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class BardTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player = new Player("New Name", "Bard", "Human", 1);
        }

        [TestCase(1, new[] { 2 } )]
        [TestCase(2, new[] { 3, 0 })]
        [TestCase(3, new[] { 3, 1 })]
        [TestCase(4, new[] { 3, 2, 0 })]
        [TestCase(5, new[] { 3, 3, 1 })]
        [TestCase(6, new[] { 3, 3, 2 })]
        [TestCase(7, new[] { 3, 3, 2, 0 })]
        [TestCase(8, new[] { 3, 3, 3, 1 })]
        [TestCase(9, new[] { 3, 3, 3, 2 })]
        [TestCase(10, new[] { 3, 3, 3, 2, 0 })]
        [TestCase(11, new[] { 3, 3, 3, 3, 1 })]
        [TestCase(12, new[] { 3, 3, 3, 3, 2 })]
        [TestCase(13, new[] { 3, 3, 3, 3, 2, 0 })]
        [TestCase(14, new[] { 4, 3, 3, 3, 3, 1 })]
        [TestCase(15, new[] { 4, 4, 3, 3, 3, 2 })]
        [TestCase(16, new[] { 4, 4, 4, 3, 3, 2, 0 })]
        [TestCase(17, new[] { 4, 4, 4, 4, 3, 3, 1 })]
        [TestCase(18, new[] { 4, 4, 4, 4, 4, 3, 2 })]
        [TestCase(19, new[] { 4, 4, 4, 4, 4, 4, 3 })]
        [TestCase(20, new[] { 4, 4, 4, 4, 4, 4, 4 })]
        public void GivenABardLevelReturnsSpellArray(int level, int[] expected)
        {
            Player player = new Player("New Name", "Bard", "Human", level);
            player.PlayerClass.AssignLevel(level);
            player.PlayerClass.GetClassSpellsPerDay();
            int[] actual = player.PlayerClass.Magic.ClassSpellsPerDay;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BonusSpells()
        {
            Player.PlayerClass.AssignBaseStats(16,16,16,16,16,16);
            Player.PlayerClass.AssignMiscMods(0,0,0,0,0,0);
            Player.CalculateTotalScore();
            Player.PlayerClass.CalculateAbilityMods();
            Player.PlayerClass.GetBonusSpells();
            int[] actual = Player.PlayerClass.Magic.BonusSpells;
            int[] expected = { 1,1,1 };
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1" })]
        [TestCase(2, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1" })]
        [TestCase(3, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence" })]
        [TestCase(4, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence" })]
        [TestCase(5, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence" })]
        [TestCase(6, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence", "suggestion" })]
        [TestCase(7, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence", "suggestion" })]
        [TestCase(8, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion" })]
        [TestCase(9, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion", "inspire greatness" })]
        [TestCase(10, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion", "inspire greatness" })]
        [TestCase(11, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion", "inspire greatness" })]
        [TestCase(12, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom" })]
        [TestCase(13, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom"})]
        [TestCase(14, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom"})]
        [TestCase(15, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics"})]
        [TestCase(16, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics"})]
        [TestCase(17, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics"})]
        [TestCase(18, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics", "mass suggestion"})]
        [TestCase(19, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics", "mass suggestion"})]
        [TestCase(20, new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +4", "inspire competence", "suggestion", "inspire greatness",
                "song of freedom","inspire heroics", "mass suggestion"})]

        public void GivenaLevelAbilityListArrayReturned(int level, string[] expected)
        {
            //Arrange
            Player player = new Player("New Name", "Bard", "Human", level);
            //Act
            player.PlayerClass.AssignClassAbilties();
            string[] actual = player.PlayerClass.ClassAbilities;
            //Assert
            Assert.AreEqual(expected, actual);
         }

        [Test]
        public void GivenScoreSpells_ThenDCisCalculate_ReturnedIsArray()
        {
            // Arrange  
            Player player = new Player("NewName", "Bard", "Human", 4);
            // Act
            player.PlayerClass.AssignBaseStats(18,18,18,18,18,18);
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
            // Act
            Player.PlayerClass.GetSpellDifficultyClass();
            int[] actual = Player.PlayerClass.Magic.SpellDC;

            // Assert
            Assert.IsNull(actual);
        }

        [TestCase(1, new[] { 4 })]
        [TestCase(2, new[] { 5, 2 })]
        [TestCase(3, new[] { 6, 3 })]
        [TestCase(4, new[] { 6, 3, 2 })]
        [TestCase(5, new[] { 6, 4, 3 })]
        [TestCase(6, new[] { 6, 4, 3 })]
        [TestCase(7, new[] { 6, 4, 4, 2 })]
        [TestCase(8, new[] { 6, 4, 4, 3 })]
        [TestCase(9, new[] { 6, 4, 4, 3 })]
        [TestCase(10, new[] { 6, 4, 4, 4, 2 })]
        [TestCase(11, new[] { 6, 4, 4, 4, 3 })]
        [TestCase(12, new[] { 6, 4, 4, 4, 3 })]
        [TestCase(13, new[] { 6, 4, 4, 4, 4, 2 })]
        [TestCase(14, new[] { 6, 4, 4, 4, 4, 3 })]
        [TestCase(15, new[] { 6, 4, 4, 4, 4, 3 })]
        [TestCase(16, new[] { 6, 5, 4, 4, 4, 4, 2 })]
        [TestCase(17, new[] { 6, 5, 5, 4, 4, 4, 3 })]
        [TestCase(18, new[] { 6, 5, 5, 5, 4, 4, 3 })]
        [TestCase(19, new[] { 6, 5, 5, 5, 5, 4, 4 })]
        [TestCase(20, new[] { 6, 5, 5, 5, 5, 5, 4 })]
        public void GivenABardLevelReturnsKnownSpellArray(int level, int[] expected)
        {
            Player player = new Player("New Name", "Bard", "Human", level);
            player.PlayerClass.AssignLevel(level);
            player.PlayerClass.GetClassKnownSpells();
            int[] actual = player.PlayerClass.Magic.SpellsKnown;
            Assert.AreEqual(expected, actual);
        }
    }
}