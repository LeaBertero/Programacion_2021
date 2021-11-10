using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion
{

    public class ListaPersonas
    {
        public Persona[] Personas { get; set; }

        //Se puso publico para que lo pueda ver al metodo el boton del fronend
        public void Redimensionar()
        {
            if (Personas == null)
            {

                Personas = new Persona[1];

            }
            else
            {
                Persona[] ArregloAux = new Persona[Personas.Length + 1];
                for (int Contador = 0; Contador < Personas.Length; Contador++)
                {

                    ArregloAux[Contador] = Personas[Contador];

                }

                Personas = ArregloAux;
            }

        }

        public void AddPersona(string Nombre, string Año, string Apellido, string Direccion, string Documento) 
        {
            Persona Persona = new Persona();
            
            Persona.Nombre = Nombre;
            
            Persona.Apelllido = Apellido;
            
            Redimensionar();
            
            Persona.Dirección = Direccion;
            

            Persona.Documento = Convert.ToInt32(Documento);
            

            Personas[Personas.Length - 1] = Persona;

        }

    }
}
