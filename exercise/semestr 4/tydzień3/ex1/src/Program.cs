using System.Linq;

public static class AnalizatorSlow
{
    public static Dictionary<string, int> ZliczSlowa(string tekst)
    {
        if (string.IsNullOrWhiteSpace(tekst))
            return new Dictionary<string, int>();

        return tekst
            .Split(new[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?' },
                   StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.ToLower())
            .GroupBy(s => s)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}

public class Program
{
    static void Main()
    {
        string tekst = "ala ma kota kota i psa ala lubi kota";
        var czestosci = AnalizatorSlow.ZliczSlowa(tekst);

        Console.WriteLine("Częstość słów:");
        foreach (var (slowo, liczba) in czestosci.OrderByDescending(kv => kv.Value))
            Console.WriteLine($"  {slowo}: {liczba}");
    }
}
