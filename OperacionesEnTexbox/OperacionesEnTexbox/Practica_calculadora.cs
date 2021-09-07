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
    public partial class FrmCalcu1 : Form
    {
        decimal numero1;
        decimal numero2;

        decimal resultado;
        public FrmCalcu1()
        {
            InitializeComponent();
        }

        private void BtnRes_suma_Click(object sender, EventArgs e)
        {
            

            numero1 = System.Convert.ToDecimal(TxtNumSuma1.Text);
            numero2 = System.Convert.ToDecimal(TxtNumSuma2.Text);

            resultado = numero1 + numero2;

            LblRes_suma.Text = System.Convert.ToString(resultado);
        }

        private void BtnRes_resta_Click(object sender, EventArgs e)
        {
            

            numero1 = System.Convert.ToDecimal(TxtNumResta1.Text);
            numero2 = System.Convert.ToDecimal(TxtNumResta2.Text);

            resultado = numero1 - numero2;

            LblRes_Resta.Text = System.Convert.ToString(resultado);
        }

        private void BtnRes_mult_Click(object sender, EventArgs e)
        {
            

            numero1 = System.Convert.ToDecimal(TxtNumMult1.Text);
            numero2 = System.Convert.ToDecimal(TxtNumMult2.Text);

            resultado = numero1 * numero2;

            LblRes_Mult.Text = System.Convert.ToString(resultado);
        }

        private void BtnRe_div_Click(object sender, EventArgs e)
        {
            

            numero1 = System.Convert.ToDecimal(TxtNumDiv1.Text);
            numero2 = System.Convert.ToDecimal(TxtNumDiv2.Text);

            resultado = numero1 / numero2;

            LblRes_Div.Text = System.Convert.ToString(resultado);
        }

        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
