namespace CSharpWarmup.Tests;

public class LeapYearTest
{
    [Fact]
    public void IsLeapYear_ShouldReturnLeapYearOrNot()
    {
        // Arrange
        int year = 2000; // divisible by 400
        
        // Act        
        bool isLeapYear = LeapYear.IsLeapYear(year);

        // Assert
        Assert.True(isLeapYear);
    }

    [Theory]
    [InlineData(2001, false)] // not divisible by 4
    [InlineData(1900, false)] // divisible by 100 but not 400
    [InlineData(2004, true)] // divisible by 4
    [InlineData(1980, true)]
    [InlineData(2026, false)]
    [InlineData(1800, false)]
    public void IsLeapYear_ShouldReturnCorrectValue(int year, bool expected)
    {
        // Act
        bool isLeapYear = LeapYear.IsLeapYear(year);

        //Assert
        Assert.Equal(expected, isLeapYear);
    }
}
