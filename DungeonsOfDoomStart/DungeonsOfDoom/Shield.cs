using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Shield: DefenseItem
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
