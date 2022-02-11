using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_atrape_el_ratón
{
    public partial class For_Mov : Form
    {
        public For_Mov()
        {
            InitializeComponent();
        }

        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            TxtIngresar.Visible = true;
            LblMovimiento.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                int x = System.Convert.ToInt32(TxtIngresar.Text);

                for (; ; )
                {
                    x = x + 10;
                    LblMovimiento.Left = x;
                    this.Refresh();

                    if (x >= 100)
                    {
                        this.Refresh();
                        break;

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar un valor");
            }
        }




                

        private void Btn_Aparecer_boton_Click(object sender, EventArgs e)
        {
            Btn_salir.Visible = true;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
