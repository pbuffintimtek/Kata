using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RomanNumerals.Models
{
    public class RomanNumeralParser
    {
        public static RomanNumeralParser Create()
        {
            return new RomanNumeralParser();
        }

        public string ToRoman(int number)
        {
            var result = "";
            var unity = GetPlace(number, Place.Unity);
            result += GetRomanTranslation(unity, new RomanNumberUnity());

            if (number >= 10)
                result = GetRomanTranslation(GetPlace(number, Place.Ten),new RomanNumberTen()) + result;

            if(number >= 100)
                result = GetRomanTranslation(GetPlace(number, Place.Hundred),new RomanNumberHundred()) + result;
           
            return result;
        }
    
        private string GetRomanTranslation(int unity, RomanNumberBase romanNumber)
        {
            var result = "";

            if (unity == 9)
            {
                return romanNumber.GetNine();
            }

            if (unity >= 5)
            {
                result += romanNumber.GetFive();
            }

            var remainder = unity % 5;

            if (remainder == 4)
            {
                return romanNumber.GetFour();
            }
            else
            {
                for (int i = 1; i <= remainder; i++)
                {
                    result += romanNumber.GetUnity();
                }
            }

            return result;
        }

        private int GetPlace(int value, int place)
        {
            return ((value % (place * 10)) - (value % place)) / place;
        }
    }
}
