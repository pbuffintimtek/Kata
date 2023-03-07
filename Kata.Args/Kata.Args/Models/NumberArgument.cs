using Kata.Args.Exceptions;
using System;

namespace Kata.Args.Models
{
    public class NumberArgument : Argument
    {
        public NumberArgument(string flag) : base(flag)
        {
            Value = 0;
        }

        public double Value { get; set; }

        public static NumberArgument Create(string flags)
        {
            return new NumberArgument(flags);
        }

        public override void SetPresent(string value)
        {
            var success = Double.TryParse(value, out double number);
            if (success)
            {
                Value= number;
            }
            else
            {
                throw new InvalidArgumentException();
            }
        }
    }
}