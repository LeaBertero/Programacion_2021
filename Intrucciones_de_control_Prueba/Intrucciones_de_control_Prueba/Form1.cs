using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intrucciones_de_control_Prueba
{

    public partial class Frm_instrucciones : Form
    {
        decimal numero1;
        decimal numero2;
        decimal resultado;

        public Frm_instrucciones()
        {
            InitializeComponent();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (TxtOperacion.Text == "+")
            {

                System.Convert.ToInt32(TxtOp1.Text);
                System.Convert.ToInt32(TxtOp2.Text);

                resultado = numero1 + numero2;

                LblRes.Text = System.Convert.ToString(resultado);

            }
            else
            {
                LblRes.Text = "Operacion Incorrecta";
            }
        }
    }
}
