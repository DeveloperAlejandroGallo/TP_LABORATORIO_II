using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }


        List<Alumno> alumnos;
        List<Jornada> jornadas;
        List<Profesor> profesores;


        #region Propiedades

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }


        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }
            set
            {
                this.jornadas[i] = value;
            }
        }


        #endregion

        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornadas = new List<Jornada>();
            profesores = new List<Profesor>();

        }

        public static bool operator ==(Universidad u, Alumno a)
        {
            foreach (Alumno alu in u.Alumnos)
            {
                if (a == alu)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        public static bool operator ==(Universidad u, Profesor profe)
        {
            foreach (Profesor p in u.profesores)
            {
                if (p == profe)
                    return true;

            }
            return false;
        }

        public static bool operator !=(Universidad u, Profesor profe)
        {
            return !(u == profe);

        }

        public static Universidad operator +(Universidad u, Universidad.EClases clase)
        {
            Profesor profe = null;
            Jornada jornada;

            foreach (Profesor p in u.Instructores)
            {
                if (p == clase)
                {
                    profe = p;
                    break;
                }
            }

            if (profe is null)
                return u;

            jornada = new Jornada(clase, profe);

            foreach (Alumno a in u.alumnos)
            {
                if (a == clase)
                    jornada.Alumnos.Add(a);
            }


            u.Jornadas.Add(jornada);

            return u;

        }

        public static Universidad operator +(Universidad uni, Alumno alu)
        {
            foreach (Alumno a in uni.Alumnos)
            {
                if (a == alu)
                    return uni;
            }
            uni.Alumnos.Add(alu);

            return uni;
        }

        public static Universidad operator +(Universidad uni, Profesor profe)
        {
            foreach (Profesor p in uni.Instructores)
            {
                if (p == profe)
                    return uni;
            }
            uni.Instructores.Add(profe);

            return uni;
        }

        public static Profesor operator ==(Universidad uni, Universidad.EClases clase)
        {
            foreach (Profesor p in uni.Instructores)
                if (p == clase)
                    return p;

            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad uni, Universidad.EClases clase)
        {
            foreach (Profesor p in uni.Instructores)
                if (p != clase)
                    return p;

            throw new SinProfesorException();

        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder str = new StringBuilder();

            foreach (Jornada j in uni.Jornadas)
                str.AppendLine(j.ToString());

            foreach (Alumno a in uni.Alumnos)
                str.AppendLine(a.ToString());

            foreach (Profesor p in uni.Instructores)
                str.AppendLine(p.ToString());

            return str.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        public static bool Guardar(Universidad u)
        {
            Xml<Universidad> universidad = new Xml<Universidad>();
            return universidad.Guardar("Universidad.xml", u);
        
        }

        public static Universidad Leer()
        {
            Universidad uni;
            Xml<Universidad> universidad = new Xml<Universidad>();
            universidad.Leer("Universidad.xml", out uni);
            return uni;
        }

    }
}
