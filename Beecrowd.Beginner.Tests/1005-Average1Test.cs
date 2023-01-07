using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class Average1Test
{
    [Theory]
    [InlineData(5.0, 7.1, "MEDIA = 6.43182")]
    [InlineData(0.0, 7.1, "MEDIA = 4.84091")]
    [InlineData(10.0, 10.0, "MEDIA = 10.00000")]
    public void CallCalculateAverage_ShowCapitalMediaEqualAverageOfTwoInputNumber(double number1, double number2, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader(number1 + Environment.NewLine + number2);
        Console.SetIn(stringReader);

        Average1.CalculateAverage();

        var result = stringWriter.GetStringBuilder().ToString().Trim().Replace(",", ".");
        Assert.Equal(expectedResult, result);
    }
}