using System;


namespace GenericoRestrincciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Estudiantes> Empleados = new AlmacenEmpleados<Estudiantes>(3);

            Empleados.AgreGar(new Estudiantes(4500));

            Empleados.AgreGar(new Estudiantes(1500));

            Empleados.AgreGar(new Estudiantes(2500));
        }
    }

    class AlmacenEmpleados<T> where T : IParaEmpleado
    {

        public AlmacenEmpleados(int z)
        {

            DatosEmpleado = new T[z];
        }

        public void AgreGar( T obj)
        {

            DatosEmpleado[i] = obj;

            i++;
        }

        public T GetEmpleado(int i)
        {

            return DatosEmpleado[i];
        }

        private int i = 0;

        private T[] DatosEmpleado;

    }






    class Director : IParaEmpleado
    {

        public  Director(double Salario)
        {

            this.Salario = Salario;

        }

        private double Salario;

        double IParaEmpleado.GetSalario()
        {
            return Salario;
        }
    }


    class Secretario : IParaEmpleado
    {

        public Secretario(double Salario)
        {

            this.Salario = Salario;

        }

        private double Salario;

        double IParaEmpleado.GetSalario()
        {
            return Salario;
        }

    }


    class Electricista : IParaEmpleado
    {

        public Electricista(double Salario)
        {

            this.Salario = Salario;

        }

        private double Salario;

        double IParaEmpleado.GetSalario()
        {
            return Salario;
        }

    }

    class Estudiantes
    {
        public Estudiantes( double edad)
        {

            this.edad = edad;
        }

        public double  GetEdad()
        {

            return edad;
        }

        private double edad;
    }


    interface IParaEmpleado
    {

        double GetSalario();
        


        
    }
}
