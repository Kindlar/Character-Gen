using NUnit.Framework;
using PlayerClasses;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class RogueTests
    {
        [Test]
        public void GetRogueName()
        {
            Player player = new Player("Name", "Rogue", "Human", 1);
            string actual = player.PlayerClass.ChosenClass;
            string expected = "Rogue";
            Assert.AreEqual(expected, actual);
        }
    }
}