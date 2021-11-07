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


        public DataTable DG = new DataTable();

        
        //contructor de la clase persona
        public  Persona()
        {
            DG.TableName = "Lista de personas";
            DG.Columns.Add("Nombre y apellido");
            //DGgrid.Columns.Add("");
        }
    }
}


         
        



    






