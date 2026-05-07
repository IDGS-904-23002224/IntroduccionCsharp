using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EjemploCSharp
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            int cal1 = 0;
            int cal2, cal3, resultado = 0;
            String dato1, dato2;

            Console.WriteLine("Ingresa primera calificación: ");

            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);

            Console.WriteLine("Ingresa la segunda calificación: ");
            dato2 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato2);

            int suma = cal1 + cal2;

            Console.WriteLine("La suma de las calificaciones es :" + suma);

            if (cal1 > cal2)
            {
                Console.WriteLine("La nota mayor es: " + cal1);
            }
            else
            {
                Console.WriteLine("La nota mayor es: " + cal2);
            }

            //// While
            ///

            int x;
            x = 1;

            while (x <= 10)
            {
                Console.WriteLine(x);
                Console.WriteLine(" - ");
                x++;

            }

            // do-while
            int y = 1;

            do
            {
                Console.WriteLine(y);
                Console.WriteLine(" - ");
                y++;

            } while (y <= 10);

            // For
            int f;
            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine(f);
                Console.WriteLine(" - ");
            }
        }
    }
}
