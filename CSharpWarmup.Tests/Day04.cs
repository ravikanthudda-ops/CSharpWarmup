namespace CSharpWarmup.Tests;

public class EvenOddTest
{
    [Fact]
    public void EvenOrOdd_ShouldReturnEvenOrOdd()
    {
        // Arrange
        int num = 10;

        // Act
        string result = EvenOdd.EvenOrOdd(num);

        // Assert
        Assert.Equal("Even", result);
    }

    [Theory]
    [InlineData(0, "Even")]
    [InlineData(1, "Odd")]
    [InlineData(-1, "Odd")]
    [InlineData(-2, "Even")]
    [InlineData(-5, "Odd")]
    public void EvenOrOdd_ShouldReturnCorrectResult(int num, string expected)
    {
        // Act
        string result = EvenOdd.EvenOrOdd(num);

        // Assert
        Assert.Equal(expected, result);
    }
}
