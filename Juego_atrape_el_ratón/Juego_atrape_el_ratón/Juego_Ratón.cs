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
    public partial class Juego_Ratón : Form
    {
        public Juego_Ratón()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
