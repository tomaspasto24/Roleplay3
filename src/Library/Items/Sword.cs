using System;

namespace Library
{
    public class Sword : Item
    {
        public Sword(string name)
        {
            this.name = name;
            this.armor = 0;
            this.damage = 50;
        }
    }
}