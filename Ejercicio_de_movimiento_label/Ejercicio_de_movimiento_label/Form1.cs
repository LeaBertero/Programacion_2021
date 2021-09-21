using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_movimiento_label
{
    public partial class Form_accion : Form
    {
        public Form_accion()
        {
            InitializeComponent();
        }

        private void Btn_click_Click(object sender, EventArgs e)
        {
            LblRojo.Top = 50;
            LblBlanco.Top = 80;

            LblRojo.Visible = true;
            
        }

        private void Btn_azul_Click(object sender, EventArgs e)
        {

            while ((LblRojo.Left = LblRojo.Width) != LblBlanco.Left)
            {
                LblRojo.Left = LblRojo.Left + 1;
                LblBlanco.Left = LblBlanco.Left - 1;

            }

        }
    }
}
