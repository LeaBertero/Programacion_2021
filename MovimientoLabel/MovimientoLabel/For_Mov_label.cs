using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoLabel
{
    public partial class For_Mov_label : Form
    {
        public For_Mov_label()
        {
            InitializeComponent();
        }

        private void BtnMover_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 540; i++)
            {
                LblVerde.Left = i;
                this.Refresh();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 230; i++)
            {
                LblRojo.Top = i;
                this.Refresh();
                
            }
        }
    }
}
