using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class OffenseItem : Item
    {
        public OffenseItem(string name, int attackPoints) : base(name, attackPoints)
        {

        }
    }
}
