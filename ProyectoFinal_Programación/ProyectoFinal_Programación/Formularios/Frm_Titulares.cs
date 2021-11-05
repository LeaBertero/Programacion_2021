using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class DataGr : Form
    {

        //Propiedades
        public persona[] Personas { get; set; } = new persona[1];
      


        string[] CargajugadorEq1 = new string[5];
        string[] Equiponumero1 = { };
        //public int AñoNacimiento { get; set; }

        //Posición inicial de la carga de nombres de los jugadores
        int posicionEqTit1 = 0;

        
        
        //Boton para cargar nuevos jugadores del equipo 1
        public void BtnCargaJugadorEq1_Click(object sender, EventArgs e)
        {
            persona persona = new persona();

            persona.Edad = System.Convert.ToInt32(TxtAño.Text);
            persona.Nombre = TxtCargaJugadorEq1.Text;

            bool resp = true;
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
            //Limpia la lista, en el caso de que el usuario se arrepienta
            //de la cantidad de jugadores a cargar

            LblListaEquipo1.Text = "";
            LblListaEquipo1.Text = "\r\n";
            foreach (var item in CargajugadorEq1)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text +  item +  "\r\n";
            }
        }

        private void BtnCargarCuerpoTec_Click(object sender, EventArgs e)
        {
            persona persona = new persona();
            persona.Nombre = TxtCuerpo.Text;
            Personas[0] = persona;
        }
        public void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblMostrarCuerpo.Text = "Técnico - El señor... \r\n";
            foreach (persona item in Personas)
            {
                LblMostrarCuerpo.Text = LblMostrarCuerpo.Text + item.Nombre + item.Edad.ToString() + item.Nombre + "\r\n";
            }
        }
        public void BtnBorrarEq1_Click(object sender, EventArgs e)
        {
            TxtCargaJugadorEq1.Text = "";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnBorrarListaEq1_Click(object sender, EventArgs e)
        {
            LblListaEquipo1.Text = "";
        }
    }
}






        





        
        






        
        
        


            

            

           
       
        
           
       
        

      
    


        

        
            




        




       

       















