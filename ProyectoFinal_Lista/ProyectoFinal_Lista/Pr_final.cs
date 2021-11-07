using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Lista
{
    public partial class Pr_final : Form
    {
       
        string[] NombreCompleto1;

        int posicion = -1;
        


        public void BtnDim_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(TxtDim.Text);
            NombreCompleto1 = new string[cantidad];
            TxtNombre.Focus();
            TxtNombre.SelectAll();
           
        }
       
        public void BtnAgregar_Click(object sender, EventArgs e)
        {

            NombreCompleto1[posicion] = TxtNombre.Text;
            posicion = posicion + 1;
            //Redimensionar();
            TxtNombre.Focus();
            TxtNombre.SelectAll();
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblLista.Text = "Lista principal: \r\n";
            foreach (string item in NombreCompleto1 )
            {
                LblLista.Text = LblLista.Text + item + "\r\n";
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }











        //private void Redimensionar()
        //{
        //    if (personas == null)
        //    {
        //        personas = new Persona[1];
        //    }
        //    else
        //    {
        //        Persona[] arraux = new Persona[personas.Length + 1];

        //        for (int contador = 0; contador <= personas.Length; contador++)
        //        {

        //            arraux[contador] = personas[contador + 1];
        //        }
        //        personas = arraux;

        //    }
        //}

    }
}

           

            
            
            




























