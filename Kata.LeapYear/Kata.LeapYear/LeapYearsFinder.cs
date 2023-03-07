
using Kata.LeapYear.Extensions;
using System;

namespace Kata.LeapYear
{
    public class LeapYearsFinder
    {
        public LeapYearsFinder(int year)
        {
            Year = year;
        }

        public int Year { get; }

        public static LeapYearsFinder Create(int year)
        {
            return new LeapYearsFinder(year);
        }

        public bool IsLeapYear()
        {
            return Year.IsYearDivisibleBy400() || Year.IsYearDivisibleBy4AndNot100();
        }
    }
}
