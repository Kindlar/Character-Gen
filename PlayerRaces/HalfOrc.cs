namespace PlayerRaces
{
    public class HalfOrc : Race
    {
        public override int StrRacialMod
        {
            get { return 2; }
            set { base.StrRacialMod = value; }
        }
        public override int IntRacialMod
        {
            get { return -2; }
            set { base.IntRacialMod = value; }
        }
        public override int ChaRacialMod
        {
            get { return -2; }
            set { base.ChaRacialMod = value; }
        }

        public override string RaceName
        {
            get { return "HalfOrc"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get
            {
                return new[]
          {
                "Dark vision", "Orc Blood"
            };
            }
            set { base.RaceSkills = value; }
        }
    }
}