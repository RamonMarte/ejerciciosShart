using System;
using System.Collections.Generic;
using System.Text;


namespace avisosVarios
{
    class AvisosTrafico : IAvisos
    {

        public AvisosTrafico()
        {

            Remitente = " DGT ";

            Mensaje = " Sancion cometida. Page antes de 3 dias y se veneficiara de una reducion del 50% ";

            fecha = " ";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.Remitente = remitente;
            this.Mensaje = mensaje;
            this.fecha = fecha;
        }

        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAvisos()
        {
            Console.WriteLine(" Mensajes {0} ha sido enviado por {1} el dis {2} ", Mensaje, Remitente, fecha);
        }

        private string Remitente;

        private string Mensaje;

        private string fecha;
    }
}
