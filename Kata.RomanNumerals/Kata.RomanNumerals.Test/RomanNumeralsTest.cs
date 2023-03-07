using Kata.RomanNumerals.Models;
using NUnit.Framework;

namespace Kata.RomanNumerals.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sould_Transform_1_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(1);

            Assert.That(result, Is.EqualTo("I"));
        } 
        
        [Test]
        public void Sould_Transform_3_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(3);

            Assert.That(result, Is.EqualTo("III"));
        }
        [Test]
        public void Sould_Transform_4_To_Roman_Numerals()
        {
            var result = RomanNumeralParser.Create().ToRoman(4);

            Assert.That(result, Is.EqualTo("IV"));
        }
        [Test]
        public void Sould_Transform_5_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(5);

            Assert.That(result, Is.EqualTo("V"));
        }    
        
        [Test]
        public void Sould_Transform_8_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(8);

            Assert.That(result, Is.EqualTo("VIII"));
        }     
        
        [Test]
        public void Sould_Transform_9_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(9);

            Assert.That(result, Is.EqualTo("IX"));
        }    
        
        [Test]
        public void Sould_Transform_10_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(10);

            Assert.That(result, Is.EqualTo("X"));
        }     
        
        [Test]
        public void Sould_Transform_15_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(15);

            Assert.That(result, Is.EqualTo("XV"));
        }    
        
        [Test]
        public void Sould_Transform_20_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(20);

            Assert.That(result, Is.EqualTo("XX"));
        }   
        
        [Test]
        public void Sould_Transform_40_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(40);

            Assert.That(result, Is.EqualTo("XL"));
        }    
        
        [Test]
        public void Sould_Transform_50_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(50);

            Assert.That(result, Is.EqualTo("L"));
        }    
        
        [Test]
        public void Sould_Transform_90_To_Roman_Numerals()
        {
           var result = RomanNumeralParser.Create().ToRoman(90);

            Assert.That(result, Is.EqualTo("XC"));
        }      
    }
}