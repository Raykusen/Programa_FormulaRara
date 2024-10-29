using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_FormulaRara
{
    class FormulaRara
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el coeficiente a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el coeficiente b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el coeficiente c:");
            double c = double.Parse(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                // Dos soluciones reales y diferentes
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las soluciones son: x1 = " + x1 + " y x2 = " + x2);
            }

            else if (discriminante == 0)
            {
                // Una solución real (raíz doble)
                double x = -b / (2 * a);
                Console.WriteLine("La solución es: x = " + x);
            }

            else
            {
                // No hay soluciones reales
                Console.WriteLine("No hay soluciones reales.");
            }

            Console.ReadLine();
        }
    }
}
