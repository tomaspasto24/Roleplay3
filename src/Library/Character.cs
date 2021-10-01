using System;

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

        public void AttackEnemy(ICharacter characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.ReturnArmor()))} de vida a {characterEnemy.ReturnName()}");
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
