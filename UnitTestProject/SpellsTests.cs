using NUnit.Framework;
using PlayerClasses;
using ZachsCharacterGenerater.Classes;
namespace ZachsCharacterGenerater
{
     [TestFixture]
    public class SpellsTests
    {
         [Test]
         public void AbilityModifierBad5ReturnsNoBonusSpells()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(-5);
             int[] expetced = {0};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier1Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(1);
             int[] expetced = { 1};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier2Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(2);
             int[] expetced = { 1, 1};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier3Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(3);
             int[] expetced = { 1, 1, 1 };
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier4Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(4);
             int[] expetced = { 1, 1, 1, 1};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier5Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(5);
             int[] expetced = { 2, 1, 1, 1, 1 };
             Assert.AreEqual(expetced, actual);
         }


         [Test]
         public void AbilityModifier6Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(6);
             int[] expetced = { 2, 2, 1, 1, 1, 1};
             Assert.AreEqual(expetced, actual);
         }


         [Test]
         public void AbilityModifier7Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(7);
             int[] expetced = { 2, 2, 2, 1, 1, 1, 1};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier8Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(8);
             int[] expetced = { 2, 2, 2, 2, 1, 1, 1, 1};
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier9Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(9);
             int[] expetced = { 3, 2, 2, 2, 2, 1, 1, 1, 1 };
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifier10Spell()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(10);
             int[] expetced = { 3, 3, 2, 2, 2, 2, 1, 1, 1 };
             Assert.AreEqual(expetced, actual);
         }

         [Test]
         public void AbilityModifierBadReturnsNoBonusSpells()
         {
             BonusSpells bonusSpells = new BonusSpells();
             int[] actual = bonusSpells.BonusSpellsCalculate(-999);
             int[] expetced = { 0};
             Assert.AreEqual(expetced, actual);
         }
    }
}