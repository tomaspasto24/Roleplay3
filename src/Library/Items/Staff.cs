using System;

namespace Library
{
    public class Staff : Item
    {
        public Staff(string name)
        {
            this.name = name;
            this.armor = 0;
            this.damage = 25;
        }
    }
}