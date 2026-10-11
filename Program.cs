using System;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("=== Average Grade System ===");
            Console.WriteLine();

            Console.WriteLine("Welcome to the A.G.S (Average Grade System)");
            Console.WriteLine();

            Console.WriteLine("To start, insert the first grade:");

            while (true)
            {
                double Grade1;

                while (!double.TryParse(Console.ReadLine(), out Grade1))
                {
                    Console.WriteLine("Invalid Number! Insert a number again.");
                }

                Console.WriteLine();
                Console.WriteLine("Insert the second grade:");

                double Grade2;

                while (!double.TryParse(Console.ReadLine(), out Grade2))
                {
                    Console.WriteLine("Invalid Number! Insert a number again.");
                }

                Console.WriteLine();
                Console.WriteLine("Insert the third grade:");

                double Grade3;

                while (!double.TryParse(Console.ReadLine(), out Grade3))
                {
                    Console.WriteLine("Invalid Number! Insert a number again.");
                }

                Console.WriteLine();
                Console.WriteLine("Insert the fourth grade:");

                double Grade4;

                while (!double.TryParse(Console.ReadLine(), out Grade4))
                {
                    Console.WriteLine("Invalid Number! Insert a number again.");
                }

                double FinalGrade = Grade1 + Grade2 + Grade3 + Grade4;
                double AverageGrade = FinalGrade / 4;

                if (AverageGrade < 5)
                {
                    string Status = "Failed";

                    Console.WriteLine();
                    Console.WriteLine($"Average Grade: {AverageGrade}. Status: {Status}");
                }

                else if ( AverageGrade < 6)
                {
                    string Status = "Retake";

                    Console.WriteLine();
                    Console.WriteLine($"Average Grade: {AverageGrade}. Status: {Status}");
                }
                else
                {
                    string Status = "Approved";

                    Console.WriteLine();
                    Console.WriteLine($"Average Grade: {AverageGrade}. Status: {Status}");
                }

                break;
            }
        }
    }
}