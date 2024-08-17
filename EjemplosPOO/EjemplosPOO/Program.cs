using System;




namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(1.45);

            Console.WriteLine( obj.convierte(50));

        }

    }

    class Circulo
    {

        private const double pi = 3.1416;   //propiedad de la clase circulo.Campo de clase.

        public double CarculoArea (int radio)  // metodo de clase. que puede hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {

        private double euro = 63.28;

        public double convierte(double cantidad)
        {
            return cantidad * euro; 
        }

        public void CambiaValorEuro(double NuevoValor)
        {
            if (NuevoValor < 0) euro = 1.253;

            else euro = NuevoValor;


        }


    }





}
