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

    public partial class Form1 : Form
    {
        int numero = 0;
        int numero1 = -0;

        public Form1()
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
            numero++;
            LblContadorblue.Text = System.Convert.ToString(numero);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            --numero1;
            LblContadorYellow.Text = System.Convert.ToString(numero1);
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            int Altoform = 500;
            Altoform = this.Height;
            int ancholabelAzul = LblContadorblue.Top;
            int Altolabel = 30;
            int x = 10;
            int paso = 5;

            while (x < Altoform + Altolabel)
            {
                this.LblContadorblue.Top =  Altolabel;
                this.Refresh();
                x = x + paso;
            }
            
        }

        private void button3_Click (object sender, EventArgs e)
        {
            int AnchoFormVerde = 300;
            AnchoFormVerde = this.Width;
            int largolabelamarillo = LblContadorYellow.Top;
            int x = 0;
            int paso = 10;

            while (x < AnchoFormVerde - largolabelamarillo)
            {
                LblContadorYellow.Left = x;
                this.Refresh();
                x = x + paso;
            }
        }

        private void BtnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();

            if (BtnCerrar.Location == BtnSalir.Location || BtnCerrar.Location == LblContadorblue.Location)
            {
                MoverBoton();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAparecer_Click(object sender, EventArgs e)
        {
            LblClose.Visible = true;
        }
    }
}
