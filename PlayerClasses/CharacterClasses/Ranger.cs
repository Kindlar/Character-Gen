using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Ranger : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Ranger"; }
            set { base.ChosenClass = value; }
        }
        public override string[] ClassSkills { get; set; }
        public override string[] ClassAbilities { get; set; }
        public override object[] ClassArmor { get {return new object[] { "Padded", "Leather", "Studded leather", "Chain shirt" };} set
        {
            base.ClassArmor = value;
        } }
        public override object[] ClassShields { get {return new object[] { "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"};} set { base.ClassShields = value; } }
        public override object[] ClassWeapons { get {return new object[] {"Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle",
                "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri", "Pick, light", "Sap",
                "Sword, short", "Battleaxe", "Flail",
                "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer", "Falchion", "Glaive",
                "Greataxe", "Greatclub", "Flail, heavy",
                "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow", "Longbow, composite",
                "Shortbow", "Shortbow, composite", "Arrows (20)"};} set { base.ClassWeapons = value; } }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4()) * 10;
            }
            set { base.Gold = value; }
        }
        public string[] SpellSchools { get; set; }

        public override void GetClassSpellsPerDay()
        {
            switch (PlayerLevel)
            {
                case 1:
                case 2:
                case 3:
                   Magic.ClassSpellsPerDay = new int[] { };
                    break;
                case 4:
                case 5:
                   Magic.ClassSpellsPerDay = new[] { 0 };
                    break;
                case 6:
                case 7:
                   Magic.ClassSpellsPerDay = new[] { 1 };
                    break;
                case 8:
                case 9:
                   Magic.ClassSpellsPerDay = new[] { 1, 0 };
                    break;
                case 10:
                   Magic.ClassSpellsPerDay = new[] { 1, 1 };
                    break;
                case 11:
                   Magic.ClassSpellsPerDay = new[] { 1, 1, 0 };
                    break;
                case 12:
                case 13:
                   Magic.ClassSpellsPerDay = new[] { 1, 1, 1 };
                    break;
                case 14:
                   Magic.ClassSpellsPerDay = new[] { 2, 1, 1, 0 };
                    break;
                case 15:
                   Magic.ClassSpellsPerDay = new[] { 2, 1, 1, 1 };
                    break;
                case 16:
                   Magic.ClassSpellsPerDay = new[] { 2, 2, 1, 1 };
                    break;
                case 17:
                   Magic.ClassSpellsPerDay = new[] { 2, 2, 2, 1 };
                    break;
                case 18:
                   Magic.ClassSpellsPerDay = new[] { 3, 2, 2, 1 };
                    break;
                case 19:
                   Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 2 };
                    break;
                case 20:
                   Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 3 };
                    break;
            }
        }

        public override void GetBonusSpells()
        {
            BonusSpells bonusSpells = new BonusSpells();
            Magic.BonusSpells = bonusSpells.BonusSpellsCalculate(StatMods.ChaAbilityMod);
        }

        public override void GetSpellDifficultyClass()
        {
            if (Magic.ClassSpellsPerDay != null)
            {
                int i =Magic.ClassSpellsPerDay.Length;
                Magic.SpellDC = new int[i];

                for (int j = 0; j < i; j++)
                {

                    Magic.SpellDC[j] = (10 + StatMods.WisAbilityMod + j);
                }
            }
        }
    }
}
