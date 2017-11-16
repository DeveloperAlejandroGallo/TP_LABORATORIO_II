using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        private string html;
        private Uri direccion;

        public delegate void dProgreso(int porcentaje);
        public delegate void dFinDescarga(string html);

        public event dProgreso progreso;
        public event dFinDescarga finDescarga;

        public Descargador(Uri direccion)
        {
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;

                cliente.DownloadStringAsync(direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progreso.Invoke(e.ProgressPercentage);
        }
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            { 
                this.html = e.Result;
                this.finDescarga.Invoke(e.Result);
            }
            catch(Exception ex)
            {
                this.finDescarga.Invoke("Error al Descargar - "+ ex);
            }
        }
    }
}
