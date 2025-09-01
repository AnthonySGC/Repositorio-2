// See https://aka.ms/new-console-template for more information
internal class Programa
{
    static void Main(string[] args)
    {
        int x, y, suma;
        Console.WriteLine("Hola mundo");
        Console.WriteLine("Programa creado por Anthony");
        Console.Write("Ingresa un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        suma = x + y;
        Console.WriteLine("El resultado es: " + suma);
    }
}


