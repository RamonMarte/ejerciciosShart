using System;


namespace Structs_y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Empledo Juan = new Empledo(Bonus.Normal, 1900.90);

            Console.WriteLine(" El salario del empleado es " + Juan.GetSalario());



        }
    }

    class Empledo
    {
        public Empledo (Bonus BonusEmpleado, double Salario)
        {

            this.BonusEmpleado = BonusEmpleado;

            this.Salario = Salario;
        }

        public double GetSalario()
        {

            return Salario + (double) BonusEmpleado;
        }

        private double Salario;

        private Bonus  BonusEmpleado;
    }

    enum Bonus { Bajo=500, Normal=1000, Bueno=1500, Extra=3000};

}
