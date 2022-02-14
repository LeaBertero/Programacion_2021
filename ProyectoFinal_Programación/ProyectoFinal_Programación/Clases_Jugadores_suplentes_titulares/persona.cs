using System;


namespace ProyectoFinal_Programación
{
    public class persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Form1 Dt = new Form1();

        //Constructor de la clase persona
        public persona()
        {
            

        }

        public bool Validar()
        {
            bool resp = false;

            if (Edad > 16 && Edad <= 30)
            {
                resp = true;
            }
            return resp;
        }


      

    }

}
         
        


        








