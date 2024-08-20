using System;
using System.Collections.Generic;


namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Numeros = new List <int>();  // Declarar una lista (coleccion de tipo lista.

            Console.WriteLine(" Introcuce elementos en la coleccion (0 Para salir) ");

            int Elem = 1;

            while (Elem != 0)
            {

                Elem = Int32.Parse(Console.ReadLine());

                Numeros.Add(Elem);
            }

            Numeros.Remove(Numeros.Count - 1);

            Console.WriteLine(" Elemetos introducidos ");

            foreach(int Elemetos in Numeros)
            {

                Console.WriteLine(Elemetos);
            }

        }
    }
}
