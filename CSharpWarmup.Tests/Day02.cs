using Xunit;
public class NameAndAgeTests
{
    [Fact]
    public void CreateGreeting_ShouldReturnNameAndAge()
    {
        // Arrange
        string name = "Ravi";
        string age = "39";

        // Act
        string result = NameAndAge.CreateGreeting(name, age);

        // Assert
        Assert.Equal("Hi, Ravi. You are 39 old", result);
    }
    [Theory]
    [InlineData("Ravi", "39", "Hi, Ravi. You are 39 old")]
    [InlineData("Rahul", "25", "Hi, Rahul. You are 25 old")]
    [InlineData("Amit", "30", "Hi, Amit. You are 30 old")]
    public void CreateGreeting_ShouldReturnCorrectMessage(
        string name,
        string age,
        string expected
    )
    {
        // Act
        string result = NameAndAge.CreateGreeting(name, age);

        // Assert
        Assert.Equal(expected, result);
    }
}