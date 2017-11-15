using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        string archivo;

        public Texto(string archivo)
        {
            this.archivo = archivo;
        }

        public bool guardar(string datos)
        {
            StreamWriter stream=null;
            try
            { 
            
            if (File.Exists(archivo))
                stream = new StreamWriter(this.archivo, true);

            else
                stream = new StreamWriter(this.archivo);

                stream.Write(datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                stream.Close();
            }

            return true;

        }

        public bool leer(out List<string> datos)
        {
            string line;
            StreamReader sr = new StreamReader(archivo);

            datos = new List<string>();
                        
            while ((line = sr.ReadLine()) != null)
                datos.Add(line);

            return true;
        }

    }
}
