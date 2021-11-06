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

        public Persona[] personas { get; set; } = new Persona[1];
        public Pr_final()
        {
            InitializeComponent();
        }

        public void BtnDim_Click(object sender, EventArgs e)
        {
            int cantidad = System.Convert.ToInt32(TxtDim.Text);
            Nombres = new string[cantidad];

           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nombres[posicion1] = TxtAgregar.Text;
            posicion1 = posicion1 + 1;
            TxtAgregar.Focus();
            TxtAgregar.SelectAll();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblLista.Text = "";
            //LblLista.Text = "Lista de personas";

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

            LblLista2.Text = "Lista: \r\n";

            foreach (Persona item in personas)
            {
                LblLista2.Text = LblLista2.Text + item.Nombre + "\r\n";


            }
        }
    }
}

