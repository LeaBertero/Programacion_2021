using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio_grados
{
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
        }

        public void BtCAF_Click(object sender, EventArgs e)
        {
            
        }

        private void BtFAC_Click(object sender, EventArgs e)
        {
            
        }

        private void BtTemp2_Click(object sender, EventArgs e)
        {
            double gcentigrados, ct1;
            ct1 = Convert.ToDouble();
            gcentigrados = (ct1 - 32.0) / 1.8;
            Txt = String.Format("{0:F3}", gcentigrados);

        }
    }
}
