using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaPersonasV2
{
    public partial class FormCargaPersonas : Form
    {
        public FormCargaPersonas()
        {
            InitializeComponent();
        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            Persona PersonaAmostrar = new Persona();

            PersonaAmostrar.Nombre = TxtNombre.Text;
            PersonaAmostrar.Apellido = TxtApellido.Text;


            LblMostrar.Text = PersonaAmostrar.NombreCompleto();

            //PersonaAmostrar.Nombre + ", " + PersonaAmostrar.Apellido

            //PersonaAmostrar = null;
            //PersonaAmostrar = new Persona();



        }

        public void BtnInscribir_Click(object sender, EventArgs e)
        {
            Materia MateriaInscripta = new Materia();
            MateriaInscripta.Nombre = TxtMateria.Text;
            MateriaInscripta.Año = System.Convert.ToInt32(TxtAño.Text);
        }
    }
}
