using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        #region PROPIEDADES Y METODOS ABSTRACTOS

        public abstract Double precio { get; set; }
       
        public abstract Double CalcularPrcioConIVA();

        #endregion

        protected string patente;
        protected EMarca marca;
        protected Byte cantidadRuedas;



        public override string ToString()
        {
            return this.patente.ToString() + "-" + this.marca.ToString() + "-" + this.cantidadRuedas.ToString();
        }

        protected string MostrarVehiculo()
        {
            return this.patente.ToString() + "-" + this.marca.ToString() + "-" + this.cantidadRuedas.ToString();
        }

        public Vehiculo(string patente ,Byte cantruedas, EMarca marca)
        {
            this.cantidadRuedas = cantruedas;
            this.marca = marca;
            this.patente = patente;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (Equals(v1, null) && Equals(v2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(v1, null) && !Equals(v2, null))
                {
                    if ( v1.marca == v2.marca &&  v1.patente == v2.patente)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
