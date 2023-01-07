using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class BashkarasFormulaTest
{
    [Theory]
    [InlineData(10.0, 20.1, 5.1, "R1 = -0.29788\r\nR2 = -1.71212")]
    public void CallAreaMethod_ShowCapitalAEqualAreaOfCircle(double number1,double number2, double number3, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader($"{number1} {number2} {number3}");
        Console.SetIn(stringReader);

        BhaskarasFormula.Calculate();

        var result = stringWriter.GetStringBuilder().ToString().Trim().Replace(",", ".");
        Assert.Equal(expectedResult, result);
    }
}