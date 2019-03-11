using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters
{
    public abstract class Character : IPickUp
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
            
        /// <summary>
        /// I'll take 10 of your health
        /// </summary>
        /// <param name="characterToFight"></param>


            characterToFight.Health -= 10;
        }
    }
}
