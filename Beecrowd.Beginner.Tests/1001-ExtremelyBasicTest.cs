using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class ExtremelyBasicTest
{
    [Theory]
    [InlineData(10, 9, "X = 19")]
    [InlineData(-10, 4, "X = -6")]
    [InlineData(15, -7, "X = 8")]
    public void CallSumMethod_ShowCapitalXEqualSumOfTwoInputNumber(int number1, int number2, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader(number1 + Environment.NewLine + number2);
        Console.SetIn(stringReader);

        ExtremelyBasic.Sum();

        var result = stringWriter.GetStringBuilder().ToString().Trim();
        Assert.Equal(expectedResult, result);
    }
}