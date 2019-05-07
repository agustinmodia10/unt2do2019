using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        #region PROPIEDADES Y METODOS ABSTRACTOS

        double _Precio = 200;

        public override double precio
        {
            get { return _Precio; }
            set { }
        }


        public override double CalcularPrcioConIVA()
        {
            double auxprecio = _Precio * 21 / 100;

            _Precio += auxprecio;

            return _Precio;
        }

        #endregion




        public override string ToString()
        {
            return base.ToString() + this.cantidadAsientos.ToString();
        }


        public string MostrarAuto()
        {
            return base.MostrarVehiculo() + "-" + this.cantidadAsientos.ToString();
        }

        public Auto(string patente, Byte cantruedas, EMarca marca,int asientos) :base(patente, cantruedas, marca)
        {
            this.cantidadAsientos = asientos;
        }
    }
}
