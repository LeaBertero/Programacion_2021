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
    public partial class CargaListaPersonas : Form
    {
        //Inicializo la variable nombres
        string[] Nombres;
        int pos = 0;
        
        public CargaListaPersonas()
        {
            InitializeComponent();
        }
        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            
            int cant = Convert.ToInt32(TxtCarga.Text);
            Nombres = new string[cant];
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            Nombres[pos] = TxtCarga.Text ;
            pos = pos + 1;

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
