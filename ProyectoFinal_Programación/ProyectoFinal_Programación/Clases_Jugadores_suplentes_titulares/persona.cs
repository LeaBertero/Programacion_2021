using System;

namespace ProyectoFinal_Programación
{
    public class persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public bool Validar() 
        {
            bool resp = false;

            if (Edad > 16 && Edad <= 30)
            {
                resp = true;
            }
            return resp;
        }
    }
}
