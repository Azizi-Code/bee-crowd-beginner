namespace Beecrowd.Beginner.Solutions;

public class Average1
{
    public static void CalculateAverage()
    {
        var number1 = Convert.ToDouble(Console.ReadLine());
        var number2 = Convert.ToDouble(Console.ReadLine());
        const double weightNumber1 = 3.5;
        const double weightNumber2 = 7.5;

        var average = (number1 * weightNumber1 + number2 * weightNumber2) / (weightNumber1 + weightNumber2);

        Console.WriteLine($"MEDIA = {average:0.00000}");
    }
}