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
        decimal primernumero;
        decimal segundonumero;
        decimal resultado;

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
            
        }
    }
}
