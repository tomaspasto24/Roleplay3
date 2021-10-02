using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : Hero
    {
        public SpellBook spellBook {get; private set;}
        public Wizard(string name, SpellBook book)
        {
            this.name = $"Mago {name}";
            this.health = 50;
            this.attack = 25;
            this.armor = 35;
            this.victoryPointsCounter = 0;
            this.inventory = new List<Item> {};
            this.spellBook = book;
        }
        
        public void HealAlly(Wizard characterAlly)
        {
            characterAlly.health += 10;
        }
        public void HealAlly(Elf characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Knight characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Dwarf characterAlly)
        {
            characterAlly.Health += 10;
        }
    }
}