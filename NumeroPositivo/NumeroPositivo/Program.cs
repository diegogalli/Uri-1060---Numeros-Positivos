using System;
using System.Globalization;

namespace NumeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            int cont = 0;
                if (a > 0.0)
            {
                cont = cont + 1;
            }
            if (b > 0.0)
            {
                cont = cont + 1;
            }
            if (c > 0.0)
            {
                cont = cont + 1;
            }
            if (d > 0.0)
            {
                cont = cont + 1;
            }
            if (e > 0.0)
            {
                cont = cont + 1;
            }
            if (f > 0.0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores positivos");
        }

    }
}
