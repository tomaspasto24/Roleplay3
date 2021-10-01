using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ElfTest
    {
        [Test]
        public void ReciveDamageTest()
        {
            Elf elfa = new Elf("Idril");
            int damage = 7;
            int expectedHealth = 100 - 7;
            elfa.RecieveDamage(damage);
            Assert.AreEqual(expectedHealth, elfa.CurrentHealth());
        }

        [Test]
        public void AttackEnemyKnightTest()
        {
            Elf elfa = new Elf("Idril");
            Knight knight = new Knight("Wade");
            elfa.AttackEnemy(knight);
            int expectedHealth = 100 - 35;
            Assert.AreEqual(expectedHealth, knight.CurrentHealth());
        }

        [Test]
        public void EquipItemAttackTest()
        {
            Elf elfa = new Elf("Idril");
            Item itemAtaque = new Item("Fuego", 15, 0);
            elfa.EquipItem(itemAtaque);
            int expectedAttack = 35 + 15;
            int expectedArmor = 5;
            Assert.IsNotEmpty(elfa.ReturnInventory());
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.AreEqual(expectedArmor, elfa.ReturnArmor());
        }

        [Test]
        public void EquipItemArmorTest()
        {
            Elf elfa = new Elf("Idril");
            Item itemArmor = new Item("Pocion", 15, 0);
            elfa.EquipItem(itemArmor);
            int expectedAttack = 35 + 15;
            int expectedArmor = 5;
            Assert.IsNotEmpty(elfa.ReturnInventory());
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.AreEqual(expectedArmor, elfa.ReturnArmor());
        }
        
        [Test]
        public void UnEquipItemTest()
        {
            Elf elfa = new Elf("Idril");
            Item itemAtaque = new Item("Fuego", 15, 0);
            elfa.EquipItem(itemAtaque);
            int expectedAttack = 35 + 15;
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            
            elfa.UnequipItem(itemAtaque);
            expectedAttack = 50 - 15;
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.IsEmpty(elfa.ReturnInventory());
        }

    }
}