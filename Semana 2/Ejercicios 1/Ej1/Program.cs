// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        int totalProductos = 0;
        double totalVentas = 0;
        bool huboVentaMayorista = false;

        Console.WriteLine("=== Control Diario de Ventas ===");
        string continuar;

        do
        {
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            double precio = double.Parse(Console.ReadLine());

            double venta = cantidad * precio;
            totalVentas += venta;
            totalProductos += cantidad;

            if (venta > 10000)
            {
                Console.WriteLine("¡Alerta! Venta individual supera los C$10,000 (posible venta mayorista)");
                huboVentaMayorista = true;
            }

            Console.Write("¿Desea registrar otra venta? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        Console.WriteLine("\n=== Resumen del Día ===");
        Console.WriteLine($"Total de ventas: C${totalVentas:N2}");
        Console.WriteLine($"Número de productos registrados: {totalProductos}");
        if (!huboVentaMayorista)
        {
            Console.WriteLine("No hubo ventas individuales mayores a C$10,000.");
        }
    }
} 
