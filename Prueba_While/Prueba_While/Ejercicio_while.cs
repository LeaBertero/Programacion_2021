﻿using System;
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
    public partial class Frm_While : Form
    {
        public Frm_While()
        {
            InitializeComponent();
        }

        private void BtnArranque_Click(object sender, EventArgs e)
        {
            while (true)
            {
                LblAzul.Left = LblRojo.Left - 1;
                LblRojo.Left = LblRojo.Left + 1;

                

                this.Refresh();

                if (LblRojo.Left + LblRojo.Width == LblAzul.Left)
                {
                    break;
                }

            }

            
        }

        private void BtnAcomodar_Click(object sender, EventArgs e)
        {
            LblRojo.Top = 70;
            LblAzul.Top = 150;
            LblRojo.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguente = new Ejemplo_Dowhile();
            formularioSiguente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }        
}


