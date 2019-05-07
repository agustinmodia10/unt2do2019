using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "EJERCICIO NRO 1 GUIA PDF";


            int numero;
            int i;
            int max = 0;
            int min = 0;
            float acum = 0;
            float prome;
            int divisor = 0;

            for (i = 0 ; i < 5; i++ )
            {

                Console.Write("ingrese un numero :");
                numero = int.Parse(Console.ReadLine());
                

                if(i == 0)
                {
                    min = numero;
                    max = numero;

                }

                if(numero > max)
                {
                    max = numero;
                }

                if (numero < min )
                {
                    min = numero;
                }

                acum = numero + acum;
                divisor = divisor + 1;
            }

            prome = (float) (acum / divisor);

            Console.Write("el maximo es : {0}   ----- el minimo es  {3} ----- el promedio es :{2:0.00} ----- el acumulado es : {1} ", max, acum,prome, min );
            Console.ReadLine();







        }
    }
}
