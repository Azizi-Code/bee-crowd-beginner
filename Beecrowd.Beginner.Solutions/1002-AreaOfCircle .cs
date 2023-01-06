namespace Beecrowd.Beginner.Solutions;

public class AreaOfCircle
{
    public static void CalculateArea()
    {
        var p = 3.14159;
        var r = Convert.ToDouble(Console.ReadLine());
        var area = p * Math.Pow(r, 2);
        var result = $"{area:0.0000}";
        Console.WriteLine($"A={result}");
    }
}