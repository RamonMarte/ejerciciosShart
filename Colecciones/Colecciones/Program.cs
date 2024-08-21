using System;
using System.Collections.Generic;


namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> Numeros = new LinkedList<int>();

            foreach (int numero in new int[] {10, 8, 6, 4, 2, 0 })
            {

                Numeros.AddLast(numero);
            }

            // Numeros.Remove(6);

            LinkedListNode<int> nodoInportante = new LinkedListNode<int>(15);

            Numeros.AddFirst(nodoInportante);

           /* foreach(int numero in Numeros)
            {

                Console.WriteLine(numero);
            }*/


            for(LinkedListNode<int> nodo = Numeros.First; nodo != null; nodo = nodo.Next)
            {

                int numero = nodo.Value;

                Console.WriteLine(numero);

            }
        }  
    }
}
