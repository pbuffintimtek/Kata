using Kata.Args.Models;
using System;

namespace Kata.Args
{
    public class Program
    {
        static void Main(string[] args)
        {
            var parser = Parser.Create().Parse("-a -b -c -d 5 -e 6 -f 7 -g wxc -h qsd -i aze");

            parser.Arguments.ForEach(arg =>
            {
                if (arg.GetType() == typeof(BooleanArgument))
                {
                    var argument = (BooleanArgument)arg;
                    Console.WriteLine(string.Format("{0} a pour valeur {1}", argument.Flag, argument.Value));

                }
                else if (arg.GetType() == typeof(StringArgument))
                {
                    var argument = (StringArgument)arg;
                    Console.WriteLine(string.Format("{0} a pour valeur {1}", argument.Flag, argument.Value));

                }
                else if (arg.GetType() == typeof(NumberArgument))
                {
                    var argument = (NumberArgument)arg;
                    Console.WriteLine(string.Format("{0} a pour valeur {1}", argument.Flag, argument.Value));
                }
            });

            Console.ReadLine();
        }
    }
}
