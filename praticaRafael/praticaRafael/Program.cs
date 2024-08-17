using System;
using System.Diagnostics.Eventing.Reader;



namespace praticaRafael
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bamos ver si la casa le pertenece");

            Console.WriteLine("¿por favor introdusca el codigo de dos digitos?");

            int codio = int.Parse(Console.ReadLine());

            Console.WriteLine("¿cuantos autos tiene usted?");

            int autos = int.Parse(Console.ReadLine());

            Console.WriteLine("tienes una llave");

            string llave = Console.ReadLine();

            if (codio == 28 && autos == 5)
            

                Console.WriteLine("la casa le pertenece");

                else

                    Console.WriteLine("lo ciento la casa no le pertenece");


            









        }



            











        
    }
}
