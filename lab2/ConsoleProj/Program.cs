using System;

class Program
{
    static void Main(string[] args)
    {
        double x, y, z;

        if (TryParseInput("Введіть x: ", out x) &&
            TryParseInput("Введіть y: ", out y) &&
            TryParseInput("Введіть z: ", out z))
        {
            double s = CalculateS(x, y, z);
            Console.WriteLine($"Значення s: {s:F3}");
        }
        else
        {
            Console.WriteLine("Некоректний ввід параметрів.");
        }
    }

    static bool TryParseInput(string message, out double value)
    {
        Console.Write(message);
        return double.TryParse(Console.ReadLine(), out value);
    }

    static double CalculateS(double x, double y, double z)
    {
        double s = Math.Pow((3 + Math.Tan(x) - (y/2)), 1.0 / 3.0) / (Math.Pow(x, 2) + Math.Pow(z, 3) + 4);
        return s;
    }
}
