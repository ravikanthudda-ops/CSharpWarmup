using System.Reflection;
using Xunit;
namespace CSharpWamup.Tests;

public class HelloWorldTests
{
    [Fact]
    public void Main_PRintsHelloWorld()
    {
        // Act
        var result = HelloWorld.GetMessage();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
}
