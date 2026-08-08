namespace CSharpWarmup.Tests;

public class LargestNumTest
{
    [Fact]
    public void LargerNum_ShouldReturnLargerNum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act
        string result = LargestNum.CompareNum(num1, num2);

        // Assert
        Assert.Equal($"{num2} is larger than {num1}", result);
    }
    [Theory]
    [InlineData(20,10,"20 is larger than 10")]
    [InlineData(-5, 5, "5 is larger than -5")]
    [InlineData(0,-1, "0 is larger than -1")]
    [InlineData(10, 10 , "Both numbers are equal")]
    public void LargerNum_ShouldReturnCorrectResult(int num1, int num2, string expected)
    {
        // Act
        string result = LargestNum.CompareNum(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
}
