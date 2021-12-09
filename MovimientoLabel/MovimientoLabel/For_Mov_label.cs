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

            for (int i = 377; i < 680; i++)
            {
                LblMovRojo.Left = i;
                LblMovRojo.Visible = true;
                this.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 248; i++)
            {
                LblAzul.Top = i;
                this.Refresh();
            }
        }
               
                

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = System.Convert.ToInt32(TxtX.Text);

            for (int i = x; i < 1330; i++)
            {
                
                LblBlanco.Left = x;

                LblBlanco.Visible = true;

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 350; i < 725; i++)
            {
                LblAmarillo.Left = i;
                LblAmarillo.Visible = true;
                this.Refresh();
            }
        }
    }
}
