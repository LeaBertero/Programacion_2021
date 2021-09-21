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

        private void Btn_click_Click(object sender, EventArgs e)
        {
            
            LblRojo.Top = 50;
            LblBlanco.Top = 100;

        }

        private void Btn_azul_Click(object sender, EventArgs e)
        {

            while ((LblRojo.Left = LblRojo.Width) != LblBlanco.Left)
            {
                LblRojo.Left = LblRojo.Left + 5;
                LblBlanco.Left = LblBlanco.Left - 1;

                this.Refresh();
            }

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
            BtnArriba.Top = BtnArriba.Top +50;
        }

        private void BtnAbajo_Click(object sender, EventArgs e)
        {
            BtnAbajo.Top = BtnAbajo.Top - 50;
        }
    }
}
