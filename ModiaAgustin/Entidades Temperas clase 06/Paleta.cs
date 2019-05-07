using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Temperas_clase_06
{
    public class Paleta
    {

        #region PROPIEDADES

        public List<Tempera> MisTemperas
        {
            get { return _temperas; }

        }

        #endregion



        #region ATRIBUTOS

        List<Tempera> _temperas;
        int _cantidadmaxima;

        #endregion


        #region CONTRUSTORES


        private Paleta(int cantidad)
        {

            this._temperas = new List<Tempera>(cantidad);
            this._cantidadmaxima = cantidad;
         
        }

        private Paleta() : this(5)
        {
            

        }


        #endregion


        #region METODOS

        string Mostrar()
        {

            //string retorno = " \n ------- CANTIDAD MAXIMA DE ELEMENTOS :  " + this._cantidadmaxima + " -------   \n";
            int flag = 0;
            int cantelemcargados = 0;
            string retorno= "--------------";
            foreach(Tempera item in this._temperas)
            {

                if ( item != null)
                {
                    retorno = retorno + "\n" + Tempera.Mostrar(item) + "--------------";
                    flag = 1;
                    cantelemcargados += 1;
                }
              
            }

            if (flag == 0)
            {
                retorno = retorno + " \n ------- ERROR NO HAY NADA CARGADO -------";
            }

            //retorno = retorno + " \n\n ------- TOTAL ELEMENTOS CARGADOS : " + cantelemcargados + " ------- \n";

            return retorno;
        }


        int Obtenerindice( Tempera t1)
        {
            int i = -1;
            for (i = 0; i < this._cantidadmaxima; i++)
            {
                if (this._temperas[i] == t1)
                {
                    return i;
                }
            }


            return i;
        }





        #endregion


        #region SOBRECARGA OPERADORES

        public static implicit operator Paleta (int cantmax)
        {
            Paleta pal1 = new Paleta(cantmax);

            return pal1;
        }
        public static explicit operator string (Paleta pal1)
        {
            
            return pal1.Mostrar();
        }

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            foreach (Tempera aux in p1._temperas)
            {
                if (aux == t1)
                {
                    return true;
                }
            } 


            return false;
        }

        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            

            if (p1 != t1 && p1._temperas.Count < p1._cantidadmaxima)
            {
                p1._temperas.Add(t1);

                return p1;
            }


            if (p1 == t1)
            {
                int indice = p1.Obtenerindice(t1);

                p1._temperas[indice]+= t1;

                return p1;
            }


            return p1;
        }

        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            int cant = t1;

            if (p1 == t1 && cant <= 0)
            {
                p1._temperas.Remove(t1);

                return p1;
            }

            if (p1 == t1 && cant > 0)
            {
                int indice = p1.Obtenerindice(t1);

                p1._temperas[indice] -= t1;

                return p1;
            }


            return p1;
        }



        #endregion
    }
}
