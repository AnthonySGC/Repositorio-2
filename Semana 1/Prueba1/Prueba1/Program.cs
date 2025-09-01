// See https://aka.ms/new-console-template for more information

int num;
Console.WriteLine("Programa para saber si un número es positivo, negativo o cero");
Console.WriteLine("Ingresa un número: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("El número es positivo");
}
else if (num < 0)
{
    Console.WriteLine("Número es negativo");
}
else
{
    Console.WriteLine("El número es cero");
}