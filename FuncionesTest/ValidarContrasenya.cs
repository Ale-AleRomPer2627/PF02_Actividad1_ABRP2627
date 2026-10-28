using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02_Actividad1;

namespace FuncionesTest
{
    [TestClass]                 //ABRP2627
    public sealed class ValidarContrasenya
    {
        [TestMethod]
        public void ContrasenyaNula()
        {
            var funciones = new FuncionesContrasenya();

            bool resultado = funciones.EsContrasenyaValida(null);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaVacia()
        {
            var funciones = new FuncionesContrasenya();

            bool resultado = funciones.EsContrasenyaValida("");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaMenorDeOchoCaracteres()
        {
            var funciones = new FuncionesContrasenya();

            bool resultado = funciones.EsContrasenyaValida("Abc#123");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaSinAlmohadilla()
        {
            var funciones = new FuncionesContrasenya();

            bool resultado = funciones.EsContrasenyaValida("Abcdef12");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaValida()
        {
            var funciones = new FuncionesContrasenya();

            bool resultado = funciones.EsContrasenyaValida("Abcdef#1");

            Assert.IsTrue(resultado);
        }
    }
}               //ABRP2627
