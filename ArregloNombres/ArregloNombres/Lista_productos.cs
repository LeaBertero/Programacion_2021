using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloNombres
{
    public partial class Lista_productos : Form
    {

        private string[,] Producto = new string[3, 2];
        private decimal[] Precio = new decimal[3];
        private int Fila = 0;

        public Lista_productos()
        {
            InitializeComponent();
            
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (Fila > 2)
            {
                LblListaPrecio.Text = "Solo se aceptan 3 productos";
            }
            else
            {
                Producto[Fila, 0] = TxtCodigo.Text;
                Producto[Fila, 1] = TxtProducto.Text;

                try
                {
                    Precio[Fila] = System.Convert.ToDecimal(TxtPrecio.Text);
                }
                catch (Exception)
                {

                    lblerror.Text = "No puede ingresar letras en el apartado -  (Precio)";
                }

                Fila = Fila + 1;

            }
           
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            LblListaPrecio.Text = "LISTA DE PRECIOS \r\n";

            for (int celda = 0; celda < Precio.Length; celda++)
            {

                LblListaPrecio.Text = LblListaPrecio.Text + Producto[celda, 0] 
                    + " - " 
                    + Producto[celda, 1] 
                    + Precio + " - " 
                    + Precio[celda].ToString() 
                    + "\r\n";
            }
        }
        private void FrmLista_Click(object sender, EventArgs e)
        {
            Lista_productos primerForm = new Lista_productos();
            primerForm.ShowDialog();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}





              
               


                
                



