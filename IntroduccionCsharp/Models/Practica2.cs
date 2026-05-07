using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace EjemploCSharp
{
    /**
     * class [nombre]
     * [atributos o variables]
     * [métodos o funciones]
     * 
     */
    /*
    internal class Practica2
    {

    }
    */

    class Practica2
    {
        String nombre;
        private int edad;
        protected String carrera;

        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }

        static void Main(string[] args)
        {
            Practica2 p2 = new Practica2();
            p2.IngresarDatos();
            p2.MostrarDatos();
        }
    }
}
