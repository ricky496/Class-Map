using System;

namespace Mapa_de_Clases
{
    internal class Docente : Empleado
    {
        public string Materia { get; set; }

        public void DarClase()
        {
            Console.WriteLine($"{Nombre} está dando clase de {Materia}.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }
    }
}
