using System;
using System.Collections.Concurrent;


namespace ConcectoPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // RealizarTarea();

            var miVariable = new { Nombre = "Rafael", Edad = 17 };

            Console.WriteLine( miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVarible = new { Nombre = " Ramon ", Edad = 25 };

            miVariable = miOtraVarible;
        }      
        

        static void RealizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(150, 90);

            Punto otroPunto = new Punto();
             
            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objectos creados: {Punto.ContadorDeObjectos()}");
        }

    }



}
