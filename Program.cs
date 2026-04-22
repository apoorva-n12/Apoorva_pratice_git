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

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial is: " + fact);
        }
    }
}
