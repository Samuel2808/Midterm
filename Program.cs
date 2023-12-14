using System.Runtime.CompilerServices;
using static System.Console;

namespace Midterm
{
    internal class Program
{

        static void Main(string[] args)
        {

            Console.Title = "🅣🅡🅔🅔 ​ 🅢🅘🅜🅤🅛🅐🅣🅞🅡";



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Clear();

            


            Game currentgame = new Game();
            currentgame.Play();

            
        }
    }
}