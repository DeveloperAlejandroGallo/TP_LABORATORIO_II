using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la operacion elegda en el combo box entre los valores ingresados en los text box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operar(object sender, EventArgs e)
        {
            Numero nro1 = new Numero(txtNumero1.Text);
            Numero nro2 = new Numero(txtNumero2.Text);

            Calculadora calc = new Calculadora();

            lblResultado.Text = calc.Operar(nro1, nro2, cmbOperacion.Text).ToString();
            if(cmbOperacion.Text != calc.ValidarOperador(cmbOperacion.Text))
            {
                cmbOperacion.SelectedItem = "+";
            }

        }
        /// <summary>
        /// Limpia todos los campos texto. Pone el combo box en su valor inicial. Deja el cursor listo para la proxima operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Limpiar(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.SelectedItem = "+";
            txtNumero1.Select();
        }
        /// <summary>
        /// Verifica si se presiono Enter en el segundo text box. Si es asi, realiza la operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HitEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnOperar.Select();
                Operar(sender, e);
            }
                

        }

    }
}
