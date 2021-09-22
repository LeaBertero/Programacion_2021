using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_movimiento_label
{
    public partial class Form_accion : Form
    {
        public Form_accion()
        {
            InitializeComponent();
        }

       

        private void BtnMoverderecha_Click(object sender, EventArgs e)
        {

            BtnMoverderecha.Left = BtnMoverderecha.Right + 1;
        }

        private void BtnMoverIzquierda_Click(object sender, EventArgs e)
        {
            BtnMoverIzquierda.Left = BtnMoverIzquierda.Left - 80;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Btn_abajo.Top = Btn_abajo.Top +50;
        }

        private void BtnAbajo_Click(object sender, EventArgs e)
        {
            BtnAbajo.Top = BtnAbajo.Top - 50;
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            if (Lblprueba.Left <= 726)
            {
                Lblprueba.Left = Lblprueba.Left + 25;
                this.Refresh();
            }
           
            
        }

        private void Btn_click_Click(object sender, EventArgs e)
        {
            LblBlanco.Left = LblBlanco.Left - 90;
            this.Refresh();
        }

        private void Form_accion_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BtnSalir.Visible = true;
        }
    }
}
