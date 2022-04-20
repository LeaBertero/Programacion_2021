using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDgV
{


    
    public partial class PruebaDataGr : Form
    {

        private int Fila = 0;

        public PruebaDataGr()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int Fila = DgProductos.Rows.Add();

            DgProductos.Rows[Fila].Cells[0].Value = TxtCodigo.Text;
            DgProductos.Rows[Fila].Cells[1].Value = TxtNombre.Text;
            DgProductos.Rows[Fila].Cells[2].Value = TxtPrecio.Text;

            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            TxtPrecio.Text = null;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (Fila != -1)
            {
                DgProductos.Rows.RemoveAt(Fila);
            }
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;

            if (Fila != -1)
            {
                LblInformacion.Text = (string)DgProductos.Rows[Fila].Cells[1].Value;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
