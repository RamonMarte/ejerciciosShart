using System;


namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado Juan = new Empleado(" Juan ");

            Juan.SALARIO =  -1200;

          

            Console.WriteLine(" El salario del empleado es: " + Juan.SALARIO);
        }  
    }

    class Empleado
    {

        public Empleado(string nombre)
        {

            this.nombre = nombre;

        }

         /*public void setSalario(double Salario)
        {

            if (Salario < 0)
            {

                Console.WriteLine(" El salario no puede ser neativo. Se asignara 0 como salario ");

                this.Salario = 0;
            }
            else
            {

                this.Salario = Salario;
            }

        }

        public double Getsalario()
        {

            return Salario;
        }*/


        private double evaluoSalario(double Salario)
        {

            if (Salario < 0) return 0;



            else return Salario;
            

        }

        // CREACION DE PROPIEDAD


        public double SALARIO
        {

            get { return this.Salario; }

            set { this.Salario = evaluoSalario (value); }

        }

        private double Salario;

        private string nombre;

    }
}
