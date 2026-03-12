using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_cw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGuesser();
        }

        static void NumberGuesser()
        {
            Console.WriteLine("Try to hit a right number: ");
            int rand = new Random().Next(1, 100);
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("That's not a number! Try again: ");
                }
                else if (guess == rand)
                {
                    Console.WriteLine("You won! Congratulations!!!");
                    break;
                }
                else if (guess < rand)
                {
                    Console.WriteLine("Too low! Try again: ");
                }
                else
                {
                    Console.WriteLine("Too high! Try again: ");
                }
            }
        }
    }
}
