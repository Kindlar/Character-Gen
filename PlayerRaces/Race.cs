namespace PlayerRaces
{
    public class Race
    {
        public virtual string RaceName { get; set; }
        public virtual int StrRacialMod { get; set; }
        public virtual int ConRacialMod { get; set; }
        public virtual int DexRacialMod { get; set; }
        public virtual int IntRacialMod { get; set; }
        public virtual int WisRacialMod { get; set; }
        public virtual int ChaRacialMod { get; set; }
        public virtual int SizeMod { get; set; }
        public virtual int RacialGroundSpeed
        {
            get { return 30; } set{ }
        }
        public virtual int RaceBonusFeats { get; set; }
        public virtual string[] RaceSkills { get; set; }
    }
}
