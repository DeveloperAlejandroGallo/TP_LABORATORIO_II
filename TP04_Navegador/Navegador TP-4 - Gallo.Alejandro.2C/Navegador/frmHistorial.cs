using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class frmHistorial : Form
    {
        public const string ARCHIVO_HISTORIAL = "historico.dat";

        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            List<string> listHistory;
            Archivos.Texto archivos = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);

            if (archivos.leer(out listHistory))
            {
                foreach (string url in listHistory)
                    lstHistorial.Items.Add(url);
            }
            else
                MessageBox.Show("No se pudo cargar el historial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
