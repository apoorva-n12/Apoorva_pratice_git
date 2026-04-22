using System;

namespace MyPracticePrograms
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            int factorial = 1;

            for (int f = 1; f <= number; f++)
            {
                factorial = factorial * f;
            }

            Console.WriteLine("Factorial is: " + factorial);
        }
    }
}
