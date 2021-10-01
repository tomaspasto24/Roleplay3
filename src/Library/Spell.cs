using System;

namespace Library
{
    public class Spell
    {
        private string name;
        private string type;
        private int effect;

        public string Name 
        {
            get
            {
                return this.name;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
        }
        public int Effect
        {
            get
            {
                return this.effect;
            }
        }
        
        public Spell(string name, string type, int effect) 
        {
            this.name = name;
            this.type = type;
            this.effect = effect;
        }
    }
}