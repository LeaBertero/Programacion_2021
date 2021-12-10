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

            LblRes.Visible = true;

            switch (TxtSigno.Text)
            {
                case "+":
                    numero1 = System.Convert.ToDecimal(TxtOper1.Text);
                    numero2 = System.Convert.ToDecimal(TxtOper2.Text);

                    resultado = numero1 + numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "-":

                    numero1 = System.Convert.ToDecimal(TxtOper1.Text);
                    numero2 = System.Convert.ToDecimal(TxtOper2.Text);

                    resultado = numero1 - numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "*":
                    numero1 = System.Convert.ToDecimal(TxtOper1.Text);
                    numero2 = System.Convert.ToDecimal(TxtOper2.Text);

                    resultado = numero1 * numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                case "/":
                    numero1 = System.Convert.ToDecimal(TxtOper1.Text);
                    numero2 = System.Convert.ToDecimal(TxtOper2.Text);

                    resultado = numero1 / numero2;

                    LblRes.Text = resultado.ToString();

                    break;

                default:

                    LblRes.Text = "Operación no valida, debe ingresar los datos correctos";
                    break;

            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewForm_Click(object sender, EventArgs e)
        {
            Form for_mov = new For_Mov();
            for_mov.ShowDialog();
        }
        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public void BtnNewForm_Click_1(object sender, EventArgs e)
        {
            For_Mov formNaranja = new For_Mov();
            formNaranja.ShowDialog();
        }
    }
}





