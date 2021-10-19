using ProyectoFinal_Programación.Clases_Jugadores_suplentes;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Suplentes : Form
    {
        public SuplentesEq1 SuplentesEq1;

        public Frm_Suplentes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


