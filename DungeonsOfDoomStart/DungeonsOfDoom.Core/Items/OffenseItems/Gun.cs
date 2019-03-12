using DungeonsOfDoom.Core.Characters;
    using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.OffenseItems
{
    class Gun : OffenseItem
    {
        public Gun(string name, int attackPoints) : base(name, attackPoints)
        {


        }

        public override void PickUp(Character monsterAttack)
        {


            monsterAttack.Health -= 15;
        }
    }
}
