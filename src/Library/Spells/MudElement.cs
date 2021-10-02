using System;

namespace Library
{
    public class MudElement : Spell
    {
        public MudElement(string name)
        {
            this.name = name;
            this.Type = "Mud";
            this.Effect = 40;
        }
    }
}