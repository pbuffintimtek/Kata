using Kata.Args.Exceptions;
using System.Collections.Generic;
using System.Linq;


namespace Kata.Args.Models
{
    public class Parser
    {
        public List<Argument> Arguments { get; set; }

        public Parser()
        {
            Arguments = new List<Argument>();
        }

        public static Parser Create()
        {
            var parser = new Parser();

            parser.Initialize();

            return parser;
        }

        private void Initialize()
        {
            this.AddBooleanArg("-a")
                 .AddBooleanArg("-b")
                 .AddBooleanArg("-c")
                 .AddNumberArg("-d")
                 .AddNumberArg("-e")
                 .AddNumberArg("-f")
                 .AddStringArg("-g")
                 .AddStringArg("-h")
                 .AddStringArg("-i");
        }

        private Parser AddStringArg(string arg)
        {
            Arguments.Add(StringArgument.Create(arg));
            return this;
        }

        private Parser AddNumberArg(string arg)
        {
            Arguments.Add(NumberArgument.Create(arg));
            return this;
        }

        private Parser AddBooleanArg(string arg)
        {
            Arguments.Add(BooleanArgument.Create(arg));
            return this;
        }

        public Parser Parse(string args)
        {
            var argCollection = args.Split(' ');
            var i = 0;
            while(i< argCollection.Length)
            {
                var argument = Arguments.FirstOrDefault(x=>x.Flag== argCollection[i]);
                if(argument == null)
                {
                    throw new InvalidArgumentException();
                }

                if(argument.GetType() == typeof(BooleanArgument)) {
                    argument.SetPresent("");
                    i++;
                }
                else
                {
                    argument.SetPresent(argCollection[i+1]);
                    i += 2;
                }
            }

            return this;
        }
    }
}
