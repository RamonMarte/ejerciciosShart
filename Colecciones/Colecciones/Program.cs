using System;
using System.Collections.Generic;


namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> Numeros = new Queue<int>();

            // rellenando o agregando elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {

                Numeros.Enqueue(numero);
            }


            // Recorriendo la cola 

            Console.WriteLine(" Recorriendo el queue ");

            foreach(int numero in Numeros)
            {

                Console.WriteLine(numero);
            }

            // Eliminando elementos del queue o cola

            Console.WriteLine(" Eliminando elementos ");

            Numeros.Dequeue();

            foreach (int numero in Numeros)
            {

                Console.WriteLine(numero);
            }



        }
    }
}
