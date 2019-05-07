using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase04Library;

namespace clase04.test
{
    class Program
    {
        static void Main(string[] args)
        {

            cosa obj1 = new cosa(100,DateTime.Today);

            Console.WriteLine(cosa.Mostrar(obj1));
            Console.ReadLine();
           
            obj1.EstablecerValor(10);
            obj1.EstablecerValor("el mole");
            obj1.EstablecerValor(new DateTime(1997, 10, 10));

            Console.WriteLine(cosa.Mostrar(obj1));
            Console.ReadLine();


        }
    }
}
