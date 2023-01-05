using Xunit;

namespace Beecrowd.Beginner.Tests;

public class HelloWoldTest
{
    [Fact]
    public void PrintHelloWorld()
    {
        //Arrange
        const string expectedResult = "Hello World!";
        var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        Hello_World.PrintHelloWorld();

        //Assert
        var result = writer.GetStringBuilder();
        Assert.Equal(expectedResult, result.ToString().Trim());
    }
}