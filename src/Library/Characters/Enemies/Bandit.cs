using System;
using System.Collections.Generic;

namespace Library
{
    public class Bandit : Enemy
    {
        public Bandit(string name)
        {
            this.name = name;
            this.victoryPoints = 100;
            this.health = 100;
            this.attack = 20;
            this.armor = 15;
            this.inventory = new List<Item> {};
        }
    }
}