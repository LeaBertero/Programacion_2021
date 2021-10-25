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

        string[] CambiojugadorEq1Sup = new string[3];
        string[] CambiojugadorEq2Sup = new string[3];


        int posicionEqSup1 = 0;
        int posicionEqSup2 = 0;

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
            CambiojugadorEq1Sup[posicionEqSup1] = TxtCargaSupEq1.Text;
            posicionEqSup1 = posicionEqSup1 + 1;
            TxtCargaSupEq1.Focus();
            TxtCargaSupEq1.SelectAll();
        }
        private void BtnAgregarSupEq2_Click(object sender, EventArgs e)
        {
            CambiojugadorEq2Sup[posicionEqSup2] = TxtCargaSupEq2.Text;
            posicionEqSup2 = posicionEqSup2 + 1;
            TxtCargaSupEq2.Focus();
            TxtCargaSupEq2.SelectAll();
        }
        private void BtnMostrarListaEqSup2_Click(object sender, EventArgs e)
        {
            LblListaEqSup1.Text = "";

            foreach (var item in CambiojugadorEq1Sup)
            {
                LblListaSuplentesEq1 = LblListaSuplentesEq1 + item + "\r\n";
            }
        }
        private void BtnDimEqSup1_Click(object sender, EventArgs e)
        {
            int CantJugEq1 = Convert.ToInt32(TxtDimEqSup1.Text);
            CambiojugadorEq1Sup = new string[CantJugEq1];
        }
        private void BtnDimEqSup2_Click(object sender, EventArgs e)
        {
            int CantJugEq2 = Convert.ToInt32(TxtDimEqSup2.Text);
            CambiojugadorEq2Sup = new string[CantJugEq2];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LblListaEqSup2.Text = "";

            foreach (var item in CambiojugadorEq2Sup)
            {
                LblListaSuplentesEq2 = LblListaSuplentesEq2 + item + "\r\n";
            }
        }
    }
}

        












        

       














       

   


