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
    public partial class Movimiento_aleatorio : Form
    {
        public Movimiento_aleatorio()
        {
            InitializeComponent();
        }

        private void Btn_comenzar_Click(object sender, EventArgs e)
        {
            int sentidoV = 1;
            int sentidoH = 1;
            int PasoV = 1;
            int pasoH = 1;

            Random RandomSentido = new Random(450);
            Random RandomPaso = new Random(78);

            for (int i = 0; i <= 80; i++)
            {
                sentidoH = RandomSentido.Next(i);
                sentidoV = RandomSentido.Next(i);

                pasoH = RandomPaso.Next(0,15);
                PasoV = RandomPaso.Next(0,30);

                Lbl_aleatorio.Left = Lbl_aleatorio.Left + (pasoH + sentidoH);
                Lbl_aleatorio.Top = Lbl_aleatorio.Top + (PasoV + sentidoV);
                this.Refresh();
            }
        }
    }
}
