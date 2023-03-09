using Kata.GameOfLife.Models;
using NUnit.Framework;

namespace Kata.GameOfLife.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SouldIncrementGeneration()
        {
            var next = Game.Create().NextGeneration("Generation 1:\r\n4 8\r\n........\r\n....*...\r\n...**...\r\n........");
            Assert.IsTrue(next.Contains("Generation 2:"));
        } 
        
        [Test]
        public void SouldContainDimensionArray()
        {
            var next = Game.Create().NextGeneration("Generation 1:\r\n4 8\r\n........\r\n....*...\r\n...**...\r\n........");
            Assert.IsTrue(next.Contains("4 8"));
        } 
        
        [Test]
        public void SouldGenerateAliveCell()
        {
            var next = Game.Create().NextGeneration("Generation 1:\r\n4 8\r\n........\r\n....*...\r\n...**...\r\n........");

            Assert.That(next, Is.EqualTo("Generation 2:\r\n4 8\r\n........\r\n...**...\r\n...**...\r\n........"));
        }
    }
}