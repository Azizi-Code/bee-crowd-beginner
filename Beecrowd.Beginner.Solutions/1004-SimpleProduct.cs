namespace Beecrowd.Beginner.Solutions;

public class SimpleProduct
{
    public static void CalculateProduct()
    {
        var number1 = Convert.ToInt32(Console.ReadLine());
        var number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"PROD = {number1 * number2}");
    }
}