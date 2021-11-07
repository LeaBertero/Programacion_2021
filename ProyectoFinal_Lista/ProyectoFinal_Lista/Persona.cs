using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Lista
{
    public class Persona
    {
        public string NombreYapellido { get; set; }
        //public int Edad { get; set; }

        //Hago nacer una nueva persona
        public Persona persona { get; set; } = new Persona();

        //hago nacer el datatable
        public DataTable DG { get; set; } = new DataTable();


        //constructor de la clase persona
        public  Persona()
        {
            //Nombres de las filas y columnas del data table
            DG.TableName = "Lista de personas";
            DG.Columns.Add("Nombre y apellido");
            
            

        }
    }
}


         
        



    






