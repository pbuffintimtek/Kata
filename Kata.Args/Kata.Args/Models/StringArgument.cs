using Kata.Args.Exceptions;
using System;

namespace Kata.Args.Models
{
    public class StringArgument : Argument
    {
        public StringArgument(string flag) : base(flag)
        {
            Value = string.Empty;
        }

        public string Value { get; set; }

        public static StringArgument Create(string flag)
        {
            return new StringArgument(flag);
        }

        public override void SetPresent(string value)
        {
            if (value.Contains("-"))
            {
                throw new InvalidArgumentException();
            }
            else
            {
                Value = value;
            }
        }
    }
}