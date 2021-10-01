using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ItemTests
    {

        [Test]
        public void CreateSword()
        {
            Item item = new Item("Espada de fuego", 30, 0);
            string expecetedName = "Espada de fuego";
            int expecetedDamage = 30;
            int expectedArmor = 0;

            Assert.AreEqual(item.ReturnName(), expecetedName);
            Assert.AreEqual(item.ReturnDamage(), expecetedDamage);
            Assert.AreEqual(item.ReturnArmor(), expectedArmor);
        }

        [Test]
        public void CreateArmor()
        {
            Item item = new Item("Armadura de caballero", 0, 40);
            string expecetedName = "Armadura de caballero";
            int expecetedDamage = 0;
            int expectedArmor = 40;

            Assert.AreEqual(item.ReturnName(), expecetedName);
            Assert.AreEqual(item.ReturnDamage(), expecetedDamage);
            Assert.AreEqual(item.ReturnArmor(), expectedArmor);
        }
    }
}