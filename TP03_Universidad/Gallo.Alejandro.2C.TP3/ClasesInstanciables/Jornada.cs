using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos y Propiedades
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }

        private Universitario.EClases clase;

        public Universitario.EClases Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
            }
        }

        private Profesor instructor;

        public Profesor Profesor
        {
            get
            {
                return instructor;
            }
            set
            {
                instructor = value;
            }
        }

        #endregion

        #region Constructores

        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }


        public Jornada(Universitario.EClases clase, Profesor instructor)
        {
            this.Clase = clase;
            this.Profesor = instructor;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("JORNADA");
            str.AppendFormat("CLASE {0}\n", this.Clase);
            str.AppendLine("PROFESOR:\n");
            str.AppendLine(Profesor.ToString());
            str.AppendLine("ALUMNOS:");
            
            foreach(Alumno a in this.Alumnos)
            {
                str.AppendLine(a.ToString());
            }

            return str.ToString();
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach(Alumno alu in j.Alumnos)
            {
                if (a == alu)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.Alumnos.Add(a);

            return j;
        }

        
        #endregion


    }
}
