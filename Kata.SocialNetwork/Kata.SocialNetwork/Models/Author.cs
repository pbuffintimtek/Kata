using System;
using System.Collections.Generic;

namespace Kata.SocialNetwork.Models
{
    public class Author
    {
        public Author(string name)
        {
            Name = name;
            Wall = new Wall();
            Followed = new List<Author>();
        }

        public string Name { get; }
        public Wall Wall { get; }
        public ICollection<Author> Followed { get; private set; }

        public static Author Create(string name)
        {
            return new Author(name);
        }

        public void Follow(Author user)
        {
            Followed.Add(user);
        }

        public TimeLine FollowedWall()
        {
            var walls = new TimeLine();
            foreach (var item in Followed)
            {
                walls.User.Add(item);
            }

            return walls;
        }

        public void Post(string message)
        {
            Wall.AddMessage(message);
        }

        public List<string> Read(Author thomas)
        {
            return thomas.Wall.Messages;
        }
    }
}
