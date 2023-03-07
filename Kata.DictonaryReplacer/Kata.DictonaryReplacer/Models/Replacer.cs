using Kata.DictonaryReplacer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.DictonaryReplacer.Models
{
    public class Replacer
    {
        public static Replacer Create()
        {
            return new Replacer();
        }

        public string Replace(string stringToReplace, Dictionary<string, string> keyReplaceDictionnary)
        {
            foreach (var key in keyReplaceDictionnary)
            {
              stringToReplace =  stringToReplace.ReplaceWithKeyValue(key.Key, key.Value);
            }

            return stringToReplace;
        }
    }
}
