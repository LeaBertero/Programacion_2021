using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFecha_prueba
{
    public partial class Proyecto_Fecha_Prueba : Form
    {

        int dia;


        public Proyecto_Fecha_Prueba()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //try
            //{

            dia = Convert.ToInt16(TxtDia.Text);

            //    if (dia > 0 && dia < 31)
            //    {
            //        if (dia > 0)
            //        {
            //            LblDia.Text = "Lunes";
            //        }

            //        if (dia > 1)
            //        {
            //            LblDia.Text = "Martes";
            //        }

            //        if (dia > 2)
            //        {
            //            LblDia.Text = "Miercoles";
            //        }

            //        if (dia > 3)
            //        {
            //            LblDia.Text = "Jueves";
            //        }

            //        if (dia > 4)
            //        {
            //            LblDia.Text = "Viernes";
            //        }

            //        if (dia > 5)
            //        {
            //            LblDia.Text = "Sábado";
            //        }

            //        if (dia > 6)
            //        {
            //            LblDia.Text = "Domingo";
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ingrese un valor");
            //}

            for (int dia = 0; dia < 31; dia++)
            {
                LblDia.Text = TxtDia.Text;
            }
        }
    }
}


                










