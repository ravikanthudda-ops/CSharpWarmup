namespace CSharpWarmup.Tests;

public class SumAndAvgTests
{
    [Fact]
    public void SumAndAvg_ShouldReturnPositiveResult()
    {
        //Arrange
        int[] number = {1,2,3,4,5};
        //Act
        double[] result = SumAndAvg.SumAndAvgResult(number);

        //Assert
        Assert.Equal(new double[]{15,3}, result);
    }
    [Theory]
    [InlineData(new double[]{15,3}, new int[]{1,2,3,4,5})]
    [InlineData(new double[]{42,8.4000000000000004}, new int[]{3,6,2,8,23})]
    [InlineData(new double[]{10,2}, new int[]{2,2,2,2,2})]
    [InlineData(new double[]{165,33}, new int[]{11,22,33,44,55})]
    [InlineData(new double[]{150,30}, new int[]{10,20,30,40,50})]
    public void SumAndAvg_ShouldReturnCorrectResult(double[] expected, int[] num)
    {
        //Act
        double[] result = SumAndAvg.SumAndAvgResult(num);

        //Assert
        Assert.Equal(expected, result);
    }
}
