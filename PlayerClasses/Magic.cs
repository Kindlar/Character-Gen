namespace PlayerClasses
{
    public class Magic
    {
        public virtual int[] TotalSpellsPerDay { get; set; }
        public virtual int[] ClassSpellsPerDay { get; set; }
        public virtual int[] SpellsKnown { get; set; }
        public virtual string[] SpellSchools { get; set; }
        public virtual int[] ClassSpells { get; set; }
        public virtual int[] BonusSpells { get; set; }
        public virtual int[] SpellDC { get; set; }
    }
}
