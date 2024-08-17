using System;
using System.Collections.Generic;
using System.Text;

namespace ConcectoPoo
{
    class Punto
    {

        public Punto( int x, int y)
        {

            this.x = x;

            this.y = y;

            contadorDeObjectos++;
        }

        public Punto()
        {

            this.x = 0;

            this.y = 0;

            contadorDeObjectos++;
        }

        public double DistanciaHasta(Punto OtroPunto)
        {

            int xDif = this.x - OtroPunto.x;

            int yDif = this.y - OtroPunto.y;

            double distaciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distaciaPuntos;

        }

        /*public static int ContadorDeObjectos()
        {

            return ContadorDeObjectos;
        }*/

        public static int ContadorDeObjectos() => contadorDeObjectos; 


        private int x, y;

        private static int contadorDeObjectos = 0;

        public const int ConstantePrueba = 7;


    }


}
