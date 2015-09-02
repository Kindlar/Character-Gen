using NUnit.Framework;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class BarbarianTests
    {
        Player Player { get; set; }

        [SetUp]
        public void Init()
        {
            Player = new Player("New Name", "Barbarian", "Human", 1);
        }

        [TestCase(1, new[] { "Fast movement", "illiteracy", "rage 1/day" })]
        [TestCase(2, new[] { "Fast movement", "illiteracy", "rage 1/day", "uncanny dodge" })]
        [TestCase(3, new[] { "Fast movement", "illiteracy", "rage 1/day", "uncanny dodge", "trap sense +1" })]
        [TestCase(4, new[] { "Fast movement", "illiteracy", "rage 2/day", "uncanny dodge", "trap sense +1" })]
        [TestCase(5, new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +1" })]
        [TestCase(6, new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +2" })]
        [TestCase(7, new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +2", "damage reduction 1/-" })]
        [TestCase(8, new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +2", "damage reduction 1/-" })]
        [TestCase(9, new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 1/-" })]
        [TestCase(10, new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 2/-" })]
        [TestCase(11, new[] { "Fast movement", "illiteracy", "greater rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 2/-" })]
        [TestCase(12, new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", "damage reduction 2/-" })]
        [TestCase(13, new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", "damage reduction 3/-" })]
        [TestCase(14, new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", 
            "damage reduction 3/-", "indomitable will" })]
        [TestCase(15, new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +5", 
            "damage reduction 3/-", "indomitable will" })]
        [TestCase(16, new[] { "Fast movement", "illiteracy", "greater rage 5/day", "improved uncanny dodge", "trap sense +5", 
            "damage reduction 4/-", "indomitable will" })]
        [TestCase(17, new[] { "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +5", 
            "damage reduction 4/-", "indomitable will" })]
        [TestCase(18, new[] { "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +6", 
            "damage reduction 4/-", "indomitable will" })]
        [TestCase(19, new[] { "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +6", 
            "damage reduction 5/-", "indomitable will" })]
        [TestCase(20, new[] { "Fast movement", "illiteracy", "tireless mighty rage 6/day", "improved uncanny dodge", "trap sense +6", 
            "damage reduction 5/-", "indomitable will" })]
        public void GivenALevel_SkillArrayIsReturned(int level, string[] expected)
        {
            Player player = new Player("New Name", "Barbarian", "Human", level);
            player.PlayerClass.AssignLevel(level);
            player.PlayerClass.AssignClassAbilties();
            string[] actual = player.PlayerClass.ClassAbilities;
            Assert.AreEqual(expected, actual);
        }
    }
}
