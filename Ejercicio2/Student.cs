﻿using System;

namespace Ejercicio2
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Estoy estudiando!");
        }

        public void MostrarEdad()
        {
            Console.WriteLine($"Mi edad es: {Edad} años.");
        }
    }
}
