using System;
using System.Globalization;



double CalculateTriangleArea(double side) => (Math.Sqrt(3) / 4) * side * side;

double CalculateSquareArea(double side) => side * side;

double CalculateHexagonArea(double side) => (3 * Math.Sqrt(3) / 2) * side * side;


// Obtener argumentos de línea de comandos
double side = double.Parse(args.Length > 0 ? args[0] : "5.0", CultureInfo.InvariantCulture);

// Calcular figuras
double triangleArea = CalculateTriangleArea(side);
double squareArea = CalculateSquareArea(side);
double hexagonArea = CalculateHexagonArea(side);

// Mostrar resultados
Console.WriteLine($"Triángulo Equilátero: área = {triangleArea:F2}");
Console.WriteLine($"Cuadrado: área = {squareArea:F2}");
Console.WriteLine($"Hexágono Regular: área = {hexagonArea:F2}");
