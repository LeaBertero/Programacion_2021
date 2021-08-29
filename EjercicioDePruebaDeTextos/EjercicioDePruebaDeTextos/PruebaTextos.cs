using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDePruebaDeTextos
{
    public partial class PruebaTextos : Form
    {
        public PruebaTextos()
        {
            InitializeComponent();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            string cadenaresultado;

            LblOrigen.Text = TxtDatoCadena.Text;
            cadenaresultado = TxtDatoCadena.Text.Substring(0, 1).ToUpper()
                + "\r\n"
                +  TxtDatoCadena.Text.Substring(1).ToLower();
            
            LblResultado.Text = cadenaresultado;

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
