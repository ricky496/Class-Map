using System;

namespace Mapa_de_Clases
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
