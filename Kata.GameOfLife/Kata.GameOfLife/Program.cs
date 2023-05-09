using Kata.GameOfLife.Models;
using System;

namespace Kata.GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nextGeneration = "Generation 1:\r\n4 8\r\n.*......\r\n..**....\r\n.**.....\r\n........";
            for (var i=0; i<100; i++) {
                Console.WriteLine(nextGeneration);
                nextGeneration = Game.Create().NextGeneration(nextGeneration);
                
            }
        }
    }
}
