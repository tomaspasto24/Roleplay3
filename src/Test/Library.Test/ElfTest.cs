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
            Sword itemAtaque = new Sword("Espada de Fuego");
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
            Armor itemArmor = new Armor("Armadura");
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
            Sword itemAtaque = new Sword("Espada de Fuego");
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