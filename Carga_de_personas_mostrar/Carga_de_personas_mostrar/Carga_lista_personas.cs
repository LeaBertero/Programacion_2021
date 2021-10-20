using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga_de_personas_mostrar
{
    
    public partial class Carga_lista_personas : Form
    {
        //VARIABLES PUBLICAS

        //string[] nombres = new string[1000]; 
        string[] nombres ;
        int posicion = 0;

        public Carga_lista_personas()
        {
            InitializeComponent();
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            nombres[posicion] = TxtCargaNombre.Text;
            posicion = posicion + 1;
            TxtCargaNombre.Focus();
            TxtCargaNombre.SelectAll();
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            

            LbllistaMostrar.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtDimensionar_Click(object sender, EventArgs e)
        {
            int Cantidad = System.Convert.ToInt32(TxtDimension.Text);
            nombres = new string[Cantidad];
        }

        private void Carga_lista_personas_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLimpiar1_Click(object sender, EventArgs e)
        {
            TxtDimension.Text = " ";
        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            TxtCargaNombre.Text = " ";
        }
    }
}

        



        

    
    

    
