using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Palete.Tempera_clase_07
{
    public partial class WFPrincipsl : Form
    {
        #region CONTRUCTORR

        public WFPrincipsl()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

        }

        #endregion

        #region BOTON SALIR
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WFPrincipsl_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));

        }
        #endregion

        #region ACCION FROM CLOSING
        private void WFPrincipsl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" seguro que desea salir; ", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region MENU AGREGAR CANTIDAD TEMPERAS
        private void cantidadDeTemperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WFCantTemp fcanttemp = new WFCantTemp();
            fcanttemp.MdiParent = this;
            fcanttemp.StartPosition = FormStartPosition.CenterScreen;
            fcanttemp.Show();

        }
        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

    }
}
