using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_variables_contador
{

    public partial class Contadores_pos_neg : Form
    {
        int numero = 1;
        int numero1 = -1;

        public Contadores_pos_neg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - BtnCerrar.Width);
            int y = r.Next(0, this.Height - BtnCerrar.Height);
            BtnCerrar.Location = new Point(x, y);
        }
        
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            ++numero;
            LblContador.Text = System.Convert.ToString(numero);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            --numero1;
            LblContador2.Text = System.Convert.ToString(numero1);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int anchformulario = 0;
            anchformulario = this.Height;
            int ancholabelAmarillo = LblContador.Height;
            int ancholargo = 10;
            int x = 100;
            int paso = 2;

            while (x < anchformulario-ancholargo)
            {
                this.LblContador.Height = x;
                this.Refresh();
                x = x + paso;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int anchformularioAzul = 0;
            anchformularioAzul = this.Left;
            int ancholabelAzul = LblContador2.Left;
            int ancholargo = -100;
            int x = 0;
            int paso = 2;

            while (x < anchformularioAzul - ancholargo)
            {
                this.LblContador2.Left = x;
                this.Refresh();
                x = x + paso;
            }
        }

        private void BtnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();

            if (BtnCerrar.Location == BtnSalir.Location || BtnCerrar.Location == LblContador.Location)
            {
                MoverBoton();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
