namespace CSharpWarmup.Tests;

public class ReverseStringTests
{
    [Fact]
    public void ReversedString_ShouldReturnReversedString()
    {
        // Arrange
        string str = "Ravi";

        // Act
        string result = ReverseString.ReversedString(str);
        
        // Assert
        Assert.Equal("ivaR",result);
    }

    [Theory]
    [InlineData("As","sA")]
    [InlineData("Mohit","tihoM")]
    [InlineData("Ravikant","tnakivaR")]
    [InlineData("Gaurav Mittal","lattiM varuaG")]
    public void ReversedString_ShouldReturnCorrectResult(string input, string expected)
    {
        // Act
        string result = ReverseString.ReversedString(input);

        //Assert
        Assert.Equal(expected, result);
    }
}
