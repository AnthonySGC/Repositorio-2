// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa que calcula la suma de los números pares e impares entre 1 y 100");

int sumaPares = 0;
int sumaImpares = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        sumaPares += i;
    else
        sumaImpares += i;
}

Console.WriteLine($"Suma de pares entre 1 y 100: {sumaPares}");
Console.WriteLine($"Suma de impares entre 1 y 100: {sumaImpares}");