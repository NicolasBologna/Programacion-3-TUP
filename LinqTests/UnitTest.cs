using NUnit.Framework;
using FluentAssertions;
using PracticaLinq;
using System.Collections.Generic;

namespace LinqTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ej1Test()
        {
            Assert.Pass();
        }

        [Test]
        public void Ej2Test()
        {
            Assert.Pass();
        }

        [Test]
        public void Ej3Test()
        {
            Assert.Pass();
        }

        [Test]
        public void Ej4Test()
        {
            var numeros = new int[] { 7, 2, 30 };

            List<string> nuevosNumeros = Ej5.CalcularCuadrados(numeros);

            nuevosNumeros.Should().NotBeNullOrEmpty()
                .And.HaveCount(2)
                .And.Contain(new List<string>() { "7 - 49", "30 - 900" });
        }

        [Test]
        public void Ej5Test()
        {
            var numeros = new int[] { 7, 2, 30 };

            List<string> nuevosNumeros = Ej5.CalcularCuadrados(numeros);

            nuevosNumeros.Should().NotBeNullOrEmpty()
                .And.HaveCount(2)
                .And.Contain(new List<string>() { "7 - 49", "30 - 900" });
        }

        [Test]
        public void Ej6Test()
        {
            var palabras = new List<string>() { "estudiar", "caminar", "dia" };

            var nuevasPalabras = Ej6.ReemplazarIa(palabras);

            nuevasPalabras.Should().NotBeNullOrEmpty()
                .And.HaveCount(3)
                .And.Contain(new List<string>() { "estud*r", "caminar", "d*" });
        
        }

        [Test]
        public void Ej7Test()
        {
            //Arrange
            var cadena = "ESTO es un EJEMPLO del EJERcicio";

            //Act
            var lista = Ej7.DevolverPalabrasCapitales(cadena);

            //Assert
            lista.Should().NotBeNullOrEmpty()
                .And.HaveCount(2)
                .And.ContainInOrder(new List<string>() { "ESTO", "EJEMPLO" });
        }
    }
}