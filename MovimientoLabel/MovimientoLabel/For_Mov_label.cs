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

            for (int i = 0; i < 340; i++)
            {
                LblVerde.Left = i;
                this.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 130; i++)
            {
                LblRojo.Top = i;
                this.Refresh();
                LblRojo.Visible = true;
                
            }
        }

        private void For_Mov_label_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //int x = System.Convert.ToInt32(TxtX.Text);

            LblBlanco.Visible = true;

            for (int i = 0; i < 300; i++)
            {
                LblBlanco.Left = i;
                this.Refresh();
            }
        }
    }
}
