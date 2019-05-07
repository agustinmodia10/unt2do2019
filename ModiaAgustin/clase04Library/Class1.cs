using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04Library
{
    public class cosa
    {

        #region ATRIBUTOS

        public int entero;
        public string cadena;
        public  DateTime fecha;

        #endregion


        public cosa ()
        {
            this.cadena = "sin valor";
            this.entero = 10;
            this.fecha = DateTime.Now;


        }

        public cosa (int a):this ()
        {

            this.entero = a;


        }

        public cosa(int a, DateTime b) : this(a)
        {

            this.fecha = b;


        }

        public cosa(int a, DateTime b, string c) : this(a, b)
        {

            this.cadena = c;


        }



        #region METODOS

        public static string Mostrar(cosa obj)
        {
            return obj.Mostrar();
        }

        public string Mostrar( )
        {

            string retorno = this.cadena +"  -   " + this.entero.ToString() + "  -   " + this.fecha.ToString();

            return retorno;
        }

        public void EstablecerValor(int a)
        {
            this.entero = a;
        }

        public void EstablecerValor(string b)
        {
            this.cadena = b;
        }


        public void EstablecerValor(DateTime c)
        {
            this.fecha = c;
        }



        #endregion
    }
}
