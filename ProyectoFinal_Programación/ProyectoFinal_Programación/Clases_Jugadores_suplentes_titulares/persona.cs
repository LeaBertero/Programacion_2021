using System;

namespace ProyectoFinal_Programación
{
    public class persona
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
