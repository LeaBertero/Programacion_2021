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
            nombres[posicion] = TxtIngresoPers.Text;
            posicion = posicion + 1;
            TxtIngresoPers.Focus();
            TxtIngresoPers.SelectAll();
        }
            

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
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
            int cantidad = System.Convert.ToInt32(TxtCarga.Text);
            nombres = new string[cantidad];
            LblCargaFinalizada.Text = "Dimension aceptada";
        }

            

        private void BtnMostrarTitulo1_Click(object sender, EventArgs e)
        {
            LblTituloDim.Visible = true;
        }

        private void BtnMostrarTitulo2_Click(object sender, EventArgs e)
        {
            LblCargaNombres.Visible = true;
        }
    }
}
