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
        public void IsYearDivisibleBy400()
        {
           var isLeap = LeapYearsFinder.Create(2000).IsLeapYear();

            Assert.That(isLeap, Is.EqualTo(true));
        }

        [Test]
        public void IsYearDivisibleBy4AndNotBy100()
        {
            var isLeap = LeapYearsFinder.Create(1992).IsLeapYear();

            Assert.That(isLeap, Is.EqualTo(true));
        }
    }
}