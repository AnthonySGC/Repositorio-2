// See https://aka.ms/new-console-template for more information
// Calificación con switch
Console.Write("Ingrese la calificación del estudiante: ");
int calificacion = int.Parse(Console.ReadLine());

string resultado = calificacion switch
{
    > 100 or < 0 => "Nota invalida",
    >= 70 => "Aprobado",
    >= 50 => "Recuperación",
    _ => "Reprobado"
};

Console.WriteLine(resultado);
// ...existing
