using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.DefenseItems
{
    public class Shield: DefenseItem
    {
        public Shield(string name, int defensePoints) : base(name, defensePoints)
        {
        }

        public override void PickUp(Character characterToPick)
        {
            characterToPick.Health += 40; // Är du helt ifrån vettet?
        }
    }
}
