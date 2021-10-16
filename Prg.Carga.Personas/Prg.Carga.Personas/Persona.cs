using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg.Carga.Personas
{
    public class Persona
    {
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }

        public Materia MateriaCursando { get; set; } = new Materia();
        public string NombreCompleto()
        {
            return Nombre + ", " + Apellido;
        }

        public string NombreCompletoConMateria()
        {
            string NCCM = "";
            NCCM = NombreCompletoConMateria() 
                + "\r\n" + MateriaCursando.Nombre 
                + " - " + MateriaCursando.Año.ToString();
            return NCCM;
        }
        public void Inscribir(Materia materia) 
        {
            MateriaCursando = materia;
        }
    }
}


        



