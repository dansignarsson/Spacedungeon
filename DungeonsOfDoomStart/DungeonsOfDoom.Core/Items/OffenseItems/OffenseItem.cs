using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.OffenseItems
{
    public abstract class OffenseItem : Item
    {
        public OffenseItem(string name, int attackPoints) : base(name, attackPoints)
        {

        }
    }
}
