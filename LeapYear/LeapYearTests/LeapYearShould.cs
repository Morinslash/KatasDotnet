namespace LeapYearTests;

public class LeapYearShould
{
    // first minimal unit test according to ../README.md
    // assert on the simplest case
    [Fact]
    public void ReturnTrueForYear2020()
    {
        var leapYear = new LeapYearSrc.LeapYear();
        bool result = leapYear.IsLeapYear(2020);
        Assert.True(result);
    }
}