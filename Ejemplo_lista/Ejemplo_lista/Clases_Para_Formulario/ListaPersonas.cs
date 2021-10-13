using Ejemplo_lista.Clases_Para_Formulario;

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
    }
}


       

