using Kata.DictonaryReplacer.Models;
using System;
using System.Collections.Generic;

namespace Kata.DictonaryReplacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var replaced = Replacer.Create().Replace("$name$ a $status$ ce kata", new Dictionary<string, string>()
            {
                {"name", "Pierre Buffin" },
                {"status", "Réussit" }
            });
            Console.WriteLine(replaced);
            Console.ReadLine();
        }
    }
}
