using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using ClasesInstanciables;
using Excepciones;

namespace UnuversidadTest
{
    [TestClass]
    public class TestingUniversidad
    {
        [TestMethod]
        public void TestDNIArgentinoInvalidoException()
        {
            Universidad uni = new Universidad();
            try
            {
                Alumno a1 = new Alumno(1, "Juan", "Lopez", "0", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
                uni += a1;
            }
            catch (DniInvalidoException e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void TestNacionalidadInvalidaException()
        {
            Universidad uni = new Universidad();
            try
            {
                Alumno a1 = new Alumno(1, "Juan", "Lopez", "29999111", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
                uni += a1;
            }
            catch (NacionalidadInvalidaException e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }

        }

        [TestMethod]
        public void TestDNINumerico()
        {
            Alumno a1 = new Alumno(1, "Ale", "Gallo", "29999111", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Assert.IsInstanceOfType(a1.DNI, typeof(int));

        }

        [TestMethod]
        public void TestUniversidadListaAlumnosNoNull()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Alumnos);
        }

        [TestMethod]
        public void TestUniversidadListaProfesoresNoNull()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Instructores);
        }
    }


}
