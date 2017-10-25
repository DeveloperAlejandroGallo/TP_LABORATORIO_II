using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private int legajo;

        public int Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }

        public Universitario()
        { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido, dni, nacionalidad)
        {
            Legajo = legajo;
        }


        protected virtual string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.ToString());
            str.AppendFormat("LEGAJO: {0}", Legajo);

            return str.ToString();
        }

        protected abstract string ParticiparEnClase();

        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }

        public static bool operator ==(Universitario unUnuversitario, Universitario otroUniversitario)
        {
            return (unUnuversitario.GetType() == otroUniversitario.GetType() &&
                unUnuversitario.DNI == otroUniversitario.DNI &&
                unUnuversitario.Nombre == otroUniversitario.Nombre);
        }

        public static bool operator !=(Universitario unUnuversitario, Universitario otroUniversitario)
        {
            return !(unUnuversitario == otroUniversitario);
        }

    }
}
