namespace PlayerStatisics
{
    public class BaseAttackModifier
    {
        public int [,] BaseAttack  ={  {1,0,0},
                                       {2,1,1},
                                       {3,2,1},
                                       {4,3,2},
                                       {5,3,2},
                                       {6,4,3},
                                       {7,5,3},
                                       {8,6,4},
                                       {9,6,4},
                                       {10,7,5},
                                       {11,8,5},
                                       {12,9,6},
                                       {13,9,6},
                                       {14,10,7},
                                       {15,11,7},
                                       {16,12,8},
                                       {17,12,8},
                                       {18,13,9},
                                       {19,14,9},
                                       {20,15,10},
                                     };
        public int GetBaseAttack(int level, string classAttack)
        {
            try
            {
                var selectedRow = (level-1);

                int selectedColumn;
                switch (classAttack)
                {
                    case "Barbarian":
                    case "Fighter":
                    case "Paladin":
                    case "Ranger":
                        selectedColumn = 0;
                        break;
                    case "Bard":
                    case "Cleric":
                    case "Druid":
                    case "Monk":
                    case "Rogue":
                        selectedColumn = 1;
                        break;
                    case "Sorcerer":
                    case "Wizard":
                        selectedColumn = 2;
                        break;
                    default:
                        selectedColumn = 0;
                        break;
                }

                return BaseAttack[selectedRow, selectedColumn];
            }
            catch
            {
                return -999;
            }
        }

        public int MeleeAttackTotal(int baseAttack, int strMod, int sizeMod, int miscMod)
        {
            int meleeTotal = baseAttack + strMod + sizeMod + miscMod;
            return meleeTotal;
        }


        public string BaseAttackString(int baseAttack)
        {
            switch (baseAttack)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return baseAttack.ToString();
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    return string.Format("{0}/{1}", baseAttack, baseAttack - 5);
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    return string.Format("{0}/{1}/{2}", baseAttack, baseAttack - 5, baseAttack - 10);
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    return string.Format("{0}/{1}/{2}/{3}", baseAttack, baseAttack - 5, baseAttack - 10, baseAttack - 15);
            }
            return "Error";
        }

        public string BaseAttackString(int baseAttack, int meleeTotal)
        {
            switch (baseAttack)

            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return meleeTotal.ToString();
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    return string.Format("{0}/{1}", meleeTotal, meleeTotal - 5);
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    return string.Format("{0}/{1}/{2}", meleeTotal, meleeTotal - 5, meleeTotal - 10);
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    return string.Format("{0}/{1}/{2}/{3}", meleeTotal, meleeTotal - 5, meleeTotal - 10, meleeTotal - 15);
            }
            return "Error";
        }
    }
}
