using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RomanNumerals.Models
{
    public abstract class RomanNumberBase
    {
        public abstract string GetUnity();
        public abstract string GetFour();
        public abstract string GetFive();
        public abstract string GetNine();
    }
}
