using System;
using System.Collections.Generic;

namespace Library
{
    public class Troll : Enemy
    {
        public Troll(string name)
        {
        this.victoryPoints = 100;
        this.name = name;
        this.health = 100;
        this.armor = 40;
        this.attack = 15;
        this.inventory = new List<Item>();
        }
    }
}