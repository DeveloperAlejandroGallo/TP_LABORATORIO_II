using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo,out T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextReader writer = new XmlTextReader(archivo);
                datos = (T)serializer.Deserialize(writer);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
