using System;


namespace Generico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            almacenObgetos<DateTime> Archivo = new almacenObgetos<DateTime>(4);

             /*Archivo.Agregar(" Juan ");

             Archivo.Agregar(" Rafiki ");

             Archivo.Agregar(" Juana ");

             Archivo.Agregar(" Julian ");*/

            Archivo.Agregar (new DateTime());

            Archivo.Agregar(new DateTime());

            Archivo.Agregar(new DateTime());

            Archivo.Agregar(new DateTime());

            DateTime NomdrePersona =  Archivo.GetElementos(2);

            Console.WriteLine(NomdrePersona);
        }
    }

    class almacenObgetos<T>
    {

        public almacenObgetos(int z)
        {

            DatosElementos = new T [z];

        }

        public void Agregar( T obj)
        {

            DatosElementos[i] = obj;

            i++;

        }

        public  T GetElementos(int i)
        {

            return DatosElementos[i];
        }

        private T [] DatosElementos;

        private int i = 0;

    }

    class Empleado
    {

        public Empleado(double Salario)
        {

            this.Salario = Salario;
               
        }

        public double GetSalario()
        {

            return Salario;

        }

        private double Salario;
    }
}
