using System;

namespace Kata.FizzBuzz.Models
{
    public class Result
    {
        public string Value { get; set; }

        public Result()
        {
            Value = string.Empty;
        }

        public static Result Create()
        {
            return new Result();
        }

        public void Add(string valueToAdd)
        {
            Value = Value + valueToAdd;
        }
    }
}