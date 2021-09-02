using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesEnTexbox
{
    public partial class Practica_calculadora : Form
    {
        public Practica_calculadora()
        {
            InitializeComponent();
        }

        private void BtnRes_suma_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = System.Convert.ToInt32(TxtNumSuma1.Text);
            numero2 = System.Convert.ToInt32(TxtNumSuma2.Text);

            resultado = numero1 + numero2;

            LblRes_suma.Text = System.Convert.ToString(resultado);
        }

        private void BtnRes_resta_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = System.Convert.ToInt32(TxtNumResta1.Text);
            numero2 = System.Convert.ToInt32(TxtNumResta2.Text);

            resultado = numero1 - numero2;

            LblRes_Resta.Text = System.Convert.ToString(resultado);
        }

        private void BtnRes_mult_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = System.Convert.ToInt32(TxtNumMult1.Text);
            numero2 = System.Convert.ToInt32(TxtNumMult2.Text);

            resultado = numero1 * numero2;

            LblRes_Mult.Text = System.Convert.ToString(resultado);
        }

        private void BtnRe_div_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = System.Convert.ToInt32(TxtNumDiv1.Text);
            numero2 = System.Convert.ToInt32(TxtNumDiv2.Text);

            resultado = numero1 / numero2;

            LblRes_Div.Text = System.Convert.ToString(resultado);
        }
    }
}
