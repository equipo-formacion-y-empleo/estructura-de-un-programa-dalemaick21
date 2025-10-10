using System;
using System.Globalization;

bool ThirdBitActiveAndPositive(int number)
{
    return (number & 4) != 0 && number > 0;

}
// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 5;

// Probar la función
bool result = ThirdBitActiveAndPositive(number);

// Mostrar resultado
Console.WriteLine($"¿{number} tiene el tercer bit activo y es positivo? {result}");