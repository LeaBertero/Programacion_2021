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


       

        private void PicRaton_Click(object sender, EventArgs e)
        {
            LblCondicion.Parent = PicRaton;
        }

        private void Mover_boton() 
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
            Mover_boton();

            if (BtnSi.Location == BtnSi.Location || BtnSi.Location == LblCondicion.Location)
            {
                Mover_boton();
            }

        }
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Form Caculadora = new FrmCalculadora();
            Caculadora.ShowDialog();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            LblTexto.Visible = true;
        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lblmsj_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
