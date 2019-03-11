using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.DefenseItems
{
    public class Potion : DefenseItem
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
