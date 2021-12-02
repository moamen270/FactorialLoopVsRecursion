using System;
using System.Diagnostics;

namespace algorithm
{
    class Program
    {
        static long LoopFactorial(int number)
        {
            long result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }

        static long RecursionFactorial(int number)
        {
            if (number == 1) return 1;
            return number * RecursionFactorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number from 1 to 20: ");
            int number = int.Parse(Console.ReadLine());
            Stopwatch loop = new Stopwatch();
            loop.Start();
            long result = LoopFactorial(number);
            loop.Stop();

            Console.WriteLine("\tTime with Loop Factorial = " + loop.Elapsed + "\n result = " + result + "\n");

            Stopwatch Recursion = new Stopwatch();
            Recursion.Start();
            result = RecursionFactorial(number);
            Recursion.Stop();
            Console.WriteLine("\tTime with Recursion Factorial = " + Recursion.Elapsed + "\n result = " + result + "\n");


        }
    }
}
