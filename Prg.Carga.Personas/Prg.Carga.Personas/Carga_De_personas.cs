using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Prg.Carga.Personas
{
    public partial class Carga_De_personas : Form
    {
        //MÉTODO PÚBLICO
        Persona personaAmostrar = new Persona();

        public Carga_De_personas()
        {
            InitializeComponent();
        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            //esto es aparecer un objeto (Instanciar)
            //es lo mismo que llama a un formulario de otro formulario

            //Persona personaAmostrar;


            personaAmostrar.Nombre = TxtNombre.Text;
            personaAmostrar.Apellido = TxtApellido.Text;

            //LblPersonas.Text = personaAmostrar.Nombre 
            //    + " " 
            //    + personaAmostrar.Apellido;

            LblPersonas.Text = personaAmostrar.NombreCompleto();

            personaAmostrar = null;
            personaAmostrar = new Persona();

        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            Materia MateriaInscripta = new Materia();
            MateriaInscripta.Nombre = TxtNombreMateria.Text;
            MateriaInscripta.Año = System.Convert.ToInt32(TxtAño.Text);


            personaAmostrar.MateriaCursando = MateriaInscripta;
            //personaAmostrar.Inscribir(MateriaInscripta);

            //personaAmostrar.MateriaCursando = MateriaInscripta;
            
            personaAmostrar.Inscribir(MateriaInscripta);

            LblMostrarInscripcion.Text = personaAmostrar.MateriaCursando.Nombre 
                + " Año "
                + personaAmostrar.MateriaCursando.Año.ToString();
        }
    }
}







      

        
