using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Titulares : Form
    {
        public persona[] Personas { get; set; } = new persona[1];

        //Propiedades //se cargan solamente dos jugadores titulares de tres fijos que ya hay
        string[] CargajugadorEq1 = new string[5];
        //string[] CargajugadorEq2 = new string[5];

        //Posición inicial de la carga de nombres de los jugadores
        int posicionEqTit1 = 0;


        public Frm_Titulares()
        {
            InitializeComponent();
        }

        //Boton para cargar nuevos jugadores del equipo 1
        public void BtnCargaJugadorEq1_Click(object sender, EventArgs e)
        {
            CargajugadorEq1[posicionEqTit1] = TxtCargaJugadorEq1.Text;
            posicionEqTit1 = posicionEqTit1 +1;
            TxtCargaJugadorEq1.Focus();
            TxtCargaJugadorEq1.SelectAll();
            LblMensaje1.Text = "";
            LblMensaje1.Text = "Carga correcta";
        }

        //Mostrar en pantalla nuevo jugador en la lista de jugadores del equipo 1
        public void BtnMostrarNuevojugadorEq1_Click(object sender, EventArgs e)
        {
            //Lismpia la lista, en el caso de que el usuario se arrepienta
            //de la cantidad de jugadores a cargar

            LblListaEquipo1.Text = " ";

            foreach (var item in CargajugadorEq1)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + item + "\r\n";
            }
        }
        
        //Dimensionar jugadores de equipo numero 2
        public void BtnEquipo1_Click(object sender, EventArgs e)
        {
            string[] Equiponumero1 = { };

            for (int i = 0; i < Equiponumero1.Length; i++)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + Equiponumero1[i] + "\r\n";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCargarCuerpoTec_Click(object sender, EventArgs e)
        {
            persona persona = new persona();
            persona.Nombre = TxtCuerpo.Text;
            Personas[0] = persona;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            LblMostrarCuerpo.Text = "Técnico - El señor... \r\n";
            foreach (persona item in Personas)
            {
                LblMostrarCuerpo.Text = LblMostrarCuerpo.Text + item.Nombre + "\r\n";


            }
        }

        private void BtnBorrarEq1_Click(object sender, EventArgs e)
        {
            TxtCargaJugadorEq1.Text = "";
        }
    }
}

        
        
        


            

            

           
       
        
           
       
        

      
    


        

        
            




        




       

       















