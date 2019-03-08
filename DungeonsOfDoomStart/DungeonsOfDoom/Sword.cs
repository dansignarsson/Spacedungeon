using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Sword : OffenseItem
    {
        public Sword(string name, int attackPoints) : base(name, attackPoints)
        {
            
           
        }
        public override void PickUp(Character monsterAttack)
        {
            monsterAttack.Health -= 5;
        }

    }
}
