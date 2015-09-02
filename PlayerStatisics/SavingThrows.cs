namespace PlayerStatisics
{
    using System;

    public class SavingThrows
    { 
        public virtual int FortAbilitySavingThrow { get; set; }
        public virtual int FortClassSavingThrow { get; set; }
        public virtual int FortMagicSavingThrow { get; set; }
        public virtual int FortMiscSavingThrow { get; set; }
        
        public virtual int ReflexAbilitySavingThrow { get; set; }
        public virtual int ReflexClassSavingThrow { get; set; }
        public virtual int ReflexMagicSavingThrow { get; set; }
        public virtual int ReflexMiscSavingThrow { get; set; }
        
        public virtual int WillAbilitySavingThrow { get; set; }
        public virtual int WillClassSavingThrow { get; set; }
        public virtual int WillMagicSavingThrow { get; set; }
        public virtual int WillMiscSavingThrow { get; set; }

        public virtual int FortSaveTotal { get; set; }
        public virtual int ReflexSaveTotal { get; set; }
        public virtual int WillSaveTotal { get; set; }

        public int[,] ThrowArray = { {0,2},
                                     {0,3},
                                     {1,3},
                                     {1,4},
                                     {1,4},
                                     {2,5},
                                     {2,5},
                                     {2,6},
                                     {3,6},
                                     {3,7},
                                     {3,7},
                                     {4,8},
                                     {4,8},
                                     {4,9},
                                     {5,9},
                                     {5,10},
                                     {5,10},
                                     {6,11},
                                     {6,11},
                                     {6,12}
                                   };

        public int GetFort(int playerLevel, string playerClass)
        {
            try
            {
                var selectedRow = (playerLevel - 1);

                int selectedColumn;
                if (playerClass == "Bard" || playerClass == "Rogue" || playerClass == "Sorcerer" || playerClass == "Wizard")
                {
                    selectedColumn = 0;
                }
                else //Barbarian, Cleric, Druid, Fighter, Monk, Paladin, Ranger, 
                {
                    selectedColumn = 1;
                }

                return ThrowArray[selectedRow, selectedColumn];

            }
            catch (Exception)
            {
                return -999;

            }
        }

        public int GetReflex(int playerLevel, string playerclass)
        {
            var selectedRow = playerLevel - 1;

            try
            {
                int selectedColumn;
                if (playerclass == "Bard" || playerclass == "Monk" || playerclass == "Ranger" || playerclass == "Rogue") 
                {
                    selectedColumn = 1;
                }
                else // Monk, Ranger, Rogue
                {
                    selectedColumn = 0;
                }
                return ThrowArray[selectedRow, selectedColumn];

            }
            catch (Exception)
            {
                return -999;
            }
        }

        public int GetWill(int playerLevel, string playerClass)
        {
            try
            {
                var selectedRow = playerLevel - 1;

                int selectedColumn;
                if (playerClass == "Barbarian" || playerClass == "Fighter" || playerClass == "Paladin" || playerClass == "Ranger" || playerClass == "Rogue")
                {
                    selectedColumn = 0;
                }
                else //Bard, Cleric, Druid, Monk, Sorcerer, Wizard
                {
                    selectedColumn = 1;
                }
                return ThrowArray[selectedRow, selectedColumn];
            }
            catch (Exception)
            {
                return -999;
            }
        } 
    }
}
