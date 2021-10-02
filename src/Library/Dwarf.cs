using System;
using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Se crea la clase
    /// </summary>
    public class Dwarf : Character
    {
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
    }
}


