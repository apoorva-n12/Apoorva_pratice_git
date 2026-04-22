using System;

namespace MyPracticePrograms
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            int fact = 1;

            for (int f = 1; f <= num; f++)
            {
                fact = fact * f;
            }

            Console.WriteLine("Factorial is: " + fact);
        }
    }
}
