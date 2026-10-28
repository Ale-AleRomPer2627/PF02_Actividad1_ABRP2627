
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02_Actividad1;

namespace FuncionesTest
{
    [TestClass]
    public sealed class ValidarFactorial
    {
        [TestMethod]
        public void FactorialMenorACero()
        {
            var funciones = new FuncionesFactorial();

            long resultado = funciones.CalcularFactorial(-1);

            Assert.AreEqual(-1L, resultado);
        }

        // ABRP2627

        [TestMethod]
        public void FactorialCeroIgualAUno()
        {
            var funciones = new FuncionesFactorial();

            long resultado = funciones.CalcularFactorial(0);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void FactorialValorUno()
        {
            var funciones = new FuncionesFactorial();

            long resultado = funciones.CalcularFactorial(1);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void FactorialValorCinco()
        {
            var funciones = new FuncionesFactorial();

            long resultado = funciones.CalcularFactorial(5);

            Assert.AreEqual(120L, resultado);
        }

        [TestMethod]
        public void FactorialDeDiez()
        {
            var funciones = new FuncionesFactorial();

            long resultado = funciones.CalcularFactorial(10);

            Assert.AreEqual(3628800L, resultado);
        }

        // ABRP2627
    }
}
