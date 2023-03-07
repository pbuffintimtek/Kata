using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.DictonaryReplacer.Extensions
{
    public static class StringExtension
    {
        public static string ReplaceWithKeyValue(this string str, string key, string value)
        {
          return  str.Replace(string.Format("${0}$", key), value);
        }
    }
}
