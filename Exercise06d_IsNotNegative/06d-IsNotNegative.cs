bool IsNotNegative(int number)
{
    return number >= 0; // Compara la variable 'number', no NumberFormatInfo
}

int number = int.Parse(args.Length > 0 ? args[0] : "0");

Console.WriteLine($"¿Es {number} no negativo? {IsNotNegative(number)}");
