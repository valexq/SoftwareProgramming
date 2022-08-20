using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_play
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "", sw = "si", cc = "";
            int clave = 0, op = 0, cont = 0;
            double total = 0;

            Console.WriteLine("PROGRAMA TRIPLE PLAY\n");

            while(sw == "si")
            {
                Console.Write("Ingrese su nombre... ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su cédula... ");
                cc = Console.ReadLine();
                Console.Write("Digite la clave... ");
                clave = Int32.Parse(Console.ReadLine());

                if (clave != 1234)
                {
                    Console.WriteLine("Clave incorrecta");
                } 
                else
                {
                    Console.WriteLine("Bienvenido " + nombre);
                    do
                    {
                        Console.Write("\t\nMenú de servicios\n1. TV cable\n2. Banda ancha\n" +
                            "3. Telefonía IP\n0. Salir\n");
                        op = Int32.Parse(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Seleccionó TV cable, costo: $40.000");
                                cont = cont + 1;
                                total = total + 40000;
                                break;
                            case 2:
                                Console.WriteLine("Seleccionó banda ancha, costo: $63.000");
                                cont = cont + 1;
                                total = total + 63000;
                                break;
                            case 3:
                                Console.WriteLine("Seleccionó telefonía IP, costo: $20.000");
                                cont = cont + 1;
                                total = total + 20000;
                                break;
                            case 0:
                                Console.WriteLine("\n\tFactura de compra\nNombre: " +
                                    nombre + "\tcédula: " + cc + "\nSu total a pagar es: " +
                                    total + " por " + cont + " servicios");
                                total = 0;
                                cont = 0;
                                break;
                            default:
                                Console.WriteLine("Error, opción no váilda");
                                break;
                        }
                    } while (op != 0);
                }
                Console.Write("¿Desea realizar otra compra? si/no... ");
                sw = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
