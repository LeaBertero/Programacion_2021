using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramacion
{
    public partial class Form_Carga : Form
    {
        //Carga de nombres (arreglo de carga  de 5 personas)
        //string[] nombres;
        //int pos = 0;

        public Persona[] Personas { get; set; } = new Persona[1];
        public int Pos  = -1;


        public Form_Carga()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Persona Persona = new Persona();
            Persona.Nombre = TxtNombre.Text;
            Persona.Apelllido = TxtApellido.Text;
            Persona.Dirección = TxtDirección.Text;
            Pos = Pos + 1;
            Persona.Documento = Convert.ToInt32 (TxtDocumento.Text);
            Personas[Pos] = Persona;

        }

        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            //int cant = Convert.ToInt32(TxtIngreso.Text);
            //nombres = new string[cant];
        }

        private void BtnMostrarLista_Click(object sender, EventArgs e)
        {

            LblMostrarLista.Text = " ";
            foreach (Persona item in Personas)
            {
                LblMostrarLista.Text = LblMostrarLista.Text + item.Nombre + item.Apelllido + item.Dirección + item.Documento + "\r\n";

            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDirección.Text = "";
            TxtDocumento.Text = "";
        }

        private void BtnCorregirNom_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
        }

        private void BtnCorregirAp_Click(object sender, EventArgs e)
        {
            TxtApellido.Text = "";
                
        }

        private void BtnCorregirDir_Click(object sender, EventArgs e)
        {
            TxtDirección.Text = "";
        }

        private void BtnCorregirDoc_Click(object sender, EventArgs e)
        {
            TxtDocumento.Text = "";
        }
    }
}
