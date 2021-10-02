using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Creacion de la clase Knight, que contiene 3 atributos para sus estadisticas, 1 para el nombre y 1 lista que representa su
    /// inventario.
    /// </summary>
    public class Knight : Character
    {
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
    }
}