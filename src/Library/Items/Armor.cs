using System;

namespace Library
{
    public class Armor : Item
    {
        public Armor(string name)
        {
            this.name = name;
            this.armor = 80;
            this.damage = 20;
        }
    }
}