using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : ICharacter
    {
        private string name { get; set;}
        private int health { get; set; }
        public int Health
        {
            set
            {
                this.health = value;
            }
        }
        private int attack { get; set;} 
        private int armor { get; set;}
        private List<Item> inventory { get; set; }
        public SpellBook spellBook; 

        public Wizard(string name, SpellBook book)
        {
            this.name = $"Mago {name}";
            this.health = 50;
            this.attack = 25;
            this.armor = 35;
            this.inventory = new List<Item> {};
            this.spellBook = book;
        }
        
        /// <summary>
        /// Método con el que se ataca al enemigo (objeto de tipo ICharacter) que recibe por parámetro.
        /// </summary>
        /// <param name="enemyToAtack"></param>
        public void AttackEnemy(ICharacter characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }

        public void RecieveDamage(int damage)
        {
            this.health = this.health - (damage - (damage * (this.armor / 100)));
        }

        public void HealAlly(Wizard characterAlly)
        {
            characterAlly.health += 10;
        }
        public void HealAlly(Elf characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Knight characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Dwarf characterAlly)
        {
            characterAlly.Health += 10;
        }

        public void EquipItem(Item item)
        {
            bool agregado = false;
            ///Se recorre el inventario por si el item que se busca implementar ya se encuentra. En caso de que no se encuentre se agrega fuera del condicional.
            foreach(Item value in this.inventory)
            {
                if(value.ReturnName() == item.ReturnName())
                {
                    this.inventory.Remove(value);
                    this.inventory.Add(item);
                    /// se elimina el daño y armadura del objeto anterior
                    this.attack -= value.ReturnDamage();
                    this.armor -= value.ReturnArmor();
                    /// se agrega el daño y la armadura del objeto
                    this.attack = this.attack + item.ReturnDamage();
                    this.armor = this.armor + item.ReturnArmor(); 
                    agregado = true;
                }
            }
            if(!agregado)
            {
                this.inventory.Add(item);
                this.attack = this.attack + item.ReturnDamage();
                this.armor = this.armor + item.ReturnArmor(); 
            System.Console.WriteLine($"Objeto {item.ReturnName()} agregado correctamente.");
            }
        }

        public void ExchangeItem(Item item, Item itemToChange)
        {
            inventory.Remove(itemToChange);
            inventory.Add(item);
            System.Console.WriteLine($"Objeto {itemToChange.ReturnName()} cambiado correctamente por {item.ReturnName()}.");
        }

        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }

        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }
        
        public string ReturnName()
        {
            return this.name;
        }
        
        public int ReturnArmor()
        {
            return this.armor;
        }
        public int ReturnAttack()
        {
            return this.attack;
        }
        public int CurrentHealth()
        {
            return this.health;
        }
        public void RestoreHealth()
        {
            this.health = 100;
        }
    }
}