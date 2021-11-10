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
    public partial class BtnCodigo : Form
    {
       // Instanciando e inicializando la clase lista persona
        public ListaPersonas Lista { get; set; } = new ListaPersonas();
       

        //Constructor
        public BtnCodigo()
        {
            InitializeComponent();

            DG.DataSource = Lista.DT;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            
            TxtNombre.Focus();
            TxtNombre.SelectAll();
            
            TxtApellido.Focus();
            TxtApellido.SelectAll();
           
            TxtDocumento.Focus();
            TxtDocumento.SelectAll();
            
            Lista.AddPersona(TxtNombre.Text, TxtApellido.Text, TxtDirección.Text, TxtDocumento.Text);
           
        }
        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            //int cant = Convert.ToInt32(TxtIngreso.Text);
            //nombres = new string[cant];
        }
            
            
            
        private void BtnMostrarLista_Click(object sender, EventArgs e)
        {

            LblMostrarLista.Text = " ";
            foreach (Persona item in Lista.Personas)
            {
                LblMostrarLista.Text = LblMostrarLista.Text 
                    + item.Nombre + " - " 
                    + item.Apelllido + " - " 
                    + item.Dirección + " - " 
                    + item.Documento 
                    + "\r\n";
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

        private void Redimensionar()
        {
            if (Lista.Personas == null)
            {

                Lista.Personas = new Persona[1];

            }
            else
            {
                Persona[] ArregloAux = new Persona[Lista.Personas.Length + 1];
                for (int Contador = 0; Contador < Lista.Personas.Length; Contador++)
                {

                    ArregloAux[Contador] = Lista.Personas[Contador];

                }

                Lista.Personas = ArregloAux;
            }

        }

       
    }
}
