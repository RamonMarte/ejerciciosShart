using System;
 


namespace ejemploFinallyAlchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {

                string linea;

                int contador = 0;

                string path = @"C:\Users\marte\Desktop\Rafiki.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {

                    Console.WriteLine(linea);

                    contador++;


                }


            }
            catch (Exception e)
            {

                Console.WriteLine("Error con la letura del archivo");

            }
            finally
            {


                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexion con el fichero cerrada");


            }
        }
    }
}
