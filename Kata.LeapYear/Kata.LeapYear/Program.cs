using System;

namespace Kata.LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1500; i < 2300; i++) {
                Console.WriteLine(string.Format("{0} - {1}",i,LeapYearsFinder.Create(i).IsLeapYear()) );
            }
           

            Console.ReadLine();
        }
    }
}
