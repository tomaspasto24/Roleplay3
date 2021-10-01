using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void WizardTest()
        {
            Wizard brujo = new Wizard("Prueba1", new SpellBook("El libro de los encantamientos."));
            brujo.EquipItem(new Item("Daga", 32, 0));
            brujo.EquipItem(new Item("Arma de fuego M-92", 40, 0));
            brujo.EquipItem(new Item("Botella", 4, 2));
            brujo.ExchangeItem(brujo.ReturnInventory()[0], brujo.ReturnInventory()[1]);
                    
            Assert.IsNotNull(brujo);
            Assert.IsNotEmpty(brujo.ReturnInventory());
            Assert.IsNotEmpty(brujo.spellBook.GetSpells());
        }

        [Test]
        public void SpellsTest()
        {
            SpellBook book = new SpellBook("El libro de los encantamientos.");
            Wizard brujo = new Wizard("Prueba1", book);
            book.AddSpell(new Spell("Bola de fuego", "fuego", 13));
            book.AddSpell(new Spell("Bola de nieve", "nieve", 16));
            book.AddSpell(new Spell("Bola de granizo", "granizo", 20));

            Assert.IsNotEmpty(book.GetSpells());
            Assert.IsNotNull(book.spellsCount);
        } 
    }


}