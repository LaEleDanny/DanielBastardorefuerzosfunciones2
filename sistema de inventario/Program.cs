using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> inventario = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Actualizar cantidad");
            Console.WriteLine("4. Mostrar inventario");
            Console.WriteLine("5. Salir");

            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre del producto: ");
                    string producto = Console.ReadLine();
                    Console.Write("Cantidad en stock: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    inventario[producto] = cantidad;
                    break;

                case 2:
                    Console.Write("Nombre del producto a eliminar: ");
                    string productoEliminar = Console.ReadLine();
                    inventario.Remove(productoEliminar);
                    break;

                case 3:
                    Console.Write("Nombre del producto a actualizar: ");
                    string productoActualizar = Console.ReadLine();
                    Console.Write("Nueva cantidad en stock: ");
                    int nuevaCantidad = int.Parse(Console.ReadLine());
                    inventario[productoActualizar] = nuevaCantidad;
                    break;

                case 4:
                    Console.WriteLine("Inventario:");
                    foreach (var kvp in inventario)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                    break;

                case 5:
                    Console.WriteLine("¡Hasta luego!");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }
}