
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg.Final
{
    public partial class Form1 : Form
    {
        //Propiedades
        string[] Nombres = new string[5];
        //public Persona[] personas { get; set; }


        //Variable pública
        int pos = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        //Método
        private void BtnCarga_Click(object sender, EventArgs e)
        {
            Nombres[pos] = TxtIngreso.Text;
            pos = pos + 1;
            TxtIngreso.Focus();
            TxtIngreso.SelectAll();
        }

        //Método
        private void BtnMostrarLista_Click(object sender, EventArgs e)
        {
            LblMostrar.Text = "";
            foreach (string item in Nombres)
            {
                LblMostrar.Text = LblMostrar.Text + item + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    
}
