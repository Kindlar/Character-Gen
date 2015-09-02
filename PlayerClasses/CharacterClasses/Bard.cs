using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Bard : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Bard"; } set { base.ChosenClass = value; }
        }
        public override string[] ClassAbilities { get; set; }
        public override string[] ClassAlignments
        {
            get
            {
                return new[] { "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
            }
            set { base.ClassAlignments = value; }
        }
        public override object[] ClassArmor { get
        {
            return new[] {"Padded", "Leather", "Studded leather", "Chain shirt"};
        } set { base.ClassArmor = value; } }
        public override object[] ClassShields {
            get
            {
                return new[]
                {
                    "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                    "Shield, heavy steel"
                };
            }
            set { base.ClassShields = value; } }
        public override object[] ClassWeapons { get
        {
            return new[]
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle",
                "Club", "Mace, heavy",
                "Morningstar", "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                "Bolts, crossbow (10)", "Dart", "Javelin"
                , "Sling", "Bullets, sling (10)", "Longsword", "Rapier", "Sap", "Sword, short", "Shortbow", "Whip"
            };
        } set { base.ClassWeapons = value; }}
        public override double Gold{
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4() + dice.D4()) * 10;
            }
            set { base.Gold = value; }
        }

        public override void AssignClassAbilties()
        {
            switch (PlayerLevel)
            {
                case 1:
                case 2:
                    ClassAbilities = new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1" };
                    break;
                case 3:
                case 4:
                case 5:
                    ClassAbilities = new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence" };
                    break;
                case 6:
                case 7:
                    ClassAbilities = new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +1", "inspire competence", "suggestion" };
                    break;
                case 8:
                    ClassAbilities = new[] { "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion" };
                    break;
                case 9:
                case 10:
                case 11:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion","inspire greatness"
                    };
                    break;
                case 12:
                case 13:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +2", "inspire competence", "suggestion","inspire greatness",
                        "song of freedom"
                    };
                    break;
                case 14:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion","inspire greatness",
                        "song of freedom"
                    };
                    break;
                case 15:
                case 16:
                case 17:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion","inspire greatness",
                        "song of freedom", "inspire heroics"
                    };
                    break;
                case 18:
                case 19:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +3", "inspire competence", "suggestion","inspire greatness",
                        "song of freedom", "inspire heroics", "mass suggestion"
                    };
                    break;
                case 20:
                    ClassAbilities = new[]
                    {
                        "Bardic music", "bardic knowledge", "countersong", "fascinate", "inspire courage +4", "inspire competence", "suggestion","inspire greatness",
                        "song of freedom", "inspire heroics", "mass suggestion"
                    };
                    break;
            }
        }

        public override void GetClassSpellsPerDay()
        {
            switch (PlayerLevel)
            {
                case 1:
                    Magic.ClassSpellsPerDay = new[] { 2 };
                    break;
                case 2:
                    Magic.ClassSpellsPerDay = new[] { 3, 0 };
                    break;
                case 3:
                    Magic.ClassSpellsPerDay = new[] { 3, 1 };
                    break;
                case 4:
                    Magic.ClassSpellsPerDay = new[] { 3, 2, 0 };
                    break;
                case 5:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 1 };
                    break;
                case 6:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 2 };
                    break;
                case 7:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 2, 0 };
                    break;
                case 8:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 1 };
                    break;
                case 9:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 2 };
                    break;
                case 10:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 2, 0 };
                    break;
                case 11:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 3, 1 };
                    break;
                case 12:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 3, 2 };
                    break;
                case 13:
                    Magic.ClassSpellsPerDay = new[] { 3, 3, 3, 3, 2, 0 };
                    break;
                case 14:
                    Magic.ClassSpellsPerDay = new[] { 4, 3, 3, 3, 3, 1 };
                    break;
                case 15:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 3, 3, 3, 2 };
                    break;
                case 16:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 4, 3, 3, 2, 0 };
                    break;
                case 17:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 4, 4, 3, 3, 1 };
                    break;
                case 18:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 4, 4, 4, 3, 2 };
                    break;
                case 19:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 4, 4, 4, 4, 3 };
                    break;
                case 20:
                    Magic.ClassSpellsPerDay = new[] { 4, 4, 4, 4, 4, 4, 4 };
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
                int i = Magic.ClassSpellsPerDay.Length;
                Magic.SpellDC = new int[i];

                for (int j = 0; j < i; j++)
                {

                    Magic.SpellDC[j] = (10 + StatMods.ChaAbilityMod + j);
                }
            }
        }

        public override void GetClassKnownSpells()
        {
            switch (PlayerLevel)
            {
                case 1:
                   Magic.SpellsKnown = new[] { 4 };
                    break;
                case 2:
                   Magic.SpellsKnown = new[] { 5, 2 };
                    break;
                case 3:
                   Magic.SpellsKnown = new[] { 6, 3 };
                    break;
                case 4:
                   Magic.SpellsKnown = new[] { 6, 3, 2 };
                    break;
                case 5:
                   Magic.SpellsKnown = new[] { 6, 4, 3 };
                    break;
                case 6:
                   Magic.SpellsKnown = new[] { 6, 4, 3 };
                    break;
                case 7:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 2 };
                    break;
                case 8:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 3 };
                    break;
                case 9:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 3 };
                    break;
                case 10:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 2 };
                    break;
                case 11:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 3 };
                    break;
                case 12:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 3 };
                    break;
                case 13:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 4, 2 };
                    break;
                case 14:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 4, 3 };
                    break;
                case 15:
                   Magic.SpellsKnown = new[] { 6, 4, 4, 4, 4, 3 };
                    break;
                case 16:
                   Magic.SpellsKnown = new[] { 6, 5, 4, 4, 4, 4, 2 };
                    break;
                case 17:
                   Magic.SpellsKnown = new[] { 6, 5, 5, 4, 4, 4, 3 };
                    break;
                case 18:
                   Magic.SpellsKnown = new[] { 6, 5, 5, 5, 4, 4, 3 };
                    break;
                case 19:
                   Magic.SpellsKnown = new[] { 6, 5, 5, 5, 5, 4, 4 };
                    break;
                case 20:
                   Magic.SpellsKnown = new[] { 6, 5, 5, 5, 5, 5, 4 };
                    break;
             }
        }
    } 
}
