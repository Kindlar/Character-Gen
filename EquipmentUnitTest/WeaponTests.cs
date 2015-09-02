using Equipment;
using NUnit.Framework;

namespace EquipmentUnitTest
{
    [TestFixture]
    public class WeaponTests
    {
        [TestCase("Gauntlet", 2)]
        [TestCase("Unarmed Strike", 0)]
        [TestCase("Dagger", 2)]
        [TestCase("Dagger, punching", 2)]
        [TestCase("Gauntlet, spiked", 5)]
        [TestCase("Mace, light", 5)]
        [TestCase("Sickle", 6)]
        [TestCase("Club", 0)]
        [TestCase("Mace, heavy", 12)]
        [TestCase("Morningstar", 12)]
        [TestCase("Shortspear", 1)]
        [TestCase("Longspear", 5)]
        [TestCase("Quarterstaff", 0)]
        [TestCase("Spear", 2)]
        [TestCase("Crossbow, heavy", 50)]
        [TestCase("Crossbow, light", 35)]
        [TestCase("Bolts, crossbow (10)", 1)]
        [TestCase("Dart", .5)]
        [TestCase("Javelin", 1)]
        [TestCase("Sling", 0)]
        [TestCase("Bullets, sling (10)", .10)]
        [TestCase("Axe, throwing", 8)]
        [TestCase("Hammer, light", 1)]
        [TestCase("Handaxe", 6)]
        [TestCase("Kukri", 2)]
        [TestCase("Pick, light", 4)]
        [TestCase("Sap", 1)]
        [TestCase("Shield,light", 0)]
        [TestCase("Spiked Armor", 0)]
        [TestCase("Spiked shield, light", 0)]
        [TestCase("Sword, short", 10)]
        [TestCase("Battleaxe", 10)]
        [TestCase("Flail", 8)]
        [TestCase("Longsword", 15)]
        [TestCase("Pick, heavy", 8)]
        [TestCase("Rapier", 20)]
        [TestCase("Scimitar", 15)]
        [TestCase("Shield, heavy", 0)]
        [TestCase("Spiked shield, heavy", 15)]
        [TestCase("Trident", 15)]
        [TestCase("Warhammer", 12)]
        [TestCase("Falchion", 75)]
        [TestCase("Glaive", 8)]
        [TestCase("Greataxe", 20)]
        [TestCase("Greatclub", 5)]
        [TestCase("Flail, heavy", 15)]
        [TestCase("Greatsword", 50)]
        [TestCase("Guisarme", 9)]
        [TestCase("Halberd", 10)]
        [TestCase("Ranseur", 10)]
        [TestCase("Scythe", 18)]
        [TestCase("Longbow", 75)]
        [TestCase("Arrows (20)", 1)]
        [TestCase("Longbow, composite", 100)]
        [TestCase("Shortbow", 30)]
        [TestCase("Shortbow, composite", 75)]
        [TestCase("Kama", 2)]
        [TestCase("Nunchaku", 2)]
        [TestCase("Sai", 1)]
        [TestCase("Siangham",3)]
        [TestCase("Sword, bastard", 35)]
        [TestCase("Waraxe, dwarven", 30)]
        [TestCase("Whip", 1)]
        [TestCase("Axe, orc double", 60)]
        [TestCase("Chain, spiked", 25)]
        [TestCase("Flail, dire",25)]
        [TestCase("Hammer, gnome hooked", 20)]
        [TestCase("Sword, two-bladed", 100)]
        [TestCase("Urgrosh, dwarven", 50)]
        [TestCase("Bolas", 5)]
        [TestCase("Crossbow, hand", 100)]
        [TestCase("Bolts, crossbow(5)",1)]
        [TestCase("Crossbow, repeating heavy", 400)]
        [TestCase("Crossbow, repeating light", 250)]
        [TestCase("Net", 20)]
        [TestCase("Shuriken", 1)]
        [TestCase("Lance", 10)]
        [TestCase("", 0)]
        public void GivenAWeaponName_ACostPropertyIsAssigned(string equipName, double expectedCost)
        {
            // Arrange
            Weapon weapon = new Weapon();

            // Act
            Equipment.Equipment builtWeapon = weapon.BuildWeapon(equipName);
            var actualCost = builtWeapon.Cost;

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}