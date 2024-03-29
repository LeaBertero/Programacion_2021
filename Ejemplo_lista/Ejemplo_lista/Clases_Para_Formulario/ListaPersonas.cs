﻿using Ejemplo_lista.Clases_Para_Formulario;
using System;

namespace Ejemplo_lista
{
    public class ListaPersonas
    {
        public Persona[] Personas { get; set; }

        public void Redimensionar()
        {
            if (Personas == null)
            {
                Personas = new Persona[1];
            }
            else
            {
                Persona[] Arraux = new Persona[Personas.Length + 1];

                for (int i = 0; i < Personas.Length; i++)
                {
                    Arraux[i] = Personas[i];
                }
                Personas = Arraux;
            }
        }

        public bool AddPersona(string Nombre, string Año)
        {
            Persona persona = new Persona();
            persona.Nombre = Nombre;
            persona.AñoNacimiento = System.Convert.ToInt32(Año);
            
            bool resp = persona.Validar();

            if (resp)
            {

                Redimensionar();

                Personas[Personas.Length - 1] = persona;

            }
            return resp;

        }

        //Override es para que no de error el ToString (Conversion)
        //que viene por defecto en visual
        //Overrode = Sobrescribr los métodos
        public override string ToString()
        {

            string Resp = "";

            Resp = "Lista de personas: \r\n";

            foreach (Persona item in Personas)
            {
                Resp = Resp
                + item.AñoNacimiento.ToString()
                + " - " + item.Nombre
                + "\r\n";
            }

            return Resp;
        }
        public int AñoNacimiento { get; set; }

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

                
















