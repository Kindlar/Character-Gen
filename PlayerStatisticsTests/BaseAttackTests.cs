using NUnit.Framework;
using PlayerStatisics;

namespace PlayerStatisticsTests
{
    [TestFixture]
    public class BaseAttackUnitTests
    {
        [Test]
        public void Level1FightReturns1()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            int expected = 1;
            int actual = bAttack.GetBaseAttack(1, "Fighter");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level20SorcererReturns105()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            int expected = 10;
            int actual = bAttack.GetBaseAttack(20, "Sorcerer");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level11ClericReturns83()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            int expected = 8;
            int actual = bAttack.GetBaseAttack(11, "Cleric");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Level1NullReturns0()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            int expected = 1;
            int actual = bAttack.GetBaseAttack(1, "");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BadDataToHitException()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            int expected = -999;
            int actual = bAttack.GetBaseAttack(99, "");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack1Return11()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11";
            string actual = bAttack.BaseAttackString(1, 11);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Baseattack2Return11()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11";
            string actual = bAttack.BaseAttackString(2, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack3Return11()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11";
            string actual = bAttack.BaseAttackString(3, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack4Return11()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11";
            string actual = bAttack.BaseAttackString(4, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack5Return11()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11";
            string actual = bAttack.BaseAttackString(5, 11);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Baseattack6Return116()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6";
            string actual = bAttack.BaseAttackString(6, 11);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Baseattack7Return116()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6";
            string actual = bAttack.BaseAttackString(7, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack8Return116()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6";
            string actual = bAttack.BaseAttackString(8, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack9Return116()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6";
            string actual = bAttack.BaseAttackString(9, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack10Return116()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6";
            string actual = bAttack.BaseAttackString(10, 11);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Baseattack11Return1161()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6/1";
            string actual = bAttack.BaseAttackString(11, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack12Return1161()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6/1";
            string actual = bAttack.BaseAttackString(12, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack13Return1161()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6/1";
            string actual = bAttack.BaseAttackString(13, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack14Return1161()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6/1";
            string actual = bAttack.BaseAttackString(14, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack15Return1161()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "11/6/1";
            string actual = bAttack.BaseAttackString(15, 11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack16Return1050()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5/0/-5";
            string actual = bAttack.BaseAttackString(16, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack17Return1050()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5/0/-5";
            string actual = bAttack.BaseAttackString(17, 10);
            Assert.AreEqual(expected, actual);
        } 

        [Test]
        public void Baseattack18Return1050()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5/0/-5";
            string actual = bAttack.BaseAttackString(18, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack19Return1050()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5/0/-5";
            string actual = bAttack.BaseAttackString(19, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Baseattack20Return1050()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5/0/-5";
            string actual = bAttack.BaseAttackString(20, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BastAttackString105()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "10/5";
            string actual = bAttack.BaseAttackString(10);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void BastAttackString15105()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "15/10/5";
            string actual = bAttack.BaseAttackString(15);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BastAttackString2015105()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "20/15/10/5";
            string actual = bAttack.BaseAttackString(20);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BastAttackStringBad5()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "Error";
            string actual = bAttack.BaseAttackString(-5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BastAttackStringBad50()
        {
            BaseAttackModifier bAttack = new BaseAttackModifier();
            string expected = "Error";
            string actual = bAttack.BaseAttackString(-5,0);
            Assert.AreEqual(expected, actual);
        }
    }
}
