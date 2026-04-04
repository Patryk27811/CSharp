using System.Linq;

public record Osoba(string Imie, int Wiek);

public static class Program
{
    public static Dictionary<int, List<Osoba>> GrupujPoWieku(List<Osoba> osoby)
    {
        if (osoby == null)
            throw new ArgumentNullException(nameof(osoby));

        return osoby
            .GroupBy(o => o.Wiek)
            .ToDictionary(g => g.Key, g => g.ToList());
    }

    static void Main()
    {
        var osoby = new List<Osoba>
        {
            new("Anna", 25),
            new("Bartek", 30),
            new("Celina", 25),
            new("Dawid", 30),
            new("Ewa", 22)
        };

        var grupy = GrupujPoWieku(osoby);
        foreach (var (wiek, lista) in grupy.OrderBy(g => g.Key))
            Console.WriteLine($"Wiek {wiek}: {string.Join(", ", lista.Select(o => o.Imie))}");
    }
}
