using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            
            Console.WriteLine("Hola mundo");
            Console.ReadLine();

            Console.WriteLine("ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("su nombre es : {0}", nombre);
            Console.ReadLine();

            Console.WriteLine("ingrese su edad :");
            edad =int.Parse (Console.ReadLine());
            Console.WriteLine("su edad es : {0}", edad);
            Console.ReadLine();

        }
    }
}
