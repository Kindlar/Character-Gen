using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Barbarian : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Barbarian"; } set { base.ChosenClass = value; }
        }
        public override string[] ClassAbilities { get; set; }
        public override string[] ClassAlignments
        {
            get
            {
                return new[] { "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil" };
            }
            set { base.ClassAlignments = value; }
        }
        public override object[] ClassArmor
        {
            get
            {
                return new[]
                {
                    "Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail", "Breastplate"
                };
            }
            set { base.ClassArmor = value; }
        }
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
        public override object[] ClassWeapons
        {
            get
            {
                return new[]
                {
                    "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light",
                    "Sickle", "Club", "Mace, heavy",
                    "Morningstar", "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy",
                    "Crossbow, light", "Bolts, crossbow (10)",
                    "Dart", "Javelin", "Sling", "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe",
                    "Kukri", "Pick, light", "Sap", "Sword, short",
                    "Battleaxe", "Flail", "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer",
                    "Falchion", "Glaive", "Greataxe", "Greatclub",
                    "Flail, heavy", "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow",
                    "Longbow, composite", "Shortbow",
                    "Shortbow, composite", "Arrows (20)"
                };
            }
            set { base.ClassWeapons = value; }
        }
        public override double Gold { get {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4() + dice.D4())*10; }
            set { base.Gold = value;} }

        public override void AssignClassAbilties()
        {
            switch (PlayerLevel)
            {
                case 1:
                    ClassAbilities = new[]
                    {"Fast movement", "illiteracy", "rage 1/day"};
                    break;
                case 2:
                    ClassAbilities = new[]
                    {"Fast movement", "illiteracy", "rage 1/day", "uncanny dodge"};
                    break;
                case 3:
                    ClassAbilities = new[]
                    {"Fast movement", "illiteracy", "rage 1/day", "uncanny dodge", "trap sense +1"};
                    break;
                case 4:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 2/day", "uncanny dodge", "trap sense +1" };
                    break;
                case 5:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +1" };
                    break;
                case 6:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +2" };
                    break;
                case 7:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 2/day", "improved uncanny dodge", "trap sense +2", "damage reduction 1/-" };
                    break;
                case 8:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +2", "damage reduction 1/-" };
                    break;
                case 9:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 1/-" };
                    break;
                case 10:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 2/-" };
                    break;
                case 11:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "greater rage 3/day", "improved uncanny dodge", "trap sense +3", "damage reduction 2/-" };
                    break;
                case 12:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", "damage reduction 2/-" };
                    break;
                case 13:
                    ClassAbilities = new[] { "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", "damage reduction 3/-" };
                    break;
                case 14:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +4", "damage reduction 3/-",
                       "indomitable will"
                    };
                    break;
                case 15:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "greater rage 4/day", "improved uncanny dodge", "trap sense +5", "damage reduction 3/-",
                       "indomitable will"
                    };
                    break;
                case 16:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "greater rage 5/day", "improved uncanny dodge", "trap sense +5", "damage reduction 4/-",
                       "indomitable will"
                    };
                    break;
                case 17:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +5", "damage reduction 4/-",
                       "indomitable will"
                    };
                    break;
                case 18:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +6", "damage reduction 4/-",
                       "indomitable will"
                    };
                    break;
                case 19:
                    ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "tireless greater rage 5/day", "improved uncanny dodge", "trap sense +6", "damage reduction 5/-",
                       "indomitable will"
                    };
                    break;
                case 20:
                     ClassAbilities = new[]
                    {
                       "Fast movement", "illiteracy", "tireless mighty rage 6/day", "improved uncanny dodge", "trap sense +6", "damage reduction 5/-",
                       "indomitable will"
                    };
                    break;
            }
        }
    }
}