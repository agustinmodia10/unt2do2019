using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erModeloParcial
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public string Nombre { get {   return _nombre; } }
        public string Raza { get { return _raza; } }

        public Mascota(string nombre, string raza)
        {
            _nombre = nombre;
            _raza = raza;
        }


        protected virtual string DatosCompletos()
        {
            string retorno = this._nombre + this._raza;

            return retorno;
        }


        protected abstract string Ficha();

    }
}
