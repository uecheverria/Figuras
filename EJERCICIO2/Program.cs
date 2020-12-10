using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Figuras f = new Figuras();
                int continuar = 1;

                for (int i = 0; i < continuar; i++)
                {
                    //Imprimir menú
                    Console.Clear();
                    Console.WriteLine("MENÚ PRINCIPAL");
                    Console.WriteLine("1. Calcular el área de un cuadrado");
                    Console.WriteLine("2. Calcular el área de un rectángulo");
                    Console.WriteLine("3. Calcular el área de un círculo");
                    Console.WriteLine("4. Cerrar la aplicación");
                    Console.Write("\nElige la opción del menú: ");
                    string opcion = Console.ReadLine();
                   
                    //Gestionar las opciones del menú
                    switch (opcion)
                    {
                        case "1":
                            continuar++;
                            f.areaCuadrado();
                            break;
                        case "2":
                            continuar++;
                            f.areaRectangulo();
                            break;
                        case "3":
                            continuar++;
                            f.areaCirculo();
                            break;
                        default:
                            //Cerrar la aplicación con temporizador
                            Console.Write("La aplicación se cerrará en: ");
                            for (int j = 3; j > 0; j--)
                            {
                                Console.Write(j+" ");
                                System.Threading.Thread.Sleep(1000);
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error inesperado: " + e.Message + "\nPulsa cualquier tecla para cerrar la aplicación.");
                Console.ReadKey();
            }
        }
    }
}
