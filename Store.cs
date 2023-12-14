using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Store
    {
        List<Item> Inventory;
        List<Tool> Tools;

        public Store()
        {
            Inventory = new List<Item>();
            Tools = new List<Tool>();            
                Inventory.Add(new Seeds("Peach", 2));
                Inventory.Add(new Seeds("Apple", 1));
                Inventory.Add(new Seeds("Pears", 5));
                Inventory.Add(new Seeds("Coconut", 10));
            Inventory.Add(new Seeds("Golden Apple", 50));
        }




        public void ShowStore(Player player)
        {
            
            foreach(Seeds seed in this.Inventory)
            {
                Console.WriteLine($"{seed.Name} seed, price: ${seed.Cost}");
            }
            Console.WriteLine($"You have ${player.Gold}");
            Console.WriteLine("Choose a number to buy the corresponding fruit:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 - Apple");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2 - Coconut");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("3 - Peach");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4 - Pear");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("5 - Golden Apple");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("0 - Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    
                    case 0:
                        Console.WriteLine("Goodbye!");
                        return;
                    case 1:
                        if(player.Gold >= 1)
                        {

                            player.Inventory.Add(new Seeds("Apple" , 1));
                            player.Gold = player.Gold - 1;
                            Console.WriteLine("You Bought an Apple Seed.");
                            
                        }
                        
                        break;
                    case 2:
                        if (player.Gold >= 10)
                        {
                            player.Inventory.Add(new Seeds("Coconut" , 10));
                            player.Gold = player.Gold - 10;
                            Console.WriteLine("You chose Bought an Coconut Seed.");
                           
                        }
                       
                        break;
                    case 3:
                        if (player.Gold >= 2)
                        {
                            player.Inventory.Add(new Seeds("Peach" , 2));
                            player.Gold = player.Gold - 2;
                            Console.WriteLine("You chose Bought an Peach Seed.");
                            
                        }
                        
                        break;
                    case 4:
                        if (player.Gold >= 5)
                        {
                            player.Inventory.Add(new Seeds("Pear", 5));
                            player.Gold = player.Gold - 5;
                            Console.WriteLine("You chose Bought an Pear Seed.");
                          
                        }
                        break;
                    case 5:
                        if (player.Gold >= 50)
                        {
                            player.Inventory.Add(new Seeds("Golden Apple", 50));
                            player.Gold = player.Gold - 5;
                            Console.Clear();
                            Console.WriteLine("\r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\nYYYYYYY       YYYYYYY     OOOOOOOOO     UUUUUUUU     UUUUUUUU     WWWWWWWW                           WWWWWWWWIIIIIIIIIINNNNNNNN        NNNNNNNN !!!  !!!  !!!  !!!  !!!  !!! \r\nY:::::Y       Y:::::Y   OO:::::::::OO   U::::::U     U::::::U     W::::::W                           W::::::WI::::::::IN:::::::N       N::::::N!!:!!!!:!!!!:!!!!:!!!!:!!!!:!!\r\nY:::::Y       Y:::::Y OO:::::::::::::OO U::::::U     U::::::U     W::::::W                           W::::::WI::::::::IN::::::::N      N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\nY::::::Y     Y::::::YO:::::::OOO:::::::OUU:::::U     U:::::UU     W::::::W                           W::::::WII::::::IIN:::::::::N     N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\nYYY:::::Y   Y:::::YYYO::::::O   O::::::O U:::::U     U:::::U       W:::::W           WWWWW           W:::::W   I::::I  N::::::::::N    N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n   Y:::::Y Y:::::Y   O:::::O     O:::::O U:::::D     D:::::U        W:::::W         W:::::W         W:::::W    I::::I  N:::::::::::N   N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n    Y:::::Y:::::Y    O:::::O     O:::::O U:::::D     D:::::U         W:::::W       W:::::::W       W:::::W     I::::I  N:::::::N::::N  N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n     Y:::::::::Y     O:::::O     O:::::O U:::::D     D:::::U          W:::::W     W:::::::::W     W:::::W      I::::I  N::::::N N::::N N::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n      Y:::::::Y      O:::::O     O:::::O U:::::D     D:::::U           W:::::W   W:::::W:::::W   W:::::W       I::::I  N::::::N  N::::N:::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n       Y:::::Y       O:::::O     O:::::O U:::::D     D:::::U            W:::::W W:::::W W:::::W W:::::W        I::::I  N::::::N   N:::::::::::N!:::!!:::!!:::!!:::!!:::!!:::!\r\n       Y:::::Y       O:::::O     O:::::O U:::::D     D:::::U             W:::::W:::::W   W:::::W:::::W         I::::I  N::::::N    N::::::::::N!!:!!!!:!!!!:!!!!:!!!!:!!!!:!!\r\n       Y:::::Y       O::::::O   O::::::O U::::::U   U::::::U              W:::::::::W     W:::::::::W          I::::I  N::::::N     N:::::::::N !!!  !!!  !!!  !!!  !!!  !!! \r\n       Y:::::Y       O:::::::OOO:::::::O U:::::::UUU:::::::U               W:::::::W       W:::::::W         II::::::IIN::::::N      N::::::::N                              \r\n    YYYY:::::YYYY     OO:::::::::::::OO   UU:::::::::::::UU                 W:::::W         W:::::W          I::::::::IN::::::N       N:::::::N !!!  !!!  !!!  !!!  !!!  !!! \r\n    Y:::::::::::Y       OO:::::::::OO       UU:::::::::UU                    W:::W           W:::W           I::::::::IN::::::N        N::::::N!!:!!!!:!!!!:!!!!:!!!!:!!!!:!!\r\n    YYYYYYYYYYYYY         OOOOOOOOO           UUUUUUUUU                       WWW             WWW            IIIIIIIIIINNNNNNNN         NNNNNNN !!!  !!!  !!!  !!!  !!!  !!! \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n                                                                                                                                                                             \r\n");
                            Console.WriteLine($"\n\nYou were able to get the seed of the golden tree and you were able to prove that the whole myth was true and that it did have that functionality. Good job {player.Name} see you next time.");
                            Console.WriteLine("\n\nPress Enter to Exit");

                            Console.ReadLine();

                            Environment.Exit(0);
                        }
                        
                        break;
                       
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
       
            Console.ReadLine();

        }



    }


}
