using System;

namespace Library
{
    public class WaterElement : Spell
    {
        public WaterElement(string name)
        {
            this.name = name;
            this.Type = "Water";
            this.Effect = 20;
        }
    }
}