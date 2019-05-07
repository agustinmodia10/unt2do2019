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
    public partial class WFCantTemp : Form
    {

        #region CONTRUCTOR

        public WFCantTemp()
        {
            InitializeComponent();

        }

        #endregion

        #region LABEL 1

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region TEXTBOX 1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region BOTON AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {


            int _canttemp = int.Parse(this.TBCANTTEMP.Text);
            this.button1.DialogResult = DialogResult.OK;

            

            if (this.button1.DialogResult == DialogResult.OK)
            {
                WFPaleta fpaleta = new WFPaleta(_canttemp);

                fpaleta.StartPosition = FormStartPosition.CenterScreen;
                fpaleta.Show();


            }

            this.Close();

        }

        #endregion

        #region LOAD WFCANTEMP
        private void WFCantTemp_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region BOTON 2 NO USADO
        private void button2_Click(object sender, EventArgs e)
        {

            
        }
        #endregion

    }
}
