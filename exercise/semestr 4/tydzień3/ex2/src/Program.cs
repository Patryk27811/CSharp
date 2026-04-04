using System.Text.Json;

public record KonfigAplkikacji(string Nazwa, string Wersja, bool DebugMode);

public static class JsonCzytnik
{
    public static T? WczytajJson<T>(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
            throw new ArgumentException("JSON nie może być pusty.");

        return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }
}

public class Program
{
    static void Main()
    {
        string json = """
        {
            "Nazwa": "MojaAplikacja",
            "Wersja": "1.0.0",
            "DebugMode": true
        }
        """;

        var config = JsonCzytnik.WczytajJson<KonfigAplkikacji>(json);
        if (config != null)
        {
            Console.WriteLine($"Nazwa: {config.Nazwa}");
            Console.WriteLine($"Wersja: {config.Wersja}");
            Console.WriteLine($"Debug: {config.DebugMode}");
        }
    }
}
