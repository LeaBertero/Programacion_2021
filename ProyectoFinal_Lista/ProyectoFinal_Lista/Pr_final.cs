using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Lista
{
    public partial class Pr_final : Form
    {
        //Propiedades
        string[] Nombres;
        int posicion1 = 0;
        int pos2 = -1;

        public Persona[] personas { get; set; } = new Persona[5];
        public Pr_final()
        {
            InitializeComponent();
        }

        public void BtnDim_Click(object sender, EventArgs e)
        {
            int cantidad = System.Convert.ToInt32(TxtDim.Text);
            Nombres = new string[cantidad];

           
        }

        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nombres[posicion1] = TxtNombre.Text;
            posicion1 = posicion1 + 1;
            //Redimensionar(); //Comentar por cualquier cosa que ocurra
            TxtNombre.Focus();
            TxtNombre.SelectAll();
            //personas[personas.Length] = Persona;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
           

            LblLista.Text = "Lista principal: \r\n";
            foreach (string item in Nombres)
            {
                LblLista.Text = LblLista.Text + item + "\r\n";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCargar2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            pos2 = pos2 + 1;
            persona.Nombre = TxtCarga2.Text;
            
            personas[pos2] = persona;
            
            
        }

        private void BtnMostrar2_Click(object sender, EventArgs e)
        {

            LblLista2.Text = "Lista extra: \r\n";

            foreach (Persona item in personas)
            {
                LblLista2.Text = LblLista2.Text + item.Nombre + "\r\n";


            }
        }

        //private void Redimensionar()
        //{
        //    if (personas == null)
        //    {
        //        personas = new Persona[0];
        //    }
        //    else
        //    {
        //        Persona[] arraux = new Persona[personas.Length + 1];

        //        for (int contador = 0; contador <= personas.Length; contador++)
        //        {

        //            arraux[contador] = personas[contador];
        //        }
        //        personas = arraux;

        //    }
        //}
    }
}

