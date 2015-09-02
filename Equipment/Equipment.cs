namespace Equipment
{
    using System;
    public class Equipment
    {
        public Double Cost { get; set; }
        public decimal Weight { get; set; }
        public string Name { get; set; }
        
        public Equipment()
        {
            Name = string.Empty;
            Cost = 0.00;
            Weight = 0.00m;
        }

        public Equipment(double cost, decimal weight, string name)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
        }

        public Equipment BuildItem(string item)
        {
            switch (item)
            {
                case "Backpack (empty)":
                    Equipment backpack = new Equipment(2, 2, "Backpack (empty)");
                    return backpack;
                case "Barrel (empty)":
                    Equipment barrel = new Equipment(2, 30, "Barrel (empty)");
                    return barrel;
                case "Basket (empty)":
                    Equipment basket = new Equipment(.4, 1, "Basket (empty)");
                    return basket;
                case "Bedroll":
                    Equipment bedroll = new Equipment(.1,5,"Bedroll");
                    return bedroll;
                case "Bell":
                    Equipment bell = new Equipment(1, 0, "Bell");
                    return bell;
                case "Blanket, winter":
                    Equipment blanket = new Equipment(.5,3,"Blanket, winter");
                    return blanket;
                case "Block and tackle":
                    Equipment blockAndTackle = new Equipment(5, 5, "Block and tackle");
                    return blockAndTackle;
                case "Bottle, wine, glass":
                    Equipment bottleWineGlass = new Equipment(2, 0, "Bottle, wine, glass");
                    return bottleWineGlass;
                case "Bucket (empty)":
                    Equipment bucket = new Equipment(.5, 2, "Bucket (empty)");
                    return bucket;
                case "Caltrops":
                    Equipment caltrops = new Equipment(1, 2, "Caltrops");
                    return caltrops;
                case "Candle":
                    Equipment candle = new Equipment(.01, 00, "Candle");
                    return candle;
                case "Canvas (sq. yd.)":
                    Equipment canvas = new Equipment(.1, 1, "Canvas (sq. yd.)");
                    return canvas;
                case "Case, map or scroll":
                    Equipment caseMapScroll = new Equipment(1, .50m, "Case, map or scroll");
                    return caseMapScroll;
                case "Chain (10 ft.)":
                    Equipment chain = new Equipment(30, 2, "Chain (10 ft.)");
                    return chain;
                case "Chalk, 1 piece":
                    Equipment chalk = new Equipment(.01, 0, "Chalk, 1 piece");
                    return chalk;
                case "Chest (empty)":
                    Equipment chest = new Equipment(.01, 0, "Chest (empty)");
                    return chest;
                case "Crowbar":
                    Equipment crowbar = new Equipment(2, 5, "Crowbar");
                    return crowbar;
                case "Firewood (per day)":
                    Equipment firewood = new Equipment(.01, 20, "Firewood (per day)");
                    return firewood;
                case "Fishhook":
                    Equipment fishhook = new Equipment(.1, 0, "Fishhook");
                    return fishhook;
                case "Fishing net, 25 sq. ft.":
                    Equipment fishingNet = new Equipment(4, 5, "Fishing net, 25 sq. ft.");
                    return fishingNet;
                case "Flask (empty)":
                    Equipment flask = new Equipment(.03, 1.50m, "Flask (empty)");
                    return flask;
                case "Flint and steel":
                    Equipment flintSteel = new Equipment(1, 0, "Flint and steel");
                    return flintSteel;
                case "Grappling hook":
                    Equipment grapplingHook = new Equipment(1, 4, "Grappling hook");
                    return grapplingHook;
                case "Hammer":
                    Equipment hammer = new Equipment(.5, 2, "Hammer");
                    return hammer;
                case "Ink (1 oz. vial)":
                    Equipment ink = new Equipment(8, 0, "Ink (1 oz. vial)");
                    return ink;
                case "Inkpen":
                    Equipment inkPen = new Equipment(.1, 0, "Inkpen");
                    return inkPen;
                case "Jug, clay":
                    Equipment jug = new Equipment(.03, 9, "Jug, clay");
                    return jug;
                case "Ladder, 10-foot":
                    Equipment ladder = new Equipment(.05, 20, "Ladder, 10-foot");
                    return ladder;
                case "Lamp, common":
                    Equipment lampCommon = new Equipment(.1, 1, "Lamp, common");
                    return lampCommon;
                case "Lantern, bullseye":
                    Equipment lanternBullseye = new Equipment(12, 3, "Lantern, bullseye");
                    return lanternBullseye;
                case "Lantern, hooded":
                    Equipment lanternHooded = new Equipment(7, 2, "Lantern, hooded");
                    return lanternHooded;
                case "Lock, Very simple":
                    Equipment lockSimple = new Equipment(20, 1, "Lock, Very simple");
                    return lockSimple;
                case "Lock, Average":
                    Equipment lockAverage = new Equipment(40, 1, "Lock, Average");
                    return lockAverage;
                case "Lock, Good":
                    Equipment lockGood = new Equipment(80, 1, "Lock, Good");
                    return lockGood;
                case "Lock, Amazing":
                    Equipment lockAmazing = new Equipment(150, 1, "Lock, Amazing");
                    return lockAmazing;
                case "Manacles":
                    Equipment manacles = new Equipment(15, 2, "Manacles");
                    return manacles;
                case "Manacles, masterwork":
                    Equipment manaclesMasterwork = new Equipment(50, 2, "Manacles, masterwork");
                    return manaclesMasterwork;
                case "Mirror, small steel":
                    Equipment mirrorSmallSteel = new Equipment(10, .50m, "Mirror, small steel");
                    return mirrorSmallSteel;
                case "Mug/Tankard, clay":
                    Equipment mugTankard = new Equipment(.02, 1, "Mug/Tankard, clay");
                    return mugTankard;
                case "Oil (1-pint flask)":
                    Equipment oil = new Equipment(.1, 1, "Oil (1-pint flask)");
                    return oil;
                case "Paper (sheet)":
                    Equipment paper = new Equipment(.4, 0, "Paper (sheet)");
                    return paper;
                case "Parchment (sheet)":
                    Equipment parchment = new Equipment(.2, 0, "Parchment (sheet)");
                    return parchment;
                case "Pick, miner’s":
                    Equipment pickMiner = new Equipment(3, 10, "Pick, miner’s");
                    return pickMiner;
                case "Pitcher, clay":
                    Equipment pitcherClay = new Equipment(.02, 5, "Pitcher, clay");
                    return pitcherClay;
                case "Piton":
                    Equipment piton = new Equipment(.1, .50m, "Piton");
                    return piton;
                case "Pole, 10-foot":
                    Equipment pole = new Equipment(.2, 8, "Pole, 10-foot");
                    return pole;
                case "Pot, iron":
                    Equipment pot = new Equipment(.5, 10, "Pot, iron");
                    return pot;
                case "Pouch, belt (empty)":
                    Equipment pouchBelt = new Equipment(1, .50m, "Pouch, belt (empty)");
                    return pouchBelt;
                case "Ram, portable":
                    Equipment ram = new Equipment(10, 20, "Ram, portable");
                    return ram;
                case "Rations, trail (per day)":
                    Equipment rationsTrail = new Equipment(.5, 1, "Rations, trail (per day)");
                    return rationsTrail;
                case "Rope, hempen (50 ft.)":
                    Equipment ropeHempen = new Equipment(1, 10, "Rope, hempen (50 ft.");
                    return ropeHempen;
                case "Rope, silk (50 ft.)":
                    Equipment ropeSilk = new Equipment(10, 5, "Rope, silk (50 ft.");
                    return ropeSilk;
                case "Sack (empty)":
                    Equipment sack = new Equipment(.1, .50m, "Sack (empty)");
                    return sack;
                case "Sealing wax":
                    Equipment sealingWax = new Equipment(1, 1, "Sealing wax");
                    return sealingWax;
                case "Sewing needle":
                    Equipment sewingNeedle = new Equipment(.5, 0, "Sewing needle");
                    return sewingNeedle;
                case "Signal whistle":
                    Equipment signalWhistle = new Equipment(.8, 0, "Signal whistle");
                    return signalWhistle;
                case "Signet ring":
                    Equipment signetRing = new Equipment(5, 0, "Signet ring");
                    return signetRing;
                case "Sledge":
                    Equipment sledge = new Equipment(1, 10, "Sledge");
                    return sledge;
                case "Soap (per lb.)":
                    Equipment soup = new Equipment(.5, 1, "Soap (per lb.");
                    return soup;
                case "Spade or shovel":
                    Equipment spadeOrShovel = new Equipment(2, 8, "Spade or shovel");
                    return spadeOrShovel;
                case "Spyglass":
                    Equipment spyglass = new Equipment(1000, 1, "Spyglass");
                    return spyglass;
                case "Tent":
                    Equipment tent = new Equipment(10, 20, "Tent");
                    return tent;
                case "Torch":
                    Equipment torch = new Equipment(.01, 1, "Torch");
                    return torch;
                case "Vial, ink or potion":
                    Equipment vailInkPotion = new Equipment(1, .10m, "Vial, ink or potion");
                    return vailInkPotion;
                case "Waterskin":
                    Equipment waterskin = new Equipment(1, 4, "Waterskin");
                    return waterskin;
                case "Whetstone":
                    Equipment whetstone = new Equipment(.02, 1, "Whetstone");
                    return whetstone;
                case "Acid (flask)":
                    Equipment acid = new Equipment(10, 1, "Acid (flask)");
                    return acid;
                case "Alchemist’s fire (flask)":
                    Equipment alchemistsFire = new Equipment(20, 1, "Alchemist’s fire (flask)");
                    return alchemistsFire;
                case "Antitoxin (vial)":
                    Equipment antitoxin = new Equipment(50, 0, "Antitoxin (vial)");
                    return antitoxin;
                case "Everburning torch":
                    Equipment everburningTorch = new Equipment(110, 1, "Everburning torch");
                    return everburningTorch;
                case "Holy water (flask)":
                    Equipment holyWater = new Equipment(25, 1, "Holy water (flask)");
                    return holyWater;
                case "Smokestick":
                    Equipment smokestick = new Equipment(20, .05m, "Smokestick");
                    return smokestick;
                case "Sunrod":
                    Equipment sunrod = new Equipment(2, 1, "Sunrod");
                    return sunrod;
                case "Tanglefoot bag":
                    Equipment tanglefootBag = new Equipment(50, 4, "Tanglefoot bag");
                    return tanglefootBag;
                case "Thunderstone":
                    Equipment thunderstone = new Equipment(30, 1, "Thunderstone");
                    return thunderstone;
                case "Tindertwig":
                    Equipment tindertwig = new Equipment(1, 0, "Tindertwig");
                    return tindertwig;
                case "Alchemist’s lab":
                    Equipment alchemistLab = new Equipment(500, 40, "Alchemist’s lab");
                    return alchemistLab;
                case "Artisan’s tools":
                    Equipment artisanTools = new Equipment(5, 5, "Artisan’s tools");
                    return artisanTools;
                case "Artisan’s tools, masterwork":
                    Equipment artisanToolsMasterwork = new Equipment(55, 5, "Artisan’s tools, masterwork");
                    return artisanToolsMasterwork;
                case "Climber’s kit":
                    Equipment climberKit = new Equipment(80, 5, "Climber’s kit");
                    return climberKit;
                case "Disguise kit":
                    Equipment disguiseKit = new Equipment(50, 8, "Disguise kit");
                    return disguiseKit;
                case "Healer’s kit":
                    Equipment healerKit = new Equipment(50, 1, "Healer’s kit");
                    return healerKit;
                case "Holly and mistletoe":
                    Equipment hollyAndMistletoe = new Equipment(0, 0, "Holly and mistletoe");
                    return hollyAndMistletoe;
                case "Holy symbol, wooden":
                    Equipment holySymbolWooden = new Equipment(1, 0, "Holy symbol, wooden");
                    return holySymbolWooden;
                case "Holy symbol, silver":
                    Equipment holySymbolSilver = new Equipment(25, 1, "Holy symbol, silver");
                    return holySymbolSilver;
                case "Hourglass":
                    Equipment hourglass = new Equipment(25, 1, "Hourglass");
                    return hourglass;
                case "Magnifying glass":
                    Equipment magnifyingGlass = new Equipment(100, 0, "Magnifying glass");
                    return magnifyingGlass;
                case "Musical instrument, common":
                    Equipment musicalInstrumentCommon = new Equipment(5, 3, "Musical instrument, common");
                    return musicalInstrumentCommon;
                case "Musical instrument, masterwork":
                    Equipment musicalInstrumentMasterwork = new Equipment(100, 3, "Musical instrument, masterwork");
                    return musicalInstrumentMasterwork;
                case "Scale, merchant’s":
                    Equipment scaleMerchant = new Equipment(2, 1, "Scale, merchant’s");
                    return scaleMerchant;
                case "Spell component pouch":
                    Equipment smallComponetPouch = new Equipment(5, 2, "Spell component pouch");
                    return smallComponetPouch;
                case "Spellbook, wizard’s (blank)":
                    Equipment spellbookWizards = new Equipment(15, 3, "Spellbook, wizard’s (blank)");
                    return spellbookWizards;
                case "Thieves’ tools":
                    Equipment thievesTool = new Equipment(30, 1, "Thieves’ tools");
                    return thievesTool;
                case "Thieves’ tools, masterwork":
                    Equipment thievesToolMasterwork = new Equipment(100, 2, "Thieves’ tools, masterwork");
                    return thievesToolMasterwork;
                case "Tool, masterwork":
                    Equipment toolMasterwork = new Equipment(20, 1, "Tool, masterwork");
                    return toolMasterwork;
                case "Water clock":
                    Equipment waterClock = new Equipment(1000, 200, "Water clock");
                    return waterClock;
                case "Artisan’s outfit":
                    Equipment artisansOutfit = new Equipment(1, 4, "Artisan’s outfit");
                    return artisansOutfit;
                case "Cleric’s vestments":
                    Equipment clericVestments = new Equipment(5, 6, "Cleric’s vestments");
                    return clericVestments;
                case "Cold weather outfit":
                    Equipment coldWeatherOutfit = new Equipment(8, 7, "Cold weather outfit");
                    return coldWeatherOutfit;
                case "Courtier’s outfit":
                    Equipment courtiersOutfit = new Equipment(30, 6, "Courtier’s outfit");
                    return courtiersOutfit;
                case "Entertainer’s outfit":
                    Equipment entertainerOutfit = new Equipment(3, 4, "Entertainer’s outfit");
                    return entertainerOutfit;
                case "Explorer’s outfit":
                    Equipment explorerOutfit = new Equipment(10, 8, "Explorer’s outfit");
                    return explorerOutfit;
                case "Monk’s outfit":
                    Equipment monkOutfit = new Equipment(5, 2, "Monk’s outfit");
                    return monkOutfit;
                case "Noble’s outfit":
                    Equipment nobleOutfit = new Equipment(75, 10, "Noble’s outfit");
                    return nobleOutfit;
                case "Peasant’s outfit":
                    Equipment peasantOutfit = new Equipment(.1, 2, "Peasant’s outfit");
                    return peasantOutfit;
                case "Royal outfit":
                    Equipment royalOutfit = new Equipment(200, 15, "Royal outfit");
                    return royalOutfit;
                case "Scholar’s outfit":
                    Equipment scholarOutfit = new Equipment(5, 6, "Scholar’s outfit");
                    return scholarOutfit;
                case "Traveler’s outfit":
                    Equipment travelerOutfit = new Equipment(1, 5, "Traveler’s outfit");
                    return travelerOutfit;
                case "Ale Gallon":
                    Equipment aleGallon = new Equipment(.2, 8, "Ale Gallon");
                    return aleGallon;
                case "Ale Mug":
                    Equipment aleMug = new Equipment(.04, 1, "Ale Mug");
                    return aleMug;
                case "Banquet (per person)":
                    Equipment banquet = new Equipment(10, 0, "Banquet (per person)");
                    return banquet;
                case "Bread, per loaf":
                    Equipment bread = new Equipment(.02, .50m, "Bread, per loaf");
                    return bread;
                case "Cheese, hunk of":
                    Equipment cheese = new Equipment(.1, .50m, "Cheese, hunk of");
                    return cheese;
                case "Inn stay, Good":
                    Equipment innStayGood = new Equipment(2, 0, "Inn stay, Good");
                    return innStayGood;
                case "Inn stay, Common":
                    Equipment innStayCommon = new Equipment(.5, 0, "Inn stay, Common");
                    return innStayCommon;
                case "Inn stay, Poor":
                    Equipment innStayPoor = new Equipment(.5, 0, "Inn stay, Poor");
                    return innStayPoor;
                case "Meals, Good (per day)":
                    Equipment mealsGood = new Equipment(.5, 0, "Meals, Good (per day)");
                    return mealsGood;
                case "Meals, Common (per day)":
                    Equipment mealsCommon = new Equipment(.3, 0, "Meals, Common (per day)");
                    return mealsCommon;
                case "Meals, Poor (per day)":
                    Equipment mealsPoor = new Equipment(.1, 0, "Meals, Poor (per day)");
                    return mealsPoor;
                case "Meat, chunk of":
                    Equipment meat = new Equipment(.3, .50m, "Meat, chunk of");
                    return meat;
                case "Wine, Common (pitcher)":
                    Equipment wineCommon = new Equipment(.2, 6, "Wine, Common (pitcher)");
                    return wineCommon;
                case "Wine, Fine (bottle)":
                    Equipment wineFine = new Equipment(10, 1.50m, "Wine, Fine (bottle)");
                    return wineFine;
            }
            return new Equipment(0,0,"");
        }
    }
}
