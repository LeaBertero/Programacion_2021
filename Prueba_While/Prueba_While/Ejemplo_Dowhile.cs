using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_While
{
    public partial class Ejemplo_Dowhile : Form
    {
        public Ejemplo_Dowhile()
        {
            InitializeComponent();
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            

            do
            {
                
                LblBlack.Left = LblBlack.Left + 1;
                LblWhite.Left = LblWhite.Left - 1;

                this.Refresh();


            } while (LblBlack.Left + LblBlack.Width != LblWhite.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
