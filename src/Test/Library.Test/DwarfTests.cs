using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class DwarfTests
    {

        [Test]
        public void EquipItem1()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            Sword item = new Sword("Espada");
            int expectedDamage = 50 + 15;
            int expectedArmor = 35;
            dwarf.EquipItem(item);

            Assert.IsNotEmpty(dwarf.ReturnInventory());
            Assert.AreEqual(dwarf.ReturnAttack(), expectedDamage);
        }


        [Test]
        public void UnequipItem()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            Sword item = new Sword("Espada");
            int expectedDamage = 15;
            int expectedArmor = 35;
            dwarf.EquipItem(item);

            dwarf.UnequipItem(item);

            Assert.IsEmpty(dwarf.ReturnInventory());
            Assert.AreEqual(dwarf.ReturnAttack(), expectedDamage);
            Assert.AreEqual(dwarf.ReturnArmor(), expectedArmor);            
        }

        [Test]
        public void AttackTest1()
        {
            Dwarf dwarf1 = new Dwarf("Atacante");
            Dwarf dwarf2 = new Dwarf("Defensor");
            int expectedHealth = 85;

            dwarf1.AttackEnemy(dwarf2);

            Assert.AreEqual(expectedHealth, dwarf2.CurrentHealth());
        }

        [Test]
        public void AttackTest2()
        {
            Dwarf dwarf1 = new Dwarf("Atacante");
            Wizard wizard = new Wizard("Defensor", new SpellBook("Libro"));
            int expectedHealth = 35;

            dwarf1.AttackEnemy(wizard);

            Assert.AreEqual(expectedHealth, wizard.CurrentHealth());
        }

        [Test]
        public void RestoreHP()
        {
            Dwarf dwarf1 = new Dwarf("Defensor");
            Wizard wizard = new Wizard("Atacante", new SpellBook("Libro"));
            int expectedHealth = 100;

            wizard.AttackEnemy(dwarf1);

            dwarf1.RestoreHealth();

            Assert.AreEqual(expectedHealth, dwarf1.CurrentHealth());
        }
    }


}