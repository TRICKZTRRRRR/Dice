using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();

            Console.Title = "Dice";

            while (true) 
            {
                int dice = number.Next(1, 7);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                if (dice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You hit 1");
                }
                else if (dice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You hit 2");
                }
                else if (dice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You hit 3");
                }
                else if (dice == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You hit 4");
                }
                else if (dice == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You hit 5");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You hit 6");
                }
                Console.ReadLine();
            }
        }
    }
}
