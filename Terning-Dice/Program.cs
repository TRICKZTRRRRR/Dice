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

            while (true) 
            {
                int dice = number.Next(1, 7);

                Console.Clear();
                if (dice == 1)
                {
                    Console.WriteLine("You hit 1");
                }
                else if (dice == 2)
                {
                    Console.WriteLine("You hit 2");
                }
                else if (dice == 3)
                {
                    Console.WriteLine("You hit 3");
                }
                else if (dice == 4)
                {
                    Console.WriteLine("You hit 4");
                }
                else if (dice == 5)
                {
                    Console.WriteLine("You hit 5");
                }
                else
                {
                    Console.WriteLine("You hit 6");
                }
                Console.ReadLine();
            }
        }
    }
}
