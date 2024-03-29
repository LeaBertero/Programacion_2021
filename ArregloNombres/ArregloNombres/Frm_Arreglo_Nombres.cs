﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloNombres
{
    public partial class Frm_Arreglo_Nombres : Form
    {
        //Variable publica  - se ve en todo el programa

        string[] Lista;
        int Pos = 0;
        
        //Constructor del formulario
        public Frm_Arreglo_Nombres()
        {
            InitializeComponent();
            BtnCargar.Enabled = false;
            BtnListar.Enabled = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Lista[Pos] = TxtCargar.Text;
                Pos = Pos + 1;

                //LblLista.Text = LblLista.Text + TxtCargar.Text + "\r\n";

                TxtCargar.Text = "";
                TxtCargar.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible seguir cargando");
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

            //MostraLista = cantidad de personas ingresadas que se van a mostrar en la lista
            for (int VerLista = 0; VerLista < Lista.Length; VerLista ++)
            {
                LbListaPers.Text = LbListaPers.Text + Lista[VerLista] + "\r\n";
                
            }
           
        }

        private void BtnDimensionar_Click(object sender, EventArgs e)
        {
            Lista = new string[System.Convert.ToInt32(TxtDimensionar.Text)];
            Pos = 0;
            BtnCargar.Enabled = true;
            BtnListar.Enabled = true;
        }

        private void BtnNewProgram_Click(object sender, EventArgs e)
        {
            Lista_productos nuevoform = new Lista_productos();
            nuevoform.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Arreglo_Nombres nuevoform = new Frm_Arreglo_Nombres();
            nuevoform.Show();
        }
    }
}




                




       


       
