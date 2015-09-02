namespace ZachsCharacterGenerater
{
    using NUnit.Framework;
    
    [TestFixture]
    public class CharacterFormTests
    {
        [TestCase("Barbarian")]
        [TestCase("Bard")]
        [TestCase("Cleric")]
        [TestCase("Druid")]
        [TestCase("Fighter")]
        [TestCase("Monk")]
        [TestCase("Paladin")]
        [TestCase("Ranger")]
        [TestCase("Rogue")]
        [TestCase("Sorcerer")]
        [TestCase("Wizard")]
        public void GivenAClass_CharacterIsCreated(string chosenClass)
        {
            CharacterForm form = new CharacterForm();
            form.CreatePlayer("name",chosenClass, "Human", 1);
            string actual = form.Player.PlayerClass.ChosenClass;
            Assert.AreEqual(chosenClass, actual);
        }
    }
}
