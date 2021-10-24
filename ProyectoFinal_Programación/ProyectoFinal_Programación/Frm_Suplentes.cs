using ProyectoFinal_Programación.Clases_Jugadores_suplentes;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{


    public partial class Frm_Suplentes : Form
    {
        //se definen var

        public SuplentesEq1 ListaSuplentesEq1;

        public object LblListaSuplentesEq1 { get; private set; }
        public string LblListaSuplentesEq2 { get; private set; }
        //public object Equiponumero1 { get; private set; }




        //public SuplentesEq2 ListaSuplentesEq2;

        string[] CambiojugadorEq1Sup = new string[5];
        string[] CambiojugadorEq2Sup = new string[5];

        public Frm_Suplentes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDeleteEq1_Click(object sender, EventArgs e)
        {
            TxtCargaSupEq1.Text = " ";
        }

        private void BtnDeleteEq2_Click(object sender, EventArgs e)
        {
            TxtCargaSupEq2.Text = " ";
        }

        

       

        public void BtnAgregarSupEq1_Click(object sender, EventArgs e)
        {
            string[] JugSupEq1 = new string[6];
            
            JugSupEq1[0] = "Jugador 1";
            JugSupEq1[1] = "Jugador 2";
            JugSupEq1[2] = "Jugador 3";
            JugSupEq1[3] = "Jugador 4";
            JugSupEq1[4] = "Jugador 5";
            JugSupEq1[5] = "Jugador 6";

            LblEquipo1.Text = JugSupEq1[3];
        }


        private void BtnAgregarSupEq2_Click(object sender, EventArgs e)
        {

        }
    }
}











       

   


