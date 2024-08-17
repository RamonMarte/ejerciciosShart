using System;



namespace avisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico Av1 = new AvisosTrafico();

            Av1.MostrarAvisos();

            AvisosTrafico Av2 = new AvisosTrafico(" Jefatura Provincial Madrid  ", " Sancion de velocidad: 300$ ", "30-07-24 " );

            Console.WriteLine( Av2.GetFecha());

            Av2.MostrarAvisos();
        }
    }
}
