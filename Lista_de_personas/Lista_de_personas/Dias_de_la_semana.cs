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
        public Dias_de_la_semana()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //string[] Dias = new string[7];

            //Dias[0] = "Lunes";
            //Dias[1] = "Martes";
            //Dias[2] = "Miercoles";
            //Dias[3] = "Jueves";
            //Dias[4] = "Viernes";
            //Dias[5] = "Sabado";
            //Dias[6] = "Domingo";

            //LblSemana.Text = Dias[0];
            //LblSemana.Visible = true;

            string[] Dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            //LblSemana.Text = Dias[0];
            LblSemana.Visible = true;

            for (int i = 0; i < 7; i++)
            {
                LblSemana.Text = LblSemana.Text + Dias[i] + "\r\n";

                LblSemana.Visible = true;
            }

        }
    }
}
