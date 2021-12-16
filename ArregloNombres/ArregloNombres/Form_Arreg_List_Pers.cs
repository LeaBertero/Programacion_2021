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
    public partial class Form_Arreg_List_Pers : Form
    {
        //Variable publica  - se ve en todo el programa

        string[] Lista = new string[5];
        int Posicion = 0;
        


        //Constructor del formulario
        public Form_Arreg_List_Pers()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Lista[Posicion] = TxtCargar.Text;
            Posicion = Posicion + 1;

            //LblLista.Text = LblLista.Text + TxtCargar.Text + "\r\n";
            
            TxtCargar.Text = "";
            TxtCargar.Focus();

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

            //MostraLista = cantidad de personas ingresadas que se van a mostrar en la lista
            for (int MostrarLista = 0; MostrarLista < 5; MostrarLista++)
            {
                LblLista.Text = LblLista.Text + Lista[MostrarLista] + "\r\n";
                
            }
           
        }

       
    }
}
