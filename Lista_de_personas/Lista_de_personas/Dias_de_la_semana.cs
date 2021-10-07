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

        public void BtnSemana_Click(object sender, EventArgs e)
        {

            //FORMA 1 - DE MOSTRAR LOS DIAS DE LA SEMANA INDIVIDUALMENTE

            //string[] Dias = new string[7];

            //Dias[0] = "lunes";
            //Dias[1] = "martes";
            //Dias[2] = "miercoles";
            //Dias[3] = "jueves";
            //Dias[4] = "viernes";
            //Dias[5] = "sabado";
            //Dias[6] = "domingo";

            //LblSemana.Text = Dias[5];
            //LblSemana.Visible = true;

            //----------------------------------------
            //FORMA 2 -  DE MMOSTRAR LOS DIAS DE LA SEMANA COMPLETA

            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            LblSemana.Visible = true;

            for (int i = 0; i < Dias.Length; i++)
            {
                //Se puede poner Dias.Length que sea menor a i (contador)
                //O diarectamente el numero de datos que tengo en el arreglo
                //En este caso, los dias de la semana
                LblSemana.Text = LblSemana.Text + Dias[i] + "\r\n";

                LblSemana.Visible = true;
            }
        }
    }
}
