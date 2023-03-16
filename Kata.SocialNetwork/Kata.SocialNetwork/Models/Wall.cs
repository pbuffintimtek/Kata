using System;
using System.Collections.Generic;

namespace Kata.SocialNetwork.Models
{
    public class Wall
    {
        public List<string> Messages { get; }

        public Wall()
        {
            Messages = new List<string>();
        }

        public void AddMessage(string message)
        {
            Messages.Add(message);
        }
    }
}