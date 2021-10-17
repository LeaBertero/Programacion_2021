using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Pantalla_inicial : Form
    {
        //Variables
        string[] NuevojugadorEq1;
        string[] NuevojugadorEq2 = new string[5];

        //Posición inicial de la carga de nombres de los jugadores
        int posicion = 0;

        public Pantalla_inicial()
        {
            InitializeComponent();
        }


        //Boton para cargar nuevos jugadores del equipo 1
        public void BtnCargaJugadorEq1_Click(object sender, EventArgs e)
        {
            NuevojugadorEq1[posicion]= TxtCargaJugadorEq1.Text;
            posicion = posicion + 1;
            TxtCargaJugadorEq1.Focus();
            TxtCargaJugadorEq1.SelectAll();
        }

        //Boton para cargar nuevos jugadores del equipo 1
        public void BtnCargaJugadorEq2_Click(object sender, EventArgs e)
        {
            NuevojugadorEq2[posicion] = TxtCargaJugadorEq2.Text;
            posicion = posicion + 1;
            TxtCargaJugadorEq2.Focus();
            TxtCargaJugadorEq2.SelectAll();
        }
        //Mostrar en pantalla nuevo jugador en la lista de jugadores del equipo 1
        public void BtnMostrarNuevojugadorEq1_Click(object sender, EventArgs e)
        {
            //Lismpia la lista, en el caso de que el usuario se arrepienta
            //de la cantidad de jugadores a cargar

            LblListaEquipo1.Text = "";

            foreach (var item in NuevojugadorEq1)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + item + "\r\n";
            }
        }
        //Mostrar en pantalla nuevo jugador en la lista de jugadores del equipo 2
        public void BtnMostrarNuevojugadorEq2_Click(object sender, EventArgs e)
        {
            //Lismpia la lista, en el caso de que el usuario se arrepienta
            //de la cantidad de jugadores a cargar

            LblListaEquipo1.Text = "";

            foreach (var item in NuevojugadorEq2)
            {
                LblListaEquipo2.Text = LblListaEquipo2.Text + item + "\r\n";
            }
        }



        //Dimensionar jugadores de equipo numero 1
        public void BtnDimEq1_Click(object sender, EventArgs e)
        {
            int cantidad = System.Convert.ToInt32(TxtDimJugadorEq1.Text);
            NuevojugadorEq1 = new string[cantidad];
        }

        //Dimensionar jugadores de equipo numero 2
        public void BtnDimEq2_Click(object sender, EventArgs e)
        {
            int cantidad = System.Convert.ToInt32(TxtDimJugadorEq2.Text);
            NuevojugadorEq2 = new string[cantidad];
        }

        public void BtnEquipo1_Click(object sender, EventArgs e)
        {
            string[] Equiponumero1 = {"Jugador 1", "Jugador 2", "Jugador 3", 
                "Jugador 4", "Jugador 5" };

            for (int i = 0; i < Equiponumero1.Length; i++)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + Equiponumero1[i] + "\r\n";
            }

            LblListaEquipo1.Visible = true;

            //Equiponumero1[0] = "jugador 1";
            //Equiponumero1[1] = "jugador 2";
            //Equiponumero1[2] = "jugador 3";
            //Equiponumero1[3] = "jugador 4";
            //Equiponumero1[4] = "jugador 5";

            //LblEquipo1.Text = Equiponumero1[3];

        }


        public void BtnEquipo2_Click(object sender, EventArgs e)
        {
            string[] Equiponumero2 = {"Jugador 1", "Jugador 2", "Jugador 3",
                "Jugador 4", "Jugador 5" };

            for (int i = 0; i < Equiponumero2.Length; i++)
            {
                LblListaEquipo2.Text = LblListaEquipo2.Text + Equiponumero2[i] + "\r\n";
            }

            LblListaEquipo2.Visible = true;

            //Equiponumero1[0] = "jugador 1";
            //Equiponumero1[1] = "jugador 2";
            //Equiponumero1[2] = "jugador 3";
            //Equiponumero1[3] = "jugador 4";
            //Equiponumero1[4] = "jugador 5";

            //LblEquipo1.Text = Equiponumero1[3];

        }

        //ÉSTE BOTÓN CIERRA EL PROGRAMA
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

        

        
