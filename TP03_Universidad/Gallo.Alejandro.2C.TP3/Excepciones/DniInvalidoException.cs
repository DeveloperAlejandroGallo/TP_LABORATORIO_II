using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        static string mensajeBase = "DNI Invalido";

        public DniInvalidoException()
            :base(mensajeBase)
        {
        }

        public DniInvalidoException(string mensaje) 
            : base(mensaje, null) 
        {
        }

        public DniInvalidoException(Exception e)
            : this(mensajeBase, e)
        {
        }


        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje , e) 
        {
        }
    }
}
