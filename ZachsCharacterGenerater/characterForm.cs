namespace ZachsCharacterGenerater
{
    using AutoMapper;
    using PlayerStatisics;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Classes;
    using Equipment;
    using static Matchers;

    public partial class CharacterForm : Form
    {
        public Player Player;
        public decimal TotalWeight { get; set; }      
        public string Broke = "You can not afford that!";
        public CheckBox[] CheckBoxs { get; set; }
        public TextBox[] SpellBoxs { get; set; }
        public TextBox[] BonusSpellBoxs { get; set; }
        public CharacterForm()
        {
            InitializeComponent();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearComboBoxes();
            nameTextBox.Focus();
        }

        private void randomBaseStatButton_Click(object sender, EventArgs e)
        {
            RandomBaseStat();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if ((raceComboBox.SelectedItem != null) && (classComboBox.SelectedItem != null) &&
                (levelComboBox.SelectedItem != null))
            {
                AbilityScoreCalculate();
                Player.PlayerClass.CalculateHitPoints();
                hitPointsTextBox.Text = Player.PlayerClass.Attack.TotalHitPoints.ToString();
                Player.CalculateSkillPoints();
                skillPointTotalTextBox.Text = Player.PlayerClass.TotalSkillPoints.ToString();
                dexACModifierTextBox.Text = Player.PlayerClass.StatMods.DexAbilityMod.ToString("n0");
                
                CalculateTotalArmorClass();
                SavingScores();
                BaseAttackCalculate();
                AssignSpellsPerDay();
                DisplaySpellsPerDay();
                DisplayBonusSpells();
                DisplaySpellDCSpells();
                Player.PlayerClass.AssignClassSkills();
                Map(Player.PlayerClass.ClassSkills);
            }
            else
            {
                MessageBox.Show("You need to select a class, race, or level.");
            }
        }

        private void DisplaySkillMods(string abilityMod, TextBox [] skillTextBox)
        {
            foreach (TextBox textBox in skillTextBox)
            {
                textBox.Text = abilityMod;
            }
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignLevelClassRace();
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            AssignLevelClassRace();
        }

        public void AssignLevelClassRace()
        {
            if ((classComboBox.SelectedItem != null) && (levelComboBox.SelectedItem != null) && (raceComboBox.SelectedItem != null) && 
                (levelComboBox.SelectedItem != null))
            {
                int level;
                int.TryParse(levelComboBox.SelectedItem.ToString(), out level);
                CreatePlayer(nameTextBox.Text, classComboBox.SelectedItem.ToString(), raceComboBox.SelectedItem.ToString(), level);
                alignmentComboBox.Items.Clear();
                if (raceComboBox.SelectedItem != null)
                {
                    DisplayRacialStats();
                    alignmentComboBox.Items.AddRange(Player.PlayerClass.ClassAlignments);
                }

                goldTextBox.Text = Player.PlayerClass.Gold.ToString();
            }
        }

        private void levelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignLevelClassRace();
        }

        private void SavingScores()
        {
            Player.PlayerClass.AssignThrows();
            Player.PlayerClass.AssignThrowsMagic(fortMagicModTextBox.Text, reflexMagicModTextBox.Text, willMagicModTextBox.Text);
            Player.PlayerClass.AssignThrowsMisc(fortMiscTextBox.Text, reflexMiscTextBox.Text, willMiscTextBox.Text);
            Player.PlayerClass.CalculateThrows();
            DisplaySavingThrows();
        }

        private void DisplaySavingThrows()
        {
            fortAbilityModTextBox.Text = Player.PlayerClass.StatMods.ChaAbilityMod.ToString();
            fortTotalSavingTextBox.Text = Player.PlayerClass.SavingThrows.FortSaveTotal.ToString();

            reflexAbilityModTextBox.Text = Player.PlayerClass.StatMods.DexAbilityMod.ToString();
            reflexTotalSavingTextBox.Text = Player.PlayerClass.SavingThrows.ReflexSaveTotal.ToString();

            willAbilityModTextBox.Text = Player.PlayerClass.StatMods.WisAbilityMod.ToString();
            willTotalSavingTextBox.Text = Player.PlayerClass.SavingThrows.WillSaveTotal.ToString();

            fortClassModTextBox.Text = Player.PlayerClass.SavingThrows.FortClassSavingThrow.ToString();
            reflexClassModTextBox.Text = Player.PlayerClass.SavingThrows.ReflexClassSavingThrow.ToString();
            willClassModTextBox.Text = Player.PlayerClass.SavingThrows.WillClassSavingThrow.ToString();
        }

        private void BaseAttackCalculate()
        {
            int meleeMiscMod;
            int.TryParse(attackMiscTextBox.Text, out meleeMiscMod);
            int rangeMiscMod;
            int.TryParse(rangedAttackMiscTextBox.Text, out rangeMiscMod);

            Player.PlayerClass.CalculateBaseAttack();
            Player.CalculateRangeTotal(rangeMiscMod);
            Player.CalculateMeleeTotal(meleeMiscMod);
            DisplayBaseAttack();
        }

        private void DisplayBaseAttack()
        {
            meleeBaseAttackTextBox.Text = Player.PlayerClass.Attack.BaseAttackTotal;
            meleeAttackTotalTextBox.Text = Player.PlayerClass.Attack.MeleeAttackTotal;

            rangedBaseAttackTextBox.Text = Player.PlayerClass.Attack.BaseAttackTotal;
            rangedAttackTotalTextBox.Text = Player.PlayerClass.Attack.RangedAttackTotal;
        }

        private void ConvertMagicModsToInt()
        {
            int strMisc;
            int dexMisc;
            int conMisc;
            int intMisc;
            int wisMisc;
            int chaMisc;

            int.TryParse(strMagicTextBox.Text, out strMisc);
            int.TryParse(dexMagicTextBox.Text, out dexMisc);
            int.TryParse(conMagicTextBox.Text, out conMisc);
            int.TryParse(intMagicTextBox.Text, out intMisc);
            int.TryParse(wisMagicTextBox.Text, out wisMisc);
            int.TryParse(chaMagicTextBox.Text, out chaMisc);

            Player.PlayerClass.AssignMiscMods(strMisc, dexMisc, conMisc, intMisc, wisMisc, chaMisc);
        }

        private void ConvertBaseStatsToInt()
        {
            if (strTextBox.Text == String.Empty)
                RandomBaseStat();
   
                int strBase;
                int dexBase;
                int conBase;
                int intBase;
                int wisBase;
                int chaBase;

                int.TryParse(strTextBox.Text, out strBase);
                int.TryParse(dexTextBox.Text, out dexBase);
                int.TryParse(conTextBox.Text, out conBase);
                int.TryParse(intTextBox.Text, out intBase);
                int.TryParse(wisTextBox.Text, out wisBase);
                int.TryParse(chaTextBox.Text, out chaBase);

                Player.PlayerClass.AssignBaseStats(strBase, dexBase, conBase, intBase, wisBase, chaBase);   
        }

        private void AbilityScoreCalculate()
        {
            ConvertBaseStatsToInt();
            ConvertMagicModsToInt();
            Player.CalculateTotalScore();
            DisplayLoadAndWeight();
            DisplayStats();
            InititiveCalculate();
        }

        private void DisplayLoadAndWeight()
        {
            Weight load = new Weight();
            LoadDisplay(load.CalculateLoad(Player.PlayerClass.TotalScore.StrTotalScore, TotalWeight));
            totalWeightTextBox.Text = TotalWeight.ToString();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void ClearCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void ClearComboBoxes()
        {
            raceComboBox.Text = null;
            classComboBox.Text = null;
            alignmentComboBox.Text = null;
        }

        private void CalculateTotalArmorClass()
        {
            int aCBonus,
                shield,
                natural,
                deflect,
                misc,
                penalty;

            int.TryParse(aCBonusTextBox.Text, out aCBonus);
            int.TryParse(shieldACTextBox.Text, out shield);
            int.TryParse(naturalArmorACTextBox.Text, out natural);
            int.TryParse(deflectModifierACTextBox.Text, out deflect);
            int.TryParse(miscModifierACTextBox.Text, out misc);
            int.TryParse(armorCheckPenaltyTextBox.Text, out penalty);

            var totalAC = 10 + aCBonus + shield + Player.PlayerClass.StatMods.DexAbilityMod + Player.Race.SizeMod + natural + deflect + misc;

            armorClassTotalTextBox.Text = totalAC.ToString("n0");
        }

        private void DisplayRacialStats()
        {
            strRacialModifierTextBox.Text = Player.Race.StrRacialMod.ToString();
            dexRacialModifierTextBox.Text = Player.Race.DexRacialMod.ToString();
            conRacialModifierTextBox.Text = Player.Race.ConRacialMod.ToString();
            intRacialModifierTextBox.Text = Player.Race.IntRacialMod.ToString();
            wisRacialModifierTextBox.Text = Player.Race.WisRacialMod.ToString();
            chaRacialModifierTextBox.Text = Player.Race.ChaRacialMod.ToString();

            sizeModifierACTextBox.Text = Player.Race.SizeMod.ToString();
            attackSizeTextBox.Text = Player.Race.SizeMod.ToString();
            rangedAttackSizeTextBox.Text = Player.Race.SizeMod.ToString();
            groundSpeedTextBox.Text = Player.TotalGround.ToString();
        }

        private void RandomBaseStat()
        {
            DiceRoll dice = new DiceRoll();
            strTextBox.Text = dice.BaseStat().ToString();
            conTextBox.Text = dice.BaseStat().ToString();
            dexTextBox.Text = dice.BaseStat().ToString();
            intTextBox.Text = dice.BaseStat().ToString();
            wisTextBox.Text = dice.BaseStat().ToString();
            chaTextBox.Text = dice.BaseStat().ToString();
        }

        private void DisplayStats()
        {
            strTotalTextBox.Text = Player.PlayerClass.TotalScore.StrTotalScore.ToString("n0");
            strAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.StrAbilityMod.ToString();
            attackStrTextBox.Text = Player.PlayerClass.StatMods.StrAbilityMod.ToString();

            dexTotalTextBox.Text = Player.PlayerClass.TotalScore.DexTotalScore.ToString("n0");
            dexAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.DexAbilityMod.ToString();
            attackDexTextBox.Text = Player.PlayerClass.StatMods.DexAbilityMod.ToString();

            conTotalTextBox.Text = Player.PlayerClass.TotalScore.ConTotalScore.ToString("n0");
            conAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.ConAbilityMod.ToString();

            intTotalTextBox.Text = Player.PlayerClass.TotalScore.IntTotalScore.ToString("n0");
            intAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();

            wisTotalTextBox.Text = Player.PlayerClass.TotalScore.WisTotalScore.ToString("n0");
            wisAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.WisAbilityMod.ToString();

            chaTotalTextBox.Text = Player.PlayerClass.TotalScore.ChaTotalScore.ToString("n0");
            chaAbilityModifierTextBox.Text = Player.PlayerClass.StatMods.ChaAbilityMod.ToString();
         }

        public void InititiveCalculate()
        {
            int initMiscMod;
            int.TryParse(initMiscModTextBox.Text, out initMiscMod);

            int initTotalMod = (initMiscMod +Player.PlayerClass.StatMods.DexAbilityMod);
            initTotalTextBox.Text = initTotalMod.ToString("n0");
            initDexModTextBox.Text = Player.PlayerClass.StatMods.DexAbilityMod.ToString("n0");            
        }

        private void weaponOneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon();
            Weapon playerWeapon = weapon.BuildWeapon(weaponOneComboBox.SelectedItem.ToString());
            DisplayWeaponOne(playerWeapon);
        }

        private void addWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon();
            Weapon shinyWeapon = weapon.BuildWeapon(weaponOneComboBox.SelectedItem.ToString());

            if ((weaponOneComboBox.SelectedItem == null) || (!((Player.PlayerClass.Gold - shinyWeapon.Cost) >= 0)))
            {
                MessageBox.Show(Broke);
                weaponOneComboBox.ResetText();
            }
            else
            {
                TotalWeight = TotalWeight + shinyWeapon.Weight;
                DisplayLoadAndWeight();
                Player.PlayerClass.Gold = Player.PlayerClass.Gold - shinyWeapon.Cost;
                goldTextBox.Text = Player.PlayerClass.Gold.ToString();
                weaponListBox.Items.Add(weaponOneComboBox.Text);
            }
        }

        private void removeWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon();
            if (weaponListBox.SelectedItem != null)
            {
                Weapon removedWeapon = weapon.BuildWeapon(weaponListBox.SelectedItem.ToString());
                TotalWeight = TotalWeight - removedWeapon.Weight;
                DisplayLoadAndWeight();
                Player.PlayerClass.Gold = Player.PlayerClass.Gold + removedWeapon.Cost;
                weaponListBox.Items.Remove(weaponListBox.SelectedItem);
            }
            totalWeightTextBox.Text = TotalWeight.ToString();
            goldTextBox.Text = Player.PlayerClass.Gold.ToString();
        }

        public void DisplayArmor(Armor armor)
        {
            armorArmorBonusTextBox.Text = armor.ArmorBonus.ToString();
            armorMaxDexBonusTextBox.Text = armor.MaxDexBonus.ToString();
            armorArmorCheckPenaltyTextBox.Text = armor.ArmorCheckPenalty.ToString();
            armorCheckPenaltyTextBox.Text = armor.ArmorCheckPenalty.ToString();
            armorArcaneSpellFailureTextBox.Text = armor.ArcaneSpellFailure.ToString();
            armorSpeedTextBox.Text = armor.Speed.ToString();
            costArmorTextBox.Text = armor.Cost.ToString();
            armorWeightTextBox.Text = armor.Weight.ToString();
        }

        public void DisplayWeaponOne(Weapon weapon)
        {
            costWeaponOneTextBox.Text = weapon.Cost.ToString();
            damageWeaponOneTextBox.Text = weapon.Damage;
            criticalWeaponOneTextBox.Text = weapon.Critical;
            rangeIncrementWeaponOneTextBox.Text = weapon.RangeIncrement;
            weightWeaponOneTextBox.Text = weapon.Weight.ToString();
            typeWeaponOneTextBox.Text = weapon.DamageType;
        }

        private void armorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Armor armor = new Armor();
            DisplayArmor((armor.BuildArmor(armorComboBox.SelectedItem.ToString())));
        }

        private void goodsOneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipment item = new Equipment();
            if (goodsOneComboBox.SelectedItem != null)
            {
                Equipment selecteditem = item.BuildItem(goodsOneComboBox.SelectedItem.ToString());
                goodsCostTextBox.Text = selecteditem.Cost.ToString();
                goodsWeightTextBox.Text = selecteditem.Weight.ToString();
            }
        }

        private void addGoodsButton_Click(object sender, EventArgs e)
        {
            Equipment item = new Equipment();
            Equipment addItem = item.BuildItem(goodsOneComboBox.SelectedItem.ToString());

            if ((goodsOneComboBox.SelectedItem == null) || (!((Player.PlayerClass.Gold - addItem.Cost) >= 0)))
            {
                MessageBox.Show(Broke);
            }
            else
            {
                goodsListBox.Items.Add(goodsOneComboBox.SelectedItem);
                TotalWeight = TotalWeight + addItem.Weight;
                DisplayLoadAndWeight();
                Player.PlayerClass.Gold = Player.PlayerClass.Gold - addItem.Cost;
                goldTextBox.Text = Player.PlayerClass.Gold.ToString();
            }
        }

        private void removeGoodsButton_Click(object sender, EventArgs e)
        {
            Equipment item = new Equipment();
            if (goodsListBox.SelectedItem != null)
            {
                Equipment removedItem = item.BuildItem(goodsListBox.SelectedItem.ToString());
                TotalWeight = TotalWeight - removedItem.Weight;
                Player.PlayerClass.Gold = Player.PlayerClass.Gold + removedItem.Cost;
            }

            DisplayLoadAndWeight();
            goldTextBox.Text = Player.PlayerClass.Gold.ToString();
            goodsListBox.Items.Remove(goodsListBox.SelectedItem);
        }

        private void addArmorButton_Click(object sender, EventArgs e)
        {
            Armor armor = new Armor();
            Armor shinyArmor = armor.BuildArmor(armorComboBox.SelectedItem.ToString());
            DisplayArmor(shinyArmor);

            if ((armorComboBox.SelectedItem == null) || (!((Player.PlayerClass.Gold - shinyArmor.Cost) >= 0)))
            {
                MessageBox.Show(Broke);
                armorComboBox.ResetText();
            }
            else
            {
                armorListBox.Items.Add(armorComboBox.Text);
                equipArmorListBox.Items.Add(armorComboBox.Text);
                TotalWeight = TotalWeight + shinyArmor.Weight;
                DisplayLoadAndWeight();
                Player.PlayerClass.Gold = Player.PlayerClass.Gold - shinyArmor.Cost;
                goldTextBox.Text = Player.PlayerClass.Gold.ToString();
            }
        }

        private void removeArmorButton_Click(object sender, EventArgs e)
        {
            Armor armor = new Armor();
            if (armorComboBox.SelectedItem != null)
            {
                Equipment removedArmor = armor.BuildArmor(goodsListBox.SelectedItem.ToString());
                TotalWeight = TotalWeight - removedArmor.Weight;
                Player.PlayerClass.Gold = Player.PlayerClass.Gold + removedArmor.Cost;
            }

            DisplayLoadAndWeight();
            goldTextBox.Text = Player.PlayerClass.Gold.ToString();
            armorListBox.Items.Remove(armorListBox.SelectedItem);
            equipArmorListBox.Items.Remove(equipArmorListBox.SelectedItem);
        }

        private void LoadDisplay(string load)
        {
            switch (load)
            {
                case "Light":
                    totalWeightTextBox.BackColor = Color.ForestGreen;
                    break;
                case "Medium":
                    totalWeightTextBox.BackColor = Color.Yellow;
                    break;
                case "Heavy":
                    totalWeightTextBox.BackColor = Color.OrangeRed;
                    break;
                case "Overload":
                    totalWeightTextBox.BackColor = Color.Red;
                    MessageBox.Show("You must put something back, you can no longer move.");
                    break;
            }
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            Armor armor = new Armor();

            if (armorComboBox.SelectedItem != null)
            {
                Armor EquipArmor = armor.BuildArmor(armorComboBox.SelectedItem.ToString());
                aCBonusTextBox.Text = EquipArmor.ArmorBonus.ToString();
                if (Player.PlayerClass.StatMods.DexAbilityMod >= EquipArmor.MaxDexBonus)
                {
                    dexACModifierTextBox.Text = EquipArmor.MaxDexBonus.ToString();
                    dexACModifierTextBox.ForeColor = Color.Red;
                }
                armorArmorCheckPenaltyTextBox.Text = EquipArmor.ArmorCheckPenalty.ToString();
                armorArcaneSpellFailureTextBox.Text = EquipArmor.ArcaneSpellFailure.ToString();
                CalculateTotalArmorClass();
                AssignACPenaltyToSkills(EquipArmor.ArmorCheckPenalty);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Armor armor = new Armor();
            Armor EquipArmor;

            if (armorComboBox.SelectedItem != null)
            {
                int acBonus;
                int.TryParse(aCBonusTextBox.Text, out acBonus);
                EquipArmor = armor.BuildArmor(armorComboBox.SelectedItem.ToString());
                aCBonusTextBox.Text = (acBonus - EquipArmor.ArmorBonus).ToString();
                dexACModifierTextBox.Text =Player.PlayerClass.StatMods.DexAbilityMod.ToString();
                dexACModifierTextBox.ResetForeColor();
                armorArmorCheckPenaltyTextBox.Clear();
                armorArcaneSpellFailureTextBox.Clear();
                CalculateTotalArmorClass();
                UnassignACPenaltyToSkills(EquipArmor.ArmorCheckPenalty);
            }
        }

        private void AssignClassSkills(CheckBox[] classSkills)
        {
            foreach (var checkbox in classSkills)
            {
                checkbox.Checked = true;
            }
        }

        private void AddOrSubtractSkillPoints(double total, double oldValue, CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (total > oldValue)
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints - 1;
                else
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints + 1;
            }
            else
            {
                if (total > oldValue)
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints - 2;
                else
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints + 2;
            }
            skillPointTotalTextBox.Text = Player.PlayerClass.TotalSkillPoints.ToString();
        }

        private void SkillCalculate(TextBox miscTB, TextBox totalTB, NumericUpDown upDown, CheckBox checkBox, double mod)
        {
            if (Player.PlayerClass.TotalSkillPoints > 0)
            {
                double misc;
                double rank;
                double oldValue;
                double.TryParse(totalTB.Text, out oldValue);

                upDown.Maximum = checkBox.Checked ? Player.PlayerClass.PlayerLevel + 3 : (Player.PlayerClass.PlayerLevel + 3)/2;
                double.TryParse(upDown.Value.ToString(), out rank);
                double.TryParse(miscTB.Text, out misc);
                double total = (rank + misc + mod);

                totalTB.Text = total.ToString();

                AddOrSubtractSkillPoints(total, oldValue, checkBox);
            }
            else
            {
                if (checkBox.Checked)
                {
                    upDown.Value = upDown.Value - 1;
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints + 1;
                }
                else
                {
                    upDown.Value = upDown.Value - 2;
                    Player.PlayerClass.TotalSkillPoints = Player.PlayerClass.TotalSkillPoints + 2;
                }
                skillPointTotalTextBox.Text = Player.PlayerClass.TotalSkillPoints.ToString();
                MessageBox.Show("You are out of skillpoints.");
            }
        }

        private CheckBox[] GetClassSkills()
        {
            switch (Player.PlayerClass.ChosenClass)
            {
                case "Barbarian":
                    return new[]
                    {
                        climbCheckBox, craftCheckBox, handleAnimalCheckBox, intimidateCheckBox, jumpCheckBox,
                        listenCheckBox, rideCheckBox,
                        survivalCheckBox, swimCheckBox
                    };
                case "Bard":
                    return new[]
                    {
                        appraiseCheckBox, balanceCheckBox, bluffCheckBox, climbCheckBox, concentrationCheckBox,
                        craftCheckBox,
                        decipherScriptCheckBox, diplomacyCheckBox, disguiseCheckBox, escapeArtistCheckBox,
                        gatherInformationCheckBox,
                        hideCheckBox, jumpCheckBox, knowledgeArcanaCheckBox, knowledgeArchitectureAndEngineeringCheckBox,
                        knowledgeDungeoneeringCheckBox, knowledgeGeographyCheckBox, knowledgeHistoryCheckBox,
                        knowledgeLocalCheckBox,
                        knowledgeNatureCheckBox, knowledgeNobilityAndRoyaltyCheckBox, knowledgeReligionCheckBox,
                        knowledgeThePlanesCheckBox,
                        listenCheckBox, moveSilentlyCheckBox, performCheckBox, professionCheckBox, senseMotiveCheckBox,
                        sleightOfHandCheckBox,
                        spellcraftCheckBox, swimCheckBox, tumbleCheckBox, useMagicDeviceCheckBox
                    };
                case "Cleric":
                    return new[]
                    {
                        concentrationCheckBox, craftCheckBox, diplomacyCheckBox, healCheckBox, knowledgeArcanaCheckBox,
                        knowledgeHistoryCheckBox,
                        knowledgeReligionCheckBox, knowledgeThePlanesCheckBox, professionCheckBox, spellcraftCheckBox

                    };
                case "Druid":
                    return new[]
                    {
                        concentrationCheckBox, craftCheckBox, diplomacyCheckBox, handleAnimalCheckBox, healCheckBox,
                        knowledgeNatureCheckBox,
                        listenCheckBox, professionCheckBox, rideCheckBox, spellcraftCheckBox, spotCheckBox,
                        survivalCheckBox, swimCheckBox
                    };
                case "Fighter":
                    return new[]
                    {
                        climbCheckBox, craftCheckBox, escapeArtistCheckBox, handleAnimalCheckBox, intimidateCheckBox,
                        jumpCheckBox,
                        rideCheckBox, swimCheckBox
                    };
                case "Monk":
                    return new[]
                    {
                        balanceCheckBox, climbCheckBox, concentrationCheckBox, craftCheckBox, diplomacyCheckBox,
                        hideCheckBox, jumpCheckBox,
                        knowledgeArcanaCheckBox, knowledgeReligionCheckBox, listenCheckBox, moveSilentlyCheckBox,
                        performCheckBox,
                        professionCheckBox, senseMotiveCheckBox, spotCheckBox, swimCheckBox, tumbleCheckBox
                    };
                case "Paladin":
                    return new[]
                    {
                        concentrationCheckBox, craftCheckBox, diplomacyCheckBox, handleAnimalCheckBox, healCheckBox,
                        knowledgeNobilityAndRoyaltyCheckBox,
                        knowledgeReligionCheckBox, professionCheckBox, rideCheckBox, senseMotiveCheckBox
                    };
                case "Ranger":
                    return new[]
                    {
                        climbCheckBox, concentrationCheckBox, craftCheckBox, handleAnimalCheckBox, healCheckBox,
                        hideCheckBox, jumpCheckBox,
                        knowledgeDungeoneeringCheckBox, knowledgeGeographyCheckBox, listenCheckBox, moveSilentlyCheckBox,
                        professionCheckBox,
                        rideCheckBox, searchCheckBox, spotCheckBox, survivalCheckBox, swimCheckBox, useRopeCheckBox
                    };
                case "Rogue":
                    return new[]
                    {
                        appraiseCheckBox, balanceCheckBox, bluffCheckBox, climbCheckBox, craftCheckBox,
                        decipherScriptCheckBox,
                        diplomacyCheckBox, disableDeviceCheckBox, disguiseCheckBox, escapeArtistCheckBox,
                        forgeryCheckBox,
                        gatherInformationCheckBox, hideCheckBox, intimidateCheckBox, knowledgeLocalCheckBox,
                        knowledgeNatureCheckBox,
                        listenCheckBox, moveSilentlyCheckBox, openLockCheckBox, performCheckBox, professionCheckBox,
                        searchCheckBox,
                        senseMotiveCheckBox, sleightOfHandCheckBox, spotCheckBox, swimCheckBox, tumbleCheckBox,
                        useMagicDeviceCheckBox,
                        useRopeCheckBox
                    };
                case "Sorcerer":
                    return new[]
                    {
                        bluffCheckBox, concentrationCheckBox, craftCheckBox, knowledgeArcanaCheckBox, professionCheckBox,
                        spellcraftCheckBox
                    };
                case "Wizard":
                    return new[]
                    {
                        concentrationCheckBox, craftCheckBox, decipherScriptCheckBox, knowledgeArcanaCheckBox,
                        knowledgeArchitectureAndEngineeringCheckBox,
                        knowledgeDungeoneeringCheckBox, knowledgeGeographyCheckBox, knowledgeHistoryCheckBox,
                        knowledgeLocalCheckBox,
                        knowledgeNobilityAndRoyaltyCheckBox, knowledgeReligionCheckBox, knowledgeThePlanesCheckBox,
                        professionCheckBox,
                        spellcraftCheckBox
                    };
            }
            return new CheckBox[] {};
        }

        private void appraiseNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(appraiseMiscTextBox, appraiseTotalTextBox, appraiseNumericUpDown, appraiseCheckBox,
                Player.PlayerClass.StatMods.IntAbilityMod);
        }

        private void balanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(balanceMiscTextBox, balanceTotalTextBox, balanceNumericUpDown, balanceCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void bluffNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(bluffMiscTextBox, bluffTotalTextBox, bluffNumericUpDown, bluffCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void climbNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(climbMiscTextBox, climbTotalTextBox, climbNumericUpDown, climbCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void concentrationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(concentrationMiscTextBox, concentrationTotalTextBox, concentrationNumericUpDown,
                concentrationCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void craftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(craftMiscTextBox, craftTotalTextBox, craftNumericUpDown, craftCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
        }

        private void decipherScriptNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(decipherScriptMiscTextBox, decipherScriptTotalTextBox, decipherScriptNumericUpDown,
                decipherScriptCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
            decipherScriptAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
            if (decipherScriptNumericUpDown.Value == 0)
            {
                decipherScriptTotalTextBox.Clear();
                decipherScriptAbilityTextBox.Clear();
            }
        }

        private void diplomacyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(diplomacyMiscTextBox, diplomacyTotalTextBox, diplomacyNumericUpDown, diplomacyCheckBox,
                Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void disableDeviceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(disableDeviceMiscTextBox, disableDeviceTotalTextBox, disableDeviceNumericUpDown,
                disableDeviceCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
            disableDeviceAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
            if (disableDeviceNumericUpDown.Value == 0)
            {
                disableDeviceTotalTextBox.Clear();
                disableDeviceAbilityTextBox.Clear();
            }
        }

        private void disguiseNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(disguiseMiscTextBox, disguiseTotalTextBox, disguiseNumericUpDown, disguiseCheckBox,
                Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void escapeArtistNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(escapeArtistMiscTextBox, escapeArtistTotalTextBox, escapeArtistNumericUpDown,
                escapeArtistCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void forgeryNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(forgeryMiscTextBox, forgeryTotalTextBox, forgeryNumericUpDown, forgeryCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
        }

        private void gatherInformationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(gatherInformationMiscTextBox, gatherInformationTotalTextBox, gatherInformationNumericUpDown,
                gatherInformationCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void handleAnimalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(handleAnimalMiscTextBox, handleAnimalTotalTextBox, handleAnimalNumericUpDown,
                handleAnimalCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
            handleAnimalAbilityTextBox.Text =Player.PlayerClass.StatMods.ChaAbilityMod.ToString();
            if (handleAnimalNumericUpDown.Value == 0)
            {
                handleAnimalTotalTextBox.Clear();
                handleAnimalAbilityTextBox.Clear();
            }
        }

        private void healNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(healMiscTextBox, healTotalTextBox, healNumericUpDown, healCheckBox, Player.PlayerClass.StatMods.WisAbilityMod);
        }

        private void hideNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(hideMiscTextBox, hideTotalTextBox, hideNumericUpDown, hideCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void intimidateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(intimidateMiscTextBox, intimidateTotalTextBox, intimidateNumericUpDown, intimidateCheckBox,
                Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void jumpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(jumpMiscTextBox, jumpTotalTextBox, jumpNumericUpDown, jumpCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void knowledgeArcanaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(knowledgeArcanaMiscTextBox, knowledgeArcanaTotalTextBox, knowledgeArcanaNumericUpDown,
                knowledgeArcanaCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
            knowledgeArcanaAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
            if (knowledgeArcanaNumericUpDown.Value == 0)
            {
                knowledgeArcanaTotalTextBox.Clear();
                knowledgeArcanaAbilityTextBox.Clear();
            }
        }

        private void knowledgeArchitectureAndEngineeringNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(knowledgeArchitectureAndEngineeringMiscTextBox,
                knowledgeArchitectureAndEngineeringTotalTextBox, knowledgeArchitectureAndEngineeringNumericUpDown,
                knowledgeArchitectureAndEngineeringCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
            knowledgeArchitectureAndEngineeringAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
            if (knowledgeArchitectureAndEngineeringNumericUpDown.Value == 0)
            {
                knowledgeArchitectureAndEngineeringTotalTextBox.Clear();
                knowledgeArchitectureAndEngineeringAbilityTextBox.Clear();
            }
        }

        private void knowledgeDungeoneeringNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeDungeoneeringMiscTextBox, knowledgeDungeoneeringTotalTextBox,
                    knowledgeDungeoneeringNumericUpDown, knowledgeDungeoneeringCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeDungeoneeringAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeDungeoneeringNumericUpDown.Value == 0)
                {
                    knowledgeDungeoneeringTotalTextBox.Clear();
                    knowledgeDungeoneeringAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeGeographyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeGeographyMiscTextBox, knowledgeGeographyTotalTextBox,
                    knowledgeGeographyNumericUpDown, knowledgeGeographyCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeGeographyAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeGeographyTotalTextBox.Clear();
                    knowledgeGeographyAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeHistoryAbilityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeHistoryMiscTextBox, knowledgeHistoryTotalTextBox, knowledgeHistoryNumericUpDown,
                    knowledgeHistoryCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeHistoryAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeHistoryTotalTextBox.Clear();
                    knowledgeHistoryAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeLocalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeLocalMiscTextBox, knowledgeLocalTotalTextBox, knowledgeLocalNumericUpDown,
                    knowledgeLocalCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeLocalAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeLocalTotalTextBox.Clear();
                    knowledgeLocalAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeNatureNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeNatureMiscTextBox, knowledgeNatureTotalTextBox, knowledgeNatureNumericUpDown,
                    knowledgeNatureCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeNatureAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeNatureTotalTextBox.Clear();
                    knowledgeNatureAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeNobilityAndRoyaltyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeNobilityAndRoyaltyMiscTextBox, knowledgeNobilityAndRoyaltyTotalTextBox,
                    knowledgeNobilityAndRoyaltyNumericUpDown, knowledgeNobilityAndRoyaltyCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeNobilityAndRoyaltyAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeNobilityAndRoyaltyTotalTextBox.Clear();
                    knowledgeNobilityAndRoyaltyAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeReligionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeReligionMiscTextBox, knowledgeReligionTotalTextBox,
                    knowledgeReligionNumericUpDown, knowledgeReligionCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeReligionAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeReligionTotalTextBox.Clear();
                    knowledgeReligionAbilityTextBox.Clear();
                }
            }
        }

        private void knowledgeThePlanesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(knowledgeThePlanesMiscTextBox, knowledgeThePlanesTotalTextBox,
                    knowledgeThePlanesNumericUpDown, knowledgeThePlanesCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                knowledgeThePlanesAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    knowledgeThePlanesTotalTextBox.Clear();
                    knowledgeThePlanesAbilityTextBox.Clear();
                }
            }
        }

        private void listenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(listenMiscTextBox, listenTotalTextBox, listenNumericUpDown, listenCheckBox, Player.PlayerClass.StatMods.WisAbilityMod);
        }

        private void moveSilentlyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(moveSilentlyMiscTextBox, moveSilentlyTotalTextBox, moveSilentlyNumericUpDown,
                moveSilentlyCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void openLockNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(openLockMiscTextBox, openLockTotalTextBox, openLockNumericUpDown, openLockCheckBox,
                    Player.PlayerClass.StatMods.IntAbilityMod);
                openLockAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    openLockTotalTextBox.Clear();
                    openLockAbilityTextBox.Clear();
                }
            }
        }

        private void performNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(performMiscTextBox, performTotalTextBox, performNumericUpDown, performCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void professionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(professionMiscTextBox, professionTotalTextBox, professionNumericUpDown,
                    professionCheckBox, Player.PlayerClass.StatMods.WisAbilityMod);
                professionAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    professionTotalTextBox.Clear();
                    professionAbilityTextBox.Clear();
                }
            }
        }

        private void rideNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(rideMiscTextBox, rideTotalTextBox, rideNumericUpDown, rideCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void searchNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(searchMiscTextBox, searchTotalTextBox, searchNumericUpDown, searchCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
        }

        private void senseMotiveNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(senseMotiveMiscTextBox, senseMotiveTotalTextBox, senseMotiveNumericUpDown,
                senseMotiveCheckBox, Player.PlayerClass.StatMods.WisAbilityMod);
        }

        private void sleightOfHandNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(sleightOfHandMiscTextBox, sleightOfHandTotalTextBox, sleightOfHandNumericUpDown,
                    sleightOfHandCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
                sleightOfHandAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    sleightOfHandTotalTextBox.Clear();
                    sleightOfHandAbilityTextBox.Clear();
                }
            }
        }
        
        //TODO speak langauge is odd. fix this. 
        private void speakLanguageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spellcraftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(spellcraftMiscTextBox, spellcraftTotalTextBox, spellcraftNumericUpDown,
                    spellcraftCheckBox, Player.PlayerClass.StatMods.IntAbilityMod);
                spellcraftAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    spellcraftTotalTextBox.Clear();
                    spellcraftAbilityTextBox.Clear();
                }
            }
        }

        private void spotNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(spotMiscTextBox, spotTotalTextBox, spotNumericUpDown, spotCheckBox, Player.PlayerClass.StatMods.WisAbilityMod);
        }

        private void survivalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(survivalMiscTextBox, survivalTotalTextBox, survivalNumericUpDown, survivalCheckBox,
                Player.PlayerClass.StatMods.WisAbilityMod);
        }

        private void swimNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(swimMiscTextBox, swimTotalTextBox, swimNumericUpDown, swimCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
        }

        private void tumbleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(tumbleMiscTextBox, tumbleTotalTextBox, tumbleNumericUpDown, tumbleCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
                tumbleAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    tumbleTotalTextBox.Clear();
                    tumbleAbilityTextBox.Clear();
                }
            }
        }

        private void useMagicDeviceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                SkillCalculate(useMagicDeviceMiscTextBox, useMagicDeviceTotalTextBox, useMagicDeviceNumericUpDown,
                    useMagicDeviceCheckBox, Player.PlayerClass.StatMods.ChaAbilityMod);
                useMagicDeviceAbilityTextBox.Text = Player.PlayerClass.StatMods.IntAbilityMod.ToString();
                if (knowledgeGeographyNumericUpDown.Value == 0)
                {
                    useMagicDeviceTotalTextBox.Clear();
                    useMagicDeviceAbilityTextBox.Clear();
                }
            }
        }

        private void useRopeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SkillCalculate(useRopeMiscTextBox, useRopeTotalTextBox, useRopeNumericUpDown, useRopeCheckBox, Player.PlayerClass.StatMods.DexAbilityMod);
        }

        private void AssignACPenaltyToSkills(int acPenalty)
        {
            int miscBalance;
            int.TryParse(balanceMiscTextBox.Text, out miscBalance);
            balanceMiscTextBox.Text = (miscBalance + acPenalty).ToString();

            int miscClimb;
            int.TryParse(climbMiscTextBox.Text, out miscClimb);
            climbMiscTextBox.Text = (miscClimb + acPenalty).ToString();

            int miscEscape;
            int.TryParse(escapeArtistMiscTextBox.Text, out miscEscape);
            escapeArtistMiscTextBox.Text = (miscEscape + acPenalty).ToString();

            int miscHide;
            int.TryParse(hideMiscTextBox.Text, out miscHide);
            hideMiscTextBox.Text = (miscHide + acPenalty).ToString();

            int miscJump;
            int.TryParse(jumpMiscTextBox.Text, out miscJump);
            jumpMiscTextBox.Text = (miscHide + acPenalty).ToString();

            int miscMoveSilently;
            int.TryParse(moveSilentlyMiscTextBox.Text, out miscMoveSilently);
            moveSilentlyMiscTextBox.Text = (miscMoveSilently + acPenalty).ToString();

            int miscSleightOfHand;
            int.TryParse(sleightOfHandMiscTextBox.Text, out miscSleightOfHand);
            sleightOfHandMiscTextBox.Text = (miscSleightOfHand + acPenalty).ToString();

            int miscSwim;
            int.TryParse(swimMiscTextBox.Text, out miscSwim);
            swimMiscTextBox.Text = (miscSwim + (acPenalty*2)).ToString();

            int miscTumble;
            int.TryParse(tumbleMiscTextBox.Text, out miscTumble);
            tumbleMiscTextBox.Text = (miscTumble + acPenalty).ToString();
        }

        private void UnassignACPenaltyToSkills(int acPenalty)
        {
            int miscBalance;
            int.TryParse(balanceMiscTextBox.Text, out miscBalance);
            balanceMiscTextBox.Text = (miscBalance - acPenalty).ToString();

            int miscClimb;
            int.TryParse(climbMiscTextBox.Text, out miscClimb);
            climbMiscTextBox.Text = (miscClimb - acPenalty).ToString();

            int miscEscape;
            int.TryParse(escapeArtistMiscTextBox.Text, out miscEscape);
            escapeArtistMiscTextBox.Text = (miscEscape - acPenalty).ToString();

            int miscHide;
            int.TryParse(hideMiscTextBox.Text, out miscHide);
            hideMiscTextBox.Text = (miscHide - acPenalty).ToString();

            int miscJump;
            int.TryParse(jumpMiscTextBox.Text, out miscJump);
            jumpMiscTextBox.Text = (miscHide - acPenalty).ToString();

            int miscMoveSilently;
            int.TryParse(moveSilentlyMiscTextBox.Text, out miscMoveSilently);
            moveSilentlyMiscTextBox.Text = (miscMoveSilently - acPenalty).ToString();

            int miscSleightOfHand;
            int.TryParse(sleightOfHandMiscTextBox.Text, out miscSleightOfHand);
            sleightOfHandMiscTextBox.Text = (miscSleightOfHand - acPenalty).ToString();

            int miscSwim;
            int.TryParse(swimMiscTextBox.Text, out miscSwim);
            swimMiscTextBox.Text = (miscSwim - (acPenalty*2)).ToString();

            int miscTumble;
            int.TryParse(tumbleMiscTextBox.Text, out miscTumble);
            tumbleMiscTextBox.Text = (miscTumble - acPenalty).ToString();
        }

        private static void FeatEnabled(int score, CheckBox box)
        {
            if (score >= 13)
            {
                box.Enabled = true;
            }
        }

        private static void FeatEnabled15(int score, CheckBox box)
        {
            if (score >= 15)
            {
                box.Enabled = true;
            }
        }

        private static void FeatEnabledBaseAttack(int bAttack, CheckBox box)
        {
            if (bAttack >= 1)
            {
                box.Enabled = true;
            }
        }

        private static string FeatAddToSkills(CheckBox Feat, string skill)
        {
            if (Feat.Checked)
            {
                int misc;
                int.TryParse(skill, out misc);
                return (misc + 2).ToString();
            }
            else
            {
                int misc;
                int.TryParse(skill, out misc);
                return (misc - 2).ToString();
            }
        }

        private void acrobaticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            jumpMiscTextBox.Text = FeatAddToSkills(acrobaticCheckBox, jumpMiscTextBox.Text);
            tumbleMiscTextBox.Text = FeatAddToSkills(acrobaticCheckBox, tumbleMiscTextBox.Text);
        }

        private void agileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            balanceMiscTextBox.Text = FeatAddToSkills(agileCheckBox, balanceMiscTextBox.Text);
            escapeArtistMiscTextBox.Text = FeatAddToSkills(agileCheckBox, escapeArtistMiscTextBox.Text);
        }

        private void alertnesssCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            listenMiscTextBox.Text = FeatAddToSkills(alertnesssCheckBox, listenMiscTextBox.Text);
            spotMiscTextBox.Text = FeatAddToSkills(alertnesssCheckBox, spotMiscTextBox.Text);
        }

        private void animalAffinityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            handleAnimalMiscTextBox.Text = FeatAddToSkills(animalAffinityCheckBox, handleAnimalMiscTextBox.Text);
            rideMiscTextBox.Text = FeatAddToSkills(handleAnimalCheckBox, rideMiscTextBox.Text);
        }

        private void armorProficiencyLightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            armorProficiencyMediumCheckBox.Enabled = true;
        }

        private void armorProficiencyMediumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            armorProficiencyHeavyCheckBox.Enabled = true;
        }

        private void athleticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            climbMiscTextBox.Text = FeatAddToSkills(athleticCheckBox, climbMiscTextBox.Text);
            swimMiscTextBox.Text = FeatAddToSkills(athleticCheckBox, swimMiscTextBox.Text);
        }

        private void combatExpertiseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            improvedDisarmCheckBox.Enabled = true;
            improvedFeintCheckBox.Enabled = true;
            improvedTripCheckBox.Enabled = true;
        }

        private void skillTabPage_Enter(object sender, EventArgs e)
        {
            TextBox[] StrAbilitySkills =
            {
                climbAbilityTextBox, jumpAbilityTextBox, swimAbilityTextBox
            };

            TextBox[] DexAbilitySkills =
            {
                balanceAbilityTextBox, escapeArtisitAbilityTextBox, hideAbilityTextBox, moveSilentlyAbilityTextBox,
                rideAbilityTextBox, useRopeAbilityTextBox
            };


            TextBox[] ConAbilitySkills =
            {
                concentrationAbilityTextBox
            };

            TextBox[] IntAbilitySkills =
            {
                appraiseAbilityTextBox, craftAbilityTextBox, forgeryAbilityTextBox,
                searchAbilityTextBox
            };

            TextBox[] WisAbilitySkills =
            {
                healAbilityTextBox, listenAbilityTextBox, senseMotiveAbilityTextBox, spotAbilityTextBox,
                survivalAbilityTextBox
            };

            TextBox[] ChaAbilitySkills =
            {
                bluffAbilityTextBox, diplomacyAbilityTextBox,
                disguiseAbilityTextBox, gatherInformationAbilityTextBox, handleAnimalAbilityTextBox,
                intimidateAbilityTextBox, performAbilityTextBox
            };

            if (Player.PlayerClass.ChosenClass != null)
            {
                AssignClassSkills(GetClassSkills());

                DisplaySkillMods(Player.PlayerClass.StatMods.StrAbilityMod.ToString(), StrAbilitySkills);
                DisplaySkillMods(Player.PlayerClass.StatMods.ConAbilityMod.ToString(), ConAbilitySkills);
                DisplaySkillMods(Player.PlayerClass.StatMods.DexAbilityMod.ToString(), DexAbilitySkills);
                DisplaySkillMods(Player.PlayerClass.StatMods.IntAbilityMod.ToString(), IntAbilitySkills);
                DisplaySkillMods(Player.PlayerClass.StatMods.WisAbilityMod.ToString(), WisAbilitySkills);
                DisplaySkillMods(Player.PlayerClass.StatMods.ChaAbilityMod.ToString(), ChaAbilitySkills);
            }
        }

        private void featTabPage_Enter(object sender, EventArgs e)
        {
            FeatEnabled(Player.PlayerClass.TotalScore.IntTotalScore, combatExpertiseCheckBox);
            FeatEnabled(Player.PlayerClass.TotalScore.DexTotalScore, dodgeCheckBox);
            FeatEnabled(Player.PlayerClass.TotalScore.StrTotalScore, powerAttackCheckBox);
            FeatEnabled15(Player.PlayerClass.TotalScore.DexTotalScore, twoWeaponFightingCheckBox);
            FeatEnabledBaseAttack(Player.PlayerClass.Attack.BaseAttack, weaponFinesseCheckBox);
            FeatEnabledBaseAttack(Player.PlayerClass.Attack.BaseAttack, weaponFocusCheckBox);
            FeatEnabledBaseAttack(Player.PlayerClass.Attack.BaseAttack, quickDrawCheckBox);
            AssignClassSkills(ClassEnableFeats());

            if ((Player.PlayerClass.ChosenClass != null) && (Player.PlayerClass.PlayerLevel != 0) && (Player.Race.RaceName != null))
            {
                totalFeatsTextBox.Text = Player.TotalFeats.ToString();
                BonusFeatsVisible(Player.PlayerClass.ChosenClass);
                bonusFeatsTextBox.Text = Player.PlayerClass.ClassBonusFeats.ToString();
            }
        }

        private CheckBox[] ClassEnableFeats()
        {
            switch (Player.PlayerClass.ChosenClass)
            {
                case "Barbarian":
                    return new[]
                    {
                armorProficiencyLightCheckBox, armorProficiencyMediumCheckBox, shieldProficiencyCheckBox, simpleWeaponProficiencyCheckBox
                    };
                case "Bard":
                    return new[]
                    {
                armorProficiencyLightCheckBox, shieldProficiencyCheckBox, simpleWeaponProficiencyCheckBox
                    };
                case "Cleric":
                    return new[]
                    {
                armorProficiencyLightCheckBox, armorProficiencyMediumCheckBox, armorProficiencyHeavyCheckBox, simpleWeaponProficiencyCheckBox
                    };
                case "Druid":
                    return new CheckBox[]{};
                case "Fighter":
                    return new[]
                    {
                simpleWeaponProficiencyCheckBox, martialWeaponProficiencyCheckBox, armorProficiencyLightCheckBox, armorProficiencyMediumCheckBox,
                armorProficiencyHeavyCheckBox, shieldProficiencyCheckBox, towerShieldProficiencyCheckBox
                    };
                case "Monk":
                    return new[]
                    {
                improvedUnarmedStrikecheckBox
                    };
                case "Paladin":
                    return new[]
                    {
                armorProficiencyLightCheckBox, armorProficiencyMediumCheckBox, armorProficiencyHeavyCheckBox, simpleWeaponProficiencyCheckBox, 
                martialWeaponProficiencyCheckBox, shieldProficiencyCheckBox
                    };
                case "Ranger":
                    return new[]
                    {
                simpleWeaponProficiencyCheckBox, martialWeaponProficiencyCheckBox, armorProficiencyLightCheckBox, shieldProficiencyCheckBox
                    };
                case "Rogue":
                    return new[]
                    {
                simpleWeaponProficiencyCheckBox, armorProficiencyLightCheckBox
                    };
                case "Sorcerer":
                    return new[]
                    {
                simpleWeaponProficiencyCheckBox
                    };
                case "Wizard":
                    return new CheckBox[] {};
            }
            return new CheckBox[] { };
        }

        private void BonusFeatsVisible(string playerClass)
        {
            if ((playerClass == "Fighter") || (playerClass == "Monk") || (playerClass == "Wizard"))
            {
                bonusFeatsTextBox.Visible = true;
                bonusFeatsLabel.Visible = true;
            }
            else
            {
                bonusFeatsTextBox.Visible = false;
                bonusFeatsLabel.Visible = false;
            }
        }

        private void equipmentTabPage_Enter(object sender, EventArgs e)
        {
            AddArmorAndWeaponsToEquipment();   
        }

        private void AddArmorAndWeaponsToEquipment()
        {                       
                armorComboBox.Items.Clear();
                weaponOneComboBox.Items.Clear();
                armorComboBox.Items.AddRange(Player.PlayerClass.ClassArmor);
                armorComboBox.Items.AddRange(Player.PlayerClass.ClassShields);
                weaponOneComboBox.Items.AddRange(Player.PlayerClass.ClassWeapons); 
        }

        public void CreatePlayer(string playerName, string playerClass, string playerRace, int level)
        {
            if (playerName == null)
            {
                Player = new Player("New Player", playerClass, playerRace, level );
            }

            Player = new Player(playerName, playerClass, playerRace, level);
        }

        private void AssignSpellsPerDay()
        {
            Player.PlayerClass.GetClassSpellsPerDay();
            Player.PlayerClass.GetBonusSpells();
            Player.PlayerClass.GetSpellDifficultyClass();
        }

        private void DisplaySpellsPerDay()
        {
            SpellBoxs = new[] { level0SpellTextBox, level1SpellTextBox, level2SpellTextBox, level3SpellTextBox, level4SpellTextBox,
                level5SpellTextBox, level6SpellTextBox,level7SpellTextBox,level8SpellTextBox, level9SpellTextBox};

            if (Player.PlayerClass.Magic.ClassSpellsPerDay != null)
            {
                int spellLength = Player.PlayerClass.Magic.ClassSpellsPerDay.Length;
                int spellboxlength = SpellBoxs.Length;
                var i = spellLength <= spellboxlength ? spellLength - 1 : spellboxlength - 1;

                for (int j = 0; j <= i; j++)
                {
                    SpellBoxs[j].Text = Player.PlayerClass.Magic.ClassSpellsPerDay[j].ToString();
                }
            }
        }

        private void DisplayBonusSpells()
        {
            BonusSpellBoxs = new[] { bonus1SpellTextBox, bonus2SpellTextBox, bonus3SpellTextBox, bonus4SpellTextBox, bonus5SpellTextBox, 
                bonus6SpellTextBox, bonus7SpellTextBox, bonus8SpellTextBox, bonus9SpellTextBox};

            if (Player.PlayerClass.Magic.ClassSpellsPerDay != null)
            {
                int spellLength = Player.PlayerClass.Magic.BonusSpells.Length;
                int spellboxlength = BonusSpellBoxs.Length;
                var i = spellLength <= spellboxlength ? spellLength : spellboxlength;

                for (int j = 0; j < i; j++)
                {
                    BonusSpellBoxs[j].Text = Player.PlayerClass.Magic.BonusSpells[j].ToString();
                }
            }
        }

        private void DisplaySpellDCSpells()
        {
            TextBox[] SpellDC = { spellDC0TextBox, spellDC1TextBox,spellDC2TextBox, spellDC3TextBox, spellDC4TextBox,
                spellDC5TextBox, spellDC6TextBox, spellDC7TextBox, spellDC8TextBox, spellDC9TextBox};

            if (Player.PlayerClass.Magic.ClassSpellsPerDay != null)
            {
                int spellLength = Player.PlayerClass.Magic.SpellDC.Length;
                int spellboxlength = SpellDC.Length;
                int i;
                if (spellLength <= spellboxlength)
                {
                    i = spellLength;
                }
                else
                {
                    i = spellboxlength;
                }

                for (int j = 0; j < i; j++)
                {
                    SpellDC[j].Text = Player.PlayerClass.Magic.SpellDC[j].ToString();
                }
            }
        }

        public void Map(string[] stringArray )
        {
            Mapper.CreateMap<string[], CheckBox[]>();
            CheckBoxs = Mapper.Map<CheckBox[]>(stringArray);

        }
    }
}
