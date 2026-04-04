public static class RownoleglePobieranie
{
    public static async Task<List<string>> PobierzRownolegleAsync(List<string> urls)
    {
        if (urls == null || urls.Count == 0)
            throw new ArgumentException("Lista URL-i nie może być pusta.");

        var zadania = urls.Select(PobierzJedenAsync);
        var wyniki = await Task.WhenAll(zadania);
        return wyniki.ToList();
    }

    private static async Task<string> PobierzJedenAsync(string url)
    {
        await Task.Delay(50);
        return $"OK: {url}";
    }
}

public class Program
{
    static async Task Main()
    {
        var urls = new List<string>
        {
            "https://api.example.com/1",
            "https://api.example.com/2",
            "https://api.example.com/3",
            "https://api.example.com/4",
            "https://api.example.com/5"
        };

        var wyniki = await RownoleglePobieranie.PobierzRownolegleAsync(urls);
        foreach (var w in wyniki)
            Console.WriteLine(w);
    }
}
