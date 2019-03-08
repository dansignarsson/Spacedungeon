using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character, IPickUp
    {
        public Player(int health, int x, int y, List<IPickUp> backpack, string name) : base(health, name)
        {
            X = x;
            Y = y;
            Backpack = backpack;
        }

        

        public int X { get; set; }
        public int Y { get; set; }

        public List<IPickUp> Backpack { get; set; }

        //List<Item> Backpack = new List<Item>();

    }
}
