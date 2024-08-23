using System;
using System.Collections.Generic;


namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> Edades = new Dictionary<string, int>();

            // Rellenar el dicionario

            Edades.Add(" Juan ", 18);

            Edades.Add(" Diandra ", 35);

            Edades["Maria"] = 25;

            Edades[" Antonio "] = 29;

            foreach(KeyValuePair<string, int> Personas in Edades)
            {

                Console.WriteLine(" Nombre:  {0} Edad: {1} ", Personas.Key, Personas.Value );
            }


        }
    }
}
