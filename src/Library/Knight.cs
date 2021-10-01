using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Creacion de la clase Knight, que contiene 3 atributos para sus estadisticas, 1 para el nombre y 1 lista que representa su
    /// inventario.
    /// </summary>
    public class Knight : ICharacter
    {
        private int health;
        private int attack {get; set;}
        private int armor {get; set;}
        private string name {get;}
        private List<Item> inventory {get; set;}
        
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
        /// Constructor de la clase Knight
        /// </summary>
        /// <param name="name">Nombre del Knight creado</param>
        public Knight(string name)
        {
            this.name = name;
            this.health = 100;
            this.attack = 25;
            this.armor = 35;
            this.inventory = new List<Item> {};
        }

        /// <summary>
        /// Método con el que se ataca al enemigo (objeto de tipo ICharacter) que recibe por parámetro.
        /// </summary>
        /// <param name="enemyToAtack"></param>
        public void AttackEnemy(ICharacter wizard)
        {
            Console.WriteLine($"Se ataca a {wizard.ReturnName()}.");
            wizard.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {wizard.ReturnName()}");
        }

        /// <summary>
        /// Metodo para equipar un item pasado por parametro, que a su vez incrementa el ataque y defensa del Knight (dependiendo del item que sea).
        /// </summary>
        /// <param name="item">Item a equipar</param>
        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }

        /// <summary>
        /// Metodo para desequipar un item que pasemos por parametro, a su vez se decrementan las estadisticas correspondientes del Knight.
        /// </summary>
        /// <param name="item">Item a desequipar</param>
        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }
        
        /// <summary>
        /// Devuelve la armadura del Knight.
        /// </summary>
        /// <returns></returns>
        public int ReturnArmor()
        {
            return this.armor;
        }

        /// <summary>
        /// Devuelve el ataque del Knight.
        /// </summary>
        /// <returns></returns>
        public int ReturnAttack()
        {
            return this.attack;
        }

        /// <summary>
        /// Devuelve el nombre del Knight.
        /// </summary>
        /// <returns></returns>
        public string ReturnName()
        {
            return this.name;
        }

        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }

        /// <summary>
        /// Devuelve la vida actual del Knight.
        /// </summary>
        /// <returns></returns>
        public int CurrentHealth()
        {
            return this.health;
        }

        /// <summary>
        /// Metodo para calcular el daño recibido por el ataque del enemigo.
        /// </summary>
        /// <param name="damage"></param>
        public void RecieveDamage(int damage)
        {
            this.health = this.health - damage;
        }
        
        /// <summary>
        /// Restaura al 100% la vida del Knight.
        /// </summary>
        /// <returns></returns>
        public void RestoreHealth()
        {
            this.health = 100;
        }
    }
}