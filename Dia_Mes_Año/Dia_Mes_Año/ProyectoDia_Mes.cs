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

        //Variables Globales

        int Dia;
        int Mes;
        int Año;

        int IncrementoDia = 0;
        int DecrementoDia =31;
        int IncrementoAño;
        

        private void BtnSemana_Click(object sender, EventArgs e)
        {
            try
            {
                Dia = Convert.ToInt32(TxtDia.Text);

                if (Dia > 0 && Dia <= 31)
                {
                    if (Dia == 1)
                    {
                        LblDia.Text = "1";
                        //MessageBox.Show("Lunes");
                    }

                    if (Dia == 2)
                    {
                        LblDia.Text = "2";
                        //MessageBox.Show("Martes");
                    }

                    if (Dia == 3)
                    {
                        LblDia.Text = "3";
                        //MessageBox.Show("Miercoles");
                    }

                    if (Dia == 4)
                    {
                        LblDia.Text = "4";
                        //MessageBox.Show("Jueves");
                    }

                    if (Dia == 5)
                    {
                        LblDia.Text = "5";
                        //MessageBox.Show("Viernes");
                    }

                    if (Dia == 6)
                    {
                        LblDia.Text = "6";
                        //MessageBox.Show("Sábado");
                    }

                    if (Dia == 7)
                    {
                        LblDia.Text = "7";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 8)
                    {
                        LblDia.Text = "8";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 9)
                    {
                        LblDia.Text = "9";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 10)
                    {
                        LblDia.Text = "10";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 11)
                    {
                        LblDia.Text = "11";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 12)
                    {
                        LblDia.Text = "12";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 13)
                    {
                        LblDia.Text = "13";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 14)
                    {
                        LblDia.Text = "14";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 15)
                    {
                        LblDia.Text = "15";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 16)
                    {
                        LblDia.Text = "16";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 17)
                    {
                        LblDia.Text = "17";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 18)
                    {
                        LblDia.Text = "18";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 19)
                    {
                        LblDia.Text = "19";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 20)
                    {
                        LblDia.Text = "20";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 21)
                    {
                        LblDia.Text = "21";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 22)
                    {
                        LblDia.Text = "22";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 23)
                    {
                        LblDia.Text = "23";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 24)
                    {
                        LblDia.Text = "24";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 25)
                    {
                        LblDia.Text = "25";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 26)
                    {
                        LblDia.Text = "26";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 27)
                    {
                        LblDia.Text = "27";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 28)
                    {
                        LblDia.Text = "28";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 29)
                    {
                        LblDia.Text = "29";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 30)
                    {
                        LblDia.Text = "30";
                        //MessageBox.Show("Domingo");
                    }

                    if (Dia == 31)
                    {
                        LblDia.Text = "31";
                        //MessageBox.Show("Domingo");
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
                        LblMes.Text = "Enero";
                        //MessageBox.Show("Enero");
                    }

                    if (Mes == 2)
                    {
                        LblMes.Text = "Febrero";
                        //MessageBox.Show("Febrero");
                    }

                    if (Mes == 3)
                    {
                        LblMes.Text = "Marzo";
                        //MessageBox.Show("Marzo");
                    }

                    if (Mes == 4)
                    {
                        LblMes.Text = "Abril";
                        //MessageBox.Show("Abril");
                    }

                    if (Mes == 5)
                    {
                        LblMes.Text = "Mayo";
                        //MessageBox.Show("Mayo");
                    }

                    if (Mes == 6)
                    {
                        LblMes.Text = "Junio";
                        //MessageBox.Show("Junio");
                    }

                    if (Mes == 7)
                    {
                        LblMes.Text = "Julio";
                        //MessageBox.Show("Julio");
                    }

                    if (Mes == 8)
                    {
                        LblMes.Text = "Agosto";
                        //MessageBox.Show("Agosto");
                    }

                    if (Mes == 9)
                    {
                        LblMes.Text = "Septiembre";
                        //MessageBox.Show("Septiembre");
                    }

                    if (Mes == 10)
                    {
                        LblMes.Text = "Octubre";
                        //MessageBox.Show("Octubre");
                    }

                    if (Mes == 11)
                    {
                        LblMes.Text = "Noviembre";
                        //MessageBox.Show("Noviembre");
                    }

                    if (Mes == 12)
                    {
                        LblMes.Text = "Diciembre";
                        //MessageBox.Show("Diciembre");
                    }
                }
            }
            catch (Exception)
            {
                //LblMes.Text = "Debe ingresar un dato correcto";
                MessageBox.Show("Debe ingresar un dato correcto");
            }
        }
                    

                

        private void BtnAño_Click(object sender, EventArgs e)
        {
            try
            {
                Año = Convert.ToInt32(TxtAño.Text);

                if (Año >= 2000 && Año <= 2022)
                {
                    if (Año == 2000)
                    {
                        LblAño.Text = "Año 2000";
                        //MessageBox.Show("Año 2000");
                    }

                    if (Año == 2001)
                    {
                        LblAño.Text = "Año 2001";
                        //MessageBox.Show("Año 2001");
                    }

                    if (Año == 2002)
                    {
                        LblAño.Text = "Año 2002";
                        //MessageBox.Show("Año 2002");
                    }

                    if (Año == 2003)
                    {
                        LblAño.Text = "Año 2003";
                        //MessageBox.Show("Año 2003");
                    }

                    if (Año == 2004)
                    {
                        LblAño.Text = "Año 2004";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2005)
                    {
                        LblAño.Text = "Año 2005";
                        //MessageBox.Show("Año 2005");
                    }

                    if (Año == 2006)
                    {
                        LblAño.Text = "Año 2006";
                        //MessageBox.Show("Año 2006");
                    }

                    if (Año == 2007)
                    {
                        LblAño.Text = "Año 2007";
                        //MessageBox.Show("Año 2007");
                    }

                    if (Año == 2008)
                    {
                        LblAño.Text = "Año 2008";
                        //MessageBox.Show("Año 2008");
                    }

                    if (Año == 2009)
                    {
                        LblAño.Text = "Año 2009";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2010)
                    {
                        LblAño.Text = "Año 2010";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2011)
                    {
                        LblAño.Text = "Año 2011";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2012)
                    {
                        LblAño.Text = "Año 2012";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2013)
                    {
                        LblAño.Text = "Año 2013";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2014)
                    {
                        LblAño.Text = "Año 2014";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2015)
                    {
                        LblAño.Text = "Año 2015";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2016)
                    {
                        LblAño.Text = "Año 2016";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2017)
                    {
                        LblAño.Text = "Año 2017";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2018)
                    {
                        LblAño.Text = "Año 2018";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2019)
                    {
                        LblAño.Text = "Año 2019";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2020)
                    {
                        LblAño.Text = "Año 2020";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2021)
                    {
                        LblAño.Text = "Año 2021";
                        //MessageBox.Show("Año 2004");
                    }

                    if (Año == 2022)
                    {
                        LblAño.Text = "Año 2022";
                        //MessageBox.Show("Año 2004");
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

            LblDia.Text = null;
            LblMes.Text = null;
            LblAño.Text = null;
        }

        private void btincrementoDia_Click(object sender, EventArgs e)
        {
           

            ++IncrementoDia;
            LblDia.Text = Convert.ToString(IncrementoDia);

            if (IncrementoDia == 31)
            {
                MessageBox.Show("Ha llegado al limite");

            }



           

        }

        private void BtincrementoAño_Click(object sender, EventArgs e)
        {

            IncrementoAño = IncrementoAño + 1;
            //++IncrementoAño;
            LblAño.Text = Convert.ToString(IncrementoAño);
        }


        private void BtIncrementoMes_Click(object sender, EventArgs e)
        {
            if (Mes == 1)
            {
                //++Mes;
                LblMes.Text = "Febrero";
                //MessageBox.Show("Enero");
            }

            if (Mes == 2)
            {
                //++Mes;
                LblMes.Text = "Marzo";
                //MessageBox.Show("Enero");
            }

            if (Mes == 3)
            {
                //++Mes;
                LblMes.Text = "Abril";
                //MessageBox.Show("Enero");
            }

            if (Mes == 4)
            {
                //++Mes;
                LblMes.Text = "Mayo";
                //MessageBox.Show("Enero");
            }

            if (Mes == 5)
            {
                //++Mes;
                LblMes.Text = "Junio";
                //MessageBox.Show("Enero");
            }

            if (Mes == 6)
            {
                //++Mes;
                LblMes.Text = "Julio";
                //MessageBox.Show("Enero");
            }

            if (Mes == 7)
            {
                //++Mes;
                LblMes.Text = "Agosto";
                //MessageBox.Show("Enero");
            }

            if (Mes == 8)
            {
                //++Mes;
                LblMes.Text = "Septiembre";
                //MessageBox.Show("Enero");
            }

            if (Mes == 9)
            {
                //++Mes;
                LblMes.Text = "Octubre";
                //MessageBox.Show("Enero");
            }

            if (Mes == 10)
            {
                //++Mes;
                LblMes.Text = "Noviembre";
                //MessageBox.Show("Enero");
            }

            if (Mes == 11)
            {
                //++Mes;
                LblMes.Text = "Diciembre";
                //MessageBox.Show("Enero");
            }
        }
        private void BtDecrementarDia_Click(object sender, EventArgs e)
        {
            --DecrementoDia;
            LblDia.Text = Convert.ToString(DecrementoDia);

            if (DecrementoDia == 0)
            {
                MessageBox.Show("Ha llegado al límite de días");

            }

            //for (DecrementoDia = 31; DecrementoDia < 1; DecrementoDia--)
            //{
            //    MessageBox.Show("Limite alcanzaddo");
            //    break;
            //}
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtDecrementar_Click(object sender, EventArgs e)
        {
            IncrementoAño = IncrementoAño - 1;
            //++IncrementoAño;
            LblAño.Text = Convert.ToString(IncrementoAño);
        }
    }
}
