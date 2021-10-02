using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    /// <summary>
    /// Clase correspondiente al personaje Elfo.
    /// </summary>
    public class Elf : Hero
    {
        /// <summary>
        /// Constructor de la clase Elf, recibe por parámetro el nombre del elfo, además se le asignan valores 
        /// a los tres atributos de la case y se inicializa la lista de elementos pertenecientes al personaje.
        /// </summary>
        /// <param name="name"></param>
        public Elf (string name)
        {
            this.name = name;
            this.victoryPointsCounter = 0;
            this.health = 100;
            this.attack = 35;
            this.armor = 5;
            this.inventory = new List<Item>();
        }
    }
}