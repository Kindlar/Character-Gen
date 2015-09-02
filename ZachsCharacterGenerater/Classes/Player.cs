namespace ZachsCharacterGenerater.Classes
{
    using PlayerClasses;
    using PlayerClasses.CharacterClasses;
    using PlayerRaces;
    using PlayerStatisics;
    public class Player
    {
        public string Name;
        public PlayerClass PlayerClass { get; set; }
        public Race Race { get; set; }
        public RacialMods RacialMods { get; set; }
        public int TotalGround { get; set; }
        public int TotalSkillPoints { get; set; }
        public int TotalFeats { get; set; }

        public Player()
        {
            this.RacialMods = new RacialMods();
            this.Race = new Race(); 
        }  

        public Player(string playerName, string playerClass, string race, int level)
        {
            Name = playerName;
            CreatePlayerClass(playerClass);
            PlayerClass.AssignLevel(level);
            CreatePlayerRace(race);
            PlayerClass.GetClassGroundSpeed();
            GetTotalGroundSpeed();
            CalculateFeats();         
        }

        public void GetTotalGroundSpeed()
        {
           TotalGround = Race.RacialGroundSpeed + PlayerClass.ClassGroundSpeed;
        }

        public virtual void CalculateTotalScore()
        {
            PlayerClass.TotalScore.StrTotalScore = PlayerClass.BaseStats.StrBaseStat + Race.StrRacialMod + PlayerClass.MiscMods.StrMiscMod;
            PlayerClass.TotalScore.DexTotalScore = PlayerClass.BaseStats.DexBaseStat + Race.DexRacialMod + PlayerClass.MiscMods.DexMiscMod;
            PlayerClass.TotalScore.ConTotalScore = PlayerClass.BaseStats.ConBaseStat + Race.ConRacialMod + PlayerClass.MiscMods.ConMiscMod;
            PlayerClass.TotalScore.IntTotalScore = PlayerClass.BaseStats.IntBaseStat + Race.IntRacialMod + PlayerClass.MiscMods.IntMiscMod;
            PlayerClass.TotalScore.WisTotalScore = PlayerClass.BaseStats.WisBaseStat + Race.WisRacialMod + PlayerClass.MiscMods.WisMiscMod;
            PlayerClass.TotalScore.ChaTotalScore = PlayerClass.BaseStats.ChaBaseStat + Race.ChaRacialMod + PlayerClass.MiscMods.ChaMiscMod;
            PlayerClass.CalculateAbilityMods();
        }

        public virtual void CalculateSkillPoints()
        {
            SkillPoints skill = new SkillPoints();
            TotalSkillPoints = skill.SkillPointTotal(PlayerClass.PlayerLevel, PlayerClass.StatMods.IntAbilityMod, PlayerClass.ChosenClass, Race.RaceName);
        }

        public void CalculateFeats()
        {
            Feats feat = new Feats();
            PlayerClass.ClassBonusFeats = feat.ClassFeatCalculate(PlayerClass.ChosenClass, PlayerClass.PlayerLevel);
            TotalFeats = Race.RaceBonusFeats + feat.FeatCalculate(PlayerClass.PlayerLevel);
        }

        public virtual void CalculateMeleeTotal(int miscMod)
        {
            BaseAttackModifier baseAttack = new BaseAttackModifier();
            PlayerClass.Attack.MeleeAttackTotal = baseAttack.BaseAttackString(PlayerClass.Attack.BaseAttack, baseAttack.MeleeAttackTotal(PlayerClass.Attack.BaseAttack, PlayerClass.StatMods.StrAbilityMod, Race.SizeMod, miscMod));
        }

        public virtual void CalculateRangeTotal(int rangeMiscMod)
        {
            BaseAttackModifier baseAttack = new BaseAttackModifier();
            PlayerClass.Attack.RangedAttackTotal = baseAttack.BaseAttackString(PlayerClass.Attack.BaseAttack, baseAttack.MeleeAttackTotal(PlayerClass.Attack.BaseAttack, PlayerClass.StatMods.DexAbilityMod, Race.SizeMod, rangeMiscMod));
        }

        public void CreatePlayerRace(string race)
        {
            switch (race)
            {
                case "Elf":
                    Race = new Elf();
                    break;
                case "Human":
                    Race = new Human();
                    break;
                case "Dwarf":
                    Race = new Dwarf();
                    break;
                case "Gnome":
                    Race = new Gnome();
                    break;
                case "Half-Elf":
                    Race = new HalfElf();
                    break;
                case "Half-Orc":
                    Race = new HalfOrc();
                    break;
                case "Halfing":
                    Race = new Halfing();
                    break;
            }
        }

        public void CreatePlayerClass(string playerClass)
        {
            switch (playerClass)
            {
                case "Barbarian":
                    PlayerClass = new Barbarian();
                    break;
                case "Bard":
                    PlayerClass = new Bard();
                    break;
                case "Cleric":
                    PlayerClass = new Cleric();
                    break;
                case "Druid":
                    PlayerClass = new Druid();
                    break;
                case "Fighter":
                    PlayerClass = new Fighter();
                    break;
                case "Monk":
                    PlayerClass = new Monk();
                    break;
                case "Paladin":
                    PlayerClass = new Paladin();
                    break;
                case "Ranger":
                    PlayerClass = new Ranger();
                    break;
                case "Rogue":
                    PlayerClass = new Rogue();
                    break;
                case "Sorcerer":
                    PlayerClass = new Sorcerer();
                    break;
                case "Wizard":
                    PlayerClass = new Wizard();
                    break;
            }
        }
    }
}
