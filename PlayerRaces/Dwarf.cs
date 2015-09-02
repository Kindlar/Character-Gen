namespace PlayerRaces
{
    public class Dwarf : Race
    {
        public override int ConRacialMod
        {
            get { return 2; }
            set { base.ConRacialMod = value; }
        }  
        public override int ChaRacialMod
        {
            get { return -2; }
            set { base.ChaRacialMod = value; }
        }

        public override int RacialGroundSpeed
        {
            get { return 20; }
            set { base.RacialGroundSpeed = value; }
        }

        public override string RaceName
        {
            get { return "Dwarf"; }
            set { base.RaceName = value; }
        }

        public override string[] RaceSkills
        {
            get { return new []
            {
                "Stone cunning", "Darkvision", "Stability", "+4 dodge against giant type", "+2 racial bonus on Appraise checks that are related to stone or metal items",
                "+1 racial bonus to attack rolls against orcs and goblinoids" , "+2 racial bonus on saving throws against poison",
            }; }
            set { base.RaceSkills = value; }
        }
    }
}