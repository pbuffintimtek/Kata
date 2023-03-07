using Kata.FizzBuzz.Models;
using NUnit.Framework;

namespace Kata.FizzBuzz.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Should_Be_1()
        {
            Assert.That(WholeNatural.Create(1).ToResult().Value, Is.EqualTo("1"));
        }
        [Test]
        public void Should_Be_Fizz()
        {
            Assert.That(WholeNatural.Create(6).ToResult().Value, Is.EqualTo("Fizz"));
        } 
        
        [Test]
        public void Should_Be_Buzz()
        {
            Assert.That(WholeNatural.Create(10).ToResult().Value, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Should_Be_FizzBuzz()
        {
            Assert.That(WholeNatural.Create(15).ToResult().Value, Is.EqualTo("FizzBuzz"));
        }
    }
}