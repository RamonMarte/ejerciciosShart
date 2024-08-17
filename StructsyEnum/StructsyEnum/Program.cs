using System;

namespace StructsyEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado Empleado1 = new Empleado(1200,250);

            Empleado1.CambiaSalario(Empleado1, 100);

            Console.WriteLine(Empleado1);



        }
    }


    public struct Empleado
    {

        public double SalarioBase, Comision;

        public Empleado(int SalarioBase, int Comision)
        {

            this.SalarioBase = SalarioBase;

            this.Comision = Comision;
        }

        public override string ToString()
        {
            return string.Format(" Salario y comision del empleado ({0},{1}) ", this.SalarioBase, this.Comision);
        }


        public void CambiaSalario(Empleado Emp, double Incremento)
        {

            Emp.SalarioBase += Incremento;

            Emp.Comision += Incremento;
        }
    }






}

