using Kata.FizzBuzz.Models;
using System;

namespace Kata.FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var number = 1; number<101; number++) { 
                var result = WholeNatural.Create(number).ToResult();
                Console.WriteLine(result.Value);
            
            }

            Console.ReadLine();
        }
    }
}
