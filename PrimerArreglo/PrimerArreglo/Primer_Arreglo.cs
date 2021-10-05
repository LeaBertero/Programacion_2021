using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerArreglo
{
    public partial class Primer_Arreglo : Form
    {
        public Primer_Arreglo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia0.Text = Dias [0];
            LblDia0.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia1.Text = Dias[1];
            LblDia1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia2.Text = Dias[2];
            LblDia2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia3.Text = Dias[3];
            LblDia3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia4.Text = Dias[4];
            LblDia4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia5.Text = Dias[5];
            LblDia5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";

            LblDia6.Text = Dias[6];
            LblDia6.Visible = true;
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
