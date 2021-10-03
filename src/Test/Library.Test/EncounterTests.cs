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
            Wizard wizard = new Wizard("Wizard", new SpellBook("El libro de los encantamientos."));
            Goblin goblin = new Goblin("Goblin");
        
            encounter.AddCharacter(wizard);
            encounter.AddCharacter(goblin);
            
            Assert.IsNotNull(encounter);
            encounter.DoEncounter();
        }        
        [Test]
        public void EncounterCharacters1()
        {
            Encounter encounter = new Encounter();
            Wizard wizard = new Wizard("Wizard",new SpellBook("El libro de los encantamientos."));
            Goblin goblin = new Goblin("Goblin");
        
            encounter.AddCharacter(wizard);
            encounter.AddCharacter(goblin);

            Assert.False(encounter.AllEnemiesAreDead());
            Assert.False(encounter.AllHeroesAreDead());
            encounter.DoEncounter();
        }

        [Test]
        public void EncounterCharacters2()
        {
            Encounter encounter = new Encounter();
            Knight knight = new Knight("Dark Knight");
            Elf elf = new Elf("Archer");
            Dwarf dwarf = new Dwarf("Dwarf");
            
            encounter.AddCharacter(knight);
            encounter.AddCharacter(elf);
            encounter.AddCharacter(dwarf);

            Goblin goblin = new Goblin("Goblin");
            Bandit bandit = new Bandit("Bandit");
            Slime slime = new Slime("Slime");

            encounter.AddCharacter(goblin);
            encounter.AddCharacter(bandit);
            encounter.AddCharacter(slime);

            encounter.DoEncounter();
            Assert.True(encounter.AllEnemiesAreDead());
        }
        
        [Test]
        public void EncounterCharacters3()
        {
            Encounter encounter = new Encounter();
            Knight knight = new Knight("Dark Knight");
            
            encounter.AddCharacter(knight);

            Goblin goblin = new Goblin("Goblin");
            Bandit bandit = new Bandit("Bandit");
            Slime slime = new Slime("Slime");

            encounter.AddCharacter(goblin);
            encounter.AddCharacter(bandit);
            encounter.AddCharacter(slime);

            encounter.DoEncounter();
            Assert.True(encounter.AllHeroesAreDead());
        }
        
        [Test]
        public void EncounterCharacters4()
        {
            Encounter encounter = new Encounter();
            Knight knight = new Knight("Dark Knight");
            Elf elf = new Elf("Archer");
            Dwarf dwarf = new Dwarf("Dwarf");
            
            encounter.AddCharacter(knight);
            encounter.AddCharacter(elf);
            encounter.AddCharacter(dwarf);

            Goblin goblin = new Goblin("Goblin");

            encounter.AddCharacter(goblin);

            encounter.DoEncounter();
            Assert.True(encounter.AllEnemiesAreDead());
        }
    }

}