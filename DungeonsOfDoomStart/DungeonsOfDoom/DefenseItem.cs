using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class DefenseItem : Item
    {
        public DefenseItem(string name, int defensePoints): base(name, defensePoints)
        {
        }
    }
}
