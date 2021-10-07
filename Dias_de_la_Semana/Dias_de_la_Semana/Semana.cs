using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dias_de_la_Semana
{
    public partial class FormSemana : Form
    {
        public FormSemana()
        {
            InitializeComponent();
        }

        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            //instancia

            //string[] Dias = new string[7];

            //string[] Dias;
            //Dias = new string[7];

            //inicializando

            //Dias[0] = "Lunes";
            //Dias[1] = "Martes";
            //Dias[2] = "Miercoles";
            //Dias[3] = "Jueves";
            //Dias[4] = "Viernes";
            //Dias[5] = "Sábado";
            //Dias[6] = "Domingo";

            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            //LblVerSemana.Visible = true;
            //LblVerSemana.Text = Dias[4];


            //for (int semanacompleta = 0; semanacompleta < 7; semanacompleta++)
            //{
            //    LblVerSemana.Text = LblVerSemana.Text + Dias[semanacompleta] + "\r\n";
            //    LblVerSemana.Visible = true;
            //}

            foreach (var item in Dias)
            {

            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
