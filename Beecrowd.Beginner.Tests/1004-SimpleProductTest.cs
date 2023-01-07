using Beecrowd.Beginner.Solutions;
using Xunit;

namespace Beecrowd.Beginner.Tests;

public class SimpleProductTest
{
    [Theory]
    [InlineData(3, 9, "PROD = 27")]
    [InlineData(-30, 10, "PROD = -300")]
    [InlineData(0, 0, "PROD = 0")]
    public void CallProductMethod_ShowCapitalProdEqualProductOfTwoInputNumber(int number1, int number2, string expectedResult)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        var stringReader = new StringReader(number1 + Environment.NewLine + number2);
        Console.SetIn(stringReader);

        SimpleProduct.CalculateProduct();

        var result = stringWriter.GetStringBuilder().ToString().Trim();
        Assert.Equal(expectedResult, result);
    }
}