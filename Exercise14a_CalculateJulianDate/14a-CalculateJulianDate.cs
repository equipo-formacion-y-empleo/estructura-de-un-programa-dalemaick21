using System;
using Microsoft.VisualBasic;

double CalculateJulianDate(int day, int month, int year)
{
    if (month <= 2)
    {

        year -= 1;
        month += 12;

    }

    int A = year / 100;
    int B = 2 - A + A / 4;


    double julianDate = Math.Floor(365.25 * (year + 4716))
                      + Math.Floor(30.6001 * (month + 1))
                    + day + B - 1524.5;


    return julianDate;

}


// Obtener argumentos de línea de comandos
int day = args.Length > 0 ? int.Parse(args[0]) : 1;
int month = args.Length > 1 ? int.Parse(args[1]) : 1;
int year = args.Length > 2 ? int.Parse(args[2]) : 2000;

    // Calcular fecha juliana
  double JulianDate = CalculateJulianDate(day, month, year);

Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
Console.WriteLine($"Fecha juliana:{Math.Round(JulianDate)}");