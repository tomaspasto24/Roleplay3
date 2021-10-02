using System;

namespace Library
{
    public class Axe : Item
    {
        public Axe(string name)
        {
            this.name = name;
            this.armor = 0;
            this.damage = 20;
        }
    }
}