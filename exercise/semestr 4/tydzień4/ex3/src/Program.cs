public class BladApiException : Exception
{
    public int KodStatusu { get; }

    public BladApiException(string komunikat, int kodStatusu)
        : base(komunikat)
    {
        KodStatusu = kodStatusu;
    }
}

public static class BezpiecznyKlient
{
    public static async Task<string> PobierzBezpiecznieAsync(string url, bool symulujBlad = false)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("URL nie może być pusty.");

        await Task.Delay(50);

        if (symulujBlad)
            throw new BladApiException($"Błąd serwera dla: {url}", 500);

        return $"Sukces: {url}";
    }

    public static async Task<string> PobierzZObslugaBledow(string url)
    {
        try
        {
            return await PobierzBezpiecznieAsync(url);
        }
        catch (BladApiException ex)
        {
            return $"Błąd {ex.KodStatusu}: {ex.Message}";
        }
    }
}

public class Program
{
    static async Task Main()
    {
        string wynik1 = await BezpiecznyKlient.PobierzZObslugaBledow("https://api.example.com");
        Console.WriteLine(wynik1);

        string wynik2 = await BezpiecznyKlient.PobierzZObslugaBledow("https://niedziala.com");
        Console.WriteLine(wynik2);
    }
}
