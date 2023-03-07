using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RomanNumerals.Models
{
    public class RomanNumberUnity : RomanNumberBase
    {
        public const string ONE = "I";
        public const string FIVE = "V";
        public const string TEN = "X";

        public override string GetFive()
        {
            return FIVE;
        }

        public override string GetFour()
        {
           return ONE + FIVE;
        }

        public override string GetNine()
        {
            return ONE + TEN;
        }
    
        public override string GetUnity()
        {
            return ONE;
        }
    }
}
