using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Boligrafo

    {
        #region ATRIBUTOS
        const short cantidadTintaMaxima = 100;
        short tinta;
        ConsoleColor color;
        #endregion

        #region METODOS

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;


            if (tinta > Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = 100;
            }

            if (tinta <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }



        }

        public ConsoleColor GetColor()
        {

            return this.color;

        }

        public short GetTinta()
        {

            return this.tinta;

        }


        private void SetTinta(short tinta)
        {

            short auxtinta = 0;
            auxtinta = this.tinta;

            if (tinta >= 0)
            {
                this.tinta = (short)(this.tinta + tinta);
            }



            if (tinta < 0)
            {
                auxtinta = (short)(auxtinta + (tinta));




                if (auxtinta >= 0)
                {
                    this.tinta = auxtinta;

                }

            }

        }

        public void Recargar()
        {

            this.tinta = Boligrafo.cantidadTintaMaxima;

        }


        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = " ";

            short auxtinta = this.tinta;

            int auxgasto = gasto * (-1);

            this.SetTinta((short)(auxgasto));

            if (this.tinta == auxtinta)
            {
                return false;
            }


            return true;
        }


        #endregion

    }
}
