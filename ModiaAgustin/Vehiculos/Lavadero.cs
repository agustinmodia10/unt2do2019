using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
   public class Lavadero 
    {

        


        #region PROPIEDADES

        private List<Vehiculo> _vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get { return _vehiculos; }
            set { _vehiculos = value; }
        }

        private float _precioAuto;

        public float PrecioAuto
        {
            get { return _precioAuto; }
            set { _precioAuto = value; }
        }

        private float _precioCamion;

        public float PrecioCamion
        {
            get { return _precioCamion; }
            set { _precioCamion = value; }
        }

        private float _precioMoto;

        public float PrecioMoto
        {
            get { return _precioMoto; }
            set { _precioMoto = value; }
        }

        #endregion

        #region CONTRUCTORES

        public Lavadero(float pAuto, float pCamion, float pMoto) : this()
        {
           
            this._precioAuto = pAuto;
            this._precioMoto = pMoto;
            this._precioCamion = pCamion;
        }



        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }



        #endregion

        #region METODOS

        private double MostrarTotalFacturado()
        {
            double retorno = 0;

            foreach (Vehiculo vehiculo in this._vehiculos)
            {
                if (vehiculo is Auto)
                {
                    retorno += this._precioAuto;
                }
                if (vehiculo is Moto)
                {
                    retorno += this.PrecioMoto;
                }
                if (vehiculo is Camion)
                {
                    retorno += this.PrecioCamion;
                }
            }

            return retorno;
        }

        private string MostrarTotalFacturadoPorCategoria()
        {
            string retorno = " \n TOTAL POR CATEGORIAS: \n";
            double totalauto = 0;
            double totalmoto = 0;
            double totalcamion = 0;

            foreach (Vehiculo vehiculo in this._vehiculos)
            {
                if (vehiculo is Auto)
                {
                    totalauto += this._precioAuto;
                }
                if (vehiculo is Moto)
                {
                    totalmoto += this.PrecioMoto;
                }
                if (vehiculo is Camion)
                {
                    totalcamion += this.PrecioCamion;
                }
            }

            return retorno += "TOTAL AUTO :" + totalauto.ToString() + "\n TOTAL MOTO " + totalmoto.ToString() + " \n TOTAL CAMION " + totalcamion.ToString();
        }



        private string MostrarLavadero()
        {
            string retorno = " Precios: \n Autos: " + this._precioAuto + "\n " + "Camiones: " + this._precioCamion + " \n " + "Motos: " + this._precioMoto;

            foreach (Vehiculo item in this._vehiculos)
            {
                retorno += "\n ";
               retorno += item.ToString();
                retorno += "\n ";
            }

            double Total = this.MostrarTotalFacturado();

            return retorno += "\n TOTAL :" + Total.ToString() + this.MostrarTotalFacturadoPorCategoria();
        }


        public override string ToString()
        {
            return MostrarLavadero(); 
        }



        #endregion

        #region SOBRECARGA OPERADORES

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            

            foreach (Vehiculo labVeiculo in lavadero._vehiculos)
            {
                if (labVeiculo == vehiculo)
                {
                    return true;
                }
            }

            return false;
        }



        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }



        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero._vehiculos.Add(vehiculo);
            }
            return lavadero;
        }



        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero._vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }

        #endregion


    }
}
