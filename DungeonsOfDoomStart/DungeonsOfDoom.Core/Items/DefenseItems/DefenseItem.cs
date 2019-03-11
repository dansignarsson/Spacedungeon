using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.DefenseItems
{
    public abstract class DefenseItem : Item
    {
        public DefenseItem(string name, int defensePoints): base(name, defensePoints)
        {
        }
    }
}
