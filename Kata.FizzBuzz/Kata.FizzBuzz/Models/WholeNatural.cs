using Kata.FizzBuzz.Extensions;


namespace Kata.FizzBuzz.Models
{
    public class WholeNatural
    {
        private const int FizzDivider = 3;
        private const int BuzzDivider = 5;
        public WholeNatural(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public static WholeNatural Create(int value)
        {
            return new WholeNatural(value);
        }

        public Result ToResult()
        {
            var result = Result.Create();

            if (Value.IsDivisibleBy(FizzDivider))
                result.Add("Fizz");

            if (Value.IsDivisibleBy(BuzzDivider))
                result.Add("Buzz");

            if (!Value.IsDivisibleBy(FizzDivider) && !Value.IsDivisibleBy(BuzzDivider))
                result.Add(Value.ToString());

            return result;
        }
    }
}
