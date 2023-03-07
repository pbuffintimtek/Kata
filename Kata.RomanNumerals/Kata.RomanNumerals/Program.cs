using Kata.RomanNumerals.Models;
using System;

namespace Kata.RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i=0; i<1000; i++) { 
            Console.WriteLine(RomanNumeralParser.Create().ToRoman(i));
            }

            Console.ReadLine();
        }
    }
}
