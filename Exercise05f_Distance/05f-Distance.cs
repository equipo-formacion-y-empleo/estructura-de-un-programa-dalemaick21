using System.Globalization;

float DistanceBetweenPoints(float x1, float y1, float x2, float y2)
{
    float dx = x2 - x1;
    float dy = y2 - y1;
    return (float)Math.Sqrt(dx * dx + dy * dy);

}

float x1 = float.Parse(args.Length > 0 ? args[0] : "0.0",CultureInfo.InvariantCulture);
float y1 = float.Parse(args.Length > 1 ? args[1] : "0.0",CultureInfo.InvariantCulture);
float x2 = float.Parse(args.Length > 2 ? args[2] : "3.0",CultureInfo.InvariantCulture);
float y2 = float.Parse(args.Length > 3 ? args[3] : "4.0",CultureInfo.InvariantCulture);


float distance = DistanceBetweenPoints(x1, y1, x2, y2);


Console.WriteLine($"Distance: {DistanceBetweenPoints(x1, y1, x2, y2)}");