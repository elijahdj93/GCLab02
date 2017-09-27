using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {
                int num;
                Console.WriteLine("Enter a number between 1 and 100:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    Console.WriteLine(num + " Odd");
                }
                else
                {


                    if (num <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (num >= 26 && num <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine(num + " Even");

                    }
                }
                string userChoice;
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();
                if (userChoice == "n" || userChoice == "N")
                {
                    keepGoing = false;
                }

            }
        }
    }
}
