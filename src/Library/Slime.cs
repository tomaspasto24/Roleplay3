using System;
using System.Collections.Generic;
namespace Library;
{
    public class Slime : Enemy
    {
        public Slime(string name)
        {
        this.victoryPoints = 30
        this.name = name;
        this.health = 100;
        this.armor = 40;
        this.attack = 15;
        this.inventory = new List<Item>();
        }
    }
}