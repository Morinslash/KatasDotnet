using FizzBuzzSrc;

namespace FizzBuzzTests;

public class FizzBuzzShould
{
    private readonly FizzBuzz _fizzBuzz;

    public FizzBuzzShould()
    {
        _fizzBuzz = new FizzBuzz();
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void Return_Correct_Value_For_Number(int input, string expected)
    {
        string result = _fizzBuzz.Convert(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    public void Return_Fizz_For_Multiples_Of_Three(int input, string expected)
    {
        string result = _fizzBuzz.Convert(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(20, "Buzz")]
    public void Return_Buzz_For_Multiples_Of_Five(int input, string expected)
    {
        string result = _fizzBuzz.Convert(input);
        Assert.Equal(expected, result);
    }
}