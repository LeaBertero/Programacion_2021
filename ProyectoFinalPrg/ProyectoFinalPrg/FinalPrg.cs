using ProyectoFinalPrg.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoFinalPrg
{
    public partial class FinalPrg : Form
    {
        //Propiedades
        public Jugador[] Personas { get; set; } = new Jugador[5];
        public int pos = -1;
        public FinalPrg()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Botón salir (Método)
            Close();
        }
        public void BtnCarga_Click(object sender, EventArgs e)
        {
            //Método instanciado e inicializado
            //por nombre, año de nacimiento
            //y posicion


            Jugador Persona = new Jugador();

            Persona.Nombre = TxtIngreso.Text;
            Persona.AñoNacimiento = Convert.ToInt32(TxtAño.Text);

            pos = pos + 1;
            Personas[pos] = Persona;
            TxtIngreso.Focus();
            TxtIngreso.SelectAll();


            
        }
        private void BtnClickLista_Click(object sender, EventArgs e)
        {

            LblMostrarLista.Text = "Lista de titulares \r\n";
            foreach (Jugador item in Personas)
            {
                LblMostrarLista.Text = LblMostrarLista.Text + item.AñoNacimiento.ToString() + item.Nombre  + "\r\n";
            }

        }


        public void Redimensionar(object sender, EventArgs e)
        {

            if (Personas == null)
            {
                Personas = new Jugador[1];
            }
            else
            {
                Jugador[] Arraux = new Jugador[Personas.Length + 1];
                for (int i = 0; i < Personas.Length; i++)
                {
                    Arraux[i] = Personas[i];
                }
                Personas = Arraux;
            }
        }


       


        private void BtnAparecerLista_Click(object sender, EventArgs e)
        {
            LblMostrarLista.Visible = true;
        }

       



    }




}

        




       


             






        
        

            


        

