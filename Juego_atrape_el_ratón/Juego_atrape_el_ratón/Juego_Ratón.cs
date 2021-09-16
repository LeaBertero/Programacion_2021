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
    public partial class BtnClickAqui : Form
    {
        public BtnClickAqui()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void PicRaton_Click(object sender, EventArgs e)
        {
            LblCondicion.Parent = PicRaton;
        }

        private void Mover_raton() 
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - PicRaton.Width);
            int y = r.Next(0, this.Height - PicRaton.Height);
            BtnSi.Location = new Point(x, y);
        }

       



        private void BtnSi_Click(object sender, EventArgs e)
        {
            LblCondicion.Parent = PicRaton;
        }
        

        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            Lblmsj.Visible = true;
        }

        private void BtnSi_MouseMove(object sender, MouseEventArgs e)
        {
            Mover_raton();

            if (BtnSi.Location == BtnSi.Location || BtnSi.Location == LblCondicion.Location)
            {
                Mover_raton();
            }

        }

        private void BtnClickAqui_Load(object sender, EventArgs e)
        {

        }
    }
}
