using FizzBuzz;
using System;

namespace FizzBuzzConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var numbers = 100;

            for (var i = 1; i <= numbers; i++)
                Console.WriteLine($"{i}\t{Calculate.FizzBuzzBy(i)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}