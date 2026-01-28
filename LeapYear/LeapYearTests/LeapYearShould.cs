using LeapYearSrc;

namespace LeapYearTests;

public class LeapYearShould
{
    [Fact]
    public void Identify_1996_as_leap_year()
    {
        bool result = LeapYear.IsLeapYear(1996);
        Assert.True(result);
    }
}