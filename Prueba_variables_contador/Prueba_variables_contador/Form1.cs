using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_variables_contador
{
    
    public partial class Form1 : Form
    {
        int numero = 0;
        int numero1 = -0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            
            ++numero;
            LblContador.Text = System.Convert.ToString(numero);
            --numero1;
            LblContador2.Text = System.Convert.ToString(numero1);


        }

        private void LblContador_Click(object sender, EventArgs e)
        {

        }
    }
}
