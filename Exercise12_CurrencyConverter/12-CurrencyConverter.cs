using System;
using System.Globalization; 

const double EUR_TO_USD = 1.09;
const double EUR_TO_JPY = 163.5;
const double EUR_TO_GBP = 0.86;



double ConvertToUSD(double euros) => euros * EUR_TO_USD;
double ConvertToJPY(double euros) => euros * EUR_TO_JPY;
double ConvertToGBP(double euros) => euros * EUR_TO_GBP;


double euros = double.Parse(args.Length > 0 ? args[0] : "100.0",CultureInfo.InvariantCulture);


// Convertir monedas
double usd = ConvertToUSD(euros);
double jpy = ConvertToJPY(euros);
double gbp = ConvertToGBP(euros);

// Mostrar resultados
Console.WriteLine($"€{euros:F2} = ${usd:F2} USD");
Console.WriteLine($"€{euros:F2} = ¥{jpy:F2} JPY");
Console.WriteLine($"€{euros:F2} = £{gbp:F2} GBP");