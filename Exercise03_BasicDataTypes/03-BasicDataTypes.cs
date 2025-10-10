using System;

class Program
{
    static void Main()
    {
        DemoBasicDataTypes();
        ShowDataTypeSizes();
    }

  static  void DemoBasicDataTypes()
    {
      
        int numeroEntero = 42;
        double numeroDecimal = 3.14159;
        char letra = 'A';
        bool esVerdadero = true;
        string mensaje = "Hola, C#";

        Console.WriteLine("=== Demostración de Tipos Básicos ===");
        Console.WriteLine($"Entero: {numeroEntero} (Tipo: {numeroEntero.GetType()})");
        Console.WriteLine($"Decimal: {numeroDecimal} (Tipo: {numeroDecimal.GetType()})");
        Console.WriteLine($"Carácter: {letra} (Tipo: {letra.GetType()})");
        Console.WriteLine($"Booleano: {esVerdadero} (Tipo: {esVerdadero.GetType()})");
        Console.WriteLine($"Cadena: {mensaje} (Tipo: {mensaje.GetType()})");
        Console.WriteLine();
    }

 static void ShowDataTypeSizes()
    {
        Console.WriteLine("=== Tamaños de Tipos de Datos ===");
        Console.WriteLine($"byte: {sizeof(byte)} byte");
        Console.WriteLine($"short: {sizeof(short)} bytes");
        Console.WriteLine($"int: {sizeof(int)} bytes");
        Console.WriteLine($"long: {sizeof(long)} bytes");
        Console.WriteLine($"float: {sizeof(float)} bytes");
        Console.WriteLine($"double: {sizeof(double)} bytes");
        Console.WriteLine($"char: {sizeof(char)} bytes");
        Console.WriteLine($"bool: {sizeof(bool)} byte (puede variar en memoria real)");
        Console.WriteLine();
    }
}
