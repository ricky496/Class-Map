using System;

namespace Mapa_de_Clases
{
    internal class MiembroDeLaComunidad : Persona
    {
        public string Direccion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }
}
