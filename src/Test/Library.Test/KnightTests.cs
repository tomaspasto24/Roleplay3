using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class KnightTests
    {

        [Test]
        public void EquipItem1()
        {
            Knight knight = new Knight("Dark Knight");
            Sword item = new Sword("Espada");
            int expectedDamage = 25 + 50;
            int expectedArmor = 35;
            knight.EquipItem(item);

            Assert.IsNotEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);
        }

        [Test]
        public void EquipItem2()
        {
            Knight knight = new Knight("Dark Knight");
            Armor item = new Armor("Armadura");
            int expectedDamage = 25 + 20;
            int expectedArmor = 35 + 80;
            knight.EquipItem(item);

            Assert.IsNotEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);
        }

        [Test]
        public void UnequipItem()
        {
            Knight knight = new Knight("Dark Knight");
            Sword item = new Sword("Espada");
            int expectedDamage = 25;
            int expectedArmor = 35;
            knight.EquipItem(item);

            knight.UnequipItem(item);

            Assert.IsEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);            
        }

        [Test]
        public void AttackTest1()
        {
            Knight knight1 = new Knight("Atacante");
            Knight knight2 = new Knight("Defensor");
            int expectedHealth = 75;

            knight1.AttackEnemy(knight2);

            Assert.AreEqual(expectedHealth, knight2.CurrentHealth());
        }

        [Test]
        public void AttackTest2()
        {
            Knight knight1 = new Knight("Atacante");
            Wizard wizard = new Wizard("Defensor", new SpellBook("Libro"));
            int expectedHealth = 25;

            knight1.AttackEnemy(wizard);

            Assert.AreEqual(expectedHealth, wizard.CurrentHealth());
        }

        [Test]
        public void RestoreHP()
        {
            Knight knight = new Knight("Defensor");
            Wizard wizard = new Wizard("Atacante", new SpellBook("Libro"));
            int expectedHealth = 100;

            wizard.AttackEnemy(knight);

            knight.RestoreHealth();

            Assert.AreEqual(expectedHealth, knight.CurrentHealth());
        }
    }


}