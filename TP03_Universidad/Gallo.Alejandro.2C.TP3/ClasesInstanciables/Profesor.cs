using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<EClases> clasesDelDia;
        static Random random;

        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {
            clasesDelDia = new Queue<EClases>();
            RandomClases();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
        }

        private void RandomClases()
        {
            clasesDelDia.Enqueue((EClases)random.Next((int)EClases.Laboratorio, (int)EClases.SPD));
            clasesDelDia.Enqueue((EClases)random.Next((int)EClases.Laboratorio, (int)EClases.SPD));
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

            foreach(EClases c in clasesDelDia)
                str.Append(c.ToString() + ", ");
            
            return str.ToString().TrimEnd(',') + ".";
        }


        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(Profesor profesor, EClases clase)
        {
            foreach(EClases cla in profesor.clasesDelDia)
            {
                if (cla == clase)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Profesor profesor, EClases clase)
        {
            return !(profesor == clase);

        }

    }
}
