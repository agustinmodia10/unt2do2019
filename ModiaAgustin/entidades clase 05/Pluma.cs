using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades_clase_05
{
    public class Pluma
    {
        #region ATRIBUTOS

        string _marca;
        tinta _tinta;
        int _cantidad;

        #endregion

        #region CONSTRUCTORES

        public Pluma(string marca, tinta tinta, int cantidad)
        {
            _marca = marca;
            _tinta = tinta;
            _cantidad = cantidad;
        }


        
        public Pluma(string marca, tinta tinta) :this(marca , tinta, 0)
        {
           
        }

        public Pluma(string marca) : this(marca,null, 0)
        {

        }

        public Pluma() : this("sin marca", null, 0)
        {

        }

        #endregion

        #region METODOS

        string  Mostrar()
        {

            string cadena = this._marca + "    -    " + tinta.Mostrar(this._tinta) + "    -    " + this._cantidad.ToString();

            return cadena;
        }
        #endregion

        #region SOBRECARGA OPERADORES

        public static bool operator == (Pluma p1, tinta t1)
        {
            return p1._tinta == t1;
        }

        public static bool operator != (Pluma p1, tinta t1)
        {
            return !(p1 == t1);
        }

        public static implicit operator string( Pluma pl1)
        {
            return pl1.Mostrar();
        }

        public static Pluma operator + (Pluma pl1, tinta t1)
        {
            if (pl1 == t1 && pl1._cantidad < 100)
            {
                pl1._cantidad += 10;
            }
            
            return pl1;
        }

        public static Pluma operator - (Pluma pl1, tinta t1)
        {
            if (pl1 == t1 && pl1._cantidad > 0)
            {
                pl1._cantidad -= 10;
            }

            return pl1;
        }
        #endregion

    }
}
