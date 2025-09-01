// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Programa para evaluar calificación");
Console.WriteLine("Ingrese su calificación");
num = Convert.ToInt32(Console.ReadLine());
if (num >= 70 && num <= 100)
{
    Console.WriteLine("Aprobado");
}
if (num >= 50 && num <= 69)
{
    Console.WriteLine("Recuperación");
}
if (num < 50 && num >= 0)
{
    Console.WriteLine("Reprobado");
}
if (num < 0 || num > 100)
{
    Console.WriteLine("Calificación inválida");
}