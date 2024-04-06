using System;
using System.Collections.Generic;

namespace ListaTareas
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("----- Menú -----");
                Console.WriteLine("1. Mostrar tareas");
                Console.WriteLine("2. Agregar tarea");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese su opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarTareas();
                        break;
                    case "2":
                        AgregarTarea();
                        break;
                    case "3":
                        EliminarTarea();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void MostrarTareas()
        {
            Console.WriteLine("----- Lista de Tareas -----");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas por realizar.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + tareas[i]);
                }
            }
            Console.WriteLine();
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente.\n");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
            }
            else
            {
                Console.Write("Ingrese el número de la tarea a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tareas.Count)
                {
                    tareas.RemoveAt(indice - 1);
                    Console.WriteLine("Tarea eliminada exitosamente.\n");
                }
                else
                {
                    Console.WriteLine("Número de tarea inválido.\n");
                }
            }
        }
    }
}
