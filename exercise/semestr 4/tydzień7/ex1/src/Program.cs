public static class SumatorPliku
{
    public static long SumujLiczbyZPliku(string sciezka)
    {
        if (!File.Exists(sciezka))
            throw new FileNotFoundException($"Plik nie istnieje: {sciezka}");

        long suma = 0;
        foreach (var linia in File.ReadLines(sciezka))
        {
            if (long.TryParse(linia.Trim(), out long liczba))
                suma += liczba;
        }
        return suma;
    }
}

public class Program
{
    static void Main()
    {
        string plik = Path.GetTempFileName();
        File.WriteAllLines(plik, new[] { "10", "20", "30", "40", "50", "abc", "", "100" });

        long suma = SumatorPliku.SumujLiczbyZPliku(plik);
        Console.WriteLine($"Suma liczb z pliku: {suma}");

        File.Delete(plik);
    }
}
