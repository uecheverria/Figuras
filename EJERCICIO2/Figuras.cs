using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO2
{
    internal class Figuras
    {
        double lado = 0;
        double radio = 0;
        double ancho = 0;
        double area = 0;

        internal void areaCuadrado() 
        {
            Console.Write("Introduce el valor del lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.Write("El área del cuadrado es: " + area + "\n\nPulsa cualquier tecla para continuar.");
            Console.ReadKey();
        }

        internal void areaCirculo()
        {
            Console.Write("Introduce el valor del radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.Write("El área del círculo es: " + area + "\n\nPulsa cualquier tecla para continuar.");
            Console.ReadKey();
        }

        internal void areaRectangulo()
        {
            Console.Write("Introduce el valor de la base del rectángulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el valor del lado del rectángulo: ");
            lado = Convert.ToDouble(Console.ReadLine());
            area = ancho*lado;
            Console.Write("El área del rectángulo es: " + area + "\n\nPulsa cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
