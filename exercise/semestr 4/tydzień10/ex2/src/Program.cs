public record TodoItemEx(int Id, string Tytul, bool Ukonczone, string Kategoria);

public static class TodoFilter
{
    public static List<TodoItemEx> FiltrujPoStatusie(List<TodoItemEx> lista, bool ukonczone)
    {
        if (lista == null) throw new ArgumentNullException(nameof(lista));
        return lista.Where(t => t.Ukonczone == ukonczone).ToList();
    }

    public static List<TodoItemEx> FiltrujPoKategorii(List<TodoItemEx> lista, string kategoria)
    {
        if (lista == null) throw new ArgumentNullException(nameof(lista));
        if (string.IsNullOrWhiteSpace(kategoria)) throw new ArgumentException("Kategoria nie może być pusta.");
        return lista.Where(t => t.Kategoria.Equals(kategoria, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static Dictionary<string, int> StatsyPoKategoriach(List<TodoItemEx> lista)
    {
        if (lista == null) throw new ArgumentNullException(nameof(lista));
        return lista
            .GroupBy(t => t.Kategoria)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}

public class Program
{
    static void Main()
    {
        var lista = new List<TodoItemEx>
        {
            new(1, "Kupić mleko", true, "Zakupy"),
            new(2, "Napisać raport", false, "Praca"),
            new(3, "Kupić chleb", false, "Zakupy"),
            new(4, "Spotkanie z klientem", true, "Praca")
        };

        Console.WriteLine("Nieukończone:");
        foreach (var t in TodoFilter.FiltrujPoStatusie(lista, false))
            Console.WriteLine($"  - {t.Tytul}");

        Console.WriteLine("\nStatystyki po kategoriach:");
        foreach (var (kat, ile) in TodoFilter.StatsyPoKategoriach(lista))
            Console.WriteLine($"  {kat}: {ile}");
    }
}
