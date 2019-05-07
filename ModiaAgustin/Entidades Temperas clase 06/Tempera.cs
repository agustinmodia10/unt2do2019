using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Temperas_clase_06
{
    public class Tempera
    {

        #region ATRIBUTOS
      
        ConsoleColor _color;

        public ConsoleColor Color
        {
            get { return _color; }
        }

        string _marca;

        public string Marca
        {
            get { return _marca ; }
        }


        sbyte _cantidad;



        #endregion

        #region CONSTRUCTORES

        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            _color = color;
            _marca = marca;
            _cantidad = cantidad;
        }

        #endregion

        #region METODOS

        string Mostrar()
        {

            string retorno = this._cantidad.ToString() + "  -   " + this._color.ToString() + "  -   " + this._marca;

            return retorno;
        }

        public static string Mostrar(Tempera obj)
        {
          
            return obj.Mostrar();
        }



        #endregion

        #region SOBRECARGA OPERADORES

        public static bool operator == (Tempera t1, Tempera t2)
        {
            if((object)t1 == null && (object)t2 == null)
            {

                return true;
            }

            if ((object)t1 != null && (object)t2 == null)
            {

                return false;
            }


            if (t1 != null && t2 != null && t1._marca == t2._marca && t2._color == t1._color )
            {

                return true;
            }


            return false;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }


        public static Tempera operator +(Tempera  temp1, sbyte cant)
        {
            
                temp1._cantidad += cant;
           

            return temp1;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {

            if(temp1 == temp2)
            {
                temp1 += temp2._cantidad;

            }


            return temp1;
        }

        public static Tempera operator -(Tempera temp1, sbyte cant)
        {

            temp1._cantidad -= cant;


            return temp1;
        }

        public static Tempera operator -(Tempera temp1, Tempera temp2)
        {

            if (temp1 == temp2)
            {
                temp1 -= temp2._cantidad;

            }


            return temp1;
        }



        public static implicit operator sbyte(Tempera temp1)
        {
            return temp1._cantidad;
        }
        
        #endregion
    }
}
