using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Rogue : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Rogue"; }
            set { base.ChosenClass = value; }
        }
        public override string[] ClassSkills { get; set; }
        public override string[] ClassAbilities { get; set; }
        public override object[] ClassArmor { get {return new object[] { "Padded", "Leather", "Studded leather", "Chain shirt" }; } set
        {
            base.ClassArmor = value;
        } }
        public override object[] ClassShields { get {return new object[] {"Buckler", "Shield, light wooden", "Shield, light steel", "Shield, heavy wooden",
                "Shield, heavy steel"};} set { base.ClassShields = value; } }
        public override object[] ClassWeapons { get {return new object[] { "Gauntlet", "Unarmed Strike", "Dagger", "Dagger, punching", "Gauntlet, spiked", "Mace, light" , "Sickle", "Club", "Mace, heavy", "Morningstar",
                "Shortspear", "Longspear", "Quarterstaff", "Spear", "Crossbow, heavy", "Crossbow, light", "Bolts, crossbow (10)", "Dart", "Javelin", "Sling",
                "Bullets, sling (10)", "Hand Crossbow", "Rapier", "Sap", "Shortbow", "Sword, short"};} set
                {
                    base.ClassWeapons = value;
                } }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return (dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4()) * 10;
            }
            set { base.Gold = value; }
        }
    }
}
