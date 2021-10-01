using System;
using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Se crea la clase
    /// </summary>
    public class Dwarf : ICharacter
    {
        private int health; 
        private int armor { get; set; }
        private int attack { get; set; }
        private string name { get; }
        private List<Item> inventory;
        
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }
        /// <summary>
        /// Constructor de la clase del personaje "Dwarf"
        /// </summary>
        /// <param name="name"></param>
        public Dwarf(string name)
        {
            this.name = name;
            this.health = 100;
            this.armor = 40;
            this.attack = 15;
            this.inventory = new List<Item>();
        }
        /// <summary>
        /// Método con el que se ataca al enemigo (objeto de tipo ICharacter) que recibe por parámetro.
        /// </summary>
        /// <param name="enemyToAtack"></param>
        public void AttackEnemy(ICharacter characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.ReturnArmor()))} de vida a {characterEnemy.ReturnName()}");
        }

        /// <summary>
        /// //Se le suma al ataque el valor del daño que tiene el item.
        /// </summary>
        /// <param name="item"></param>
        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }
        /// <summary>
        /// Se le resta al ataque el valor del daño que tiene el item.
        /// </summary>
        /// <param name="item"></param>
        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }
        /// <summary>
        /// Retorna la armadura del Dwarf
        /// </summary>
        /// <returns></returns>
        public int ReturnArmor()
        {
            return this.armor;
        }
        /// <summary>
        /// Retorna el ataque del Dwarf
        /// </summary>
        /// <returns></returns>
        public int ReturnAttack()
        {
            return this.attack;
        }
        /// <summary>
        /// Retorna la vida actual del Dwarf
        /// </summary>
        /// <returns></returns>
        public int CurrentHealth()
        {
            return this.health;
        }
        /// <summary>
        /// Vuele a dejar en el estado inicial la vida del Dwarf.
        /// </summary>
        public void RestoreHealth()
        {
            this.health = 100;
        }
        
        public string ReturnName()
        {
            return this.name;
        }
        public void RecieveDamage(int damage)
        {
            this.health = this.health - damage;
        }
        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }
    }
}


