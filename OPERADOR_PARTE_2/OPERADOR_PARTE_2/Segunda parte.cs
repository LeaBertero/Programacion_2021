using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPERADOR_PARTE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;
            decimal resultado;

            switch (TxtOperador.Text)
            {
                case "+":
                    numero1 = Convert.ToInt32(TxtOper1.Text);
                    numero2 = Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 + numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "-":

                    numero1 = Convert.ToInt32(TxtOper1.Text);
                    numero2 = Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 - numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "*":
                    numero1 = Convert.ToInt32(TxtOper1.Text);
                    numero2 = Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 * numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "/":
                    numero1 = Convert.ToInt32(TxtOper1.Text);
                    numero2 = Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 / numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                default:

                    LblRes.Text = "Error";
                    break;
            }

        }
    }
}
