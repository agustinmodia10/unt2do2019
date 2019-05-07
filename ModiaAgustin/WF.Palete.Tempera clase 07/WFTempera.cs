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
    public partial class WFTempera : Form
    {
        #region PROPIEDAD PARA COMPARTIR EL OBJECTO
        private Tempera _mitempera;

        public Tempera MiTempera
        {
            get { return _mitempera; }

        }

        #endregion

        #region CONTRUCTORES

        public WFTempera()
        {
            InitializeComponent();

            #region INICIALIZO COMBOBOX COLOR

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                CBCOLOR.Items.Add(color);


            }

            #endregion



        }

        public WFTempera(Tempera temp) : this()
        {
            sbyte cantidad = temp;
            this.TBCANT.Text = cantidad.ToString();
            this.TBMARCA.Text = temp.Marca;
            this.CBCOLOR.SelectedItem = temp.Color;


        }



        #endregion

        #region LABEL 1

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region COMBO BOX COLOR

        private void CBCOLOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        #endregion

        #region BOTON ACEPTAR

        private void BAceptar_Click(object sender, EventArgs e)
        {
            
            ConsoleColor ccolor = (ConsoleColor) this.CBCOLOR.SelectedItem;
            string marc = this.TBMARCA.Text;
            sbyte cant =  SByte.Parse(this.TBCANT.Text);

                
            Tempera temp = new Tempera(ccolor, marc , cant);
            //MessageBox.Show(Tempera.Mostrar(temp));
            this._mitempera = temp;
            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region BOTON CANCELAR

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

        }

        #endregion

        private void WFTempera_Load(object sender, EventArgs e)
        {

        }

        private void TBMARCA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
