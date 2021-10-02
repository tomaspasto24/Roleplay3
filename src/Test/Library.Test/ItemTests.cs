using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ItemTests
    {

        [Test]
        public void CreateSword()
        {
            Sword item = new Sword("Espada de fuego");
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
            Armor item = new Armor("Armadura de caballero");
            string expecetedName = "Armadura de caballero";
            int expecetedDamage = 0;
            int expectedArmor = 40;

            Assert.AreEqual(item.ReturnName(), expecetedName);
            Assert.AreEqual(item.ReturnDamage(), expecetedDamage);
            Assert.AreEqual(item.ReturnArmor(), expectedArmor);
        }
    }
}