namespace PlayerStatisics
{
    public class HitPoints
    {
        public int TotalHitPoints { get; set; }

        public int D4HitDice()
        {
            return 4;
        }

        public int D6HitDice()
        {
            return 6;
        }

        public int D8HitDice()
        {
            return 8;
        }

        public int D10HitDice()
        {
            return 10;
        }

        public int D12HitDice()
        {
            return 12;
        }

        public int GetLevel1HitPointsD4(int conMod)
        {
            int result = D4HitDice() + conMod;
            if (result >= 1)
            return TotalHitPoints = result;
            return TotalHitPoints = 1;
        }

        public int GetLevel1HitPointsD6(int conMod)
        {
            int result = D6HitDice() + conMod;
            if (result >= 1)
            return TotalHitPoints = result;
            return TotalHitPoints = 1;
        }

        public int GetLevel1HitPointsD8(int conMod)
        {
            int result = D8HitDice() + conMod;
            if (result >= 1)
            return TotalHitPoints = result;
            return TotalHitPoints = 1;
        }

        public int GetLevel1HitPointsD10(int conMod)
        {
            int result = D10HitDice() + conMod;
            if (result >= 1)
            return TotalHitPoints = result;
            return TotalHitPoints = 1;
        }

        public int GetLevel1HitPointsD12(int conMod)
        {
            int result = D12HitDice() + conMod;
            if (result >= 1)
            return TotalHitPoints = result;
            return TotalHitPoints = 1;
        }
        public int GetLevel2AndUpHitPontsD4(int conMod)
        {
            DiceRoll dice = new DiceRoll();
            int result = dice.D4() + conMod;
            if (result >= 1)
            return result;
            return 1;
        }

        public int GetLevel2AndUpHitPontsD6(int conMod)
        {
            DiceRoll dice = new DiceRoll();
            int result = dice.D6() + conMod;
            if (result >= 1)
            return result;
            return 1;
        }

        public int GetLevel2AndUpHitPontsD8(int conMod)
        {
            DiceRoll dice = new DiceRoll();
            int result = dice.D8() + conMod;
            if (result >= 1)
            return result;
            return 1;
        }

        public int GetLevel2AndUpHitPontsD10(int conMod)
        {
            DiceRoll dice = new DiceRoll();
            int result = dice.D10() + conMod;
            if (result >= 1)
            return result;
            return 1;
        }

        public int GetLevel2AndUpHitPontsD12(int conMod)
        {
            DiceRoll dice = new DiceRoll();
            int result = dice.D12() + conMod;
            if (result >= 1)
            return result;
            return 1;
        }

        public int GetTotalHitpointsD4(int conMod, int level)
        {
            int count = level - 1;

            TotalHitPoints = GetLevel1HitPointsD4(conMod);

            while (count > 0)
            {
                TotalHitPoints = TotalHitPoints + GetLevel2AndUpHitPontsD4(conMod);
                count--;
            }

            return TotalHitPoints;
        }

        public int GetTotalHitpointsD6(int conMod, int level)
        {
            int count = level - 1;

            TotalHitPoints = GetLevel1HitPointsD6(conMod);

            while (count > 0 )
            {
               TotalHitPoints = TotalHitPoints + GetLevel2AndUpHitPontsD6(conMod);
                count--;
            }

            return TotalHitPoints;
        }

        public int GetTotalHitpointsD8(int conMod, int level)
        {
            int count = level - 1;

            TotalHitPoints = GetLevel1HitPointsD8(conMod);

            while (count > 0)
            {
                TotalHitPoints = TotalHitPoints + GetLevel2AndUpHitPontsD8(conMod);
                count--;
            }

            return TotalHitPoints;
        }

        public int GetTotalHitpointsD10(int conMod, int level)
        {
            int count = level - 1;

            TotalHitPoints = GetLevel1HitPointsD10(conMod);

            while (count > 0)
            {
                TotalHitPoints = TotalHitPoints + GetLevel2AndUpHitPontsD10(conMod);
                count--;
            }

            return TotalHitPoints;
        }

        public int GetTotalHitpointsD12(int conMod, int level)
        {
            int count = level - 1;

            TotalHitPoints = GetLevel1HitPointsD12(conMod);

            while (count > 0)
            {
                TotalHitPoints = TotalHitPoints + GetLevel2AndUpHitPontsD12(conMod);
                count--;
            }

            return TotalHitPoints;
        }

        public int GetTotalHitPoints(int conMod, int level , string playerclass)
        {
            switch (playerclass)
            {
                case "Sorcerer":
                case "Wizard":
                   TotalHitPoints = GetTotalHitpointsD4(conMod, level);
                     break;
                case "Bard":
                case "Rogue":
                   TotalHitPoints = GetTotalHitpointsD6(conMod, level);
                     break;
                case "Druid":
                case "Cleric":
                case "Monk":
                case "Ranger":
                    TotalHitPoints = GetTotalHitpointsD8(conMod, level);
                    break;
                case "Fighter":
                case "Paladin":                    
                    TotalHitPoints = GetTotalHitpointsD10(conMod, level);
                    break;
                case "Barbarian":
                    TotalHitPoints = GetTotalHitpointsD12(conMod,level);
                    break;
            }

            return TotalHitPoints;
        }
    }
}
