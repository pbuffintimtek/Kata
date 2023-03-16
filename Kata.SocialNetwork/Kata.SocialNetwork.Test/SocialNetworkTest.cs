using Kata.SocialNetwork.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Kata.SocialNetwork.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldPostMessage()
        {
            var thomas = Author.Create("Thomas");
            thomas.Post("a message");

            Assert.That(thomas.Name, Is.EqualTo("Thomas"));
            Assert.That(thomas.Wall.Messages.FirstOrDefault(), Is.EqualTo("a message"));
        }

        [Test]
        public void ShouldReadWall()
        {

            var alice = Author.Create("Alice");
            var thomas = Author.Create("Thomas");
            thomas.Post("a message");
            var message = alice.Read(thomas);

            Assert.That(message, Is.EqualTo(new List<string>()
            {
                "a message"
            }));
        }

        [Test]
        public void ShouldReadAllWall()
        {
            var alice = Author.Create("Alice");
            var thomas = Author.Create("Thomas");
            var charlie = Author.Create("Charlie");
            thomas.Post("a message");
            alice.Post("a message");

            charlie.Follow(alice);
            charlie.Follow(thomas);

            var timeLine = charlie.FollowedWall();

            CollectionAssert.AreEquivalent(timeLine.User, new List<Author>() { alice, thomas });
        }
    }
}