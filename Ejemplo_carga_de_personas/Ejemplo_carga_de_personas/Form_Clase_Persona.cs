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
    public partial class Clase_Persona : Form
    {

        Persona PersonaAmostrar = new Persona();

        public Clase_Persona()
        {
            InitializeComponent();

        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            //Persona PersonaAmostrar;
            //PersonaAmostrar = new Persona();

            

            PersonaAmostrar.Nombre = TxtNombre.Text;
            PersonaAmostrar.Apellido = TxtApellido.Text;

            //LblMostrar.Text = System.Convert.ToString(TxtNombre.Text) + " " + System.Convert.ToString(TxtApellido.Text);

            //LblMostrar.Text = PersonaAmostrar.Nombre + " " + PersonaAmostrar.Apellido;

            LblMostrar.Text = PersonaAmostrar.NombreCompleto();
            PersonaAmostrar = null;

            PersonaAmostrar = new Persona();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            Materia inscrpionMateria = new Materia();
            inscrpionMateria.Nombre = TxtNombMateria.Text;

            inscrpionMateria.Año = System.Convert.ToInt32(TxtAño.Text);

            PersonaAmostrar.MateriaCursando = inscrpionMateria;


            LblInscripcion.Text = PersonaAmostrar.MateriaCursando + "Año" 
                + PersonaAmostrar.MateriaCursando.Año.ToString();
         }
    }
}
