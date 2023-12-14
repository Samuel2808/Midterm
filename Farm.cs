using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Farm
    {
        public List<Trees> Trees;
        public List<Seeds> Seeds;
        public Farm()
        {
            Trees = new List<Trees>();
            Seeds = new List<Seeds>();
        }


        public void showFarm()
        {
            Console.WriteLine("Trees:");


            foreach (Trees tree in Trees)
            {
                Console.WriteLine(tree.Name);
            }
            Console.ReadLine();

            Console.WriteLine("Seeds:");
            foreach (Seeds seed in Seeds)
            {
                Console.WriteLine(seed.Name);
            }
            Console.ReadLine();
        }
    }
}
