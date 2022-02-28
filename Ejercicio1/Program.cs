using System;

/*Create a C# program that requests three names of people from the user and stores 
 * them in an array of objects of type Person. To do this, first create a Person class 
 * that has a Name property of type string and override the ToString() method.

End the program by reading people and executing the ToString() method on the screen.*/

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
