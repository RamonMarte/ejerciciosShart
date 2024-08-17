using System;


namespace usoArrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el Main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }

        static int[] LeerDatos()
        {

            Console.WriteLine("Cuatos elementos quieres que tenga el array");

            string repuesta = Console.ReadLine();

            int numElementos = int.Parse(repuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {

                Console.WriteLine($"Introduce el dato para la posicion {i}");

                repuesta = Console.ReadLine();

                int datosElementos = int.Parse(repuesta);

                datos[i] = datosElementos;
            }

            return datos;

        }
    }

}
