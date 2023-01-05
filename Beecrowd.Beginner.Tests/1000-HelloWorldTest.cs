using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class HelloWorldTest
{
    [Fact]
    public void PrintHelloWorld_ShowHelloWorldTextWithExclamationMarkAtTheEnd()
    {
        //Arrange
        const string expectedResult = "Hello World!";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        //Act
        HelloWorld.PrintHelloWorld();

        //Assert
        var output = stringWriter.GetStringBuilder();
        Assert.Equal(expectedResult, output.ToString().Trim());
    }
}