using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades_clase_05;

namespace test_clase_05
{
    class Program
    {
        static void Main(string[] args)
        {

            tinta obj1 = new tinta();

            Console.WriteLine(tinta.Mostrar(obj1));
            Console.ReadLine();

            tinta obj2 = new tinta(ConsoleColor.Blue);

            Console.WriteLine(tinta.Mostrar(obj2));
            Console.ReadLine();

            tinta obj3 = new tinta(ConsoleColor.Magenta,ETipotinta.ConBrillito);

            Console.WriteLine(tinta.Mostrar(obj3));
            Console.ReadLine();

            tinta obj4 = new tinta();
            
            if(obj1 ==  obj4)
            {
                Console.WriteLine("las tintas son iguales");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine(" las tintas no son iguales");
                Console.ReadLine();

            }

            Pluma pl1 = new Pluma("bic" , obj2 , 10);

            string cadenapl1 = pl1;

            Console.WriteLine(cadenapl1);
            Console.ReadLine();

            if (pl1 == obj2)
            {
                Console.WriteLine("las tintas de las plumas son iguales");
                Console.ReadLine();

            }

            Pluma pl2 = new Pluma();

            pl2 = pl1 + obj2;

            string cadenapl2 = pl2;

            Console.WriteLine(cadenapl2);
            Console.ReadLine();
          
            pl2 = pl2 - obj2;

            cadenapl2 = pl2;
            
            Console.WriteLine(cadenapl2);
            Console.ReadLine();
            pl2 = pl2 + obj2;

            
        }
    }
}
