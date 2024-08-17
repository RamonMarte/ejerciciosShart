using System;
using System.IO;

namespace destrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.Mensaje();
        }
    }

    class ManejoArchivos
    {

        StreamReader Archivo = null;

        int Contador = 0;

        string Linea;

        public ManejoArchivos()
        {

            Archivo = new StreamReader(@"C:\Rafa.txt");

            while((Linea = Archivo.ReadLine()) != null)
            {

                Console.WriteLine(Linea);

                Contador++;
            }
        }

        public void Mensaje()
        {

            Console.WriteLine(" Hay {0} lineas ", Contador);
        }

        ~ManejoArchivos()
        {

            Archivo.Close();
        }
    }
}
