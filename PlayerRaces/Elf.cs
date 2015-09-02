namespace PlayerRaces
{
    public class Elf : Race
    {
        public override int DexRacialMod
        {
            get { return 2; }
            set { base.DexRacialMod = value; }
        }

        public override int ConRacialMod
        {
            get { return -2; }
            set { base.ConRacialMod = value; }
        }

        public override string RaceName
        {
            get { return "Elf"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get
            {
                return new[]
                {
                    "Immunity to magic sleep", "Low-light vision", "+2 to Listen, Search, and Spot",
                    "Hidden door or portal sense"
                };
            }
            set { base.RaceSkills = value; }
        }
    }
}