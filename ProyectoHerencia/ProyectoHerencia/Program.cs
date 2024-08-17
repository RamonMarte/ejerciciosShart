using System;



namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Caballo miBabieca = new Caballo("Babieca");

             ISaltosConpatas IMiBabieca = miBabieca;

             Humanos miJuan = new Humanos("Juan");

             Gorila miCopito = new Gorila("Copito");


             Mamiferos animal = new Mamiferos("Bucefalo");

             Caballo Bucefalo = new Caballo("Bucefalo");


             Mamiferos[] AlmacenAnimales = new Mamiferos[3];

             AlmacenAnimales[0] = miBabieca;
             AlmacenAnimales[1] = miJuan;
             AlmacenAnimales[2] = miCopito;

             for (int i = 0; i<3; i++)
             {

                 AlmacenAnimales[i].Pensar();
             }

             Mamiferos miMamifero = new Mamiferos(" ");

             /* miJuan.getNombre();
              miBabieca.getNombre();
              miCopito.getNombre();*/


            /*Ballena miBallena = new Ballena("miBallena");

            miBallena.nadar();

            Console.WriteLine(" Patas utilizadas en el salto de bavieca: " + IMiBabieca.NumeroPatas());*/

            Lagartija miLagartija = new Lagartija("Juancho");

            miLagartija.GetNombre();

            Humanos miHumano = new Humanos("Juan");

            miHumano.GetNombre();
        }
    }

    interface IMamiferosTerrestres
    {

        int NumeroPatas();
    }

    interface IAnimelesYDeportes
    {

        string TipoDeportes();

        Boolean EsOlinpico();
    }

    interface ISaltosConpatas
    {

        int NumeroPatas();
    }

    abstract class Animales
    {

        public void Respirar()
        {

            Console.WriteLine("soy capaz de respirar");
        }

        public abstract void GetNombre();
    }

    class Lagartija : Animales
    {

        public Lagartija(string Nombre)
        {

            nombreReptil = Nombre;
        }

        public override void GetNombre()
        {

            Console.WriteLine("El nomdre del reptil es: " + nombreReptil);
        }

        private string nombreReptil;
    }

    class Mamiferos : Animales
    {

        public Mamiferos(string nombre)
        {

            nombreServivo = nombre;
        }

        public virtual void Pensar()
        {

            Console.WriteLine("Pensamineto basico instintivo");
        }

        public void cuidarCrias()
        {

            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public override void GetNombre()
        {

            Console.WriteLine("El nomdre del ser vivo es: " + nombreServivo);
        }

       

        private string nombreServivo;
    }

    class Ballena : Mamiferos
    {

        public Ballena(string nombreBallena) : base(nombreBallena)
        { 
        
        
        }
        
        public void nadar()
        {

            Console.WriteLine(" Soy capaz de nadar ");
        }
    }

    class Caballo: Mamiferos, IMamiferosTerrestres, IAnimelesYDeportes, ISaltosConpatas
    {
     
        int ISaltosConpatas.NumeroPatas()
        {

            return 2;

        }
     

        public string TipoDeportes()
        {

            return " Hipica ";
        }

        public Boolean EsOlinpico()
        {

            return true;
        }

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {


        }

        public void galopar()
        {

            Console.WriteLine(" Soy capaz de galopar ");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {

            return 4;
        }
    }

    class Humanos : Mamiferos
    {

        public Humanos (string nombreHumanos) : base(nombreHumanos)
        {


        }

        public override void Pensar()
        {

            Console.WriteLine("Soy capaz de penzar ");
        }

    }

    class Adolescentes : Humanos
    {

        public Adolescentes (string nombreAdolecentes) : base(nombreAdolecentes)
        {

           
        }

        public override void Pensar()
        {

            Console.WriteLine(" laas hormonas me inpiden pensar cobn claridad ");
        }
    }

     class Gorila : Mamiferos, IMamiferosTerrestres
    {

        public int NumeroPatas()
        {

            return 2;
        }

        public Gorila(string nombreGorilas) : base(nombreGorilas)
        {


        }

        public override void Pensar()
        {

            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void Trepar()
        {

            Console.WriteLine("Soy capaz de trepar ");
        }




    }

    
         
}



