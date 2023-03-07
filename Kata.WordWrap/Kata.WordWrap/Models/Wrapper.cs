using System;

namespace Kata.WordWrap.Models
{
    public class Wrapper
    {
        public static string Wrap(string text, int number)
        {
            var words = text.Split(' ');
            var line = "";
            var result = "";
            foreach (var word in words)
            {
                if (line.Length + word.Length > number)
                {
                    result += line + "\n";
                    line = word;
                }
                else
                {
                    line += " " + word;
                }           
            }
            result += line;
            return result.Trim();
        }
    }
}
