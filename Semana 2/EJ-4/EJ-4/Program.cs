// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("   FERRETERÍA CARRETERA MASAYA      ");
        Console.WriteLine("==================================\n");

        string formato = "dd/MM/yyyy";
        DateTime fechaEntrega;
        bool fechaValida = false;

        while (!fechaValida)
        {
            Console.Write("Ingrese la fecha de entrega (dd/MM/yyyy): ");
            string input = Console.ReadLine()!.Trim(); // el ! evita advertencia de null

            try
            {
                // Intentar parsear exactamente en dd/MM/yyyy
                fechaEntrega = DateTime.ParseExact(input, formato, CultureInfo.InvariantCulture);

                // Fecha válida: mostrar y registrar
                Console.WriteLine("\nFecha válida: " + fechaEntrega.ToString("dd/MM/yyyy") + "\n");
                File.AppendAllText("fechas_validas.txt", $"[{DateTime.Now}] Fecha válida ingresada: {fechaEntrega:dd/MM/yyyy}{Environment.NewLine}");

                fechaValida = true; // salir del bucle
            }
            catch (FormatException)
            {
                // Registrar el error en log.txt
                File.AppendAllText("log.txt", $"[{DateTime.Now}] Formato inválido ingresado: {input}{Environment.NewLine}");

                // Mensaje claro al usuario
                Console.WriteLine("\nFormato inválido. Use exactamente dd/MM/yyyy (ej. 05/09/2025).\n");
            }
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
