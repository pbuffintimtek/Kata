using NUnit.Framework;
using System;

namespace Kata.LeapYear.Test
{
    public class LeapYearTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_2000_is_leap_year_as_it_divisible_by_400()
        {
           var isLeap = LeapYearsFinder.Create(2000).IsLeapYear();

            Assert.That(isLeap, Is.EqualTo(true));
        }

        [Test]
        public void Should_1992_is_leap_year_as_it_divisible_by_4_and_not_by_100()
        {
            var isLeap = LeapYearsFinder.Create(1992).IsLeapYear();

            Assert.That(isLeap, Is.EqualTo(true));
        }
    }
}