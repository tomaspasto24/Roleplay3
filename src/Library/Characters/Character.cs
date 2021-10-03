using System;
using System.Collections.Generic;

namespace Library
{
    public class Character
    {
        protected int health;
        protected int attack {get; set;}
        protected int armor {get; set;}
        protected string name {get; set;}
        protected List<Item> inventory {get; set;}

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
        /// Metodo para equipar un item pasado por parametro, que a su vez incrementa el ataque y defensa del character (dependiendo del item que sea).
        /// </summary>
        /// <param name="item">Item a equipar</param>
        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }

        /// <summary>
        /// Metodo para desequipar un item que pasemos por parametro, a su vez se decrementan las estadisticas correspondientes del character.
        /// </summary>
        /// <param name="item">Item a desequipar</param>
        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }
        public void AttackEnemy(Character characterEnemy)
        {
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }

        /// <summary>
        /// Retorna la armadura del character
        /// </summary>
        /// <returns></returns>
        public int ReturnArmor()
        {
            return this.armor;
        }
        /// <summary>
        /// Retorna el ataque del character
        /// </summary>
        /// <returns></returns>
        public int ReturnAttack()
        {
            return this.attack;
        }
        /// <summary>
        /// Retorna la vida actual del character
        /// </summary>
        /// <returns></returns>
        public int CurrentHealth()
        {
            return this.health;
        }
        /// <summary>
        /// Vuele a dejar en el estado inicial la vida del character.
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
