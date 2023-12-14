using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Player
    {
        public string Name;
        public int Gold;
        public List<Seeds> Inventory;
        List<Tool> Tools;
        public Farm Farm;

        public Player(string name) { 
            Name = name;
            Inventory = new List<Seeds>();
            Tools = new List<Tool>();
            Gold = 0;
            Farm= new Farm();
        }


        public void PlantTree()
        {
            Console.WriteLine("You ventured today to the tree farm in order to plant a new tree, Let's hope you didn't forget them at home");
            if (Inventory.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, Inventory.Count);
                this.Farm.Seeds.Add(Inventory[randomIndex]);

                Console.WriteLine($"You planted a {Inventory[randomIndex].Name} seed");
                Inventory.Remove(Inventory[randomIndex]);
            }
            else
            {
                Console.WriteLine("You don't have enough seeds");
            }

        }

        public void showInventory()
        {
            foreach (Seeds seed in Inventory)
            {
                Console.WriteLine($"{seed.Name} seed");
            }
            Console.ReadLine();
        }




    }


}
