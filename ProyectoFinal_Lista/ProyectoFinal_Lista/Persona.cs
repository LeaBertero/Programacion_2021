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
        public int AñodeNaciemiento { get; set; }
        public int Edad  { get; set; }


        public DataTable DGdate = new DataTable();

        public Persona()
        {
            DGdate.TableName = "Lista de personas";
            DGdate.Columns.Add("Nombre y apellido");
        }
    }

    
}






