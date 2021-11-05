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
        int posicion = 0;
        //int cantidad = 0;
        
        
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
            Nombres[posicion] = TxtAgregar.Text;
            posicion = posicion + 1;
            TxtAgregar.Focus();
            TxtAgregar.SelectAll();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            LblLista.Text = "";
            LblLista.Text = "Lista de personas";

            foreach (string item in Nombres)
            {
                LblLista.Text = LblLista.Text+ item + "\r\n";
            }
        }
    }
}

