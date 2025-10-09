
double triangleBase = double.Parse(args.Length > 0 ? args[0] : "6,0");
double triangleHeight = double.Parse(args.Length > 1 ? args[1] : "4,0");


double CalculateTriangleArea()
{
    return (triangleBase * triangleHeight) / 2;
} 


Console.WriteLine($"Área del triángulo: {CalculateTriangleArea():F2}");
