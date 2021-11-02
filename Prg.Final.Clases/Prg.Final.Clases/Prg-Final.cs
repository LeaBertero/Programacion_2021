using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg.Final.Clase
{
    public partial class Form1 : Form
    {

        public Persona Persona { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnCarga_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
