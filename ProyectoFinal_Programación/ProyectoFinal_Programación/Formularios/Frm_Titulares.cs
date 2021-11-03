using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Titulares : Form
    {
        public Persona Persona { get; set; }

        //Propiedades //se cargan solamente dos jugadores titulares de tres fijos que ya hay
        string[] CargajugadorEq1 = new string[5];
        //string[] CargajugadorEq2 = new string[5];

        //Posición inicial de la carga de nombres de los jugadores
        int posicionEqTit1 = 0;
        int posicionEqTit2 = 0;

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
    }
}

        
        
        


            

            

           
       
        
           
       
        

      
    


        

        
            




        




       

       















