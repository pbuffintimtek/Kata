using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kata.FizzBuzz.Extensions
{
    public static class IntExtension
    {
        public static bool IsDivisibleBy(this int value, int divider)
        {
            return value % divider == 0;
        }
    }
}
