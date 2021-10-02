using System;
using System.Collections.Generic;

namespace Library
{
    public class Goblin : Enemy
    {
        public Goblin(string name)
        {
            this.name = name;
            this.victoryPoints = 55;
            this.health = 100;
            this.attack = 10;
            this.armor = 15;
            this.inventory = new List<Item> {};
        }
    }
}