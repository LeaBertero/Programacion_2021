using ProyectoFinalPrg.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoFinalPrg
{
    public partial class FinalPrg : Form
    {
        //Propiedades
        public Persona[] Personas { get; set; } = new Persona[1];


        public FinalPrg()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Botón salir (Método)
            Close();
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            Persona Persona = new Persona();
            Persona.Nombre = TxtIngreso.Text;
            Personas[0] = Persona;
            
        }

        private void BtnClickLista_Click(object sender, EventArgs e)
        {

            LblMostrarLista.Text = "Lista: \r\n";
            foreach (Persona item in Personas)
            {
                LblMostrarLista.Text = LblMostrarLista.Text + item.Nombre + "\r\n";
            }
        }
    }
}
