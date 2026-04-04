public static class ApiKlient
{
    public static async Task<string> PobierzDaneAsync(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("URL nie może być pusty.");

        await Task.Delay(100);
        return $"Dane z: {url}";
    }
}

public class Program
{
    static async Task Main()
    {
        string wynik = await ApiKlient.PobierzDaneAsync("https://api.example.com/data");
        Console.WriteLine(wynik);
    }
}
