using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }


        private string apellido;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = ValidaNombreApellido(value);
            }
        }

        private int dni;

        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                if (ValidarDNI(Nacionalidad,value)==0)
                    throw new Exception();

                dni = value;
            }
        }

        private ENacionalidad nacionalidad;

        public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }

        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = ValidaNombreApellido(value);
            }
        }

        public string StringToDNI
        {
            set
            {
                  DNI = ValidarDNI(Nacionalidad,value);
            }
        }

        public Persona()
        { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            DNI = ValidarDNI(nacionalidad, dni);
        }

        private int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && (dato < 1 || dato > 89999999))
                return dato;
            else
                return 0;

        }

        private int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if (int.TryParse(dato, out dni))
                return ValidarDNI(nacionalidad, dni);
            else
                return 0;

        }

        private string ValidaNombreApellido(string dato)
        {
            Regex r = new Regex("^[A-Za-z ]+$");
            if (r.IsMatch(dato))
                return dato;
            else
                return "";
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", Apellido, Nombre);
            str.AppendFormat("DNI: {0}", DNI);
            str.AppendFormat("NACIONALIDAD: {0}", Nacionalidad);
            return str.ToString();
        }
    }
}
