using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Item : IPickUp
    {
        public string Name { get; set; }

        public int Impact { get; set; }

        public Item(string name, int impact)
        {
            Name = name;
            Impact = impact;
        }

        public virtual void PickUp(Character characterToPick)
        {
        }
    }
}
