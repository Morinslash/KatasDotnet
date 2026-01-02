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
        string result = fizzBuzz.GetOutput(input);
        Assert.Equal(expected, result);
    }
}