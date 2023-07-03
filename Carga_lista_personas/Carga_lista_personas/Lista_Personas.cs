using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga_lista_personas
{
    public partial class Lista_Personas : Form
    {

        public Lista_Personas()
        {
            InitializeComponent();
        }

        //string[] nombres = new string[100];
        string[] nombres;
        int posicion = 0;

        public void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                nombres[posicion] = TxtIngresoPers.Text;
                posicion = posicion + 1;
                TxtIngresoPers.Focus();
                TxtIngresoPers.SelectAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible seguir cargando");
            }
        }

            

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblLista.Text = "";
            foreach (var item in nombres)
            {
                LblLista.Text = LblLista.Text + item + "\r\n";
            }
        }

                

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    int cantidad = System.Convert.ToInt32(TxtCarga.Text);
                    nombres = new string[cantidad];
                    //LblCargaFinalizada.Text = "Dimension aceptada";
                    MessageBox.Show("Dimension aceptada");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor");
            }
        }

        private void BtnMostrarTitulo1_Click(object sender, EventArgs e)
        {
            LblTituloDim.Visible = true;
        }

        private void BtnMostrarTitulo2_Click(object sender, EventArgs e)
        {
            LblCargaNombres.Visible = true;
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxtCarga.Text = null;
            TxtIngresoPers.Text = null;
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            LblLista.Text = "";
        }
    }
}



            

