namespace PlayerClasses
{
    public class BonusSpells
    {
        public int[] BonusSpellsCalculate(int abilityMod)
        {
     
            switch (abilityMod)
            {
                case -5:
                case -4:
                case -3:
                case -2:
                case -1:
                case 0:
                    return new[] { 0 };
                case 1:
                    return new[] { 1 };
                case 2:
                    return new[] { 1, 1 };
                case 3:
                    return new[] { 1, 1, 1};
                case 4:
                    return new[] { 1, 1, 1, 1};
                case 5:
                    return new[] { 2, 1, 1, 1, 1};
                case 6:
                    return new[] { 2, 2, 1, 1, 1, 1 };
                case 7:
                    return new[] { 2, 2, 2, 1, 1, 1, 1 };
                case 8:
                    return new[] { 2, 2, 2, 2, 1, 1, 1, 1,};
                case 9:
                    return new[] { 3, 2, 2, 2, 2, 1, 1, 1, 1 };
                case 10:
                    return new[] { 3, 3, 2, 2, 2, 2, 1, 1, 1 };
            }
            return new[] { 0 };
        }
    }
}
