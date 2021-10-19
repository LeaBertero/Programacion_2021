using ProyectoFinal_Programación.Clases_Jugadores_suplentes;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Suplentes : Form
    {
        //se definen var

        public SuplentesEq1 ListaSuplentesEq1;
        //public SuplentesEq2 ListaSuplentesEq2;

        public Frm_Suplentes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarSupEq1_Click(object sender, EventArgs e)
        {
            string[] Equiponumero1 = {"1 - Pastore", "2 - Lucas Zelarayan ", "3 - Javier Correa",
                "4 - Franco Vazquez", "5 - Juan Ramírez " };

            for (int i = 0; i < Equiponumero1.Length; i++)
            {
                LblListaSuplentesEq1.Text = LblListaSuplentesEq1.Text + Equiponumero1[i] + "\r\n";
            }

            LblListaSuplentesEq1.Visible = true;

            //Equiponumero1[0] = "jugador 1";
            //Equiponumero1[1] = "jugador 2";
            //Equiponumero1[2] = "jugador 3";
            //Equiponumero1[3] = "jugador 4";
            //Equiponumero1[4] = "jugador 5";

            //LblEquipo1.Text = Equiponumero1[3];
        }

        private void BtnAgregarSupEq2_Click(object sender, EventArgs e)
        {
            string[] Equiponumero2 = {"1 - EMILIANO RIGONI", "2 - DANIEL MANCINI ", "3 - LUCIANO VIETTO",
                "4 - MATEO GARCÍA", "5 - MATEO BUSTOS" };

            for (int i = 0; i < Equiponumero2.Length; i++)
            {
                LblListaSuplentesEq2.Text = LblListaSuplentesEq2.Text + Equiponumero2[i] + "\r\n";
            }

            LblListaSuplentesEq2.Visible = true;

            //Equiponumero1[0] = "jugador 1";
            //Equiponumero1[1] = "jugador 2";
            //Equiponumero1[2] = "jugador 3";
            //Equiponumero1[3] = "jugador 4";
            //Equiponumero1[4] = "jugador 5";

            //LblEquipo1.Text = Equiponumero1[3];
        }
    }
}

   


