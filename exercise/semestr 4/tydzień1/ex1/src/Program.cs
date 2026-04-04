using System.Linq;

int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
var parzyste = WybierzParzyste(liczby);

Console.WriteLine("Parzyste liczby:");
foreach (var n in parzyste)
    Console.Write($"{n} ");
Console.WriteLine();

static int[] WybierzParzyste(int[] liczby) =>
    liczby.Where(n => n % 2 == 0).ToArray();
