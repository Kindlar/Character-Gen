namespace PlayerClasses
{
    public class Feats
    {
        public int TotalFeats(int level, string race)
        {
           return FeatCalculate(level) + RacialFeatCalculate(race);
        }

        public int FeatCalculate(int level)
        {
            switch (level)
            {
                case 1:
                case 2:
                    return 1;
                case 3:
                case 4:
                case 5:
                    return 2;
                case 6:
                case 7:
                case 8:
                    return 3;
                case 9:
                case 10:
                case 11:
                    return 4;
                case 12:
                case 13:
                case 14:
                    return 5;
                case 15:
                case 16:
                case 17:
                    return 6;
                case 18:
                case 19:
                case 20:
                    return 7;
            }
            return 0;
        }

        public int RacialFeatCalculate(string playerClass)
        {
            if (playerClass == "Human")
                return 1;
                return 0;
        }

        public int ClassFeatCalculate(string playerClass, int level)
        {
            int[,] featArray =
            {
                {1,1,0},
                {2,2,0},
                {2,2,0},
                {3,2,0},
                {3,2,1},
                {4,3,1},
                {4,3,1},
                {5,3,1},
                {5,3,1},
                {6,3,2},
                {6,3,2},
                {7,3,2},
                {7,3,2},
                {8,3,2},
                {8,3,3},
                {9,3,3},
                {9,3,3},
                {10,3,3},
                {10,3,3},
                {11,3,4}
            };

            try
            {
                int selectedColum;
                int selectedRow = level - 1;

                if (playerClass == "Fighter")
                    selectedColum = 0;
                else if (playerClass == "Monk")
                    selectedColum = 1;
                else if (playerClass == "Wizard")
                    selectedColum = 2;
                else
                    return 0;

                return featArray[selectedRow, selectedColum];
            }
            catch
            {
                return 0;
            }
        }
    }
}