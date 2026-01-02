using System.Globalization;

namespace FizzBuzzSrc;

public class FizzBuzz
{
    /// <summary>
    /// Utility for producing FizzBuzz output for a number.
    /// </summary>
    public string Convert(int number)
    {
        return (number % 3 == 0, number % 5 == 0) switch
        {
            (true, true) => "FizzBuzz",
            (true, false) => "Fizz",
            (false, true) => "Buzz",
            _ => number.ToString(CultureInfo.InvariantCulture)
        };
    }
}