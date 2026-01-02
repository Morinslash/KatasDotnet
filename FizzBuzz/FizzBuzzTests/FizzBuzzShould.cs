using FizzBuzzSrc;

namespace FizzBuzzTests;

public class FizzBuzzShould
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void Return_Correct_Value_For_Number(int input, string expected)
    {
        var fizzBuzz = new FizzBuzz();
        string result = fizzBuzz.Convert(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    public void Return_Fizz_For_Multiples_Of_Three(int input, string expected)
    {
        var fizzBuzz = new FizzBuzz();
        string result = fizzBuzz.Convert(input);
        Assert.Equal(expected, result);
    }
}