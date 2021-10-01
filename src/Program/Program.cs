using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Elf elf1 = new Elf("Elf1");
            Elf elf2 = new Elf("Elf2");
            Item item1 = new Item("Fuego", 10, 0);
            Item item2 = new Item("Escudo", 10, 5);
            elf1.EquipItem(item1);
            elf1.EquipItem(item2);
            
            while (elf2.CurrentHealth()>0)
            {
                elf1.AttackEnemy(elf2);
                elf2.AttackEnemy(elf1);
            }

            /*Creacion de darkKnight y de los items sword y armor*/
            Knight darkKnight = new Knight("Dark Knight");
            Item sword = new Item("Sword", 15, 0);
            Item armor = new Item("Armor", 0, 20);

            /*Equipado de items a darkKnight*/
            darkKnight.EquipItem(sword);
            darkKnight.EquipItem(armor);

            /*Printeo de stats de darkKnight*/
            Console.WriteLine($"Stats de: {darkKnight.ReturnName()}: ");
            Console.WriteLine($"Attack: {darkKnight.ReturnAttack()}");
            Console.WriteLine($"Armor: {darkKnight.ReturnArmor()}");
            Console.WriteLine($"Health: {darkKnight.CurrentHealth()}");

            /*Creacion de defensor*/
            Knight defensor = new Knight("Defensor");

            /*Combate entre darkKnight y defensor*/
            while ((defensor.CurrentHealth() > 0) & (darkKnight.CurrentHealth() > 0))
            {
                darkKnight.AttackEnemy(defensor);
                Console.WriteLine($"Current health of {defensor.ReturnName()}: {defensor.CurrentHealth()}");
                defensor.AttackEnemy(darkKnight);
                Console.WriteLine($"Current health of {darkKnight.ReturnName()}: {darkKnight.CurrentHealth()}");
            }
            if (defensor.CurrentHealth() <= 0)
            {
                Console.WriteLine($"{darkKnight.ReturnName()} killed {defensor.ReturnName()}.");
            }
            else
            {
                Console.WriteLine($"{defensor.ReturnName()} killed {darkKnight.ReturnName()}.");         
            }

            /*Restauracion de la vida de darkKnight*/
            darkKnight.RestoreHealth();
            Console.WriteLine($"{darkKnight.ReturnName()}'s health has been restored.");

            SpellBook libro = new SpellBook("Libro de hechizos.");
            Wizard brujo = new Wizard("Brujo", libro);

            Item daga = new Item("Daga", 10, 40);
            brujo.EquipItem(daga);

            brujo.AttackEnemy(elf1);
        }
    }
}
