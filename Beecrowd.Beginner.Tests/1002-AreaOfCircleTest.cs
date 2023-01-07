using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class AreaOfCircleTest
{
    [Theory]
    [InlineData(2.00, "A=12.5664")]
    [InlineData(100.64, "A=31819.3103")]
    [InlineData(150.00, "A=70685.7750")]
    public void CallAreaMethod_ShowCapitalAEqualAreaOfCircle(double number1, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader(number1.ToString());
        Console.SetIn(stringReader);

        AreaOfCircle.CalculateArea();

        var result = stringWriter.GetStringBuilder().ToString().Trim().Replace(",", ".");
        Assert.Equal(expectedResult, result);
    }
}