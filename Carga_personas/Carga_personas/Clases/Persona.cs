using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name Space - Ruta donde se encuentra el archivo
namespace Carga_personas
{
    //Sepone public a la clase para que se pueda ver en el formulario,
    //de lo contrario no se puede ver si no es publica
    public class Personas
    {
        public string Nombre { get; set; }
        public int AñoNacimiento { get; set; }
    }
}
