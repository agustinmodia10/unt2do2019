using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Temperas_clase_06;

namespace WF.Palete.Tempera_clase_07
{
    public partial class WFPaleta : Form
    {
        Paleta pal;

        

        #region CONTRUCTORES

        public WFPaleta()
        {
            InitializeComponent();

        }

        public WFPaleta(int cantemp) :this()
        {

            pal = cantemp;

        }



        #endregion

        #region LIST BOX 1

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        #endregion

        #region FORM1

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region BOTON AGREGAR

        private void button1_Click(object sender, EventArgs e)
        {
            WFTempera fTempera = new WFTempera();
            fTempera.ShowDialog();
            if (fTempera.DialogResult == DialogResult.OK)
            {
                this.pal += fTempera.MiTempera;
                this.listBox1.Items.Clear();

                foreach (Tempera item in this.pal.MisTemperas)
                {

                    if (item != null)
                    {
                        this.listBox1.Items.Add(Tempera.Mostrar(item));
                    }



                }




            }
        }

        #endregion

        #region BOTON RESTAR TEMPERAS
        private void button2_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            Tempera tempsellec = pal.MisTemperas[indice];

            WFTempera fTempera = new WFTempera(tempsellec);
            //MessageBox.Show(Tempera.Mostrar(tempsellec));
            fTempera.ShowDialog();



            if (fTempera.DialogResult == DialogResult.OK)
            {
                int canttemp = fTempera.MiTempera;
                int aux = tempsellec;
                int flag = 0;

                if (fTempera.MiTempera == tempsellec)
                    flag = 1;

                
                if (aux != 0)
                {
                    this.pal -= fTempera.MiTempera;

                }

                
                aux = tempsellec;
                
                if (aux == 0)
                {

                    this.pal -= tempsellec;

                }

                this.listBox1.Items.Clear();

                foreach (Tempera item in this.pal.MisTemperas)
                {

                    if (item != null)
                    {
                        this.listBox1.Items.Add(Tempera.Mostrar(item));
                    }



                }

            }
        }
        #endregion
    }
}
