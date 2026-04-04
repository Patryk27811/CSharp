public static class KopiowaniePliku
{
    public static void Kopiuj(string zrodlo, string cel)
    {
        if (!File.Exists(zrodlo))
            throw new FileNotFoundException($"Plik źródłowy nie istnieje: {zrodlo}");
        if (string.IsNullOrWhiteSpace(cel))
            throw new ArgumentException("Ścieżka docelowa nie może być pusta.");

        using var czytnik = new StreamReader(zrodlo);
        using var pisarz = new StreamWriter(cel);

        string? linia;
        int liczbaLinii = 0;
        while ((linia = czytnik.ReadLine()) != null)
        {
            pisarz.WriteLine(linia);
            liczbaLinii++;
        }

        Console.WriteLine($"Skopiowano {liczbaLinii} linii z '{zrodlo}' do '{cel}'.");
    }
}

public class Program
{
    static void Main()
    {
        string zrodlo = Path.GetTempFileName();
        string cel = Path.GetTempFileName();
        File.WriteAllLines(zrodlo, new[] { "Linia 1", "Linia 2", "Linia 3" });

        KopiowaniePliku.Kopiuj(zrodlo, cel);

        Console.WriteLine("Zawartość skopiowanego pliku:");
        foreach (var l in File.ReadAllLines(cel))
            Console.WriteLine($"  {l}");

        File.Delete(zrodlo);
        File.Delete(cel);
    }
}
