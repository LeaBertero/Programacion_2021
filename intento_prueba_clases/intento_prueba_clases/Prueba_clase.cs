using System;
using System.Windows.Forms;

namespace intento_prueba_clases
{
    public partial class Prueba_clase : Form
    {
        public Prueba_clase()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            LblMundo.Text = "EL mensaje oculto, no tiene contenido...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblMundo.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAparecercontroles_Click(object sender, EventArgs e)
        {
            LblRojo.Visible = true;
            LblAzul.Visible = true;
        }

        private void BtnAzul_Click(object sender, EventArgs e)
        {
            LblAzul.Left = LblAzul.Left + 10;
        }
            

        private void BtnRojo_Click(object sender, EventArgs e)
        {
            LblRojo.Left = LblRojo.Left - 10;
        }
    }
}
