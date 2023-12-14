using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Trees
    {
        public string Name;
        public int fruitCost;
        public int Age;

        public Trees(string name, int seedPrice)
        {
            Name = name;
            this.fruitCost = seedPrice*2;
           
        }

        

    }
}
