using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_label_Texbox
{
    public partial class FrmSiguiente : Form
    {
        public FrmSiguiente()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            string ResultadoFrase;

            ResultadoFrase = TxtIngresoFrase.Text;

            LblOriginal.Text = TxtIngresoFrase.Text.ToLower();
            
            LblResultado.Text = ResultadoFrase;
        }
    }
}
