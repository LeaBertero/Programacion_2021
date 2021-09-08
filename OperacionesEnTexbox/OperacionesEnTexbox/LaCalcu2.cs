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
    public partial class FrmCalcu2 : Form
    {
        

        public FrmCalcu2()
        {
            InitializeComponent();
        }

        private void LaCalcu2_Load(object sender, EventArgs e)
        {
             
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (TxtOperacion.Text == "+") 
            {
                decimal numero1 = System.Convert.ToInt32(TxtNum1.Text);
                decimal numero2 = System.Convert.ToInt32(TxtNum2.Text);

                decimal Resultado = numero1 + numero2;

                LblRes.Text = System.Convert.ToString(Resultado);
            }

            if (TxtOperacion.Text == "-")
            {
                decimal numero1 = System.Convert.ToInt32(TxtNum1.Text);
                decimal numero2 = System.Convert.ToInt32(TxtNum2.Text);

                decimal Resultado = numero1 - numero2;

                LblRes.Text = System.Convert.ToString(Resultado);
            }

            if (TxtOperacion.Text == "*")
            {
                decimal numero1 = System.Convert.ToInt32(TxtNum1.Text);
                decimal numero2 = System.Convert.ToInt32(TxtNum2.Text);

                decimal Resultado = numero1 * numero2;

                LblRes.Text = System.Convert.ToString(Resultado);
            }

            if (TxtOperacion.Text == "/")
            {
                decimal numero1 = System.Convert.ToInt32(TxtNum1.Text);
                decimal numero2 = System.Convert.ToInt32(TxtNum2.Text);

                decimal Resultado = numero1 / numero2;

                LblRes.Text = System.Convert.ToString(Resultado);
            }
            else
            {
                LblMensajeError.Text = "Operacion no valida";
            }


        }

        
    }
}
