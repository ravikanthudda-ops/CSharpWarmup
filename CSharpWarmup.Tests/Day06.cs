namespace CSharpWarmup.Tests;

public class CalculatorTest
{
    [Fact]
    public void Addition_ShouldReturnAdditionOfTwoNum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        
        // Act
        int result = Calculator.Addition(num1, num2);
        
        // Assert
        Assert.Equal(30,result);
    }
    [Theory]
    [InlineData(4,5,9)]
    [InlineData(-1,5,4)]
    [InlineData(0,5,5)]
    [InlineData(0,-1,-1)]
    [InlineData(0,0,0)]
    public void Addition_ShouldReturnCorrectResult(int num1, int num2, int expected)
    {
        // Act
        int result = Calculator.Addition(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Subtraction_ShouldReturnSubtractionOfTwoNum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;
        
        // Act
        int result = Calculator.Subtraction(num1, num2);

        // Assert
        Assert.Equal(-10, result);
    }

    [Theory]
    [InlineData(4,5,-1)]
    [InlineData(-1,5,-6)]
    [InlineData(0,5,-5)]
    [InlineData(10,-1,11)]
    [InlineData(11,5,6)]
    [InlineData(10,10,0)]
    public void Subtraction_ShouldReturnCorrectResult(int num1, int num2, int expected)
    {
        // Act
        int result = Calculator.Subtraction(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Multiplication_ShouldReturnMultiplicationOfTwoNum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act
        int result = Calculator.Multiplication(num1, num2);

        // Assert
        Assert.Equal(200, result);
    }
    [Theory]
    [InlineData(4,5,20)]
    [InlineData(-1,5,-5)]
    [InlineData(0,5,0)]
    [InlineData(10,1,10)]
    [InlineData(11,5,55)]
    [InlineData(-2, -3, 6)]
    public void Multiplication_ShouldReturnCorrectResult(int num1, int num2, int expected)
    {
        // Act
        int result = Calculator.Multiplication(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Division_ShouldReturnDivisionOfTwoNum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act
        int result = Calculator.Division(num1, num2);

        // Assert
        Assert.Equal(5, result);
    }
    [Theory]
    [InlineData(55,5,11)]
    [InlineData(20,5,4)]
    [InlineData(10,5,2)]
    [InlineData(10,1,10)]
    [InlineData(5, 2, 2)]
    public void Division_ShouldReturnCorrectResult(int num1, int num2, int expected)
    {
        // Act
        int result = Calculator.Division(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Division_ByZero_ShouldThrowDivideByZeroException()
    {
        // Arrange
        int num1 = 10;
        int num2 = 0;

        // Act & Asser
        Assert.Throws<DivideByZeroException>(
            () => Calculator.Division(num1, num2)
        );
    }
}
