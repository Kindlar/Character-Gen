namespace ZachsCharacterGenerater
{
    using Classes;
    using NUnit.Framework;
    
    [TestFixture]
    public class PlayerTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player player = new Player("Kindlar", "Fighter", "Elf", 1);
            Player = player;
            Player.PlayerClass.AssignBaseStats(10, 10, 10, 10, 10, 10);
            Player.CalculateTotalScore();
            Player.PlayerClass.CalculateBaseAttack();
            Player.GetTotalGroundSpeed();
        }

        [Test]
        public void PlayerCharacter_GivenAName_PlayerNameIsAssigned()
        {
            string actual = Player.Name;
            Assert.AreEqual("Kindlar", actual);
        }

        [Test]
        public void PlayerCharacter_GivenAName_PlayerClassIsAssigned()
        {
            string actual = Player.PlayerClass.ChosenClass;
            Assert.AreEqual("Fighter", actual);
        }

        [Test]
        public void PlayerCharacter_GivenAName_RaceIsAssigned()
        {
            string actual = Player.Race.RaceName;
            Assert.AreEqual("Elf", actual);
        }

        [Test]
        public void PlayerCharacter_GivenALevel_LevelIsAssigned()
        {
            int actual = Player.PlayerClass.PlayerLevel;
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void PlayerCharacter_GivenRace_RacialStatsAssigned()
        {
            int actual = Player.Race.DexRacialMod;
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void PlayerCharacter_GivenACharacter_GroundSpeedIsAssigned()
        {
            int actual = Player.TotalGround;
            Assert.AreEqual(30, actual);
        }

        [Test]
        public void PlayerChatacter_RangedAttackused_ReturnIsNotNull()
        {

            Player.CalculateRangeTotal(0);
            string actual = Player.PlayerClass.Attack.RangedAttackTotal;
            Assert.AreEqual("2", actual);
        }
    }
}
