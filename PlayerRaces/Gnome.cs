namespace PlayerRaces
{
    public class Gnome : Race
    {
        public override int StrRacialMod
        {
            get { return -2; }
            set { base.StrRacialMod = value; }
        }
        public override int ConRacialMod
        {
            get { return 2; }
            set { base.ConRacialMod = value; }
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
            get { return "Gnome"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get
            {
                return new[]
          {
                "Low-light vision", "+2 versus illusions", "+4 against giant types", "1/day: Speak with animals(burrowing)",
                "1/day dancing lights","1/day ghost sounds", "prestidigitation"
            };
            }
            set { base.RaceSkills = value; }
        }
    }
}