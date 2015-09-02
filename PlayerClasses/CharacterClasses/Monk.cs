using PlayerStatisics;

namespace PlayerClasses.CharacterClasses
{
    public class Monk : PlayerClass
    {
        public override string ChosenClass
        {
            get { return "Monk"; }
            set { base.ChosenClass = value; }
        }
        public override int ClassBonusFeats { get; set; }
        public override int ClassGroundSpeed { get; set; }
        public override string[] KnownFeats { get; set; }
        public override string[] ClassSkills { get; set; }
        public override string[] ClassAbilities { get; set; }
        public override string[] ClassAlignments
        {
            get { return new[] {"Lawful Good", "Lawful Neutral", "Lawful Evil"}; }
            set { base.ClassAlignments = value; }
        }
        public override object[] ClassWeapons
        {
            get
            {
                return new object[]
                {
                    "Club", "Crossbow, light", "Crossbow, heavy", "Dagger", "Handaxe", "Javelin", "Kama", "Nunchaki",
                    "Quarterstaff", "Sai", "Shuriken", "Saingham",
                    "Sling"
                };
            }
            set { base.ClassWeapons = value; }
        }
        public override double Gold
        {
            get
            {
                DiceRoll dice = new DiceRoll();
                return dice.D4() + dice.D4() + dice.D4() + dice.D4() + dice.D4();
            }
            set { base.Gold = value; }
        }

        public override void GetClassUnarmedStrike()
        {
        }

        public override void GetClassGroundSpeed()
        {
            switch (PlayerLevel)
            {
                case 1:
                case 2:
                    break;
                case 3:
                case 4:
                case 5:
                    ClassGroundSpeed = 10;
                    break;
                case 6:
                case 7:
                case 8:
                    ClassGroundSpeed = 20;
                    break;
                case 9:
                case 10:
                case 11:
                    ClassGroundSpeed = 30;
                    break;
                case 12:
                case 13:
                case 14:
                    ClassGroundSpeed = 40;
                    break;
                case 15:
                case 16:
                case 17:
                    ClassGroundSpeed = 50;
                    break;
                case 18:
                case 19:
                case 20:
                    ClassGroundSpeed = 60;
                    break;
            }
        }
    }
}