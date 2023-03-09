using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.GameOfLife.Models
{
    public class Game
    {
        public const string Generation = "Generation ";

        public static Game Create()
        {
            return new Game();
        }

        public string NextGeneration(string data)
        {
            var result = "";
            var lines = data.Split(Environment.NewLine);

            var generationNumber = Int32.Parse(lines[0].Split(' ')[1].Replace(":", string.Empty)) + 1;
            result = Generation + generationNumber + ":" + Environment.NewLine;

            var width = Int32.Parse(lines[1].Split(" ")[1]);
            var height = Int32.Parse(lines[1].Split(" ")[0]);

            result += lines[1];


            var array = GetArray(lines.Skip(2).ToArray(), width, height);
            result = IncrementGeneration(array);

            return result;
        }

        private string IncrementGeneration(string[,] array)
        {
            var result = "";
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    var val = array[k, l];
                }
            }   
            
            return result;
        }

        private string[,] GetArray(string[] lines, int width, int height)
        {
            string[,] array = new string[height, width];

            for (var i = 0; i < lines.Length; i++)
            {
                for (var j = 0; j < lines[i].Length; j++)
                {
                    array[i, j] = lines[i][j].ToString();
                }
            }

            return array;
        }
    }
}
