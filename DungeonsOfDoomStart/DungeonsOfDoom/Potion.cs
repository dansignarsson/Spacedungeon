using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Potion : DefenseItem
    {
        public Potion(string name, int defensePoints) : base(name, defensePoints)
        {

        }

        public override void PickUp(Character characterToPick)
        {
            characterToPick.Health += 10; 
        }
    }
}
