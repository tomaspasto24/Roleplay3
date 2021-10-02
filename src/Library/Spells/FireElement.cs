using System;

namespace Library
{
    public class FireElement : Spell
    {
        public FireElement(string name)
        {
            this.name = name;
            this.Type = "Fire";
            this.Effect = 25;
        }
    }
}