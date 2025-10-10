
double celsius = double.Parse(args.Length > 0 ? args[0] : "25");

double ConvertTemperatures()
{
    return celsius * 9 / 5 + 32;
}

Console.WriteLine($"{ConvertTemperatures():F2}°F");