using System;



namespace usoDowhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Numero = new Random();

            int aleatorio = Numero.Next(0, 100);

            int minumero ;

            int intentos = (0);

            Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {

                intentos++;

                try
                {


                    minumero = int.Parse(Console.ReadLine());


                }
                catch (Exception ex)
                {

                    Console.WriteLine("No has introducido un valor numerico valido. Se toma como numero introducido el 0");

                    minumero = 0;

                }


                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            }

            while (aleatorio != minumero);

                Console.WriteLine($"correcto! has nesecitado {intentos} intentos");

                Console.WriteLine("A partir de esta lenea de codigo el programa continuaria");

            

        }
    }
}
