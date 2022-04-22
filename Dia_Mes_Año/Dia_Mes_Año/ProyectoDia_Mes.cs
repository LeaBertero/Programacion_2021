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

        private void BtnMes_Click(object sender, EventArgs e)
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

        private void BtnAño_Click(object sender, EventArgs e)
        {
            Año = Convert.ToInt32(TxtAño.Text);

            if (Año > 1900 && Año < 2022)
            {
                
            }
            else
            {
                MessageBox.Show("Año incorrecto");
            }
        }
    }
}
