using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO NRO 3 GUIA PDF";

            double numero;
            int np;
            int i;
            Console.Write("ingrese un numero :");
            numero = Double.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                numero = Double.Parse(Console.ReadLine());

            }

            for ( i = 0; i < numero; i++)
            {

            }




        }
    }
}
