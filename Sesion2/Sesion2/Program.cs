﻿using Sesion2.clases;
using System.Data;

namespace Sesion2
{
    ///Leer los datos de una persona y decir si es mayor o menor de edad.   
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
 
            Persona persona = new Persona();

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Dime tu fecha de nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine($"Tu edad es: {persona.CalcularEdad()}"); 
        }
    }
}