﻿using System;

namespace ProyectoFinalPrg.Clases
{
    public class Jugador
    {

        
        public string Nombre { get; set; }

        public int AñoNacimiento { get; set; }
        public object Personas { get; private set; }

        public void AddPersona(string nombre, string año)
        {
            Jugador Persona = new Jugador();

            Persona.Nombre = nombre;
            Persona.AñoNacimiento = Convert.ToInt32(año);

        }
            
           

       

        public bool Validar() 
        {
            bool resp = false;

            if (AñoNacimiento > 1900 && AñoNacimiento <= DateTime.Now.Year)
            {
                resp = true;   
            }

            return resp;
        }
        
    }


}



      



       
