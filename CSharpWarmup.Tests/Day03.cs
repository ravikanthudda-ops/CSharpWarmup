using Xunit;
namespace CSharpWarmup.Tests;

public class AddNumberTests
{
    [Fact]
    public void Addition_ShouldReturnSumOfTwoNumbers()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act
        int result = AddNumber.Addition(num1, num2);

        // Assert
        Assert.Equal(30, result);
    }
    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(0, 10 , 10)]
    [InlineData(-10, 20, 10)]
    [InlineData(-10, -20, -30)]
    [InlineData(100, -50, 50)]
    public void Addition_ShouldReturnCorrectResult(
        int num1,
        int num2,
        int expected
    )
    {
        // Act
        int result = AddNumber.Addition(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
}
