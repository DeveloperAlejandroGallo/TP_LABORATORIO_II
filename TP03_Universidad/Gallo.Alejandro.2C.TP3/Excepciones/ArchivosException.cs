using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        static string msj = "ERROR EN ARCHIVO";

        public ArchivosException()
            :base(msj)
        {
        }
    
        public ArchivosException(Exception innerException)
            : base(msj,innerException) 
        { 
        }


    }
}
