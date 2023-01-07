namespace Beecrowd.Beginner.Solutions
{
    public class BhaskarasFormula
    {
        public static void Calculate()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            double a = Convert.ToDouble(inputs[0]);
            double b = Convert.ToDouble(inputs[1]);
            double c = Convert.ToDouble(inputs[2]);

            if (a == 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            double difference = (b * b) - (4 * a * c);
            if (difference < 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            double answer1 = (-b + Math.Sqrt(difference)) / (2 * a);
            double answer2 = (-b - Math.Sqrt(difference)) / (2 * a);

            Console.WriteLine($"R1 = {answer1:0.00000}");
            Console.WriteLine($"R2 = {answer2:0.00000}");

        }
    }
}
