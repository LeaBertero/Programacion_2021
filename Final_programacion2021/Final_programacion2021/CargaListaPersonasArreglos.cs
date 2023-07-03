using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_programacion2021
{
    public partial class CargaListaPersonasArreglos : Form
    {
        //Inicializo la variable nombres
        string[] Nombres;
        int posicion = 0;
        int cantidad = 0;
        
        public CargaListaPersonasArreglos()
        {
            InitializeComponent();
        }
        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            
            cantidad = Convert.ToInt16(TxtCarga.Text);
            Nombres = new string[cantidad];
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            Nombres[posicion] = TxtCarga.Text;
            posicion = posicion + 1;

            TxtCarga.Focus();
            TxtCarga.SelectAll();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LblLista.Text = "";
            foreach (string item in Nombres)
            {
                LblLista.Text = LblLista.Text + item + "\r\n";
            }
        }
    }

   
}
