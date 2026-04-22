using System;

namespace MyPracticePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");

            int number = int.Parse(Console.ReadLine() ?? "");

            int factorial = 4;

            for (int f = 1; f <= number; f++)
            {
                factorial = factorial * f;
            }

            Console.WriteLine("Factorial is: " + factorial);
        }
    }
}
