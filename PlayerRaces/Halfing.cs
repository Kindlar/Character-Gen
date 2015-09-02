namespace PlayerRaces
{
    public class Halfing : Race
    {
        public override int StrRacialMod
        {
            get { return -2; }
            set { base.StrRacialMod = value; }
        }
        public override int DexRacialMod
        {
            get { return 2; }
            set { base.DexRacialMod = value; }
        }
        public override int SizeMod
        {
            get { return 1; }
            set { base.SizeMod = value; }
        }

        public override int RacialGroundSpeed
        {
            get { return 20; }
            set { base.RacialGroundSpeed = value; }
        }

        public override string RaceName
        {
            get { return "Halfing"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get
            {
                return new[]
          {
                "+2 on Climb, Jump, Listen, and Move Silently", "Orc Blood", "+1 on all saving throws","+2 moral bonus on saving throw",
                "+1 on thrown weapons or sling attack rolls"
            };
            }
            set { base.RaceSkills = value; }
        }
    }
}