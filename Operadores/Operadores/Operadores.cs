using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        decimal numero1;
        decimal numero2;
        decimal resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (TxtOperador.Text == "+") 
            {
                numero1 =System.Convert.ToInt32(TxtOper1.Text);
                numero2 =System.Convert.ToInt32(TxtOper2.Text);

                resultado = numero1 + numero2;

                LblRes.Text = System.Convert.ToString(resultado);

            }
            if (TxtOperador.Text == "-")
            {
                numero1 = System.Convert.ToInt32(TxtOper1.Text);
                numero2 = System.Convert.ToInt32(TxtOper2.Text);

                resultado = numero1 - numero2;

                LblRes.Text = System.Convert.ToString(resultado);

            }
            if (TxtOperador.Text == "*")
            {
                numero1 = System.Convert.ToInt32(TxtOper1.Text);
                numero2 = System.Convert.ToInt32(TxtOper2.Text);

                resultado = numero1 * numero2;

                LblRes.Text = System.Convert.ToString(resultado);

            }
            if (TxtOperador.Text == "/")
            {
                numero1 = System.Convert.ToInt32(TxtOper1.Text);
                numero2 = System.Convert.ToInt32(TxtOper2.Text);

                resultado = numero1 / numero2;

                LblRes.Text = System.Convert.ToString(resultado);

            }
            
        }
    }
}
