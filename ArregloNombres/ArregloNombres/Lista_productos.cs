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
            
               
            try
            {

                if (Fila > 2)
                {
                    LblListaPrecio.Text = "Solo se aceptan 3 productos";
                }
                else
                {
                    
                    Producto[Fila, 0] = TxtCodigo.Text;
                    Producto[Fila, 1] = TxtProducto.Text;

                    Precio[Fila] = System.Convert.ToDecimal(TxtPrecio.Text);
                    Fila = Fila + 1;

                }

            }
            catch (Exception)
            {

                lblerror.Text = "No puede ingresar letras en el apartado -  (Precio)";
            }
        
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            LblListaPrecio.Text = "CÓDIGO - PRODUCTO - PRECIO \r\n \r\n"; 

            for (int celda = 0; celda < Precio.Length; celda++)
            {

                LblListaPrecio.Text = LblListaPrecio.Text +
                    Producto[celda, 0] 
                    + " - " 
                    + Producto[celda, 1] 
                    //+ Precio[celda] + " - " 
                    + Precio[celda].ToString() 
                    + "\r\n";
            }
        }
       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


               




            



                

           






              
               


                
                



