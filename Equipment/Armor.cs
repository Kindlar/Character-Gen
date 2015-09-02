namespace Equipment
{
    public class Armor : Equipment
    {
        public int ArmorBonus { get; set; }
        public int MaxDexBonus { get; set; }
        public int ArmorCheckPenalty { get; set; }
        public int ArcaneSpellFailure { get; set; }
        public int Speed { get; set; }

        public Armor()
        {
            ArmorBonus = 0;
            MaxDexBonus = 0;
            ArmorCheckPenalty = 0;
            ArcaneSpellFailure = 0;
            Speed = 0;
        }

        public Armor(int armorBonus, int maxDex, int aCPenalty, int spellFailure, int speed, double cost, decimal weight, string name) : base( cost, weight, name)
        {
            ArmorBonus = armorBonus;
            MaxDexBonus = maxDex;
            ArmorCheckPenalty = aCPenalty;
            ArcaneSpellFailure = spellFailure;
            Speed = speed;   
        }

        public Armor BuildArmor(string armor)
        {
            switch (armor)
            {
                case "Padded":
                    Armor padded = new Armor(1, 8, 0, 5, 30, 5.00, 10, "Padded");
                    return padded;
                case "Leather":
                    Armor leather = new Armor(2, 6, 0, 10, 30, 10.00, 15, "Leather");
                    return leather;
                case "Studded leather":
                    Armor studdedLeather = new Armor(3, 5, -1, 15, 30, 25.00, 25, "Studded leather");
                    return studdedLeather;
                case "Chain shirt":
                    Armor chainShirt = new Armor(4, 4, -2, 20, 30, 100.00, 25, "Chain shirt");
                    return chainShirt;
                case "Hide":
                    Armor hide = new Armor(3, 4, -3, 20, 20, 15.00, 25, "Hide");
                    return hide;
                case "Scale mail":
                    Armor scale = new Armor(4, 3, -4, 25, 20, 50.00, 30, "Scale mail");
                    return scale;
                case "Chainmail":
                    Armor chainMail = new Armor(5, 2, -5, 30, 20, 150.00, 40, "Chainmail");
                    return chainMail;
                case "Breastplate":
                    Armor breastPlate = new Armor(5, 3, -4, 25, 20, 200.00, 30, "Breastplate");
                    return breastPlate;
                case "Splint mail":
                    Armor splintMail = new Armor(6, 0, -7, 40, 20, 200.00, 45, "Splint mail");
                    return splintMail;
                case "Banded mail":
                    Armor bandedMail = new Armor(6, 1, -6, 35, 20, 250.00, 35, "Banded mail");
                    return bandedMail;
                case "Half-plate":
                    Armor halfPlate = new Armor(7, 0, -7, 40, 20, 600.00, 50, "Half-plate");
                    return halfPlate;
                case "Full plate":
                    Armor fullPlate = new Armor(8, 1, -6, 35, 20, 1500.00, 50, "Full plate");
                    return fullPlate;
                case "Buckler":
                    Armor buckler = new Armor(1, 0, -1, 5, 0, 15, 5, "Buckler");
                    return buckler;
                case "Shield, light wooden":
                    Armor lightWoodenShield = new Armor(1, 0, -1, 5, 0, 3, 5, "Shield, light wooden");
                    return lightWoodenShield;
                case "Shield, light steel":
                    Armor lightSteelShield = new Armor(1, 0, -1, 5, 0, 9, 6, "Shield, light steel");
                    return lightSteelShield;
                case "Shield, heavy wooden":
                    Armor heavyWoodenShield = new Armor(2, 0, -1, 15, 0, 7, 10, "Shield, heavy wooden");
                    return heavyWoodenShield;
                case "Shield, heavy steel":
                    Armor heavySteelShield = new Armor(2, 0, -2, 15, 0, 20, 15, "Shield, heavy steel");
                    return heavySteelShield;
                case "Shield, tower":
                    Armor towerShield = new Armor(4, 2, -10, 50, 0, 30, 45, "Shield, tower");
                    return towerShield;
            }
            return null;
        }
    }
}
