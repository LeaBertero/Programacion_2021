using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_atrape_el_ratón
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;
            decimal resultado;

            switch (TxtSigno.Text)
            {
                case "+":
                    numero1 = System.Convert.ToInt32(TxtOper1.Text);
                    numero2 = System.Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 + numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "-":

                    numero1 = System.Convert.ToInt32(TxtOper1.Text);
                    numero2 = System.Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 - numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "*":
                    numero1 = System.Convert.ToInt32(TxtOper1.Text);
                    numero2 = System.Convert.ToInt32(TxtOper2.Text);

                    resultado = numero1 * numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "/":
                    numero1 = System.Convert.ToInt32(TxtOper1.Text);
                    numero2 = System.Convert.ToInt32(TxtOper2.Text);

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
