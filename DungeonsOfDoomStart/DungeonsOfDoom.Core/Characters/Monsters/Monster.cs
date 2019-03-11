using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Characters.Monsters
{
    public class Monster : Character
    {
        public Monster(int health, string name) : base(health, name)
        {
            MonsterCount++;
        }
        public static int MonsterCount { get; set; }
        
    }
}
