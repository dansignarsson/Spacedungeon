using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters.Monsters
{
    public class Zombie : Monster
    {/// <summary>
    /// I'm a Zombie
    /// </summary>
    /// <param name="health"></param>
        public Zombie(int health) : base(health, "Zombie")
        {
        }
    }
}
