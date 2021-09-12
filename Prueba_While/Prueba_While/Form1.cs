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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArranque_Click(object sender, EventArgs e)
        {
            while (true)
            {
                LblAzul.Left = LblAzul.Left + 80;
                LblRojo.Left = LblRojo.Left + 80;
                this.Refresh();
                break;
                               
            }


        }

        private void BtnAcomodar_Click(object sender, EventArgs e)
        {
            LblRojo.Top = 50;
            LblAzul.Top = 50;
        }
    }        
}
