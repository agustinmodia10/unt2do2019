using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "EJERCICIO NRO 2 GUIA PDF";

            double numero;

            Console.Write("ingrese un numero :");
            numero = Double.Parse(Console.ReadLine());

            while ( numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                numero = Double.Parse(Console.ReadLine());

            }


            double cuadrado = Math.Pow(numero, 2);
            Double cubo = Math.Pow(numero, 3);

            Console.Write("el cuadrado de {1} es: {0}", cuadrado, numero);
            Console.ReadLine();
            Console.Write("el cubo de {1} es: {0}", cubo, numero);
            Console.ReadLine();
        }
    }
}
