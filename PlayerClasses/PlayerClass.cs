using PlayerStatisics;

namespace PlayerClasses
{
    public abstract class PlayerClass
    {
        public AbilityMods StatMods { get; set; }
        public BaseStats BaseStats { get; set; }
        public MiscMods MiscMods { get; set; }
        public TotalScore TotalScore { get; set; }
        public SavingThrows SavingThrows { get; set; }
        public Magic Magic { get; set; }
        public Attack Attack { get; set; }
        public virtual string[] KnownFeats { get; set; }
        public virtual double Gold { get; set; }
        public virtual int ClassGroundSpeed { get; set; }
        public virtual string ChosenClass { get; set; }
        public virtual int PlayerLevel { get; set; }
        public virtual int ClassBonusFeats { get; set; }
        public virtual string[] ClassSkills { get; set; }
        public virtual string[] ClassAbilities { get; set; }
        public virtual string[] ClassAlignments
        {
            get
            {
                return new[] { "Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil",
                "Chaotic Good", "Chaotic Neutral", "Chaotic Evil" };
            }
            set { }
        }
        public virtual object[] ClassArmor
        {
            get { return new object[] {"No trained armor"}; }
            set { }
        }
        public virtual object[] ClassShields { get
            { return new object[] {};} set {} }
        public virtual object[] ClassWeapons { get; set; }
        public int TotalSkillPoints { get; set; }

        protected PlayerClass()
        {
            this.StatMods = new AbilityMods();
            this.BaseStats = new BaseStats();
            this.MiscMods = new MiscMods();
            this.TotalScore = new TotalScore();
            this.SavingThrows = new SavingThrows();
            this.Magic = new Magic();
            this.Attack = new Attack();
        }

        public virtual void AssignLevel(int level)
        {
            PlayerLevel = level;
        }

        public virtual void AssignClassAbilties() {}

        public virtual void AssignClassSkills() {}

        public virtual void AssignBaseStats(int str, int dex, int con, int intellegence, int wis, int cha)
        {
            BaseStats.StrBaseStat = str;
            BaseStats.DexBaseStat = dex;
            BaseStats.ConBaseStat = con;
            BaseStats.IntBaseStat = intellegence;
            BaseStats.WisBaseStat = wis;
            BaseStats.ChaBaseStat = cha;
        }

        public virtual void AssignMiscMods(int str, int dex, int con, int intellegence, int wis, int cha)
        {
            MiscMods.StrMiscMod = str;
            MiscMods.DexMiscMod = dex;
            MiscMods.ConMiscMod = con;
            MiscMods.IntMiscMod = intellegence;
            MiscMods.WisMiscMod = wis;
            MiscMods.ChaMiscMod = cha;
        }

        public virtual void AssignThrows()
        {
            SavingThrows.FortAbilitySavingThrow = StatMods.ConAbilityMod;
            SavingThrows.ReflexAbilitySavingThrow = StatMods.DexAbilityMod;
            SavingThrows.WillAbilitySavingThrow = StatMods.WisAbilityMod;

            SavingThrows.FortClassSavingThrow = SavingThrows.GetFort(PlayerLevel, ChosenClass);
            SavingThrows.ReflexClassSavingThrow = SavingThrows.GetReflex(PlayerLevel, ChosenClass);
            SavingThrows.WillClassSavingThrow = SavingThrows.GetWill(PlayerLevel, ChosenClass);
        }

        public virtual void AssignThrowsMisc(string fortMisc, string reflexMisc, string willMisc)
        {
            int fMisc;
            int rMisc;
            int wMisc;

            int.TryParse(fortMisc, out fMisc);
            int.TryParse(reflexMisc, out rMisc);
            int.TryParse(willMisc, out wMisc);

            SavingThrows.FortMiscSavingThrow = fMisc;
            SavingThrows.ReflexMiscSavingThrow = rMisc;
            SavingThrows.WillMiscSavingThrow = wMisc;
        }

        public virtual void AssignThrowsMagic(string fortMisc, string reflexMisc, string willMisc)
        {
            int fMisc;
            int rMisc;
            int wMisc;

            int.TryParse(fortMisc, out fMisc);
            int.TryParse(reflexMisc, out rMisc);
            int.TryParse(willMisc, out wMisc);

            SavingThrows.FortMagicSavingThrow = fMisc;
            SavingThrows.ReflexMagicSavingThrow = rMisc;
            SavingThrows.WillMagicSavingThrow = wMisc;
        }

        public virtual void CalculateAbilityMods()
        {
            AbilityModifier ability = new AbilityModifier();
            StatMods.StrAbilityMod = ability.Calculate(TotalScore.StrTotalScore);
            StatMods.DexAbilityMod = ability.Calculate(TotalScore.DexTotalScore);
            StatMods.ConAbilityMod = ability.Calculate(TotalScore.ConTotalScore);
            StatMods.IntAbilityMod = ability.Calculate(TotalScore.IntTotalScore);
            StatMods.WisAbilityMod = ability.Calculate(TotalScore.WisTotalScore);
            StatMods.ChaAbilityMod = ability.Calculate(TotalScore.ChaTotalScore);
        }
        
        public virtual void CalculateHitPoints()
        {
            HitPoints hp = new HitPoints();
            Attack.TotalHitPoints = hp.GetTotalHitPoints(StatMods.ConAbilityMod, PlayerLevel, ChosenClass);
        }

        public virtual void CalculateThrows()
        {
            SavingThrows.FortSaveTotal = 
                SavingThrows.FortAbilitySavingThrow + SavingThrows.FortClassSavingThrow + SavingThrows.FortMagicSavingThrow + SavingThrows.FortMiscSavingThrow;
            SavingThrows.ReflexSaveTotal = 
                SavingThrows.ReflexAbilitySavingThrow + SavingThrows.ReflexClassSavingThrow + SavingThrows.ReflexMagicSavingThrow + SavingThrows.ReflexMiscSavingThrow;
            SavingThrows.WillSaveTotal = 
                SavingThrows.WillAbilitySavingThrow + SavingThrows.WillClassSavingThrow + SavingThrows.WillMagicSavingThrow + SavingThrows.WillMiscSavingThrow;
        }

        public virtual void CalculateBaseAttack()
        {
            BaseAttackModifier baseAttack = new BaseAttackModifier();
            Attack.BaseAttack = baseAttack.GetBaseAttack(PlayerLevel, ChosenClass);
            Attack.BaseAttackTotal = baseAttack.BaseAttackString(Attack.BaseAttack);
        }
        
        public virtual void GetClassSpellsPerDay() { }

        public virtual void GetClassKnownSpells() { }

        public virtual void GetBonusSpells() { }

        public virtual void GetSpellDifficultyClass() { }

        public virtual void GetKnownSpells() { }

        public virtual void GetClassUnarmedStrike() { }

        public virtual void GetClassGroundSpeed() { }
    }
}
