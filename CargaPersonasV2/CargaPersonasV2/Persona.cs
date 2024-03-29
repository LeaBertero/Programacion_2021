﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Nombre del name space
namespace CargaPersonasV2
{
    public class Persona
    {
        //Propiedades de la persona
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Materia MateriaCursando { get; set; } = new Materia();

        public string NombreCompleto()
        {
            return Nombre + Apellido;
        }

        public void Inscribir(Materia materia)
        {
            MateriaCursando = materia;
        }

    }
}

