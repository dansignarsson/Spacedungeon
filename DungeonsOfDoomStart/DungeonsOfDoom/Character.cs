using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character : IPickUp
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public Character(int health,string name)
        {
            Name = name;
            Health = health;
        }

        virtual public void Fight(Character characterToFight)
        {

            characterToFight.Health -= 10;
        }
    }
}
