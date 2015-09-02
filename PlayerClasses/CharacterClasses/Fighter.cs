using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Fighter : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Fighter"; }
            set { base.ChosenClass = value; }
        }
        public override int ClassBonusFeats { get; set; }
        public override object[] ClassArmor
        {
            get
            {
                return new object[]
                {
                    "Padded", "Leather", "Studded leather", "Chain shirt", "Hide", "Scale mail", "Chainmail",
                    "Breastplate", "Splint mail",
                    "Banded mail", "Half-plate", "Full plate", "Padded", "Leather", "Hide"
                };
            }
            set { base.ClassArmor = value; }
        }
        public override object[] ClassShields
        {
            get
            {
                return new object[]
                {
                    "Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                    "Shield, heavy steel", "Shield, tower"
                };
            }
            set { base.ClassShields = value; }
        }
        public override object[] ClassWeapons
        {
            get
            {
                return new object[]
                {
                    "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light",
                    "Sickle", "Club", "Mace, heavy", "Morningstar",
                    "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light",
                    "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                    "Bullets, sling (10)", "Axe, throwing", "Hammer, light", "Handaxe", "Kukri", "Pick, light", "Sap",
                    "Sword, short", "Battleaxe", "Flail",
                    "Longsword", "Pick, heavy", "Rapier", "Scimitar", "Trident", "Warhammer", "Falchion", "Glaive",
                    "Greataxe", "Greatclub", "Flail, heavy",
                    "Greatsword", "Guisarme", "Halberd", "Lance", "Ranseur", "Scythe", "Longbow", "Longbow, composite",
                    "Shortbow", "Shortbow, composite", "Arrows (20)"
                };
            }
            set { base.ClassWeapons = value; }
        }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4())*10;
            }
            set { base.Gold = value; }
        }
    }
}