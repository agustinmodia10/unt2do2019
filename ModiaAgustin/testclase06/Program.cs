using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Temperas_clase_06;
namespace testclase06
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temp1 = new Tempera(ConsoleColor.Blue, "marca", 10);

            Console.Write(Tempera.Mostrar(temp1));
            Console.ReadLine();

            // sbyte cantidad = temp1;




            // Console.Write(cantidad);
            // Console.ReadLine();

            // temp1 += cantidad;

            //cantidad = temp1;

            // Console.Write(cantidad );
            // Console.ReadLine();

            Tempera temp2 = new Tempera(ConsoleColor.Cyan, "marca", 20);
            Paleta p = 8;

            p += temp1;
            p += temp2;


            Console.Write((string) p);
            Console.ReadLine();



        }
    }
}
