using System;

namespace Library
{
    public class Spell
    {
        protected string name;
        protected string type;
        protected int effect;

        public string Name 
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            protected set
            {
                this.type = value;
            }
        }
        public int Effect
        {
            get
            {
                return this.effect;
            }
            protected set
            {
                this.effect = value;
            }
        }

        // Se comenta el constructor de Item para que no interfiera con las subclases.
        // public Spell(string name, string type, int effect) 
        // {
        //     this.name = name;
        //     this.type = type;
        //     this.effect = effect;
        // }
    }
}