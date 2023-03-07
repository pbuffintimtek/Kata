using Kata.DictonaryReplacer.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.DictonaryReplacer.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DictonaryReplacerWithOneKey()
        {
            var stringToReplace = "$temp$";
            var keyReplaceDictionnary = new Dictionary<string, string>
            {
                { "temp", "temporary" }
            };

            var stringReplaced = Replacer.Create().Replace(stringToReplace, keyReplaceDictionnary);

            Assert.That(stringReplaced, Is.EqualTo("temporary"));
        }
        
        [Test]
        public void DictonaryReplacerWithTwoKey()
        {
            var stringToReplace = "$temp$ here comes the name $name$";
            var keyReplaceDictionnary = new Dictionary<string, string>
            {
                { "temp", "temporary" },
                { "name", "John Doe" }
            };

            var stringReplaced = Replacer.Create().Replace(stringToReplace, keyReplaceDictionnary);

            Assert.That(stringReplaced, Is.EqualTo("temporary here comes the name John Doe"));
        }
    }
}