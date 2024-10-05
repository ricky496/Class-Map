using System;
using System.Collections.Generic;

namespace Mapa_de_Clases
{
    internal class Program
    {
        static List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEstudiante();
                        break;
                    case "2":
                        AgregarEmpleado();
                        break;
                    case "3":
                        AgregarAdministrativo();
                        break;
                    case "4":
                        MostrarMiembros();
                        break;
                    case "5":
                        return; // Salir
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Agregar Empleado");
            Console.WriteLine("3. Agregar Administrativo");
            Console.WriteLine("4. Mostrar Información");
            Console.WriteLine("5. Salir");
        }

        static void AgregarEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            Console.Write("Nombre: ");
            estudiante.Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            estudiante.Edad = int.Parse(Console.ReadLine());
            Console.Write("Promedio de Notas: ");
            estudiante.PromedioNotas = double.Parse(Console.ReadLine());
            miembros.Add(estudiante);
        }

        static void AgregarEmpleado()
        {
            Empleado empleado = new Empleado();
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            empleado.Edad = int.Parse(Console.ReadLine());
            Console.Write("Sueldo: ");
            empleado.Sueldo = double.Parse(Console.ReadLine());
            miembros.Add(empleado);
        }

        static void AgregarAdministrativo()
        {
            Administrativo administrativo = new Administrativo();
            Console.Write("Nombre: ");
            administrativo.Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            administrativo.Edad = int.Parse(Console.ReadLine());
            Console.Write("Sueldo: ");
            administrativo.Sueldo = double.Parse(Console.ReadLine());
            miembros.Add(administrativo);
        }

        static void MostrarMiembros()
        {
            foreach (var miembro in miembros)
            {
                miembro.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
