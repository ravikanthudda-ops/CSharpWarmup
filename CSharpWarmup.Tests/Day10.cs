namespace CSharpWarmup.Tests;

public class SumOfXNumTests
{
    [Fact]
    public void SumOfFirstXNumber_ShouldReturnSum()
    {
        //Arrange
        int number = 5;
        
        //Act
        double result = SumOfXNum.SumOfN(number);

        //Assert
        Assert.Equal(15, result);
    }
    [Theory]
    [InlineData(5,15)]
    [InlineData(0,0)]
    [InlineData(1,1)]
    [InlineData(2,3)]
    [InlineData(3,6)]
    [InlineData(10,55)]
    [InlineData(100,5050)]
    [InlineData(-1,-1)]
    [InlineData(-5,-15)]
    [InlineData(-10,-55)]
    [InlineData(int.MinValue,0)]
    public void SumOfFirstXNumber_ShouldReturnCorrectResult(int num, int expected)
    {
        //Act
        double result = num < 0 ? -SumOfXNum.SumOfN(num) : SumOfXNum.SumOfN(num);

        //Assert
        Assert.Equal(expected, result);
    }
}
