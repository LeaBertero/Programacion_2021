using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_prueba
{
    public partial class Calculadora : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (TxtResultado.Text == "0")
                TxtResultado.Text = "";

            TxtResultado.Text += boton.Text;

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(TxtResultado.Text);

            if (operador == '+')
            {
                TxtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(TxtResultado.Text);
          
            }
            else if (operador == '-')
            {
                TxtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(TxtResultado.Text);
            }     


        }   

        private void ClickOperador(object sender, EventArgs e)
        {

            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(TxtResultado.Text);
            operador = Convert.ToChar (boton.Tag);

            TxtResultado.Text = "0";

        }

    }
}