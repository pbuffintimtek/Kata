using System;
using System.Linq;

namespace Kata.GameOfLife.Models
{
    public class Game
    {
        public const string Generation = "Generation ";
        public int X { get; set; }
        public int Y { get; set; }
        public static Game Create()
        {
            return new Game();
        }

        public string NextGeneration(string data)
        {
            var result = "";
            var lines = data.Split(Environment.NewLine);
            var generationNumber = Int32.Parse(lines[0].Replace("Generation", string.Empty).Replace(":", string.Empty));
            var dimensions = lines[1].Split(' ');
            Y = Int32.Parse(dimensions[0]);
            X = Int32.Parse(dimensions[1]);
            var generation = new string[Y, X];

            for (var i = 0; i < Y; i++)
            {
                for (var j = 0; j < lines[i + 2].Length; j++)
                {
                    if (lines[i + 2][j] == '*')
                    {
                        generation[i, j] = "*";
                    }
                    else
                    {
                        generation[i, j] = ".";
                    }
                }
            }

            var nextGeneration = CalculeNextGeneration(generation);

            result += $"Generation {generationNumber + 1}:\r\n";
            result += $"{Y} {X}\r\n";
            result += string.Join("\r\n", nextGeneration.OfType<string>()
    .Select((value, index) => new { value, index })
    .GroupBy(x => x.index / nextGeneration.GetLength(1))
    .Select(x => $"{string.Join("", x.Select(y => y.value))}"));

            return result;
        }

        private string[,] CalculeNextGeneration(string[,] generation)
        {
            var nextGeneration = new string[Y, X];

            for (var i = 0; i < Y; i++)
            {
                for (var j = 0; j < generation.GetLength(1); j++)
                {
                    var balance = 0;
                    for (var k = -1; k <= 1; k++)
                    {
                        for (var l = -1; l <= 1; l++)
                        {
                            if (i + k >= 0 && i + k < Y && j + l >= 0 && j + l < X && !(k==0 && l==0))
                            {
                                if (generation[i + k, j + l] == "*")
                                {
                                    balance++;
                                }
                            }
                        }
                    }

                    if (generation[i, j] == "*" && balance < 2)
                    {
                        nextGeneration[i, j] = ".";
                    }
                    else if (generation[i, j] == "*" && balance > 3)
                    {
                        nextGeneration[i, j] = ".";
                    }
                    else if(generation[i, j] == "*")
                    {
                        nextGeneration[i, j] = "*";
                    }

                    if (generation[i, j] == "." && balance == 3)
                    {
                        nextGeneration[i, j] = "*";
                    }
                    else if(generation[i, j] == ".")
                    {
                        nextGeneration[i,j] = ".";
                    }
                }
            }

            return nextGeneration;
        }
    }
}
