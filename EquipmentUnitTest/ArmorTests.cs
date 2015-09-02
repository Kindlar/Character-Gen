using Equipment;
using NUnit.Framework;

namespace EquipmentUnitTest
{
    [TestFixture]
    public class ArmorTests
    {
        Armor Armor { get; set; }

        [SetUp]
        public void SetupArmor()
        {
            Armor armor = new Armor();
            Armor = armor;
        }
        [Test]
        public void ArmorConstrucotorReturnsArmorBonus0()
        {
            int actual = Armor.ArmorBonus;
            int expect = 0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsArcaneSpellFailure0()
        {
            int actual = Armor.ArcaneSpellFailure;
            int expect = 0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsArmorCheckPenaltys0()
        {
            int actual = Armor.ArmorCheckPenalty;
            int expect = 0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsMaxDexBonus0()
        {
            int actual = Armor.MaxDexBonus;
            int expect = 0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstructorReturnSpeed0()
        {
            int actual = Armor.Speed;
            int expect = 0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsArmorBonus1()
        {
            Armor = new Armor(1,2,3,4,5,6.0,7.00m,"name");
            int actual = Armor.ArmorBonus;
            int expect = 1;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsMaxDex2()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            int actual = Armor.MaxDexBonus;
            int expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsACpenaltyReturn3()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            int actual = Armor.ArmorCheckPenalty;
            int expect = 3;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsSpellFailure4()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            int actual = Armor.ArcaneSpellFailure;
            int expect = 4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsSpeedReturns5()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            int actual = Armor.Speed;
            int expect = 5;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsCost6()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            double actual = Armor.Cost;
            double expect = 6.0;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ArmorConstrucotorReturnsWeight700M()
        {
            Armor = new Armor(1, 2, 3, 4, 5, 6.0, 7.00m, "name");
            decimal actual = Armor.Weight;
            decimal expect = 7.00m;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void BuildArmorPaddedReturnsPadded()
        {
            Armor padded = Armor.BuildArmor("Padded");
            string actual = padded.Name;
            string expected = "Padded";
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void BuildArmorLeatherReturnsLeather()
        {
            Armor leather = Armor.BuildArmor("Leather");
            string actual = leather.Name;
            string expected = "Leather";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorStuddedLeatherReturnsStuddedLeather()
        {
            Armor studdedLeather = Armor.BuildArmor("Studded leather");
            string actual = studdedLeather.Name;
            string expected = "Studded leather";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorChainShirtReturnsChainShirt()
        {
            Armor chainShirt = Armor.BuildArmor("Chain shirt");
            string actual = chainShirt.Name;
            string expected = "Chain shirt";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorHideReturnsHide()
        {
            Armor hide = Armor.BuildArmor("Hide");
            string actual = hide.Name;
            string expected = "Hide";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorScaleMailReturnsScaleMail()
        {
            Armor scaleMail = Armor.BuildArmor("Scale mail");
            string actual = scaleMail.Name;
            string expected = "Scale mail";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorChainmailReturnsChainmail()
        {
            Armor chainmail = Armor.BuildArmor("Chainmail");
            string actual = chainmail.Name;
            string expected = "Chainmail";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorBreastplateReturnsBreastplate()
        {
            Armor breastplate = Armor.BuildArmor("Breastplate");
            string actual = breastplate.Name;
            string expected = "Breastplate";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorSplintMailReturnsSplintMail()
        {
            Armor splintMail = Armor.BuildArmor("Splint mail");
            string actual = splintMail.Name;
            string expected = "Splint mail";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorBandedMailReturnsBandedMail()
        {
            Armor bandedMail = Armor.BuildArmor("Banded mail");
            string actual = bandedMail.Name;
            string expected = "Banded mail";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorHalfPlateReturnsHalfPlate()
        {
            Armor halfPlate = Armor.BuildArmor("Half-plate");
            string actual = halfPlate.Name;
            string expected = "Half-plate";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void BuildArmorFullPlateReturnsFullPlate()
        {
            Armor armor = new Armor();
            Armor fullPlate = armor.BuildArmor("Full plate");
            string actual = fullPlate.Name;
            string expected = "Full plate";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorBucklerReturnsBuckler()
        {
            Armor shield = Armor.BuildArmor("Buckler");
            string actual = shield.Name;
            string expected = "Buckler";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorLightWoodenShieldReturnsLightWoodenShield()
        {
            Armor shield = Armor.BuildArmor("Shield, light wooden");
            string actual = shield.Name;
            string expected = "Shield, light wooden";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorLightSteelShieldReturnsLightSteelShield()
        {
            Armor shield = Armor.BuildArmor("Shield, light steel");
            string actual = shield.Name;
            string expected = "Shield, light steel";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorHeavyWoodenShieldReturnsHeavyWoodenShield()
        {
            Armor shield = Armor.BuildArmor("Shield, heavy wooden");
            string actual = shield.Name;
            string expected = "Shield, heavy wooden";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorHeavySteelShieldReturnsHeavySteelShield()
        {
            Armor shield = Armor.BuildArmor("Shield, heavy steel");
            string actual = shield.Name;
            string expected = "Shield, heavy steel";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorTowerShieldReturnsTowerShield()
        {
            Armor shield = Armor.BuildArmor("Shield, tower");
            string actual = shield.Name;
            string expected = "Shield, tower";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildArmorReturnNull()
        {
            Armor.BuildArmor("null");
            string actual = Armor.Name;
            Assert.IsEmpty(actual);
        }
    }
}
