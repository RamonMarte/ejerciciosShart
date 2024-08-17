using System;
using System.Runtime.InteropServices;


namespace UsoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Array implicito

            //var datos = new[] { "Ramon", "Marte", "Dominicana" }; 

            var Valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 85.2 }; //  Todo double

            // Arrays de Objetos

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arraysEmpleados = new Empleados[3];

            arraysEmpleados[0] = new Empleados("Rafael", 17);

            arraysEmpleados[1] = Ana;

            arraysEmpleados[2] = new Empleados("Manuel", 51);

            // Arrays de tipos o clases anonimas

            var Personas = new[]
            {

                new{Nombre = " Juan", Edad = 19},

                new {Nombre = "Maria", Edad = 49}, 

                new {Nombre = "Diana", Edad = 35}, 
            };

            /*for (int  i = 0; i<arraysEmpleados.Length; i++)
            {

                Console.WriteLine(arraysEmpleados[i].getInfo());
            }*/

            foreach(var Variables in Personas)
            {

                Console.WriteLine(Variables);
            }

        }
    }
            

    class Empleados 
    { 
    
        public Empleados (string Nombre, int Edad)
        {

            this.Nombre = Nombre;

            this.Edad = Edad;

        }

        public string getInfo()
        {

            return " Nombre del empreado: " + Nombre + " Edad " + Edad;
        }
        private string Nombre;

         private int Edad;


        
    }

    
    
}


