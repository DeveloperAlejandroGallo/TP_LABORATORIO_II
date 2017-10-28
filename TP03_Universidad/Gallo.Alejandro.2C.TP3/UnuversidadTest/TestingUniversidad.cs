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
        public void TestMethod1()
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



    }
}
