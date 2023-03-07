using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Args.Models
{
    public class BooleanArgument : Argument
    {
        public BooleanArgument(string flag) : base(flag)
        {
            Value = false;
        }

        public bool Value { get; set; }

        public static BooleanArgument Create(string flag)
        {
            return new BooleanArgument(flag);
        }


        public override void SetPresent(string value)
        {
            Value = true;
        }
    }
}
