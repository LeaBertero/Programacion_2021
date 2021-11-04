using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programación
{
    public partial class Frm_Titulares : Form
    {

        //Propiedades
        public persona[] Personas { get; set; } = new persona[1];
        string[] Equiponumero1 = { };
        string[] CargajugadorEq1 = new string[5];

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

            LblListaEquipo1.Text = "";

            foreach (var item in CargajugadorEq1)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + item + "\r\n";
            }
        }

        public void BtnEquipo1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Equiponumero1.Length; i++)
            {
                LblListaEquipo1.Text = LblListaEquipo1.Text + Equiponumero1[i] + "\r\n";
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
                LblMostrarCuerpo.Text = LblMostrarCuerpo.Text + item.Nombre + "\r\n";


            }
        }
        public void BtnBorrarEq1_Click(object sender, EventArgs e)
        {
            TxtCargaJugadorEq1.Text = "";
        }

        //public void BtnBuscarJug_Click(object sender, EventArgs e)
        //{
        //    private void Btn_Buscar_Click(object sender, EventArgs e)
        //    {
        //        Personas = persona.(Convert.ToInt32(TB_BuscarID.Text));

        //        if (persona.Id > 0)
        //        {
        //            TB_BuscarCat.Text = Prod.Cat;
        //            TB_BuscarCant.Text = Prod.Cant.ToString();
        //            TB_BuscarProd.Text = Prod.Prod;

        //            TB_BuscarID.Focus();

        //            Lbl_Notificaciones.Text = "Producto encontrado.";
        //        }
        //        else
        //        {
        //            TB_BuscarCat.Text = "";
        //            TB_BuscarCant.Text = "";
        //            TB_BuscarProd.Text = "";
        //            TB_BuscarID.Focus();
        //            TB_BuscarID.SelectAll();

        //            Lbl_Notificaciones.Text = "El producto no existe.";
        //        }
        //    }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}


        
        






        
        
        


            

            

           
       
        
           
       
        

      
    


        

        
            




        




       

       















