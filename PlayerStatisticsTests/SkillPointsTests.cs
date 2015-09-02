using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class SkillPointsUnitTest
    {
        [Test]
        public void HumanReturns4()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 4;
            int actual = skillPoints.SkillPointRace("Human");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ElfReturns0()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 0;
            int actual = skillPoints.SkillPointRace("Elf");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HumanLevel5Returns4()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 4;
            int actual = skillPoints.SkillPointRaceHighlevel(5,"Human");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ElfLevel5Returns0()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 0;
            int actual = skillPoints.SkillPointRaceHighlevel(5,"Elf");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BarbarianIntModNegative1Returns12()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 12;
            int actual = skillPoints.SkillPointTotalLevelOne(-1, "Barbarian");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BardIntMod2Returns32()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 32;
            int actual = skillPoints.SkillPointTotalLevelOne(2, "Bard");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RogueIntMod4Returns48()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 48;
            int actual = skillPoints.SkillPointTotalLevelOne(4, "Rogue");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OtherIntMod3Returns20()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 20;
            int actual = skillPoints.SkillPointTotalLevelOne(3, "");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BarbarianLevel2IntMod2Returns6()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 6;
            int actual = skillPoints.SkillPointTotalHighLevel(2, 2, "Barbarian");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RangerLevel20IntMod0Returns114()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 114;
            int actual = skillPoints.SkillPointTotalHighLevel(20, 0, "Bard");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RogueLevel10IntMod4Returns108()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 108;
            int actual = skillPoints.SkillPointTotalHighLevel(10, 4, "Rogue");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ClericLevel1IntMod4Returns0()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 0;
            int actual = skillPoints.SkillPointTotalHighLevel(1, 4, "Cleric");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OtherLevel2IntMod4Returns6()
        {
            SkillPoints skillPoints = new SkillPoints();
            int expected = 6;
            int actual = skillPoints.SkillPointTotalHighLevel(2, 4, "");
            Assert.AreEqual(expected, actual);
        }

    }
            
    [TestFixture]
    public class SkillPointsIntergrationTest
    {
        [Test]
        public void Level1HumanRangerIntMod4Returns24()
        {
            SkillPoints skillpoints = new SkillPoints();
            int expected = 44;
            int actual = skillpoints.SkillPointTotal(1, 4,"Ranger","Human");
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Level1ElfWizardIntMod4Returns24()
        {
            SkillPoints skillpoints = new SkillPoints();
            int expected = 24;
            int actual = skillpoints.SkillPointTotal(1, 4, "Wizard", "Elf");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level2HumanWizardIntMod4Returns35()
        {
            SkillPoints skillpoints = new SkillPoints();
            int expected = 35;
            int actual = skillpoints.SkillPointTotal(2, 4, "Wizard", "Human");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level2ElfClericIntMod4Returns38()
        {
            SkillPoints skillpoints = new SkillPoints();
            int expected = 30;
            int actual = skillpoints.SkillPointTotal(2, 4, "Cleric", "Elf");
            Assert.AreEqual(expected, actual);
        }
    }
}
