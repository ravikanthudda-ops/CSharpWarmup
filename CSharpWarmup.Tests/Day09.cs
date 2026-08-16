namespace CSharpWarmup.Tests;

public class Day09
{
    public void CountDigitInNumber_ShouldReturnDigitCount()
    {
        // Arrange
        int number = 578923;
        
        // Act
        int result = CountDigitInNumber.DigitCount(number);

        // Assert
        Assert.Equal(6, result);
    }
    [Theory]
    [InlineData(123,3)]
    [InlineData(5323,4)]
    [InlineData(0,1)]
    [InlineData(-1,1)]
    [InlineData(-435,3)]
    public void CountDigitInNumber_ShouldReturnCorrectResult(int num, int expected)
    {
        // Act
        int result = CountDigitInNumber.DigitCount(num);

        //Assert
        Assert.Equal(expected, result);
    }
}
