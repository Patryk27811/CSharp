using System.Text.Json;

public record PostApi(int Id, int UserId, string Title, string Body);

public static class JsonDeserializator
{
    public static List<T> DeserializujListe<T>(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
            throw new ArgumentException("JSON nie może być pusty.");

        var wynik = JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return wynik ?? new List<T>();
    }
}

public class Program
{
    static void Main()
    {
        string json = """
        [
            {"id": 1, "userId": 1, "title": "Pierwszy post", "body": "Treść pierwsza"},
            {"id": 2, "userId": 1, "title": "Drugi post", "body": "Treść druga"},
            {"id": 3, "userId": 2, "title": "Trzeci post", "body": "Treść trzecia"}
        ]
        """;

        var posty = JsonDeserializator.DeserializujListe<PostApi>(json);
        Console.WriteLine($"Pobrano {posty.Count} postów:");
        foreach (var p in posty)
            Console.WriteLine($"  [{p.Id}] {p.Title}");
    }
}
