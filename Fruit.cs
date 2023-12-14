using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Fruit : Item
    {
        public string Name;
        public int Cost;

        public Fruit(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
