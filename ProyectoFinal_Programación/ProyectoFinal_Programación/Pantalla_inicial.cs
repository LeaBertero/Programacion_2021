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
        string[] NuevojugadorEq1 = new string [5];
        string[] NuevojugadorEq2 = new string[5];
        int posicion = 0;


        public Pantalla_inicial()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Boton para cargar nuevos jugadores del equipo 1
        private void BtnCargaJugadorEq1_Click(object sender, EventArgs e)
        {
            NuevojugadorEq1[posicion]= TxtCargaJugadorEq1.Text;
            posicion = posicion + 1;
            TxtCargaJugadorEq1.Focus();
            TxtCargaJugadorEq1.SelectAll();
        }
        
        //Boton para cargar nuevos jugadores del equipo 1
        private void BtnCargaJugadorEq2_Click(object sender, EventArgs e)
        {
            NuevojugadorEq2[posicion] = TxtCargaJugadorEq2.Text;
            posicion = posicion + 1;
            TxtCargaJugadorEq2.Focus();
            TxtCargaJugadorEq2.SelectAll();
        }


        private void BtnMostrarNuevojugadorEq1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarNuevojugadorEq2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquipo1_Click(object sender, EventArgs e)
        {
            string[] Equiponumero1 = {"Jugador 1", "Jugador 2", "Jugador 3", 
                "Jugador 4", "Jugador 5" };

            for (int i = 0; i < Equiponumero1.Length; i++)
            {
                LblEquipo1.Text = LblEquipo1.Text + Equiponumero1[i] + "\r\n";
            }

            LblEquipo1.Visible = true;


            //Equiponumero1[0] = "jugador 1";
            //Equiponumero1[1] = "jugador 2";
            //Equiponumero1[2] = "jugador 3";
            //Equiponumero1[3] = "jugador 4";
            //Equiponumero1[4] = "jugador 5";

            //LblEquipo1.Text = Equiponumero1[3];
        }


        private void BtnEquipo2_Click(object sender, EventArgs e)
        {
            string[] Equiponumero2 = {"Jugador 1", "Jugador 2", "Jugador 3",
                "Jugador 4", "Jugador 5" };

            for (int i = 0; i < Equiponumero2.Length; i++)
            {
                LblEquipo2.Text = LblEquipo2.Text + Equiponumero2[i] + "\r\n";
            }

            LblEquipo2.Visible = true;

        }

       
    }
}

        
