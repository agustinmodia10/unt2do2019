using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase04Library;

namespace clase04.wp
{
    public partial class fmrcosa : Form
    {
        public fmrcosa()
        {
            InitializeComponent();
      
        }

        #region CARGA FORMU
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        #endregion


        private void fmrcosa_Layout(object sender, LayoutEventArgs e)
        {

        }


        #region MOMENTO PREVIO A CERRAR EL FORMU
        private void fmrcosa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion


        #region PARA CERRAR EL FORMU
        private void fmrcosa_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion


        #region INICIALIZO EL BOTON

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "CAMBIO NOMBRE DEL BOTON";

            this.Text = "CAMBIO NOMBRE DE LA VENTANA";

            cosa obj1 = new cosa(10, new DateTime(1997, 10, 10), "el mole 10");
            MessageBox.Show(cosa.Mostrar(obj1));
        }

        #endregion
    }
}
