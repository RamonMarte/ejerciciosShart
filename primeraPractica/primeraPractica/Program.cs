using System;


namespace primeraPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("El avion va a arrancar");

            Avion miAvion = new Avion();

            miAvion.arracarMotor();

            miAvion.Volar();

            miAvion.conducir();

            miAvion.pararMotor();


            Console.WriteLine();


            Console.WriteLine("En cendiendo el coche");

            Coche miCoche = new Coche();

            miCoche.arracarMotor();

            miCoche.acelera();

            miCoche.conducir();

            miCoche.Frenal();
             
            miCoche.pararMotor();

            miCoche.Mecanico();

            Console.WriteLine();

            Console.WriteLine("Polimolfismo en accion");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.conducir();

            miVehiculo = miAvion;

            miVehiculo.conducir();
        }

    }


    class Vehiculo
    { 
    
        public void arracarMotor()
        {

            Console.WriteLine("En ciende el motor para arrancar");
        }

        public void pararMotor()
        {

            Console.WriteLine("Apagando el motor");
        }

        public virtual void conducir()
        {

            Console.WriteLine("conduce el vehiculo");
        }
    }


    class Avion : Vehiculo
    {
    
        public void Volar()
        {

            Console.WriteLine("El avion vuela alto");
        }

        public override void conducir()
        {
            // base.conducir();

            Console.WriteLine("Pilotando el avion");
        }

    }


    class Coche :Vehiculo
    {
    
    
        public void acelera()
        {

            Console.WriteLine(" El coche esta acelerando");
        }

        public override void conducir()
        {
            // base.conducir();

            Console.WriteLine("Toma la culba con desicion y destreza");
        }

        public void Frenal()
        {

            Console.WriteLine(" El coche esta a punto de frenal");
        }

        public void Mecanico()
        {

            Console.WriteLine(" mi coche es mecanico y automatico ");

        }
    

    }
}
