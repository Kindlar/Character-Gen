using NUnit.Framework;
using ZachsCharacterGenerater.Classes;

namespace PlayerClassesTests.CharacterClassTests
{
    [TestFixture]
    public class MonkTests
    {

        [TestCase(1, 30)]
        [TestCase(2, 30)]
        [TestCase(3, 40)]
        [TestCase(4, 40)]
        [TestCase(5, 40)]
        [TestCase(6, 50)]
        [TestCase(7, 50)]
        [TestCase(8, 50)]
        [TestCase(9, 60)]
        [TestCase(10, 60)]
        [TestCase(11, 60)]
        [TestCase(12, 70)]
        [TestCase(13, 70)]
        [TestCase(14, 70)]
        [TestCase(15, 80)]
        [TestCase(16, 80)]
        [TestCase(17, 80)]
        [TestCase(18, 90)]
        [TestCase(19, 90)]
        [TestCase(20, 90)]
        public void GivenALevel_LandSpeedIfReturned(int level, int expected)
        {

            // Arrange
            Player player = new Player("NewName", "Monk", "Human", level);

            // Act
            player.PlayerClass.GetClassGroundSpeed();
            int actual = player.TotalGround;

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}