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
    public partial class BtnClickAqui : Form
    {
        public BtnClickAqui()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAtrapar_Click(object sender, EventArgs e)
        {
            LblFalse.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
