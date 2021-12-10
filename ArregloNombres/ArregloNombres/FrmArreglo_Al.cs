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
    public partial class FrmArreglo_Al : Form
    {
        //Variable publica  - se ve en todo el programa
        string[] Lista = new string[5];
        int posicion = 0;
        


        //Constructor del formulario
        public FrmArreglo_Al()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Lista[posicion] = TxtCargar.Text;
            posicion = posicion + 1;
            LblLista.Text = LblLista.Text + TxtCargar.Text + "\r\n";
            TxtCargar.Text = "";
            TxtCargar.Focus();

        }
    }
}
