using System;



namespace usoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseas entrar en el bucle While");

            string Repuesta = (Console.ReadLine());

            while (Repuesta != "no")
            {

                Console.WriteLine("Estas ejecutando el interior del bucle While");

                Console.WriteLine("Introduce tu nombre, por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"sal dras del buncle {nombre} cuando respodad 'no' a la pregunta");

                Console.WriteLine("Deseas repetir otra vez");

                Repuesta = Console.ReadLine();


            }

            Console.WriteLine("Has salido del bucless");

        }
    }
}
