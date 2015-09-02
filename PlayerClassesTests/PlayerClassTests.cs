using NUnit.Framework;
using PlayerClasses;
using PlayerClasses.CharacterClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests
{
    [TestFixture]
    public class PlayerClassTests
    {
        [Test]
        public void AssignedBaseStatsReturn()
        {
            //Arange
            Player player = new Player("NewName", "Wizard", "Human", 1);
            player.PlayerClass.AssignBaseStats(12, 10, 10, 10, 10, 10);
            player.PlayerClass.AssignMiscMods(0, 0, 0, 0, 0, 0);
            //Act
            player.CalculateTotalScore();
            //Assert
            int actual = player.PlayerClass.StatMods.StrAbilityMod;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AssignedRaceReturnName()
        {
            //Arange
            Player player = new Player("NewName", "Rogue", "Elf", 1);
            //Assert
            string actual = player.Race.RaceName;
            string expected = "Elf";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HitPointsStatsReturn()
        {
            //Arange
            Player player = new Player("NewName", "Rogue", "Elf", 1);
            //Act
            player.PlayerClass.AssignBaseStats(10, 10, 10, 10, 10, 10);
            player.PlayerClass.AssignMiscMods(0, 0, 0, 0, 0, 0);
            player.PlayerClass.CalculateHitPoints();
            //Assert
            int actual = player.PlayerClass.Attack.TotalHitPoints;
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SkillPointsStatsReturn()
        {
            //Arange
            Player player = new Player("NewName", "Wizard", "Human", 1);
            player.PlayerClass.AssignBaseStats(10,10,10,10,10,10);
            player.PlayerClass.AssignMiscMods(0,0,0,0,0,0);
            player.CalculateTotalScore();          
            //Act
            player.CalculateSkillPoints();
            //Assert
            int actual = player.TotalSkillPoints;
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TotalScoreIsReturned()
        {
            //Arrange
            Player player = new Player("NewName", "Wizard", "Human", 1);

            player.PlayerClass.AssignBaseStats(10, 10, 10, 10, 10, 10);
            player.PlayerClass.AssignMiscMods(1, 2, 3, 4, 5, 6);
            //Act
            player.CalculateTotalScore();
            //Assert
            int actual = player.PlayerClass.TotalScore.ChaTotalScore;
            int expected = 16;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AbleToGetabilityModifier()
        {
            //Arrange
            Player player = new Player("NewName", "Wizard", "Human", 1);
            player.PlayerClass.AssignBaseStats(13,13,13,13,13,13);
            player.PlayerClass.AssignMiscMods(0,0,0,0,0,0);
            //Act
            player.CalculateTotalScore();
            //Assert
            int actual = player.PlayerClass.StatMods.StrAbilityMod;
            int expected = 1;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void AbleToGetTotalGold()
        {
            //Arrange
            Wizard player = new Wizard();
            //Assert
            double actual = player.Gold;
            Assert.IsTrue(actual >= 30 && actual <= 120);
        }

        [Test]
        public void AbleToGetTotalFeats()
        {
            //Arrange
            Player player = new Player("NewName", "Wizard", "Human", 1);
            //Act
            player.CalculateFeats();
            //Assert
            int actual = player.TotalFeats;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BaseAttackIsReturned()
        {
            //Arrange
            Wizard player = new Wizard();
            player.AssignBaseStats(10, 10, 10, 10, 10, 10);
            player.AssignMiscMods(0, 0, 0, 0, 0, 0);
            player.AssignLevel(1);
            //Act
            player.CalculateBaseAttack();
            int actual = player.Attack.BaseAttack;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MeleeTotalAttackIsReturned()
        {
            //Arrange
            Player player = new Player("NewName", "Wizard", "Human", 1);
            player.PlayerClass.AssignBaseStats(12, 10, 10, 10, 10, 10);
            player.PlayerClass.AssignMiscMods(0, 0, 0, 0, 0, 0);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.CalculateBaseAttack();
            //Act
            player.CalculateMeleeTotal(0);
            string actual = player.PlayerClass.Attack.MeleeAttackTotal;
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SavingThrowReturned()
        {
            //Arrange
            Player player = new Player("NewName", "Wizard", "Dwarf", 1);
            player.PlayerClass.AssignBaseStats(12, 10, 10, 10, 10, 10);
            player.PlayerClass.AssignMiscMods(0, 0, 0, 0, 0, 0);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            //Act
            player.PlayerClass.CalculateThrows();
            //Assert
            int actual = player.PlayerClass.SavingThrows.ReflexClassSavingThrow;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetClassAllignments()
        {
            //Arrange
            PlayerClass pc = new Fighter();
            //Act
            string[] actual = pc.ClassAlignments;
            string[] expected = {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMagicThrowsAreAssigned()
        {
            // Arrange
            PlayerClass pc = new Ranger();
            
            // Act
            pc.AssignThrowsMagic("3","2","1");
            int actual = pc.SavingThrows.FortMagicSavingThrow;
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMiscThrowsAreAssigned()
        {
            // Arrange
            PlayerClass pc = new Ranger();

            // Act
            pc.AssignThrowsMisc("3", "2", "1");
            int actual = pc.SavingThrows.FortMiscSavingThrow;
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetThrowsAreAssigned()
        {
            Player player = new Player("NewName", "Ranger", "Human", 1);
            // Arrange
            player.PlayerClass.AssignBaseStats(18,18,18,18,18,18);
            player.CalculateTotalScore();
            player.PlayerClass.CalculateAbilityMods();
            player.PlayerClass.CalculateThrows();
            // Act
            player.PlayerClass.AssignThrows();
            int actual = player.PlayerClass.SavingThrows.FortClassSavingThrow;
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
