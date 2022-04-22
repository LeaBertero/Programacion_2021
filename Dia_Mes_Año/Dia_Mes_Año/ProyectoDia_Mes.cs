using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_Mes_Año
{
    public partial class ProyectoDia_Mes : Form
    {
        public ProyectoDia_Mes()
        {
            InitializeComponent();
        }

        int Dia;
        int Mes;
        int Año;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

       

        private void BtnSemana_Click(object sender, EventArgs e)
        {
            try
            {
                Dia = Convert.ToInt32(TxtDia.Text);

                if (Dia > 0 && Dia <= 7)
                {
                    if (Dia == 1)
                    {
                        MessageBox.Show("Lunes");
                    }

                    if (Dia == 2)
                    {
                        MessageBox.Show("Martes");
                    }

                    if (Dia == 3)
                    {
                        MessageBox.Show("Miercoles");
                    }

                    if (Dia == 4)
                    {
                        MessageBox.Show("Jueves");
                    }

                    if (Dia == 5)
                    {
                        MessageBox.Show("Viernes");
                    }

                    if (Dia == 6)
                    {
                        MessageBox.Show("Sábado");
                    }

                    if (Dia == 7)
                    {
                        MessageBox.Show("Domingo");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar un dato correcto");
            }
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            try
            {
                Mes = Convert.ToInt32(TxtMes.Text);

                if (Mes > 0 && Mes <= 12)
                {

                    if (Mes == 1)
                    {
                        MessageBox.Show("Enero");
                    }

                    if (Mes == 2)
                    {
                        MessageBox.Show("Febrero");
                    }

                    if (Mes == 3)
                    {
                        MessageBox.Show("Marzo");
                    }

                    if (Mes == 4)
                    {
                        MessageBox.Show("Abril");
                    }

                    if (Mes == 5)
                    {
                        MessageBox.Show("Mayo");
                    }

                    if (Mes == 6)
                    {
                        MessageBox.Show("Junio");
                    }

                    if (Mes == 7)
                    {
                        MessageBox.Show("Julio");
                    }

                    if (Mes == 8)
                    {
                        MessageBox.Show("Agosto");
                    }

                    if (Mes == 9)
                    {
                        MessageBox.Show("Septiembre");
                    }

                    if (Mes == 10)
                    {
                        MessageBox.Show("Octubre");
                    }

                    if (Mes == 11)
                    {
                        MessageBox.Show("Noviembre");
                    }

                    if (Mes == 12)
                    {
                        MessageBox.Show("Diciembre");
                    }
                    else
                    {
                        MessageBox.Show("Dato ingresado incorrecto");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un dato correcto");
            }
        }
                

        private void BtnAño_Click(object sender, EventArgs e)
        {
            try
            {
                Año = Convert.ToInt32(TxtAño.Text);

                if (Año > 1900 && Año <= 2022)
                {
                    if (Año == 2000)
                    {
                        MessageBox.Show("Año 2000");
                    }

                    if (Año == 2001)
                    {
                        MessageBox.Show("Año 2001");
                    }

                    if (Año == 2002)
                    {
                        MessageBox.Show("Año 2002");
                    }

                    if (Año == 2003)
                    {
                        MessageBox.Show("Año 2003");
                    }

                    if (Año == 2004)
                    {
                        MessageBox.Show("Año 2004");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar un dato correcto");
            }
            
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxtDia.Text = null;
            TxtMes.Text = null;
            TxtAño.Text = null;
        }
    }
}
