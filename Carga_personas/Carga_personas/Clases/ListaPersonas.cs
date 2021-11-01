using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_personas
{
    public class ListaPersonas
    {
        public Persona[] personas { get; set; }

        public void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Persona[1];
            }
            else
            {
                Persona[] arraux = new Persona[personas.Length + 1];

                for (int contador = 0; contador < personas.Length; contador++)
                {
                    arraux[contador] = personas[contador];
                }
                personas = arraux;
            }
        }

        public bool AddPersona(string nombre, string Año)
        {
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.AñoNacimiento = System.Convert.ToInt32(Año);
             
            bool Resp = persona.Validar();

            if (Resp)
            {
                Redimensionar();
                personas[personas.Length - 1] = persona;
            }

            return Resp;
        }

        //override es para reempleza el tostring por defecto de la conversion que viene en el programa (C#)
        public  string ToStringFiltrado(int añominimo )
        {
            string Resp = "";

            Resp = "Lista: \r\n";

            foreach (Persona item in personas)
            {
                if (item.AñoNacimiento >= añominimo)
                {
                    Resp = Resp + item.AñoNacimiento.ToString() + " - " + item.Nombre + "\r\n";
                }
                
            }

            return Resp;
        }
    }
}






        
