namespace PlayerRaces
{
    public class Human : Race
    {
        public override int RaceBonusFeats
        {
            get { return 1; }
            set { base.RaceBonusFeats = value; }
        }

        public override string RaceName
        {
            get { return "Human"; }
            set { base.RaceName = value; }
        }

        public override int RacialGroundSpeed
        {
            get { return 30; }
            set { base.RacialGroundSpeed = value; }
        }
    }
}