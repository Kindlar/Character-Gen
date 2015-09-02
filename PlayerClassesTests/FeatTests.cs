using NUnit.Framework;
using PlayerClasses;

namespace PlayerClassesTests
{
    [TestFixture]
    public class FeatTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(5, 2)]
        [TestCase(6, 3)]
        [TestCase(7, 3)]
        [TestCase(8, 3)]
        [TestCase(9, 4)]
        [TestCase(10, 4)]
        [TestCase(11, 4)]
        [TestCase(12, 5)]
        [TestCase(13, 5)]
        [TestCase(14, 5)]
        [TestCase(15, 6)]
        [TestCase(16, 6)]
        [TestCase(17, 6)]
        [TestCase(18, 7)]
        [TestCase(19, 7)]
        [TestCase(20, 7)]
        [TestCase(21, 0)]
        public void GivenALevel_ReturnsFeat(int level, int expected)
        {
            Feats feats = new Feats();
            int actual = feats.FeatCalculate(level);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Human", 1)]
        [TestCase("Elf", 0)]

        public void GivenARace_ReturnRaceFeats(string race, int expected)
        {
            Feats feats = new Feats();
            int actual = feats.RacialFeatCalculate(race);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Cleric", 1, 0)]
        [TestCase("Fighter", 1, 1)]
        [TestCase("Fighter", 2, 2)]
        [TestCase("Fighter", 3, 2)]
        [TestCase("Fighter", 4, 3)]
        [TestCase("Fighter", 5, 3)]
        [TestCase("Fighter", 6, 4)]
        [TestCase("Fighter", 7, 4)]
        [TestCase("Fighter", 8, 5)]
        [TestCase("Fighter", 9, 5)]
        [TestCase("Fighter", 10, 6)]
        [TestCase("Fighter", 11, 6)]
        [TestCase("Fighter", 12, 7)]
        [TestCase("Fighter", 13, 7)]
        [TestCase("Fighter", 14, 8)]
        [TestCase("Fighter", 15, 8)]
        [TestCase("Fighter", 16, 9)]
        [TestCase("Fighter", 17, 9)]
        [TestCase("Fighter", 18, 10)]
        [TestCase("Fighter", 19, 10)]
        [TestCase("Fighter", 20, 11)]
        [TestCase("Monk", 1, 1)]
        [TestCase("Monk", 2, 2)]
        [TestCase("Monk", 3, 2)]
        [TestCase("Monk", 4, 2)]
        [TestCase("Monk", 5, 2)]
        [TestCase("Monk", 6, 3)]
        [TestCase("Monk", 7, 3)]
        [TestCase("Monk", 8, 3)]
        [TestCase("Monk", 9, 3)]
        [TestCase("Monk", 10, 3)]
        [TestCase("Monk", 11, 3)]
        [TestCase("Monk", 12, 3)]
        [TestCase("Monk", 13, 3)]
        [TestCase("Monk", 14, 3)]
        [TestCase("Monk", 15, 3)]
        [TestCase("Monk", 16, 3)]
        [TestCase("Monk", 17, 3)]
        [TestCase("Monk", 18, 3)]
        [TestCase("Monk", 19, 3)]
        [TestCase("Monk", 20, 3)]
        [TestCase("Wizard", 1, 0)]
        [TestCase("Wizard", 2, 0)]
        [TestCase("Wizard", 3, 0)]
        [TestCase("Wizard", 4, 0)]
        [TestCase("Wizard", 5, 1)]
        [TestCase("Wizard", 6, 1)]
        [TestCase("Wizard", 7, 1)]
        [TestCase("Wizard", 8, 1)]
        [TestCase("Wizard", 9, 1)]
        [TestCase("Wizard", 10, 2)]
        [TestCase("Wizard", 11, 2)]
        [TestCase("Wizard", 12, 2)]
        [TestCase("Wizard", 13, 2)]
        [TestCase("Wizard", 14, 2)]
        [TestCase("Wizard", 15, 3)]
        [TestCase("Wizard", 16, 3)]
        [TestCase("Wizard", 17, 3)]
        [TestCase("Wizard", 18, 3)]
        [TestCase("Wizard", 19, 3)]
        [TestCase("Wizard", 20, 4)]
        public void GivenAClass_ClassFeatsAreReturned(string chosenClass, int level, int expected)
        {
            Feats feats = new Feats();
            int actual = feats.ClassFeatCalculate(chosenClass, level);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HumanFighterLevel10Returns11()
        {
            Feats feats = new Feats();
            int actual = feats.TotalFeats(10,"Human");
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DwarfClericLevel6Returns3()
        {
            Feats feats = new Feats();
            int actual = feats.TotalFeats(6, "Dwarf");
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}