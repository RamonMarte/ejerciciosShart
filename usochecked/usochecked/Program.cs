using System;

namespace usochecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                int numero = int.MaxValue;

                int resultado = unchecked(numero + 20);

                Console.WriteLine(resultado);


            


        }
    }
}
