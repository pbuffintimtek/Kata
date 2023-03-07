using Kata.Bowling.Models;
using Newtonsoft.Json.Linq;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Kata.Bowling.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Be_Scored_90()
        {
          var score = Line.Create()
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .AddScore(9)
                .AddScore(0)
                .TotalScore();

            Assert.That(score, Is.EqualTo(90));
        } 
        
        [Test]
        public void Should_Be_Scored_150()
        {
          var score = Line.Create()
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .AddScore(5)
                .TotalScore();

            Assert.That(score, Is.EqualTo(150));
        } 
        
        [Test]
        public void Should_Be_Scored_267()
        {
          var score = Line.Create()
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(9)
                .AddScore(0)
                .TotalScore();

            Assert.That(score, Is.EqualTo(267));
        }  
        
        [Test]
        public void Should_Be_Scored_300()
        {
          var score = Line.Create()
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(10)
                .AddScore(10)
                .AddScore(10) 
                .AddScore(10)
                .AddScore(10)
                .TotalScore();

            Assert.That(score, Is.EqualTo(300));
        }
    }
}