public record WierszCsv(string[] Kolumny);

public static class CsvCzytnik
{
    public static List<WierszCsv> WczytajCsv(string sciezka, char separator = ',')
    {
        if (!File.Exists(sciezka))
            throw new FileNotFoundException($"Plik nie istnieje: {sciezka}");

        return File.ReadAllLines(sciezka)
            .Where(linia => !string.IsNullOrWhiteSpace(linia))
            .Select(linia => new WierszCsv(linia.Split(separator)))
            .ToList();
    }

    public static void WypiszCsv(List<WierszCsv> wiersze)
    {
        foreach (var wiersz in wiersze)
            Console.WriteLine(string.Join(" | ", wiersz.Kolumny));
    }
}

public class Program
{
    static void Main()
    {
        string sciezkaPliku = Path.GetTempFileName() + ".csv";
        File.WriteAllLines(sciezkaPliku, new[]
        {
            "Imie,Nazwisko,Wiek",
            "Anna,Kowalska,25",
            "Bartek,Nowak,30",
            "Celina,Wiśniewska,22"
        });

        var wiersze = CsvCzytnik.WczytajCsv(sciezkaPliku);
        CsvCzytnik.WypiszCsv(wiersze);

        File.Delete(sciezkaPliku);
    }
}
