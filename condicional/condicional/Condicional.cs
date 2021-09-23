using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (TxtOperacion.Text == "+")
            {
                int operador1 = System.Convert.ToInt32(TxtOper1.Text);
                int operador2 = System.Convert.ToInt32(TxtOper2.Text);
                int res = operador1 + operador2;

                LblRes.Text = res.ToString();
            }
            else if (TxtOperacion.Text == "-")
            {
                int operador1 = System.Convert.ToInt32(TxtOper1.Text);
                int operador2 = System.Convert.ToInt32(TxtOper2.Text);
                int res = operador1 - operador2;

                LblRes.Text = res.ToString();
            }
            else if (TxtOperacion.Text == "*")
            {
                int operador1 = System.Convert.ToInt32(TxtOper1.Text);
                int operador2 = System.Convert.ToInt32(TxtOper2.Text);
                int res = operador1 * operador2;

                LblRes.Text = res.ToString();
            }
            else if (TxtOperacion.Text == "/")
            {
                int operador1 = System.Convert.ToInt32(TxtOper1.Text);
                int operador2 = System.Convert.ToInt32(TxtOper2.Text);
                int res = operador1 / operador2;

                LblRes.Text = res.ToString();
            }
        }

        private void BtnAparecerRes_Click(object sender, EventArgs e)
        {
            LblRes.Visible = true;
        }
    }
}
