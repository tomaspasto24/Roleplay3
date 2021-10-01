using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    /// <summary>
    /// Clase correspondiente al personaje Elfo.
    /// </summary>
    public class Elf : ICharacter
    {
        private string name {get; set;}
        private int health;
        private int attack {get; set;}
        private int armor {get; set;}  
        private List<Item> inventory;

        /// <summary>
        /// Constructor de la clase Elf, recibe por parámetro el nombre del elfo, además se le asignan valores 
        /// a los tres atributos de la case y se inicializa la lista de elementos pertenecientes al personaje.
        /// </summary>
        /// <param name="name"></param>
        public Elf (string name)
        {
            this.name = name;
            this.health = 100;
            this.attack = 35;
            this.armor = 5;
            this.inventory = new List<Item>();
        }

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
        /// Método que recibe por parámetro en entero que corresponde al daño que recive el elfo
        /// y se le resta de su vida.
        /// </summary>
        /// <param name="damage"></param>        
        public void RecieveDamage(int damage)
        {
            this.health = this.health - damage;
        }

        /// <summary>
        /// Método con el que se ataca al enemigo (objeto de tipo ICharacter) que recibe por parámetro.
        /// </summary>
        /// <param name="enemyToAtack"></param>
        public void AttackEnemy(ICharacter enemyToAtack)
        {
            Console.WriteLine($"Se ataca a {enemyToAtack.ReturnName()}.");
            enemyToAtack.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {enemyToAtack.ReturnName()}");
        }

        /// <summary>
        /// Método para agregar un item (recibido por parámetro) a la lista inventario de la clase.
        /// También se aumenta el valor del ataque o de la defensa del elfo según cómo corresponda.
        /// </summary>
        /// <param name="item"></param>
        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }

        /// <summary>
        /// Método para quitar un item (recibido por parámetro) de la lista inventario de la clase.
        /// También se le disminuye el valor al ataque o a la defensa, según cómo corresponda.
        /// </summary>
        /// <param name="item"></param>
        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }
        
        /// <summary>
        /// Método para devolver el valor de la defensa del elfo.
        /// </summary>
        /// <returns></returns>
        public int ReturnArmor()
        {
            return this.armor;
        }

        /// <summary>
        /// Métpdp para acceder al nombre
        /// </summary>
        /// <returns></returns>
        public string ReturnName()
        {
            return this.name;
        }

        /// <summary>
        /// Método para devolver el valor del ataque del elfo. 
        /// </summary>
        /// <returns></returns>
        public int ReturnAttack()
        {
            return this.attack;
        }

        /// <summary>
        /// Método para devolver el la vida actual que tiene el elfo. 
        /// </summary>
        /// <returns></returns>
        public int CurrentHealth()
        {
            return this.health;
        }

        /// <summary>
        /// Método para que el elfo vuelva a tener el 100% de vida.
        /// </summary>
        public void RestoreHealth()
        {
            this.health = 100;
        }

        /// <summary>
        /// Método que devuelve el inventario 
        /// </summary>
        /// <returns></returns>
        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }
    }
}