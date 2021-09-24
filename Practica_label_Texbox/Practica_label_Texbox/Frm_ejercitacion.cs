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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string resultadoFraseOriginal;

            resultadoFraseOriginal = TxTIngreso.Text;

            LblFraseResultado.Text = TxTIngreso.Text.Substring(0,3);
            LblFraseOriginal.Text = resultadoFraseOriginal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Form NuevoFormulario = new FrmSiguiente();
            NuevoFormulario.ShowDialog();
        }
    }
}
