using System;

namespace ProyectoFinalPrg.Clases
{
    public class Jugador
    {

        public string Nombre { get; set; }

        public int AñoNacimiento { get; set; }

        public bool Validar() 
        {
            bool resp = false;

            if (AñoNacimiento > 1900 && AñoNacimiento <= DateTime.Now.Year)
            {
                resp = true;   
            }

            return resp;
        }
    }
}

       
