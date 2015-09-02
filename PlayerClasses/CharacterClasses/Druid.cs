using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Druid : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Druid"; }
            set { base.ChosenClass = value; }
        }
        public override string[] ClassAbilities { get; set; }
        public override string[] ClassAlignments
        {
            get
            {
                return new[] { "Lawful Neutral", "Neutral Good", "True Neutral", "Neutral Evil", "Chaotic Neutral" };
            }
            set { base.ClassAlignments = value; }
        }
        public override object[] ClassArmor {
            get
            {
                return new[] {"Padded", "Leather", "Hide"};
            }
            set
            { base.ClassArmor = value; }
        }
        public override object[] ClassShields
        {
            get
            {
                return new[] 
                {"Shield, light wooden", "Shield, heavy wooden"};
            } set
        {
            base.ClassShields = value;
        } }
        public override object[] ClassWeapons { get
        {
            return new[] {"Club", "Dagger", "Dart", "QuarterStaff", "Scimitar", "Sickle", "Shortspear", "Sling", "Spear"};
        } set{ base.ClassWeapons = value; } }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4()) * 10;
            }
            set { base.Gold = value; }
        }

        public string[] SpellSchools { get; set; }

        public override void GetClassSpellsPerDay()
        {
            switch (PlayerLevel)
            {
                case 1:
                   Magic.ClassSpellsPerDay = new[] { 3, 1 };
                    break;
                case 2:
                   Magic.ClassSpellsPerDay = new[] { 4, 2 };
                    break;
                case 3:
                   Magic.ClassSpellsPerDay = new[] { 4, 2, 1 };
                    break;
                case 4:
                   Magic.ClassSpellsPerDay = new[] { 5, 3, 2 };
                    break;
                case 5:
                   Magic.ClassSpellsPerDay = new[] { 5, 3, 2, 1 };
                    break;
                case 6:
                   Magic.ClassSpellsPerDay = new[] { 5, 3, 3, 2 };
                    break;
                case 7:
                   Magic.ClassSpellsPerDay = new[] { 6, 4, 3, 2, 1 };
                    break;
                case 8:
                   Magic.ClassSpellsPerDay = new[] { 6, 4, 3, 3, 2 };
                    break;
                case 9:
                   Magic.ClassSpellsPerDay = new[] { 6, 4, 4, 3, 2, 1 };
                    break;
                case 10:
                   Magic.ClassSpellsPerDay = new[] { 6, 4, 4, 3, 3, 2 };
                    break;
                case 11:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 4, 4, 3, 2, 1 };
                    break;
                case 12:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 4, 4, 3, 3, 2 };
                    break;
                case 13:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 4, 4, 3, 2, 1 };
                    break;
                case 14:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 4, 4, 3, 3, 2 };
                    break;
                case 15:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 4, 4, 3, 2, 1 };
                    break;
                case 16:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 4, 4, 3, 3, 2 };
                    break;
                case 17:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 5, 4, 4, 3, 2, 1 };
                    break;
                case 18:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 5, 4, 4, 3, 3, 2 };
                    break;
                case 19:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 5, 5, 4, 4, 3, 3 };
                    break;
                case 20:
                   Magic.ClassSpellsPerDay = new[] { 6, 5, 5, 5, 5, 5, 4, 4, 4, 4 };
                    break;

            }
        }

        public override void GetBonusSpells()
        {
            BonusSpells bonusSpells = new BonusSpells();
            Magic.BonusSpells = bonusSpells.BonusSpellsCalculate(StatMods.WisAbilityMod);
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
