using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class SimpleSumTest
{
    [Theory]
    [InlineData(30, 10, "SOMA = 40")]
    [InlineData(-30, 10, "SOMA = -20")]
    [InlineData(0, 0, "SOMA = 0")]
    public void CallSumMethod_ShowCapitalSomaEqualSumOfTwoInputNumber(int number1, int number2, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader(number1 + Environment.NewLine + number2);
        Console.SetIn(stringReader);

        SimpleSum.CalculateSum();

        var result = stringWriter.GetStringBuilder().ToString().Trim();
        Assert.Equal(expectedResult, result);
    }
}