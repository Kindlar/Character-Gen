namespace PlayerRaces
{
    public class HalfElf : Race
    {
        public override string RaceName
        {
            get { return "HalfElf"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get
            {
                return new[]
          {
                "Low-light vision","+1 on Listen, Search and Spot","+2 on Diplomacy and Gather Information", "Elven-Blood"

            };
            }
            set { base.RaceSkills = value; }
        }
    }
}