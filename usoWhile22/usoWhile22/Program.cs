using System;



namespace usoWhile22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Numero = new Random();

            int aleatorio = Numero.Next(0,100);

            int minumero = (101);

            int intentos = (0);

            Console.WriteLine("Introduce un numero entre 0 y 100");

            while (aleatorio != minumero)
            {

                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

                



            }

            Console.WriteLine($"correcto! has nesecitado {intentos} intentos");




        }
    }
}
