using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Paladin : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Paladin"; }
            set { base.ChosenClass = value; }
        }
        public override string[] ClassAbilities { get; set; }
        public override string[] ClassAlignments
        {
            get { return new[] {"Lawful Good"}; }
            set { base.ClassAlignments = value; }
        }
        public override object[] ClassArmor { get {return  new object[] {"Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail", "Breastplate", "Splint mail",
                "Banded mail", "Half-plate", "Full plate", "Padded", "Leather", "Hide"};} set
                {
                    base.ClassArmor = value;
                } }
        public override object[] ClassShields { get
        {
            return new object[]
            {
                "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"
            };
        } set { base.ClassShields = value; }}
        public override object[] ClassWeapons { get
        {
            return new object[]
            {
                "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light", "Sickle",
                "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri", "Pick, light", "Sap",
                "Sword, short", "Battleaxe", "Flail",
                "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer", "Falchion", "Glaive",
                "Greataxe", "Greatclub", "Flail, heavy",
                "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow", "Longbow, composite",
                "Shortbow", "Shortbow, composite", "Arrows (20)"
            };
        } set { base.ClassWeapons = value; } }
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

        public override void AssignClassAbilties()
        {
            switch (PlayerLevel)
            {
                case 1:
                    ClassAbilities = new[] { "Aura of good", "detect evil", "smite evil 1/day" };
                    break;
                case 2:
                    ClassAbilities = new[] { "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands" };
                    break;
                case 3:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands","aura of courage","divine health",
                    };
                    break;
                case 4:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 1/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead"
                    };
                    break;
                case 5:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount"
                    };
                    break;
                case 6:
                case 7:
                case 8:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 1/week"
                    };
                    break;
                case 9:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 2/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 2/week"
                    };
                    break;
                case 10:
                case 11:
                ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 2/week"
                    };
                    break;
                case 12:
                case 13:
                case 14:
                ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 3/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 3/week"
                    };
                    break;
                case 15:
                case 16:
                case 17:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 4/week"
                    };
                    break;
                case 18:
                case 19:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 4/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 5/week"
                    };
                    break;
                case 20:
                    ClassAbilities = new[]
                    {
                        "Aura of good", "detect evil", "smite evil 5/day", "divine grace", "lay on hands","aura of courage","divine health",
                        "turn undead", "special mount", "remove disease 5/week"
                    };
                    break;
            }
        }

        public override void GetClassSpellsPerDay()
        {
            switch (PlayerLevel)
            {
                case 1:
                case 2:
                case 3:
                   Magic.ClassSpellsPerDay = new int[] {};
                    break;
                case 4:
                case 5:
                   Magic.ClassSpellsPerDay = new[] {0};
                    break;
                case 6:
                case 7:
                   Magic.ClassSpellsPerDay = new[] {1};
                    break;
                case 8:
                case 9:
                   Magic.ClassSpellsPerDay = new[] { 1,0 };
                    break;
                case 10:
                   Magic.ClassSpellsPerDay = new[] { 1,1 };
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

        public override void GetSpellDifficultyClass()
        {
            if (Magic.ClassSpellsPerDay != null)
            {
                int i =Magic.ClassSpellsPerDay.Length;
                Magic.SpellDC = new int[i];

                for (int j = 0; j < i; j++)
                {

                    Magic.SpellDC[j] = (10 + StatMods.ChaAbilityMod + j);
                }
            }
        }
    }
}
