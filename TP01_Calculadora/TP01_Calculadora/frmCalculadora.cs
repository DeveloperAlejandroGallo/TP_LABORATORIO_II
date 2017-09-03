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


        private void Operar_Click(object sender, EventArgs e)
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
        private void limpiar(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.SelectedItem = "+";
            txtNumero1.Select();
        }

        private void HitEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnOperar.Select();
                Operar_Click(sender, e);
            }
                

        }

    }
}
