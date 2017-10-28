using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        
        private int legajo;


        public Universitario()
        { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }


        protected virtual string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.ToString());
            str.AppendFormat("LEGAJO: {0}", this.legajo);

            return str.ToString();
        }

        protected abstract string ParticiparEnClase();

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType() &&
                (this.DNI == ((Universitario)obj).DNI || this.legajo == ((Universitario)obj).legajo));
        }

        public static bool operator ==(Universitario unUniversitario, Universitario otroUniversitario)
        {
            return (unUniversitario.GetType() == otroUniversitario.GetType() &&
                (unUniversitario.DNI == otroUniversitario.DNI || unUniversitario.legajo == otroUniversitario.legajo) );
        }

        public static bool operator !=(Universitario unUniversitario, Universitario otroUniversitario)
        {
            return !(unUniversitario == otroUniversitario);
        }




    }
}
