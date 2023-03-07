using Kata.Args.Exceptions;
using Kata.Args.Models;
using NUnit.Framework;
using System.Linq;

namespace Kata.Args.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Initialize_Parser()
        {
            var parser = Parser.Create();

            var flag1 = parser.Arguments.FirstOrDefault(x => x.Flag == "-a");
            var flag2 = parser.Arguments.FirstOrDefault(x => x.Flag == "-b");
            var flag3 = parser.Arguments.FirstOrDefault(x => x.Flag == "-c");
            var flag4 = parser.Arguments.FirstOrDefault(x => x.Flag == "-d");
            var flag5 = parser.Arguments.FirstOrDefault(x => x.Flag == "-e");
            var flag6 = parser.Arguments.FirstOrDefault(x => x.Flag == "-f");
            var flag7 = parser.Arguments.FirstOrDefault(x => x.Flag == "-g");
            var flag8 = parser.Arguments.FirstOrDefault(x => x.Flag == "-h");
            var flag9 = parser.Arguments.FirstOrDefault(x => x.Flag == "-i");

            Assert.That(((BooleanArgument)flag1).Value, Is.EqualTo(false));
            Assert.That(((BooleanArgument)flag2).Value, Is.EqualTo(false));
            Assert.That(((BooleanArgument)flag3).Value, Is.EqualTo(false));
            Assert.That(((NumberArgument)flag4).Value, Is.EqualTo(0));
            Assert.That(((NumberArgument)flag5).Value, Is.EqualTo(0));
            Assert.That(((NumberArgument)flag6).Value, Is.EqualTo(0));
            Assert.That(((StringArgument)flag7).Value, Is.EqualTo(string.Empty));
            Assert.That(((StringArgument)flag8).Value, Is.EqualTo(string.Empty));
            Assert.That(((StringArgument)flag9).Value, Is.EqualTo(string.Empty));

            Assert.That(parser.Arguments.Count, Is.EqualTo(9));
        }
        
        [Test]
        public void Should_Parser_Parse_Boolean()
        {
            var parser = Parser.Create().Parse("-a");

            var flag = parser.Arguments.FirstOrDefault(x => x.Flag == "-a");
            
            Assert.That(((BooleanArgument)flag).Value, Is.EqualTo(true));
        } 
        
        [Test]
        public void Should_Parser_Parse_2_Boolean()
        {
            var parser = Parser.Create().Parse("-a -b");

            var flag1 = parser.Arguments.FirstOrDefault(x => x.Flag == "-a");
            var flag2 = parser.Arguments.FirstOrDefault(x => x.Flag == "-b");
            
            Assert.That(((BooleanArgument)flag1).Value, Is.EqualTo(true));
            Assert.That(((BooleanArgument)flag2).Value, Is.EqualTo(true));
        } 
        
        [Test]
        public void Should_Parser_Parse_Number()
        {
            var parser = Parser.Create().Parse("-d 5");

            var flag1 = parser.Arguments.FirstOrDefault(x => x.Flag == "-d");
         
            Assert.That(((NumberArgument)flag1).Value, Is.EqualTo(5));
        }
        [Test]
        public void Should_Parser_Not_Parse_Invalid_Argument()
        {
       
            Assert.Throws<InvalidArgumentException>(() =>
            {
                var parser = Parser.Create().Parse("-d aze");
            });
        } 
        
        [Test]
        public void Should_Parser_Not_Parse_Unknown_Argument()
        {
       
            Assert.Throws<InvalidArgumentException>(() =>
            {
                var parser = Parser.Create().Parse("-p aze");
            });
        }
        
        [Test]
        public void Should_Parser_Parse_All_Flags()
        {
            var parser = Parser.Create().Parse("-a -b -c -d 5 -e 6 -f 7 -g aze -h qsd -i wxc");

            var flag1 = parser.Arguments.FirstOrDefault(x => x.Flag == "-a");
            var flag2 = parser.Arguments.FirstOrDefault(x => x.Flag == "-b");
            var flag3 = parser.Arguments.FirstOrDefault(x => x.Flag == "-c");
            var flag4 = parser.Arguments.FirstOrDefault(x => x.Flag == "-d");
            var flag5 = parser.Arguments.FirstOrDefault(x => x.Flag == "-e");
            var flag6 = parser.Arguments.FirstOrDefault(x => x.Flag == "-f");
            var flag7 = parser.Arguments.FirstOrDefault(x => x.Flag == "-g");
            var flag8 = parser.Arguments.FirstOrDefault(x => x.Flag == "-h");
            var flag9 = parser.Arguments.FirstOrDefault(x => x.Flag == "-i");
         
            Assert.That(((BooleanArgument)flag1).Value, Is.EqualTo(true));
            Assert.That(((BooleanArgument)flag2).Value, Is.EqualTo(true));
            Assert.That(((BooleanArgument)flag3).Value, Is.EqualTo(true));
            Assert.That(((NumberArgument)flag4).Value, Is.EqualTo(5));
            Assert.That(((NumberArgument)flag5).Value, Is.EqualTo(6));
            Assert.That(((NumberArgument)flag6).Value, Is.EqualTo(7));
            Assert.That(((StringArgument)flag7).Value, Is.EqualTo("aze"));
            Assert.That(((StringArgument)flag8).Value, Is.EqualTo("qsd"));
            Assert.That(((StringArgument)flag9).Value, Is.EqualTo("wxc"));
        }
    }
}