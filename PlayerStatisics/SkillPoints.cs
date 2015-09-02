namespace PlayerStatisics
{
    public class SkillPoints
    {
        public int TotalSkillPoints { get; set; }

        public int SkillPointTotal (int level , int intModifier, string playerClass, string race)
        {
            if (level == 1)
            {
                SkillPointTotalLevelOne(intModifier, playerClass);
                SkillPointRace(race);
            }
            else
            {
                SkillPointTotalLevelOne(intModifier, playerClass);
                SkillPointTotalHighLevel(level, intModifier, playerClass);
                SkillPointRace(race);
                SkillPointRaceHighlevel(level, race);
            }

            return TotalSkillPoints;
        }

        public int SkillPointTotalLevelOne (int intModifier, string playerClass)
        {
            switch (playerClass)
            {
                case "Barbarian":
                case "Druid":
                case "Monk":
                    TotalSkillPoints = ((4 + intModifier) * 4);
                    break;
                case "Bard":
                case "Ranger":
                    TotalSkillPoints = ((6 + intModifier) * 4);
                    break;
                case "Rogue":
                    TotalSkillPoints = ((8 + intModifier) * 4);
                    break;
                default:
                    TotalSkillPoints = ((2 + intModifier) * 4);
                    break;
            }

            return TotalSkillPoints;
        }

        public int SkillPointTotalHighLevel(int level, int intModifier, string playerClass)
        {
            switch (playerClass)
            {
                case "Barbarian":
                case "Druid":
                case "Monk":
                    TotalSkillPoints = TotalSkillPoints + ((4 + intModifier) * (level - 1));
                    break;
                case "Bard":
                case "Ranger":
                    TotalSkillPoints = TotalSkillPoints + ((6 + intModifier) * (level - 1));
                    break;
                case "Rogue":
                    TotalSkillPoints = TotalSkillPoints + ((8 + intModifier) * (level - 1));
                    break;
                default:
                    TotalSkillPoints = TotalSkillPoints + ((2 + intModifier) * (level - 1));
                    break;
            }

            return TotalSkillPoints;
        }

        public int SkillPointRace(string race)
        {
            if (race == "Human")
            {
                TotalSkillPoints = TotalSkillPoints + 4;
            }
            return TotalSkillPoints;
        }

        public int SkillPointRaceHighlevel(int level, string race)
        {
            if (race == "Human")
            {
                TotalSkillPoints = TotalSkillPoints + (level-1);
            }
            return TotalSkillPoints;
        }
    }
}
