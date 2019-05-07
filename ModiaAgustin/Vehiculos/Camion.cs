using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected float tara;

        #region PROPIEDADES Y METODOS ABSTRACTOS

        double _Precio = 300;

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
            return base.ToString() + "-" + this.tara.ToString();
        }


        public string MostrarCamion ()
        {
            return base.MostrarVehiculo() + "-" + this.tara.ToString();
        }

        public Camion (string patente, Byte cantruedas, EMarca marca, float tara) : base(patente, cantruedas, marca)
        {
            this.tara = tara;
        }
    }
}
