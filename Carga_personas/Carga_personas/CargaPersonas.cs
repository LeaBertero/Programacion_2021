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
        //public Persona[] personas { get; set; }
        //public Personas[] personas { get; set; } = new Personas[3];
        //public int Pos = -1;
        public ListaPersonas Lista { get; set; } = new ListaPersonas();

        public CargaPersonas()
        {
            InitializeComponent();
        }


        public void BtnCargar_Click(object sender, EventArgs e)
        {
            //Persona persona = new Persona();
            //persona.Nombre = TxtCargaPers.Text;
            ////Pos = Pos + 1;
            //Lista.Redimensionar();
            //Lista.personas[Lista.personas.Length -1] = persona;
            //persona.AñoNacimiento = System.Convert.ToInt32(TxtNacimiento.Text);
            //LblLista.Text = " ";
            if (!Lista.AddPersona(TxtCargaPers.Text, TxtNacimiento.Text))
            {
                TxtNacimiento.Text = "";
                TxtNacimiento.Focus();
                TxtNacimiento.SelectAll();
                LblLista.Text = "Persona no valida";
                
            }
            else 
            {
                TxtNacimiento.Text = "";
                TxtCargaPers.Text = "";
                TxtCargaPers.Focus();
                LblLista.Text = "Persona aceptada";
            }
        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            //LblLista.Text = "Lista de personas cargadas: \r\n";
            //foreach (Persona item in Lista.personas)
            //{
            //    LblLista.Text = LblLista.Text  +item.Nombre + " - " + item.AñoNacimiento + "\r\n";
            //}

            LblLista.Text = Lista.ToString();
        }

       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMostraFiltro_Click(object sender, EventArgs e)
        {
            LblLista.Text = Lista.ToString(
        }





        //private void Redimensionar()
        //{
        //    if (personas == null)
        //    {
        //        personas = new Persona[1];
        //    }
        //    else 
        //    {
        //        Persona[] arraux = new Persona[personas.Length + 1];

        //        for (int contador = 0; contador < personas.Length; contador++)
        //        {
        //            arraux[contador] = personas[contador];
        //        }
        //        personas = arraux;
        //    }
        //}

    }
}



       






        

