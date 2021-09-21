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
            LblRojo.Visible = true;
            this.Refresh();
            LblRojo.Top = 50;

            
        }
    }
}
