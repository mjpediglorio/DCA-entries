using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask what coin will the use buy
            Coin();
            //Ask input for how many DCA entries
            DCAF();
            //Ask input for what are the entries
            Entries();
            Average();
            Profit();

            void Coin()
            {
                Console.WriteLine("What coin will you buy?");
                Declaration.Coin = Console.ReadLine();
                Console.Clear();
            }
            void DCAF()
            {
                Console.WriteLine($"How many entries would you DCA {Declaration.Coin}?");
                Declaration.DCA = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            void Entries()
            {
                Console.WriteLine($"You are willing to buy {Declaration.DCA} times!\n");
                int[] entries= new int[Declaration.DCA];

                for (int y=0; y < Declaration.DCA; y++)
                {
                    Console.WriteLine($"What would be your entry for {Declaration.Coin}?");
                    entries[y] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (int o = 0; Declaration.DCA > o; o++)
                {
                    Console.WriteLine($"You're willing to buy at prices {entries[o]}");
                }

                for (int p = 0; p < Declaration.DCA; p++)
                {
                    Declaration.result = Declaration.result + entries[p];
                }

                //Dollar Value
                Console.Clear();
                Console.WriteLine("How much money are you willing to put per entry?");
                Declaration.Dollars = int.Parse(Console.ReadLine());
                

                //Target
                Console.WriteLine($"What is your target price for {Declaration.Coin}?");
                Declaration.target = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            void Average()
            {
                Declaration.ave = Declaration.result / Declaration.DCA;
                Console.WriteLine($"Your average entry for {Declaration.Coin} is {Declaration.ave}");
                Console.WriteLine();

                //compute

                Declaration.value = Declaration.Dollars * Declaration.DCA;
                Declaration.value = Declaration.value / Declaration.ave;
                Console.WriteLine($"You will have {Declaration.value} {Declaration.Coin}!");
                Console.WriteLine();
            }

            void Profit()
            {
                Declaration.initial = Declaration.DCA * Declaration.Dollars;
                Declaration.profit = Declaration.value * Declaration.target;
                Declaration.profit = Declaration.profit - Declaration.initial;
                Console.WriteLine($"Your initial investment will be ${Declaration.initial}");
                Console.WriteLine();
                Console.WriteLine($"Your profit will be ${Declaration.profit} at your target price of {Declaration.target}");
                Console.ReadLine();
            }
        }
    }
}
