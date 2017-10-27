using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            RandomClases();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
        }

        private void RandomClases()
        {
            clasesDelDia.Enqueue((Universidad.EClases)random.Next((int)Universidad.EClases.Laboratorio, (int)Universidad.EClases.SPD));
            clasesDelDia.Enqueue((Universidad.EClases)random.Next((int)Universidad.EClases.Laboratorio, (int)Universidad.EClases.SPD));
        }

        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.MostrarDatos());
            str.AppendLine(ParticiparEnClase());

            return str.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("CLASES DEL DIA ");

            foreach(Universidad.EClases c in clasesDelDia)
                str.Append(c.ToString() + ", ");
            
            return str.ToString().TrimEnd(',') + ".";
        }


        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(Profesor profesor, Universidad.EClases clase)
        {
            foreach(Universidad.EClases cla in profesor.clasesDelDia)
            {
                if (cla == clase)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Profesor profesor, Universidad.EClases clase)
        {
            return !(profesor == clase);

        }

    }
}
