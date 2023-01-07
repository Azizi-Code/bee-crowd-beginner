namespace Beecrowd.Beginner.Solutions;

public class SimpleSum
{
    public static void CalculateSum()
    {
        var number1 = Convert.ToInt32(Console.ReadLine());
        var number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"SOMA = {number1 + number2}");
    }
}