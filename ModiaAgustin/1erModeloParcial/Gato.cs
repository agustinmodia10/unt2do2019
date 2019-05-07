using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erModeloParcial
{
    public class Gato : Mascota
    {
        #region CONSTRUCTOR 
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        #endregion

        #region METODO ABSTRACTO
        protected override string Ficha()
        {
            string retorno = this.Nombre + " " + this.Raza;

            return retorno;
        }

        #endregion

        #region SOBRECARGA OPERADORES
        public static bool operator ==(Gato g1, Gato g2)
        {

            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        #endregion

        #region SOBREESCRIBO

        public override string ToString()
        {
            return this.Ficha();
        }


        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                if ((Gato)obj == this)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion


    }
}
