using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resume = true;
            string answer = "y";
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
            do
            {
                double length, width, hieght, area, perimeter, volume;

                Console.WriteLine("Enter Lenght: ");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hieght: ");
                hieght = double.Parse(Console.ReadLine());

                perimeter = (length + width) * 2;
                area = length * width;
                volume = length * width * hieght;

                Console.WriteLine($"Area: {Math.Round(area, 2)}");
                Console.WriteLine($"Perimeter: {Math.Round(perimeter, 2)}");
                Console.WriteLine($"Volume: {Math.Round(volume, 2)}");

                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine($"You have enetered {answer}\nPlease enter either (y/n)");
                    answer = Console.ReadLine().ToLower();
                }
                if (answer == "n")
                {
                    Console.WriteLine("Good Bye");
                    resume = false;
                }
            }
            while (resume);

            Console.ReadLine();



        }
    }
}
