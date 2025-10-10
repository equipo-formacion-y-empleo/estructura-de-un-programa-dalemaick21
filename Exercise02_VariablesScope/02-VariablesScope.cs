using System;

class Program
{
    static double totalSurface = 0;

    static double CalculateRectangleAreas(double width, double height)
    {
        totalSurface += width * height;
        return totalSurface;
    }

    static void Main(string[] args)
    {
        double area1 = CalculateRectangleAreas(
            double.Parse(args.Length > 0 ? args[0] : "3"),
            double.Parse(args.Length > 1 ? args[1] : "4")
        );

        double area2 = CalculateRectangleAreas(
            double.Parse(args.Length > 2 ? args[2] : "5"),
            double.Parse(args.Length > 3 ? args[3] : "6")
        );

        Console.WriteLine($"Suma total de superficies: {totalSurface}");
    }
}
