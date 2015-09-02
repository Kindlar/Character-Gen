namespace Equipment
{
    using System.Linq;

    public class Weapon : Equipment
    {
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public int AttackBonus { get; set; }
        public string Critical { get; set; }
        public string Size { get; set; }
        public string RangeIncrement { get; set; }

        public  Weapon()
        {
            AttackBonus = 0;
            Critical = string.Empty;
            Size = string.Empty;
            Damage = string.Empty;
            DamageType = string.Empty;
            RangeIncrement = string.Empty;
        }

        public Weapon(int attackBonus, string critical, string size, string damage, string rangeIncrement, string damageType, double cost, decimal weight, string name)
            : base(cost, weight, name)
        {
            Damage = damage;
            DamageType = damageType;
            AttackBonus = attackBonus;
            Critical = critical;
            Size = size;
            RangeIncrement = rangeIncrement;
        }

        public Weapon BuildWeapon(string weapon)
        {
            switch (weapon)
            {
                case "Gauntlet":
                    Weapon gauntlet = new Weapon(0, "x2", "M", "1d3", "-", "Bludgeoning", 2, 1.00m, "Gauntlet");
                    return gauntlet;
                case "Unarmed Strike":
                    Weapon unarmedStrike = new Weapon(0, "x2", "M", "1d3", "-", "Bludgeoning", 0, 0, "Unarmed Strike");
                    return unarmedStrike;
                case "Dagger":
                    Weapon dagger = new Weapon(0, "19-20x2", "M", "1d4", "10", "Piercing or slashing", 2, 1, "Dagger");
                    return dagger;
                case "Dagger, punching":
                    Weapon daggerPunching = new Weapon(0, "x3", "M", "1d4", "-", "Piercing", 2, 1, "Dagger, punching");
                    return daggerPunching;
                case "Gauntlet, spiked":
                    Weapon gauntletSpiked = new Weapon(0, "x2", "M", "1d4", "-", "Piercing", 5, 1, "Gauntlet, spiked");
                    return gauntletSpiked;
                case "Mace, light":
                    Weapon maceLight = new Weapon(0, "x2", "M", "1d6", "-", "Bludgeoning", 5, 4, "Mace, light");
                    return maceLight;
                case "Sickle":
                    Weapon sickle = new Weapon(0, "x2", "M", "1d6", "-", "Slashing", 6, 2, "Sickle");
                    return sickle;
                case "Club":
                    Weapon club = new Weapon(0, "x2", "M", "1d6", "10", "Bludgeoning", 0, 3, "Club");
                    return club;
                case "Mace, heavy":
                    Weapon maceHeavy = new Weapon(0, "x2", "M", "1d8", "-", "Bludgeoning", 12, 8, "Mace, heavy");
                    return maceHeavy;
                case "Morningstar":
                    Weapon morningstar = new Weapon(0, "x2", "M", "1d8", "-", "Bludgeoning and Piercing", 12, 8, "Morningstar");
                    return morningstar;
                case "Shortspear":
                    Weapon shortspear = new Weapon(0, "x2", "M", "1d6", "20", "Piercing", 1, 3, "Shortspear");
                    return shortspear;
                case "Longspear":
                    Weapon longspear = new Weapon(0, "x3", "M", "1d8", "-", "Piercing", 5, 9, "Longspear");
                    return longspear;
                case "Quarterstaff":
                    Weapon quarterstaff = new Weapon(0, "x2", "M", "1d6/1d6", "-", "Bludgeoning", 0, 4, "Quarterstaff");
                    return quarterstaff;
                case "Spear":
                    Weapon spear = new Weapon(0, "x3", "M", "1d8", "20", "Piercing", 2, 6, "Spear");
                    return spear;
                case "Crossbow, heavy":
                    Weapon crossbowHeavy = new Weapon(0, "19-20x2", "M", "1d10", "120", "Piercing", 50, 8, "Crossbow, heavy");
                    return crossbowHeavy;
                case "Crossbow, light":
                    Weapon crossbowLight = new Weapon(0, "19-20x2", "M", "1d8", "80", "Piercing", 35, 4, "Crossbow, light");
                    return crossbowLight;
                case "Bolts, crossbow (10)":
                    Weapon boltsCrossbow = new Weapon(0, "-", "-", "-", "-", "-", 1, 1, "Bolts, crossbow (10)");
                    return boltsCrossbow;
                case "Dart":
                    Weapon dart = new Weapon(0, "x2", "M", "1d4", "20", "Piercing", .50, .50m, "Dart");
                    return dart;
                case "Javelin":
                    Weapon javelin = new Weapon(0, "x2", "M", "1d6", "30", "Piercing", 1, 2, "Javelin");
                    return javelin;
                case "Sling":
                    Weapon sling = new Weapon(0, "x2", "M", "1d4", "50", "Bludgeoning", 0, 0, "Sling");
                    return sling;
                case "Bullets, sling (10)":
                    Weapon bulletsSling = new Weapon(0, "-", "-", "-", "-", "-", .10, 5, "Bullets, sling");
                    return bulletsSling;
                case "Axe, throwing":
                    Weapon axeThrowing = new Weapon(0, "x2", "M", "1d6", "10", "Slashing", 8, 2, "Axe, throwing");
                    return axeThrowing;
                case "Hammer, light":
                    Weapon hammerLight = new Weapon(0, "x2", "M", "1d4", "20", "Bludgeoning", 1, 2, "Hammer, light");
                    return hammerLight;
                case "Handaxe":
                    Weapon handaxe = new Weapon(0, "x3", "M", "1d6", "-", "Slashing", 6, 3, "Handaxe");
                    return handaxe;
                case "Kukri":
                    Weapon kukri = new Weapon(0, "18-20x2", "M", "1d4", "-", "Slashing", 2, 8, "Kukri");
                    return kukri;
                case "Pick, light":
                    Weapon pickLight = new Weapon(0, "x4", "M", "1d4", "-", "Piercing", 4, 3, "Pick, light");
                    return pickLight;
                case "Sap":
                    Weapon sap = new Weapon(0, "x2", "M", "1d6", "-", "Bludgeoning", 1, 2, "Sap");
                    return sap;
                case "Shield,light":
                    Weapon shieldLight = new Weapon(0, "x2", "M", "1d3", "-", "Bludgeoning", 0, 0, "Shield Light");
                    return shieldLight;
                case "Spiked Armor":
                    Weapon spikedArmor = new Weapon(0, "x2", "M", "1d6", "-", "Piercing", 0, 0, "Spiked Armor");
                    return spikedArmor;
                case "Spiked shield, light":
                    Weapon spikedShieldLight = new Weapon(0, "x2", "M", "1d4", "-", "Piercing", 0, 0, "Spiked shield, light");
                    return spikedShieldLight;
                case "Sword, short":
                    Weapon swordShort = new Weapon(0, "19-20x2", "M", "1d6", "-", "Piercing", 10, 2, "Sword, short");
                    return swordShort;
                case "Battleaxe":
                    Weapon battleaxe = new Weapon(0, "x3", "M", "1d8", "-", "Slashing", 10, 6, "Battleaxe");
                    return battleaxe;
                case "Flail":
                    Weapon flail = new Weapon(0, "x2", "M", "1d8", "-", "Bludgeoning", 8, 5, "Flail");
                    return flail;
                case "Longsword":
                    Weapon longsword = new Weapon(0, "19-20x2", "M", "1d8", "-", "Slashing", 15, 4, "Longsword");
                    return longsword;
                case "Pick, heavy":
                    Weapon pickHeavy = new Weapon(0, "x4", "M", "1d6", "-", "Piercing", 8, 5, "Pick, heavy");
                    return pickHeavy;
                case "Rapier":
                    Weapon rapier = new Weapon(0, "18-20x2", "M", "1d6", "-", "Piercing", 20, 2, "Rapier");
                    return rapier;
                case "Scimitar":
                    Weapon scimitar = new Weapon(0, "18-20x2", "M", "1d6", "-", "Slashing", 15, 4, "Scimitar");
                    return scimitar;
                case "Shield, heavy":
                    Weapon shieldHeavy = new Weapon(0, "x2", "M", "1d4", "-", "Bludgeoning", 0, 0, "Shield,heavy");
                    return shieldHeavy;
                case "Spiked shield, heavy":
                    Weapon spikedShieldHeavy = new Weapon(0, "x2", "M", "1d6", "-", "Piercing", 15, 4, "Spiked shield,heavy");
                    return spikedShieldHeavy;
                case "Trident":
                    Weapon trident = new Weapon(0, "x2", "M", "1d8", "10", "Piercing", 15, 4, "Trident");
                    return trident;
                case "Warhammer":
                    Weapon warhammer = new Weapon(0, "x3", "M", "1d8", "-", "Bludgeoning", 12, 5, "Warhammer");
                    return warhammer;
                case "Falchion":
                    Weapon falchion = new Weapon(0, "18-20x2", "M", "2d4", "-", "Slashing", 75, 8, "Falchion");
                    return falchion;
                case "Glaive":
                    Weapon glaive = new Weapon(0, "x3", "M", "1d10", "-", "Slashing", 8, 10, "Glaive");
                    return glaive;
                case "Greataxe":
                    Weapon greataxe = new Weapon(0, "x3", "M", "1d12", "-", "Slashing", 20, 12, "Greataxe");
                    return greataxe;
                case "Greatclub":
                    Weapon greatclub = new Weapon(0, "x2", "M", "1d10", "-", "Bludgeoning", 5, 8, "Greatclub");
                    return greatclub;
                case "Flail, heavy":
                    Weapon flailHeavy = new Weapon(0, "19-20x2", "M", "1d10", "-", "Bludgeoning", 15, 10, "Flail, heavy");
                    return flailHeavy;
                case "Greatsword":
                    Weapon greatsword = new Weapon(0, "19-20x2", "M", "2d6", "-", "Slashing", 50, 8, "Greatsword");
                    return greatsword;
                case "Guisarme":
                    Weapon guisarme = new Weapon(0, "x3", "M", "2d4", "-", "Slashing", 9, 12, "Guisarme");
                    return guisarme;
                case "Halberd":
                    Weapon halberd = new Weapon(0, "x3", "M", "1d10", "-", "Piercing or Slashing", 10, 12, "Halberd");
                    return halberd;
                case "Lance":
                    Weapon lance = new Weapon(0, "x3", "M", "1d8", "-", "Piercing", 10, 10, "Lance");
                    return lance;
                case "Ranseur":
                    Weapon ranseur = new Weapon(0, "x3", "M", "2d4", "-", "Piercing", 10, 12, "Ranseur");
                    return ranseur;
                case "Scythe":
                    Weapon scythe = new Weapon(0, "x4", "M", "2d4", "-", "Piercing or Slashing", 18, 10, "Scythe");
                    return scythe;
                case "Longbow":
                    Weapon longbow = new Weapon(0, "x3", "M", "1d8", "100", "Piercing", 75, 3, "Longbow");
                    return longbow;
                case "Arrows (20)":
                    Weapon arrow = new Weapon(0, "-", "-", "-", "-", "-", 1, 3, "Arrow (20)");
                    return arrow;
                case "Longbow, composite":
                    Weapon longbowComposite = new Weapon(0, "x3", "M", "1d8", "110", "Piercing", 100, 3, "Longbow, composite");
                    return longbowComposite;
                case "Shortbow":
                    Weapon shortbow = new Weapon(0, "x3", "M", "1d6", "60", "Piercing", 30, 2, "Shortbow");
                    return shortbow;
                case "Shortbow, composite":
                    Weapon shortbowComposite = new Weapon(0, "x3", "M", "1d6", "70", "Piercing", 75, 2, "Shortbow, composite");
                    return shortbowComposite;
                case "Kama":
                    Weapon kama = new Weapon(0, "x2", "M", "1d6", "-", "Slashing", 2, 2, "Kama");
                    return kama;
                case "Nunchaku":
                    Weapon nunchaku = new Weapon(0, "x2", "M", "1d6", "-", "Bludgeoning", 2, 2, "Nunchaku");
                    return nunchaku;
                case "Sai":
                    Weapon sai = new Weapon(0, "x2", "M", "1d4", "10", "Bludgeoning", 1, 1, "Sai");
                    return sai;
                case "Siangham":
                    Weapon siangham = new Weapon(0, "x2", "M", "1d6", "-", "Piercing", 3, 1, "Siangham");
                    return siangham;
                case "Sword, bastard":
                    Weapon swordBastard = new Weapon(0, "19-20x2", "M", "1d10", "-", "Slashing", 35, 6, "Sword, bastard");
                    return swordBastard;
                case "Waraxe, dwarven":
                    Weapon waraxeDwarven = new Weapon(0, "x3", "M", "1d10", "-", "Slashing", 30, 8, "Waraxe, dwarven");
                    return waraxeDwarven;
                case "Whip":
                    Weapon whip = new Weapon(0, "x2", "M", "1d3", "-", "Slashing", 1, 2, "Whip");
                    return whip;
                case "Axe, orc double":
                    Weapon axeOrcDouble = new Weapon(0, "x3", "M", "1d8/1d8", "-", "Slashing", 60, 15, "Axe, orc double");
                    return axeOrcDouble;
                case "Chain, spiked":
                    Weapon chainSpiked = new Weapon(0, "x2", "M", "2d4", "-", "Piercing", 25, 10, "Chain, spiked");
                    return chainSpiked;
                case "Flail, dire":
                    Weapon flailDire = new Weapon(0, "x2", "M", "1d8/1d8", "-", "Bludgeoning", 25, 10, "Flail, dire");
                    return flailDire;
                case "Hammer, gnome hooked":
                    Weapon hammerGnomeHooked = new Weapon(0, "x3/x4", "M", "1d8/1d6", "-", "Bludgeoning and Piercing", 20, 10, "Hammer, gnome hooked");
                    return hammerGnomeHooked;
                case "Sword, two-bladed":
                    Weapon swordTwoBladed = new Weapon(0, "19-20x2", "M", "1d8/1d8", "-", "Slashing", 100, 10, "Sword, two-bladed");
                    return swordTwoBladed;
                case "Urgrosh, dwarven":
                    Weapon urgroshDwarven = new Weapon(0, "x3", "M", "1d8/1d6", "-", "Slashing or Piercing", 50, 12, "Urgrosh, dwarven");
                    return urgroshDwarven;
                case "Bolas":
                    Weapon bolas = new Weapon(0, "x2", "M", "1d4", "10", "Bludgeoning", 5, 2, "Bolas");
                    return bolas;
                case "Crossbow, hand":
                    Weapon crossbowHand = new Weapon(0, "19-20x2", "M", "1d4", "30", "Piercing", 100, 2, "Crossbow, hand");
                    return crossbowHand;
                case "Bolts, crossbow(5)":
                    Weapon boltsCrossbow5 = new Weapon(0, "-", "-", "-", "-", "-", 1, 1, "Bolts, crossbow");
                    return boltsCrossbow5;
                case "Crossbow, repeating heavy":
                    Weapon crossbowRepeatingHeavy = new Weapon(0, "19-20x2", "M", "1d10", "120", "Piercing", 400, 12, "Crossbow, repeating heavy");
                    return crossbowRepeatingHeavy;
                case "Crossbow, repeating light":
                    Weapon crossbowRepeatingLight = new Weapon(0, "19-20x2", "M", "1d8", "80", "Piercing", 250, 6, "Crossbow, repeating heavy");
                    return crossbowRepeatingLight;
                case "Net":
                    Weapon net = new Weapon(0, "-", "M", "-", "10", "-", 20, 1, "Net");
                    return net;
                case "Shuriken":
                    Weapon shuriken = new Weapon(0, "x2", "M", "1d2", "10", "Piercing", 1, .50m, "Shuriken");
                    return shuriken;
            }
            return new Weapon(0, "Error", "Error", "Error", "Error", "Error", 0, 0, "Error");
        }
    }
}
