using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_lista
{
    public partial class Prueba_limpiar_controles : Form
    {
        public Prueba_limpiar_controles()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.Text = "el mensaje se autodestrira en 5..4..3..";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Enabled = true;
            //textBox1.Enabled = false;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // textBox1.Visible = false;
            textBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}
