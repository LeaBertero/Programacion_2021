using ProyectoFinal_Programación.Clases_Jugadores_suplentes;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Suplentes : Form
    {
        //se definen var

        public SuplentesEq1 ListaSuplentesEq1;

        string[] Equiponumero1 = { "Jugador 1", "Jugador 2", "Jugador 3" };
        string[] Equiponumero2 = { "Jugador 1", "Jugador 2", "Jugador 3" };

        public object LblListaSuplentesEq1 { get; private set; }
        public string LblListaSuplentesEq2 { get; private set; }
        //public object Equiponumero1 { get; private set; }

        //public SuplentesEq2 ListaSuplentesEq2;

        string[] CambiojugadorEq1Sup = new string[4];
        string[] CambiojugadorEq2Sup = new string[4];


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
        public void BtnDeleteEq1_Click(object sender, EventArgs e)
        {
            LblListaEqSup1.Text = " ";
        }
        public void BtnDeleteEq2_Click(object sender, EventArgs e)
        {
            LblListaEqSup2.Text = " ";
        }
        public void BtnAgregarSupEq1_Click(object sender, EventArgs e)
        {
            CambiojugadorEq1Sup[posicionEqSup1] = TxtCargaSupEq1.Text;
            posicionEqSup1 = posicionEqSup1 + 1;
            TxtCargaSupEq1.SelectAll();
            TxtCargaSupEq1.Focus();
        }
        public void BtnAgregarSupEq2_Click(object sender, EventArgs e)
        {
            CambiojugadorEq2Sup[posicionEqSup2] = TxtCargaSupEq2.Text;
            posicionEqSup2 = posicionEqSup2 + 1;
            TxtCargaSupEq2.SelectAll();
            TxtCargaSupEq2.Focus();
        }
        public void BtnMostrarListaEqSup2_Click(object sender, EventArgs e)
        {
            for (int contadorsuplentes = 0; contadorsuplentes < Equiponumero1.Length; contadorsuplentes++)
            {
                LblListaEqSup1.Text = LblListaEqSup1.Text + Equiponumero1[contadorsuplentes] + "\r\n";
            }

            LblListaEqSup1.Visible = true;

            // estructura comentada y cambiada :D

            //LblListaEqSup1.Text = " ";

            //foreach (var item in CambiojugadorEq1Sup)
            //{
            //    LblListaEqSup1.Text = LblListaEqSup1.Text + item + "\r\n";
            //}
        }
            
        public void BtnDimEqSup1_Click(object sender, EventArgs e)
        {
            //int CantJugEq1 = Convert.ToInt32(TxtDimEqSup1.Text);
            //CambiojugadorEq1Sup = new string[CantJugEq1];
        }
        public void BtnDimEqSup2_Click(object sender, EventArgs e)
        {
            //int CantJugEq2 = Convert.ToInt32(TxtDimEqSup2.Text);
            //CambiojugadorEq2Sup = new string[CantJugEq2];
        }
        public void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Equiponumero2.Length; i++)
            {
                LblListaEqSup2.Text = LblListaEqSup2.Text + Equiponumero2[i] + "\r\n";
            }

            LblListaEqSup2.Visible = true;

            //LblListaEqSup2.Text = "";

            //foreach (var item in CambiojugadorEq2Sup)
            //{
            //    LblListaEqSup2.Text = LblListaEqSup2.Text + item + "\r\n";
            //}
        }
        public void button1_Click(object sender, EventArgs e)
        {
            //Corregir
            Form FormTit_Sup = new FormTit_Sup();
            FormTit_Sup.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}




            








        

        












        

       














       

   


