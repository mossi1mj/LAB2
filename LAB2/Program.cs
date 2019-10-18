using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";

            while (answer == "y" || answer != "n")
            {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

                double length, width, area, perimeter;

                Console.WriteLine("Enter Lenght: ");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = double.Parse(Console.ReadLine());

                perimeter = (length + width) * 2;
                area = length * width;

                Console.WriteLine($"Area: {Math.Round(area, 2)}");
                Console.WriteLine($"Perimeter: {Math.Round(perimeter, 2)}");
                
                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine().ToLower();

                if (answer != "n")
                {
                    Console.WriteLine($"\nYou have entered {answer}\nPlease type either (y/n).\n");
                }
            }
            Console.ReadLine();



        }
    }
}
