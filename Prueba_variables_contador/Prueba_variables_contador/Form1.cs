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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            --numero1;
            LblContador2.Text = System.Convert.ToString(numero1);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int anchformulario = 0;
            anchformulario = this.Top;
            int ancholabelAmarillo = LblContador.Top;
            int ancholargo = 10;
            int x = 30;
            int paso = 5;

            while (x < anchformulario-ancholargo)
            {
                this.LblContador.Top = x;
                this.Refresh();
                x = x + paso;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int anchformularioAzul = 0;
            anchformularioAzul = this.Top;
            int ancholabelAzul = LblContador2.Top;
            int ancholargo = 10;
            int x = 30;
            int paso = 5;

            while (x < anchformularioAzul - ancholargo)
            {
                this.LblContador2.Top = x;
                this.Refresh();
                x = x + paso;
            }
        }
    }
}
