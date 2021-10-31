﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga_personas
{
    public partial class CargaPersonas : Form
    {

        //Se declara una propiedad persona como entero
        public Persona[] personas { get; set; }
        //public Personas[] personas { get; set; } = new Personas[3];
        //public int Pos = -1;

        public Persona Lista { get; set; }
        public Persona lista { get; set; }

        public CargaPersonas()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = TxtCargaPers.Text;
            //Pos = Pos + 1;
            Redimensionar();
            personas[personas.Length -1] = persona;
            persona.AñoNacimiento = System.Convert.ToInt32(TxtNacimiento.Text);
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            LblLista.Text = "Lista de personas cargadas: \r\n";
            foreach (Persona item in personas)
            {
                LblLista.Text = LblLista.Text  +item.Nombre + " - " + item.AñoNacimiento + "\r\n";
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Persona[1];
            }
            else 
            {
                Persona[] arraux = new Persona[personas.Length + 1];
                
                for (int contador = 0; contador < personas.Length; contador++)
                {
                    arraux[contador] = personas[contador];
                }
                personas = arraux;
            }
        }

       
    }
}






        

