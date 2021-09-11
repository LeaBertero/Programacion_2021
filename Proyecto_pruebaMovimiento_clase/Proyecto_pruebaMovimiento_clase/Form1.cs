using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_pruebaMovimiento_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMover_Click(object sender, EventArgs e)
        {
            int x = System.Convert.ToInt32(TxtBoxUser.Text);
            


            for (int i = 0; i < 500; i++)
            {
                LblMov.Left = i;
                this.Refresh();
                
            }
            
    }   }
}
