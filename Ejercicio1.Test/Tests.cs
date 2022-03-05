using NUnit.Framework;
using Ejercicio1;
using FluentAssertions;

namespace Ejercicio1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnGreeter()
        {
            //Arrange
            Persona persona = new("Pepito");

            //Act
            string mensaje = persona.ToString();

            //Assert
            mensaje.Should().Be("Hola! mi nombre es Pepito.");
        }

        [Test]
        public void ShouldReturnGreeter2()
        {
            //Arrange
            Persona persona = new("Juan");

            //Act
            string mensaje = persona.ToString();

            //Assert
            mensaje.Should().Be("Hola! mi nombre es Juan.");
        }
    }
}