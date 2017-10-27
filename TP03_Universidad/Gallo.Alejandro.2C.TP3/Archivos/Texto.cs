using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter file = new StreamWriter(archivo);
                file.Write(datos);
                file.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                StreamReader file = new StreamReader(archivo);
                
                datos = file.ReadToEnd(); 
                return true;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
