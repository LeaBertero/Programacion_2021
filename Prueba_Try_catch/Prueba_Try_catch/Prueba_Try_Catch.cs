using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Try_catch
{
    public partial class Prueba_Try_Catch : Form
    {
        public Prueba_Try_Catch()
        {
            InitializeComponent();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                LblRes.Text = (System.Convert.ToDecimal(TxtNum1.Text)
                / System.Convert.ToDecimal(TxtNum2.Text)).ToString();
            }
            catch (Exception /*mensajeError*/)
            {
                //LblError.Visible = true;
                //LblError.Text = mensajeError.Message;
                //LblError.Text = "Imposible dividir por 0";
                MessageBox.Show("Debe ingresar un numero");
            }



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
