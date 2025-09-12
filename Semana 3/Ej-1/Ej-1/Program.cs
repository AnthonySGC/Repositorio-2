// See https://aka.ms/new-console-template for more information
// Importamos las librerías básicas de C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definimos el espacio de nombres del programa
namespace ej2
{
    // Clase principal
    internal class Program
    {
        // Método principal (punto de entrada del programa)
        static void Main(string[] args)
        {
            // ---------------- VARIABLES PRINCIPALES ----------------
            bool opcion = true;         // Controla si el programa sigue ejecutándose (si el usuario quiere seguir comprando)
            string seleccion;           // Guarda la respuesta del usuario (1 = sí, 2 = no, etc.)
            int select = 0;             // Número del producto seleccionado
            int cantidad = 0;           // Cantidad de productos elegidos
            float subtotal = 0;         // Acumula el total sin descuento
            float precio = 0;           // Precio temporal del producto elegido
            float porcentaje = 0.20F;   // Porcentaje de descuento (20%)
            float montoMaximo = 200;    // Monto mínimo para aplicar descuento
            float descuento = 0;        // Monto del descuento calculado
            float totalConDesc = 0;     // Total después de aplicar descuento

            // ---------------- BUCLE PRINCIPAL ----------------
            while (opcion)
            {
                // Preguntamos al usuario si desea comprar un producto
                Console.WriteLine("¿Desea comprar un producto?");
                Console.WriteLine("1) Si");
                Console.WriteLine("2) No");

                seleccion = Console.ReadLine(); // Guardamos la opción ingresada por el usuario

                // ---------------- SI ELIGE COMPRAR ----------------
                if (seleccion == "1")
                {
                    // Mostramos menú de productos disponibles
                    Console.WriteLine("1)Producto:  Coca cola, Precio: 35");
                    Console.WriteLine("2)Producto:  Pan, Precio: 20");
                    Console.WriteLine("3)Producto:  Huevo, Precio: 150");

                    // Intentamos leer un número de producto (validación con TryParse)
                    bool productoValido = int.TryParse(Console.ReadLine(), out select);

                    // Si no es válido o está fuera del rango (1-3), pedimos repetir
                    if (!productoValido || select < 1 || select > 3)
                    {
                        Console.WriteLine("Por favor, ingrese un número válido de producto (1-3).");
                        continue; // Regresa al inicio del bucle
                    }

                    // Según la selección, asignamos precio y calculamos subtotal con la función
                    switch (select)
                    {
                        case 1:
                            precio = 35;
                            subtotal += subtotalFuncion(precio, cantidad);
                            break;
                        case 2:
                            precio = 20;
                            subtotal += subtotalFuncion(precio, cantidad);
                            break;
                        case 3:
                            precio = 150;
                            subtotal += subtotalFuncion(precio, cantidad);
                            break;
                    }
                }
                // ---------------- SI ELIGE SALIR ----------------
                else if (seleccion == "2")
                {
                    opcion = false; // Se termina el ciclo

                    // Mostramos el descuento aplicado
                    Console.WriteLine($"Descuento: {obtenerDescuento(subtotal)}");

                    // Mostramos el total final con descuento
                    Console.WriteLine($"Total a pagar: {totalConDescuento(subtotal)}");

                    Console.ReadKey(); // Espera que el usuario presione una tecla antes de cerrar
                }
                // ---------------- OPCIÓN INVÁLIDA ----------------
                else
                {
                    Console.WriteLine("Ingrese números de acuerdo a la lista");
                    continue; // Regresa al inicio del bucle
                }
            }

            // ------------------- FUNCIONES AUXILIARES -------------------

            // Calcula el subtotal de un producto (precio * cantidad)
            float subtotalFuncion(float precioP, int cantidadP)
            {
                return precioP * cantidadP;
            }

            // Calcula el descuento a aplicar en base al subtotal
            float obtenerDescuento(float total)
            {
                if (total >= montoMaximo) // Solo aplica si supera el monto mínimo
                {
                    descuento = total * porcentaje; // Calculamos descuento
                }
                else
                {
                    descuento = 0; // Si no alcanza el monto, no hay descuento
                }

                return descuento; // Retornamos el valor del descuento
            }

            // Calcula el total final aplicando el descuento
            float totalConDescuento(float total)
            {
                totalConDesc = total - descuento; // Total menos descuento
                return totalConDesc; // Retornamos el total final
            }
        }
    }
}
