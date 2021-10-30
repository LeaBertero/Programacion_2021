using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga_personas
{
    public partial class CargaPersonas : Form
    {
        //Se declara una propiedad persona como entero
        public Persona[] personas { get; set; } = new Persona[1];

        public CargaPersonas()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = TxtCargaPers.Text;
            personas[0] = persona;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            LblLista.Text = "Lista: \r\n";
            foreach (Persona item in personas)
            {
                LblLista.Text = LblLista.Text + item.Nombre + "\r\n";
            }

        }
    }
}
