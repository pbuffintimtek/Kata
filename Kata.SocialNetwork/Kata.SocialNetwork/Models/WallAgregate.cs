using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.SocialNetwork.Models
{
    public class WallAgregate
    {
        public List<Author> User { get; set; }

        public WallAgregate()
        {
            User = new List<Author>();
        }
    }
}
