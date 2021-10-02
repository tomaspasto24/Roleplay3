using System;

namespace Library
{
    public class Helmet : Item
    {
        public Helmet(string name)
        {
            this.name = name;
            this.armor = 50;
            this.damage = 0;
        }
    }
}