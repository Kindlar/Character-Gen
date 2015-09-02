namespace PlayerClasses
{
    public class Attack
    {
        public int TotalHitPoints { get; set; }
        public string BaseAttackTotal { get; set; }
        public string MeleeAttackTotal { get; set; }
        public string RangedAttackTotal { get; set; }
        public virtual int BaseAttack { get; set; }
    }
}
