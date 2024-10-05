using System;

namespace Mapa_de_Clases
{
    internal class Empleado : MiembroDeLaComunidad
    {
        public double Sueldo { get; set; }

        public void Trabajar()
        {
            Console.WriteLine($"{Nombre} está trabajando.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
