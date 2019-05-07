using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erModeloParcial
{
    public class Perro : Mascota
    {
        #region ATRIBUTOS
        private int edad;
        private bool esAlfa;
        #endregion

        #region CONSTRUCTORES
        public Perro(string nombre, string raza, int edad, bool esAlfa)  : this (nombre, raza) 
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public Perro(string nombre, string raza) : base( nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        #endregion

        #region METODO ABSTRACTO
        protected override string Ficha()
        {
            string retorno = "";
            
            if(this.esAlfa == true)
            {

                retorno = this.Nombre + " " + this.Raza + " , alfa de la manada" + " , edad " + this.edad.ToString();

            }

            if (this.esAlfa == false)
            {

                retorno = this.Nombre + " " + this.Raza + " , edad " + this.edad.ToString();

            }

            return retorno ;
        }

        #endregion

        #region SOBRECARGA OPERADORES
        public static bool operator ==( Perro p1, Perro p2)
        {

            if(p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad )
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p1)
        {
            return p1.edad;
        }

        #endregion

        #region SOBREESCRIBO

        public override string ToString()
        {
            return this.Ficha();
        }


        public override bool Equals(object obj)
        {

            if( obj is Perro)
            {
              
                if ((Perro)obj == this )
                {
                   return true;
                }
   
            }
            return false;    
        }

        #endregion
    }
}
