using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeapYear.Extensions
{
    public static class IntExtension
    {
        public static bool IsYearDivisibleBy400(this int value)
        {
            return value % 400 == 0;
        }  
        
        public static bool IsYearDivisibleBy4AndNot100(this int value)
        {
            return value % 4 == 0 && value % 100 != 0;
        }
    }
}
