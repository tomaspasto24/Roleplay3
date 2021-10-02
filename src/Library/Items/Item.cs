using System;

namespace Library
{
    public class Item
    {
        protected int damage {get; set;}
        protected string name {get; set;}
        protected int armor {get; set;}

        // Se comenta el constructor de Item para que no interfiera con las subclases.
        // public Item(string name, int damage, int armor)
        // {
        //     this.damage = damage;
        //     this.name = name;
        //     this.armor = armor;
        // }

        public int ReturnDamage()
        {
            return this.damage;
        }
        public int ReturnArmor()
        {
            return this.armor;
        }

        public string ReturnName()
        {
            return this.name;
        }
    }
}