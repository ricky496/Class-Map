using System;

namespace Mapa_de_Clases
{
    internal class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }
}

