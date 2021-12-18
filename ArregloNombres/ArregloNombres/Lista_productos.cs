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

                Precio[Fila] = System.Convert.ToDecimal(TxtPrecio.Text);

                Fila = Fila + 1;

            }
           
        }
       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLista_Click(object sender, EventArgs e)
        {
            Lista_productos primerForm = new Lista_productos();
            primerForm.Show();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < Precio.Length; contador++)
            {
                LblListaPrecio.Text = LblListaPrecio.Text 
                + Producto[contador, 0] + " - " 
                + Producto[contador, 1] + " - " 
                + (Precio[contador]).ToString() 
                + "\r\n";

                //conversion con .tostring al arrelo o bien la conversion convencional
                //de system.convert.tostring("Lo que se va a convertir")
            }
        }
    }
}


