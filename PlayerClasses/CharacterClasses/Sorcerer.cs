using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Sorcerer : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Sorcerer"; }
            set { base.ChosenClass = value; }
        }
        public override string[] ClassSkills { get; set; }
        public override string[] ClassAbilities { get; set; }
        public override object[] ClassWeapons { get {return new object[] { "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle", "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff","Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)"};} set { base.ClassWeapons = value; } }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4()) * 10;
            }
            set { base.Gold = value; }
        }
        public string[] SpellSchools { get; set; }

        public override void GetClassSpellsPerDay()
        {
            switch (PlayerLevel)
            {
                case 1:
                   Magic.ClassSpellsPerDay = new[] { 5, 3 };
                    break;
                case 2:
                   Magic.ClassSpellsPerDay = new[] { 6, 4 };
                    break;
                case 3:
                   Magic.ClassSpellsPerDay = new[] { 6, 5 };
                    break;
                case 4:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 3 };
                    break;
                case 5:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 4 };
                    break;
                case 6:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 5, 3 };
                    break;
                case 7:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 4 };
                    break;
                case 8:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 5, 3 };
                    break;
                case 9:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 4 };
                    break;
                case 10:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 5, 3 };
                    break;
                case 11:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 4 };
                    break;
                case 12:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 5, 3 };
                    break;
                case 13:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 4 };
                    break;
                case 14:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 5, 3 };
                    break;
                case 15:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 4 };
                    break;
                case 16:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 5, 3 };
                    break;
                case 17:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 6, 4 };
                    break;
                case 18:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 6, 5, 3 };
                    break;
                case 19:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 4 };
                    break;
                case 20:
                   Magic.ClassSpellsPerDay = new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
                    break;
            }
        }

        public override void GetBonusSpells()
        {
            BonusSpells bonusSpells = new BonusSpells();
            Magic.BonusSpells = bonusSpells.BonusSpellsCalculate(StatMods.ChaAbilityMod);
        }

        public override void GetClassKnownSpells()
        {
            switch (PlayerLevel)
            {
                case 1:
                   Magic.SpellsKnown = new[] { 4, 2 };
                    break;
                case 2:
                   Magic.SpellsKnown = new[] { 5, 2 };
                    break;
                case 3:
                   Magic.SpellsKnown = new[] { 5, 3 };
                    break;
                case 4:
                   Magic.SpellsKnown = new[] { 6, 3, 1 };
                    break;
                case 5:
                   Magic.SpellsKnown = new[] { 6, 4, 2 };
                    break;
                case 6:
                   Magic.SpellsKnown = new[] { 7, 4, 2, 1 };
                    break;
                case 7:
                   Magic.SpellsKnown = new[] { 7, 5, 3, 2 };
                    break;
                case 8:
                   Magic.SpellsKnown = new[] { 8, 5, 3, 2, 1 };
                    break;
                case 9:
                   Magic.SpellsKnown = new[] { 8, 5, 4, 3, 2 };
                    break;
                case 10:
                   Magic.SpellsKnown = new[] { 9, 5, 4, 3, 2, 1 };
                    break;
                case 11:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 3, 2 };
                    break;
                case 12:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 3, 2, 1 };
                    break;
                case 13:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 3, 2 };
                    break;
                case 14:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 3, 2, 1 };
                    break;
                case 15:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 2 };
                    break;
                case 16:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 2, 1 };
                    break;
                case 17:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 3, 2 };
                    break;
                case 18:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 3, 2, 1 };
                    break;
                case 19:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 3, 3, 2 };
                    break;
                case 20:
                   Magic.SpellsKnown = new[] { 9, 5, 5, 4, 4, 4, 3, 3, 3, 3 };
                    break;
            }
        }

        public override void GetSpellDifficultyClass()
        {
            if (Magic.ClassSpellsPerDay != null)
            {
                int i =Magic.ClassSpellsPerDay.Length;
                Magic.SpellDC = new int[i];

                for (int j = 0; j < i ; j++)
                {

                    Magic.SpellDC[j] = (10 + StatMods.ChaAbilityMod + j);
                }
            }
        }
    }
}
