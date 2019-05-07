using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades_clase_05
{
    public class tinta
    {


        #region ATRIBUTOS

        ConsoleColor _color;
        ETipotinta _tipotinta;

        #endregion


        #region CONSTRUCTORES


        public tinta(ConsoleColor color, ETipotinta tipotinta)
        {
            _tipotinta = tipotinta;
            _color = color;
        }

        public tinta(ConsoleColor color) : this(color, ETipotinta.Comun)
        {


        }

        public tinta() : this(ConsoleColor.Black, ETipotinta.Comun)
        {

        }

        #endregion

        #region METODOS

        string Mostrar()
        {

            string retorno = this._tipotinta.ToString() + "  -   " + this._color.ToString();

            return retorno;
        }

        public static string Mostrar(tinta obj)
        {
            return obj.Mostrar();
        }


        #endregion

        #region SOBRECARGA OPERADORES

        public static bool operator ==( tinta t1, tinta t2)
            {

            if(t1._color == t2._color && t1._tipotinta == t2._tipotinta)
            {
                return true;
            }

               return false;
             }


 
        public static bool operator !=( tinta t1 , tinta t2)
            {
                 return !(t1 == t2);
             }

        #endregion


    }
}
