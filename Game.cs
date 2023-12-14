using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{

    internal class Game
    {

        private string GameTitle = "Tree Simulator";
        private string GameArt = @"
        ,----,                                                                                                                                     
      ,/   .`|                                                                                                                                     
    ,`   .'  :                                                                ____                 ,--,                  ___                       
  ;    ;     /                                               ,--,           ,'  , `.             ,--.'|                ,--.'|_                     
.'___,/    ,' __  ,-.                                      ,--.'|        ,-+-,.' _ |        ,--, |  | :                |  | :,'   ,---.    __  ,-. 
|    :     |,' ,'/ /|                            .--.--.   |  |,      ,-+-. ;   , ||      ,'_ /| :  : '                :  : ' :  '   ,'\ ,' ,'/ /| 
;    |.';  ;'  | |' | ,---.     ,---.           /  /    '  `--'_     ,--.'|'   |  || .--. |  | : |  ' |     ,--.--.  .;__,'  /  /   /   |'  | |' | 
`----'  |  ||  |   ,'/     \   /     \         |  :  /`./  ,' ,'|   |   |  ,', |  |,'_ /| :  . | '  | |    /       \ |  |   |  .   ; ,. :|  |   ,' 
    '   :  ;'  :  / /    /  | /    /  |        |  :  ;_    '  | |   |   | /  | |--'|  ' | |  . . |  | :   .--.  .-. |:__,'| :  '   | |: :'  :  /   
    |   |  '|  | ' .    ' / |.    ' / |         \  \    `. |  | :   |   : |  | ,   |  | ' |  | | '  : |__  \__\/: . .  '  : |__'   | .; :|  | '    
    '   :  |;  : | '   ;   /|'   ;   /|          `----.   \'  : |__ |   : |  |/    :  | : ;  ; | |  | '.'| ,"" .--.; |  |  | '.'|   :    |;  : |    
    ;   |.' |  , ; '   |  / |'   |  / |         /  /`--'  /|  | '.'||   | |`-'     '  :  `--'   \;  :    ;/  /  ,.  |  ;  :    ;\   \  / |  , ;    
    '---'    ---'  |   :    ||   :    |        '--'.     / ;  :    ;|   ;/         :  ,      .-./|  ,   /;  :   .'   \ |  ,   /  `----'   ---'     
                    \   \  /  \   \  /           `--'---'  |  ,   / '---'           `--`----'     ---`-' |  ,     .-./  ---`-'                     
                     `----'    `----'                       ---`-'                                        `--`---'                                 
                                                                                                                                                   
";

        public int day;
        public Store store;
        public bool isAllowedToPlant = true;



        public Game()
        {

            day = 1;
            store = new Store();
        }

        public void Play()

        {
           
           
            Console.WriteLine(GameArt);
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Welcome to Tree Simulator"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Prees ENTER to start..."));
            Console.ReadLine();
            Console.Clear();
          
            Console.WriteLine("Please, to begin enter your name:");
            Player player = new Player(name: Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Welcome {player.Name}\n\nIn this adventure you will need to find your way to the golden apple that you can only buy from the mysterious vendor \nBut first you will need to earn some money, thankfully your family left you a tree farm, so why do you go and plant the seeds in front of you so you can grow a tree and later sell some fruit. \nYou will have to be careful since there are many thieves in the area and they will be interfering with your harvest. \nYou will have to collect the gold and use it in the store to buy other types of seeds and earn more money.");
            Console.WriteLine("\nPress Enter to plant a Apple Tree.");
            player.Inventory.Add(new Seeds("apple", 1));
            Console.ReadLine();
            player.PlantTree();
            Console.WriteLine("Congrats! You planted your first tree");
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            DisplayMenu(player);
           



            



        }

        public void DisplayMenu(Player player)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear(); 
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Show Inventory");
                Console.WriteLine("2. Show Farm");
                Console.WriteLine("3. Go to Market");
                Console.WriteLine("4. Pass the Day");
                Console.WriteLine("5. Plant tree");
                Console.WriteLine("6. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You selected: Show Inventory \n\n 'Here you would see all the seeds that you have in your posetion'");
                            player.showInventory();
                            break;
                        case 2:
                            Console.WriteLine("You selected: Show Farm \n\n 'Here you would see all the Tree's and seed that you already planted'");
                            player.Farm.showFarm();
                            break;
                        case 3: 
                            Console.WriteLine("You selected: Go to Market \n\n'Welcome to the seed store, here you can buy different types of seeds'");
                            store.ShowStore(player);
                            break;
                        case 4:
                            Console.WriteLine("You selected: Pass the Day\n\n'Spending daylight will help your seeds grow and your trees generate fruit but be careful as unexpected things can happen '");
                            PassDay(player);
                            break;
                        case 5:
                            Console.WriteLine("You selected: Plant tree\n\n'You can plant a seed from your inventory but it will be random \n\n(You can only plant one tree per day.)'");
                            if (isAllowedToPlant == true) player.PlantTree();
                            else
                            {
                                Console.WriteLine("You already went back home and it's dark outside, it's better to go tomorrow morning");
                            }
                            isAllowedToPlant = false;
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.Write("Press Enter to continue...");
                Console.ReadLine(); 
            }

            Console.WriteLine("Goodbye!");
        }


        public void PassDay(Player player)
        {
            this.day++;
            Random random = new Random();
            int randomIndex = random.Next(0, 10);
            if(randomIndex == 2)
            {
                if(player.Gold > 1) 
                { 
                int GoldStolen = random.Next(1, player.Gold);
                Console.WriteLine($"While you were on your way home, a group of thieves robbed you. You got robbed ${GoldStolen}!");
                player.Gold = player.Gold - GoldStolen;
}
            }
            else if(randomIndex == 10)
            {
                if(player.Farm.Trees.Count > 0)
                {
                    int TreeRemoved = random.Next(0, player.Farm.Trees.Count);
                    Console.WriteLine($"Some thief has destroyed {player.Farm.Trees[TreeRemoved].Name} of your farm");
                    player.Farm.Trees.Remove(player.Farm.Trees[TreeRemoved]);
                }

                
            }


            foreach (Seeds seed in player.Farm.Seeds.ToList())
            {
                seed.Age++;
                if(seed.Age >= 2)
                {
                    player.Farm.Trees.Add(new Trees(name: $"{seed.Name} Tree", seed.Cost));
                    player.Farm.Seeds.Remove(seed);
                    Console.WriteLine($"Your {seed.Name} seed grew into a {seed.Name} Tree!");
                }
            }
            foreach (Trees tree in player.Farm.Trees.ToList())
            {
                tree.Age++;
                if (tree.Age % 2 == 0)
                {
                    player.Gold = player.Gold + tree.fruitCost;
                    Console.WriteLine($"You sold fruit and got ${tree.fruitCost}");
                }
            }

            isAllowedToPlant = true;
            Console.WriteLine($"Day: {day}");
            Console.ReadLine();
            
        }

    }
}
