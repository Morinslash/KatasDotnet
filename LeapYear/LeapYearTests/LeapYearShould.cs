using LeapYearSrc;

namespace LeapYearTests;

public class LeapYearShould
{
    [Theory]
    [InlineData(1996)]
    [InlineData(2004)]
    [InlineData(2008)]
    public void Identify_years_as_leap_year(int year)
    {
        bool result = LeapYear.IsLeapYear(year);
        Assert.True(result);
    }

    [Theory]
    [InlineData(1995)]
    [InlineData(1999)]
    [InlineData(2003)]
    public void Identify_years_as_common_year(int year)
    {
        bool result = LeapYear.IsLeapYear(year);
        Assert.False(result);
    }
}