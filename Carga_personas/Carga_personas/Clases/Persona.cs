using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_personas
{
    public class Persona
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
