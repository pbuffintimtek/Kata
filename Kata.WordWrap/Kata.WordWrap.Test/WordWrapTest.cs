using Kata.WordWrap.Models;
using NUnit.Framework;

namespace Kata.WordWrap.Test
{
    public class Tests
    {
        string text;
        string text2;
        [SetUp]
        public void Setup()
        {
            text = "La vie est belle, profitez-en !";
            text2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        }

        [Test]
        public void Should_Cut_Text_In_2_Parts()
        {
            var response = Wrapper.Wrap(text, 20);
            Assert.That(response, Is.EqualTo("La vie est belle,\nprofitez-en !"));

        } 
        
        [Test]
        public void Should_Cut_Text_In_5_Parts()
        {
            var response = Wrapper.Wrap(text2, 30);
            Assert.That(response, Is.EqualTo("Lorem ipsum dolor sit amet,\nconsectetur adipiscing elit,\nsed do eiusmod tempor\nincididunt ut labore et dolore\nmagna aliqua."));

        }
    }
}