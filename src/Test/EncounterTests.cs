using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class EncounterTests
    {
        [Test]
        public void CreateEncounter()
        {
            Encounter encounter = new Encounter();
            Wizard wizard = new Wizard("Wizard");
            Goblin goblin = new Goblin("Goblin");
        
            encounter.AddCharacter(wizard);
            encounter.AddCharacter(goblin);
            
            Assert.IsNotEmpty(encounter);
            Assert.IsNotNull(encounter);
            encounter.DoEncounter();
        }        
        
        [Test]
        public void EncounterCharacters()
        {
            Encounter encounter = new Encounter();
            Wizard wizard = new Wizard("Wizard");
            Goblin goblin = new Goblin("Goblin");
        
            encounter.AddCharacter(wizard);
            encounter.AddCharacter(goblin);

            Assert.False(encounter.AllEnemiesAreDead());
            Assert.False(encounter.AllHeroesAreDead());
            encounter.DoEncounter();
        }
    }

}