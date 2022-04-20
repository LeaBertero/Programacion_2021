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


    
    public partial class Form1 : Form
    {

        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int n = DgProductos.Rows.Add();

            DgProductos.Rows[n].Cells[0].Value = TxtCodigo.Text;
            DgProductos.Rows[n].Cells[1].Value = TxtNombre.Text;
            DgProductos.Rows[n].Cells[2].Value = TxtPrecio.Text;

            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            TxtPrecio.Text = null;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                DgProductos.Rows.RemoveAt(n);
            }
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                LblInformacion.Text = (string)DgProductos.Rows[n].Cells[1].Value;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
