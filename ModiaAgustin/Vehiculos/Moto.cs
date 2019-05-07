using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        #region PROPIEDADES Y METODOS ABSTRACTOS
        double _Precio = 100;

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
            return base.ToString() + "-" + this.cilindrada.ToString();
        }


        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + "-" + this.cilindrada.ToString();
        }

        public Moto (string patente, Byte cantruedas, EMarca marca, float cilindros) : base(patente, cantruedas, marca)
        {
            this.cilindrada = cilindros;
        }
    }
}
