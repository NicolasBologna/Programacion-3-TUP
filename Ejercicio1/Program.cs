using System;

/*
Crear un programa en C# que solicite al usuario tres nombres de personas y los almacene 
en un array de objetos de tipo Persona. Para ello, cree primero una clase Persona 
que tenga una propiedad Nombre de tipo string. 
Además, la clase persona debe sobreescribir el método ToString() produciendo el siguiente resultado: "Hola! mi nombre es {Nombre}.".
Finalizar el programa ejecutando el método ToString() para cada persona en la pantalla. 
 */

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            for (int i = 0; i < 3; i++)
            {
                personas[i] = new Persona(Console.ReadLine());
            }

            foreach (var persona in personas)
            {
                Console.WriteLine(persona.ToString());
            }
        }
    }
}
