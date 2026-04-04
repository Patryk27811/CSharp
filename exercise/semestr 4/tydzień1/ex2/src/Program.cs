using System.Linq;

int[] liczby = { 10, 20, 30, 40, 50 };
double srednia = ObliczSrednia(liczby);
Console.WriteLine($"Średnia: {srednia}");

static double ObliczSrednia(int[] liczby)
{
    if (liczby == null || liczby.Length == 0)
        throw new ArgumentException("Tablica nie może być pusta.");
    return liczby.Average();
}
