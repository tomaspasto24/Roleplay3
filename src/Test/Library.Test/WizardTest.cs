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
            brujo.EquipItem(new Staff("Staff de Hielo"));
            brujo.EquipItem(new Sword("Daga"));
            brujo.EquipItem(new Armor("Tunica de mago"));
                    
            Assert.IsNotNull(brujo);
            Assert.IsNotEmpty(brujo.ReturnInventory());
            Assert.IsNotEmpty(brujo.spellBook.GetSpells());
        }

        [Test]
        public void SpellsTest()
        {
            SpellBook book = new SpellBook("El libro de los encantamientos.");
            Wizard brujo = new Wizard("Prueba1", book);
            book.AddSpell(new FireElement("Bola de fuego"));
            book.AddSpell(new WaterElement("Bola de nieve"));
            book.AddSpell(new MudElement("Bola de barro"));

            Assert.IsNotEmpty(book.GetSpells());
            Assert.IsNotNull(book.spellsCount);
        } 
    }


}