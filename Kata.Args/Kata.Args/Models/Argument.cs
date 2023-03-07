using System;

namespace Kata.Args.Models
{
    public abstract class Argument
    {
        public string Flag { get; set; }
        public Argument(string flag)
        {
            Flag = flag;
        }

        public abstract void SetPresent(string value);
    }
}