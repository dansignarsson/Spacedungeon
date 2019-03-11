using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items.OffenseItems
{
    public class Sword : OffenseItem
    {/// <summary>
    /// I'm a sword
    /// </summary>
    /// <param name="name"></param>
    /// <param name="attackPoints"></param>
        public Sword(string name, int attackPoints) : base(name, attackPoints)
        {
            
           
        }
       
        public override void PickUp(Character monsterAttack)
        {
            

            monsterAttack.Health -= 5;
        }

    }
}
