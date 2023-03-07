using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RomanNumerals.Models
{
    public class RomanNumberTen : RomanNumberBase
    {
        public const string TEN = "X";
        public const string FIFTY = "L";
        public const string HUNDRED = "C";
        public override string GetFive()
        {
            return FIFTY;
        }

        public override string GetFour()
        {
            return TEN + FIFTY;
        }

        public override string GetNine()
        {
            return TEN + HUNDRED;
        }

        public override string GetUnity()
        {
            return TEN;
        }
    }
}
