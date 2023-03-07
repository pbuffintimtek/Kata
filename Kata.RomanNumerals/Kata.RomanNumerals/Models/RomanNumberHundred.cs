using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RomanNumerals.Models
{
    public class RomanNumberHundred : RomanNumberBase
    {
        public const string HUNDRED = "C";
        public const string FOURHUNDRED = "CD";
        public const string FIVEHUNDRED = "D";
        public const string NINEHUNDRED = "CM";
        public const string THOUSAND = "M";

        public override string GetFive()
        {
            return FIVEHUNDRED;
        }

        public override string GetFour()
        {
            return HUNDRED + FIVEHUNDRED;
        }

        public override string GetNine()
        {
            return HUNDRED + THOUSAND;
        }

        public override string GetUnity()
        {
            return HUNDRED;
        }
    }
}
