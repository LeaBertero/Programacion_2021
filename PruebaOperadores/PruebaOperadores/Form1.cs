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
    }
}
