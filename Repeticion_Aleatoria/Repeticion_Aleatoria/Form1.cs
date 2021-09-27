using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeticion_Aleatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_comenzar_Click(object sender, EventArgs e)
        {
            int sentidoV = 1;
            int sentidoH = 1;
            int PasoV = 1;
            int pasoH = 1;

            for (int i = 0; i < 100; i++)
            {
                Lbl_aleatorio.Left = Lbl_aleatorio.Left + (pasoH * sentidoH);
                Lbl_aleatorio.Top = Lbl_aleatorio.Top + (PasoV * sentidoV);
                this.Refresh();
            }
        }
    }
}
