using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtMulti_Click(object sender, EventArgs e)
        {
            double num1, num2;

            num1 = Convert.ToDouble(Txtoper1.Text);
            num2 = Convert.ToDouble(Txtoper2.Text);

            TxtRes.Text = String.Format("{0:F2}",num1* num2);

        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Txtoper1.Text = null;
            Txtoper2.Text = null;
            TxtRes.Text = null;
           
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtMultEj2_Click(object sender, EventArgs e)
        {
            double oper1, oper2, m;
            string res;
            //extrae la entrada del usuario
            oper1 = Convert.ToDouble(TxtNum1.Text);
            oper2 = Convert.ToDouble(TxtNum2.Text);
            m = oper1 * oper2;
            res = (String.Format("{0:F2}", m));
            TxtNumRes.Text = res;
        }

        private void BtLimpiar2_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = null;
            TxtNum2.Text = null;
            TxtNumRes.Text = null;
        }
    }
}
