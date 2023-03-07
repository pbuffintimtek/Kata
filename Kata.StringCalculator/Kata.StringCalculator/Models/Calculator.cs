using System;


namespace Kata.StringCalculator.Models
{
    public class Calculator
    {
        public static Calculator Create()
        {
            return new Calculator();
        }

        public string Add(string number)
        {
            var delimiter = ",";
            if (number.StartsWith("//"))
            {
                delimiter = number.Substring(2, 1);
                number = number.Substring(4);
            }

            var response = CheckForSeparator(number, delimiter + "\n", "\n");

            if (!string.IsNullOrEmpty(response))
                return response;

            response = CheckForSeparator(number, "\n" + delimiter, delimiter);

            if (!string.IsNullOrEmpty(response))
                return response;

            var numbers = number.Split(new string[] { delimiter, "\n" }, StringSplitOptions.None);
            var total = 0;
            foreach (var num in numbers)
            {
                if (string.IsNullOrEmpty(num))
                    return "Number is missing";

                var interger = Int32.Parse(num);
                if(interger < 0)
                    return "Negative not allowed";

                total += interger;
            }

            return total.ToString();
        }

        private string CheckForSeparator(string number, string format, string errorChar)
        {
            var i = number.IndexOf(format);

            if (i >= 0)
            {
                return string.Format("Number expected but {0} found at position {1}.", errorChar, i + 1);
            }

            return string.Empty;
        }
    }
}
