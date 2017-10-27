using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
       public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        public Alumno()
        { }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :base(id, nombre, apellido, dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            :this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.MostrarDatos());
            str.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            str.AppendLine(ParticiparEnClase());

            return str.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            return alumno.claseQueToma == clase && alumno.estadoCuenta != EEstadoCuenta.Deudor;
        }

        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return alumno.claseQueToma != clase;
        }






    }
}
