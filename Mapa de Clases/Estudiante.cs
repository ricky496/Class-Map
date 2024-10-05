using System;

namespace Mapa_de_Clases
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        public double PromedioNotas { get; set; }

        public void Estudiar()
        {
            Console.WriteLine($"{Nombre} está estudiando.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Promedio de Notas: {PromedioNotas}");
        }
    }
}

