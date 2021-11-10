using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion
{

    public class ListaPersonas
    {
        public Persona[] Personas { get; set; }


        public ListaPersonas()
        {
            DT.TableName = "Lista de personas";
            DT.Columns.Add("Nombre");
            DT.Columns.Add("Apellido");
            DT.Columns.Add("Direccion");
            DT.Columns.Add("Documento");

            LeerDTdeArchivos();

        }

        public void LeerDTdeArchivos() 
        {
            if (System.IO.File.Exists("Lista.xml"))
            {
                DT.Clear();
                DT.ReadXml("Lista.xml");

            }
        }




        public DataTable DT = new DataTable();



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

        public void AddPersona(string Nombre,string Apellido, string Direccion, string Documento) 
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
