using Kata.StringCalculator.Models;
using NUnit.Framework;

namespace Kata.StringCalculator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Add_2_Numbers()
        {
            var response = Calculator.Create().Add("5,3");

            Assert.That(response, Is.EqualTo("8"));
        }

        [Test]
        public void Should_Add_New_Line()
        {
            var response = Calculator.Create().Add("1\n5,3");

            Assert.That(response, Is.EqualTo("9"));
        }

        [Test]
        public void Should_Add_New_Line_In_Wrong_Place()
        {
            var response = Calculator.Create().Add("175.2,\n35");
            Assert.That(response, Is.EqualTo("Number expected but \n found at position 6."));
        }
        
        [Test]
        public void Should_Detect_Comma_In_Wrong_Place()
        {
            var response = Calculator.Create().Add("175.2\n,35");
            Assert.That(response, Is.EqualTo("Number expected but , found at position 6."));
        }

        [Test]
        public void Should_Detect_Missing_Number()
        {
            var response = Calculator.Create().Add("1,2,3,");
            Assert.That(response, Is.EqualTo("Number is missing"));
        }   
        
        [Test]
        public void Should_Change_Delimiter()
        {
            var response = Calculator.Create().Add("//|\n1|2|3");
            Assert.That(response, Is.EqualTo("6"));
        }  
        
        [Test]
        public void Should_Detecte_Negative_Number()
        {
            var response = Calculator.Create().Add("-1,2");
            Assert.That(response, Is.EqualTo("Negative not allowed -1"));
        }
    }
}