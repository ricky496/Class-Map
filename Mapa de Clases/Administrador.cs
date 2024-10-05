using System;

namespace Mapa_de_Clases
{
    internal class Administrador : Empleado
    {
        public void Gestionar()
        {
            Console.WriteLine($"{Nombre} está gestionando.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Rol: Administrador");
        }
    }
}
