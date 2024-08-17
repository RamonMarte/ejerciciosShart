using System;

namespace UsoCoche
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Coches coche1 = new Coches(); //crear objetos/instancia de tipo coche. Dar un estado inicial a nuestro coche

            Coches coche2 = new Coches();

            Console.WriteLine(coche1.GetInfoCoche());
            Console.WriteLine(coche2.GetInfoCoche());

            Coches coche3 = new Coches( 4500.25, 1200.35);

            Console.WriteLine(coche3.GetInfoCoche());

            coche3.SetExtras(true, "Cuero");

            Console.WriteLine(coche3.getExtras());

        }
    }

    partial class Coches
    {

        public Coches()
        {

            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            tapiceria = " Tela ";
        }

        public Coches(double LargoCoche, double AnchoCoche)
        {
            ruedas = 4;

            largo = LargoCoche;

            ancho = AnchoCoche;

            tapiceria = " Tela ";

        }

    }

    partial class Coches
    { 

        public string GetInfoCoche()
        { 
            return "Informacion del coche:\n " + " ruedas " + ruedas + " largo " + largo + " ancho " + ancho;
        }

        public void  SetExtras(bool Climatizador, string Tapiceria)
        {

            this.climatizeria = Climatizador;

            this.tapiceria = Tapiceria;
        }

        public string getExtras()
        {

            return " Extras del coche; \n" + " Tapicaria: " + tapiceria + " Climatizador " + climatizeria;

        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizeria;

        private string tapiceria;


    }


}
