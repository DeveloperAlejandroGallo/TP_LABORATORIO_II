using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        static string mensajeBase = "ERROR=> DNI INVALIDO";

        public DniInvalidoException()
            :base(mensajeBase)
        {
        }

        public DniInvalidoException(string mensaje) 
            : base(mensaje) 
        {
        }

        public DniInvalidoException(Exception e)
            : base(mensajeBase, e)
        {
        }


        public DniInvalidoException(string mensaje, Exception innerException)
            : base(mensajeBase + ": " + mensaje , innerException) 
        {
        }
    }
}
