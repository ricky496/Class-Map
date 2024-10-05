using System;

namespace Mapa_de_Clases
{
    internal class Maestro : Docente
    {
        public void PrepararExamen()
        {
            Console.WriteLine($"{Nombre} está preparando un examen.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Rol: Maestro");
        }
    }
}
