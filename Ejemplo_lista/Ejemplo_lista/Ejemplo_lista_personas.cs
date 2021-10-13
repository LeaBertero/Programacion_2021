using Ejemplo_lista.Clases_Para_Formulario;
using System;
using System.Windows.Forms;

namespace Ejemplo_lista
{
    public partial class Ejemplo_lista_personas : Form
    {
        //Esta lista, es un arreglo de personas

        //public Persona[] Personas { get; set; } = new Persona [3];
        // public int Pos = -1;
        //public Persona[] Personas { get; set; }

        public Ejemplo_lista_personas()
        {
            InitializeComponent();
        }
        
        public ListaPersonas Lista { get; set; } = new ListaPersonas();
        
        
        public void BtnCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = TxtNombre.Text;
            persona.AñoNacimiento = System.Convert.ToInt32(TxtAño.Text);
            //Pos = Pos + 1;
            Lista.Redimensionar();
            //Personas[Personas.Length - 1] = persona;
            Lista.Personas[Lista.Personas.Length - 1] = persona;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblLista.Text = "Lista de personas: \r\n";
            foreach (Persona item in Lista.Personas)
            {
                LblLista.Text = LblLista.Text 
                + item.AñoNacimiento.ToString() 
                + " - " + item.Nombre 
                + "\r\n";
            }
        }

        //private void Redimensionar()
        //{
        //    if (Lista.Personas == null)
        //    {
        //        Lista.Personas = new Persona[1];
        //    }
        //    else
        //    {
        //        Persona[] Arraux = new Persona[Lista.Personas.Length + 1];

        //        for (int i = 0; i < Lista.Personas.Length; i++)
        //        {
        //            Arraux[i] = Lista.Personas[i];
        //        }
        //        Lista.Personas = Arraux;
        //    }
        //}
       
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}





        



 
        



        

        

        









