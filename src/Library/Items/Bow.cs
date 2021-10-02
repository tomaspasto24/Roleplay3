using System;

namespace Library
{
    public class Bow : Item
    {
        public Bow(string name)
        {
            this.name = name;
            this.armor = 0;
            this.damage = 43;
        }
    }
}