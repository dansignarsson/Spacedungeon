using DungeonsOfDoom.Core.Characters;
using DungeonsOfDoom.Core.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core
{
    public class Room
    {
        //public Skeleton Skeleton { get; set; }
        //public Zombie Zombie { get; set; }
        //public Sword Sword { get; set; }
        //public Potion Potion { get; set; }
        public Character Monster { get; set; }
        public Item Item { get; set; }


    }
}
