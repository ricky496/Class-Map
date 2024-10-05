using System;

namespace Mapa_de_Clases
{
    internal class Administrativo : Empleado
    {
        public void GestionarRecursos()
        {
            Console.WriteLine($"{Nombre} está gestionando recursos administrativos.");
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Rol: Administrativo");
        }
    }
}

