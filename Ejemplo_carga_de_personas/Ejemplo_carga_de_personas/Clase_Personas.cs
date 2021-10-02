using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_carga_de_personas
{
    public partial class Clase_Personas : Form
    {
        public Clase_Personas()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Persona PersonaAmostrar;
            PersonaAmostrar = new Persona();
        }
    }
}
