using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;


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

        private Universidad.EClases clase;

        public Universidad.EClases Clase
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

        public Profesor Instructor
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


        public Jornada(Universidad.EClases clase, Profesor instructor)
            :this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("JORNADA");
            str.AppendFormat("CLASE {0}\n", this.Clase);
            str.AppendLine("PROFESOR:\n");
            str.AppendLine(Instructor.ToString());
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

        public static bool Guardar(Jornada jornada)
        {
            Texto archivoTxt = new Texto();
            archivoTxt.Guardar("Jornada.txt", jornada.ToString());
            return true;
        }

        public static string Leer()
        {
            string str;
            Texto texto = new Texto();
            texto.Leer("Jornada.txt", out str);
            return str;


        }


        #endregion


    }
}
