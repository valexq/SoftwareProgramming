using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAmigo
{
    class Program
    {

        public static void imprimir(string mensaje)
        {
            Console.WriteLine();
        }

        public static string leer(string mensaje)
        {
            imprimir(mensaje);
            return Console.ReadLine();
        }


        public static void imprimir(Amigo objA)
        {
            imprimir("Nombre: " + objA.Name);
            imprimir("Cédula: " + objA.Id);
            imprimir("Telefono: " + objA.Tel);
            imprimir("Correo: " + objA.Correo);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA AGENDA");
            Amigo amigo1 = new Amigo();
            amigo1.Name = "Vanessa";
            amigo1.Correo = "dadas@correo.itm.co";
            amigo1.Id = 10221921;
            amigo1.Tel = 312121032;
            Console.WriteLine(amigo1);
            Amigo amigo2 = new Amigo("samuel", "samu@core.co", 36987,21010301 );
            imprimir(amigo2);
            imprimir(amigo1);
            Console.ReadKey();
        }

    }
        
}

    
