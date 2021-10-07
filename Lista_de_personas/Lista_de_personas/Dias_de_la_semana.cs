using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_personas
{
    

    public partial class Dias_de_la_semana : Form
    {
        string[] nombres = new string[1000];
        int posicion = 0;

        public Dias_de_la_semana()
        {
            InitializeComponent();
        }

        public void BtnCargar_Click(object sender, EventArgs e)
        {
            nombres[posicion] = TxtNombre.Text;
            posicion = posicion + 1;
            TxtNombre.Focus();
            TxtNombre.SelectAll();
        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {

        }

        public void BtnSemana_Click(object sender, EventArgs e)
        {

            //FORMA 1/////////////////////////////////////////////////

            //string[] Dias = new string[9];

            //Dias[0] = "Lunes";
            //Dias[1] = "Martes";
            //Dias[2] = "Miercoles";
            //Dias[3] = "Jueves";
            //Dias[4] = "Viernes";
            //Dias[5] = "Sábado";
            //Dias[6] = "Domingo";
            //Dias[7] = "";
            //Dias[8] = "Fin de la semana - A desacansar !!";

            //LblSemana.Text = Dias[8];
            //LblSemana.Visible = true;


            //FORMA 2 - ///////////////////////////////////////
            //Se puede poner Dias.Length que sea menor a i (contador)
            //O diarectamente el numero de datos que tengo en el arreglo
            //En este caso, los dias de la semana



            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            //LblSemana.Visible = true;

            //for (int i = 0; i < Dias.Length; i++)
            //{

            //    LblSemana.Text = LblSemana.Text + Dias[i] + "\r\n";

            //    LblSemana.Visible = true;


            foreach (string item in Dias)
            {
                LblSemana.Text = LblSemana.Text + item + "\r\n";
                LblSemana.Visible = true;
            }
        }

       
    }
 
}

