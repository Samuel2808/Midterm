using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Seeds : Item
    {
        public string Name;
        public int Cost;
        public int Age;

        public Seeds(string name)
        {
            Name = name;
            Age = 0;
            Cost = 1;
        }

        public Seeds(string name, int cost)
        {
            Cost = cost;
            Age = 0;
            Name = name;
        }
        
    }
}
