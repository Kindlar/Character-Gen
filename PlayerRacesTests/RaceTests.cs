using NUnit.Framework;
using PlayerRaces;

namespace PlayerRacesTests
{
    [TestFixture]
    public class RaceTests
    {
        [Test]
        public void ElfReturnDex2()
        {
            Elf race = new Elf();
            int actual = race.DexRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HumanReturnInt0()
        {
            Human race = new Human();
            int actual = race.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DwarfReturnChaBad2()
        {
            Dwarf race = new Dwarf();
            int actual = race.ChaRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfElfReturn0Str()
        {
            HalfElf race = new HalfElf();
            int actual = race.StrRacialMod;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfOrcReturn2Str()
        {
            HalfOrc race = new HalfOrc();
            int actual = race.StrRacialMod;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfingReturnBad2Str()
        {
            Halfing race = new Halfing();
            int actual = race.StrRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GnomeReturnBad2Str()
        {
            Gnome race = new Gnome();
            int actual = race.StrRacialMod;
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BadDataReturnNull()
        {
            Race race = new Race();
            Assert.IsNull(race.RaceName);
        }
    }
}
