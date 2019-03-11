using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters.Monsters
{
    public class Skeleton : Monster
    {
        /// <summary>
        /// I'm a skeleton!
        /// </summary>
        /// <param name="health"></param>
        public Skeleton(int health) : base(health, "Skeleton")
        {

        }
          
        public override void Fight(Character characterToFight)
        {
            if (characterToFight.Health >= Health * 2)
            {
                characterToFight.Health = characterToFight.Health - 2;
            }
            else
            {
                characterToFight.Health = characterToFight.Health - 5;
            }


        }
    }
}
