using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erModeloParcial
{
    class Grupo
    {
        #region ATRIBUTOS

        private List<Mascota> _manada;
        private string _nombre;
        static ETipoManada _tipo;

        #endregion

        #region PROPIEDAD

        public  ETipoManada tipo { set { Grupo._tipo = value; } }

        #endregion

        #region contructores

        //contructor de clase o estatico
        static Grupo()
        {
           Grupo._tipo = ETipoManada.unica;
        }

        private Grupo()
        {

            this._manada = new List<Mascota>();


        }

        public Grupo(string nombre):this()
        {
            _nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Grupo._tipo = tipo;
        }

        #endregion

        #region SOBRECARGAOPERADORES
        public static bool operator ==(Grupo G1, Mascota M1)
        {

            foreach(Mascota item in G1._manada)
            {
                if(item == M1)
                {
                    return true;
                    
                }

            }

            return false;
        }

        public static bool operator !=(Grupo G1, Mascota M1)
        {
            return !(G1 == M1);
        }


        public static Grupo operator +(Grupo G1, Mascota M1)
        {
            if (G1 != M1)
            {

                G1._manada.Add(M1);

                return G1;
            }

            if (G1 == M1)
            {

                Console.WriteLine(" Ya esta el {0} en el grupo" + "\n", M1);

                return G1;
            }



            return G1;
        }



        public static Grupo operator -(Grupo G1, Mascota M1)
        {
            if (G1 == M1)
            {

                G1._manada.Remove(M1);

                return G1;
            }
            if (G1 != M1)
            {

                Console.WriteLine(" No esta el {0} en el grupo" + "\n", M1 );

                return G1;
            }


            return G1;
        }


        #endregion


        public static implicit operator String(Grupo G1)
        {
            string retorno = " GRUPO: " + G1._nombre + "  - TIPO "+ Grupo._tipo + "\n";
            retorno += "\n CANTIDAD DE INTEGRANTES: " + G1._manada.Count.ToString() + "\n";
            foreach (Mascota item in G1._manada)
            {
                retorno += "\n ";
                retorno += item.ToString();
                retorno += "\n ";
            }


            return retorno;
        }

    }
}
