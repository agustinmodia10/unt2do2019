using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreriaclaseo03; // libreria x referemcia
// using clase_boligrafos; // libreria andrentro del proyecto
using ClassLibrary2; // libreria x referemcia

namespace clase_03_ejer_01
{
    class Program
    {
        static void Main(string[] args)

        {
            #region CREO OBJ
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);

            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            #endregion

            #region VARIABLES
            string cadena = " ";
            int canttinta = 25;
            string dibu = " hola ";
            #endregion

            #region PRUEBA BOLIGRAFO 1

            bool auxbool = boligrafo1.Pintar(canttinta, out dibu);
            if (auxbool == true)
            {
                for (int i = 1; i <= canttinta; i++)
                {


                    cadena = "*" + cadena;

                }

                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine(cadena);
                Console.ReadLine();



            }
            if (auxbool == false)
            {
                Console.WriteLine("ERROR NO HAY MAS TINTA");
                Console.ReadLine();
            }

            Console.WriteLine("RECARGO TINTA");
            Console.ReadLine();
            boligrafo1.Recargar();
            


            Console.WriteLine(boligrafo1.GetTinta());
            Console.ReadLine();
            #endregion

            #region PRUEBA BOLIGRAFO 2
            auxbool = boligrafo2.Pintar(canttinta, out dibu);
            if (auxbool == true)
            {
                for (int i = 1; i <= canttinta; i++)
                {


                    cadena = "*" + cadena;

                }

                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine(cadena);
                Console.ReadLine();



            }
            if (auxbool == false)
            {
                Console.WriteLine("ERROR NO HAY MAS TINTA");
                Console.ReadLine();
            }

            #endregion

            #region PRUEBA AGREGAR REFERENCIAS
            Console.WriteLine(testclaseo3.Saludar());
            Console.ReadLine();
            #endregion



        }
    }
}
