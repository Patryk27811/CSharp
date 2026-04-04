using System.Text.Json;

public record TodoItemFull(
    int Id,
    string Tytul,
    bool Ukonczone,
    DateTime Utworzono,
    string? Opis = null
);

public static class JsonValidator
{
    private static readonly JsonSerializerOptions Opcje = new()
    {
        WriteIndented = false,
        PropertyNameCaseInsensitive = true
    };

    public static string Serializuj(TodoItemFull item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        return JsonSerializer.Serialize(item, Opcje);
    }

    public static TodoItemFull? Deserializuj(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
            throw new ArgumentException("JSON nie może być pusty.");
        return JsonSerializer.Deserialize<TodoItemFull>(json, Opcje);
    }

    public static bool CzySerializacjaPoprawna(TodoItemFull item)
    {
        try
        {
            string json = Serializuj(item);
            var odtworzony = Deserializuj(json);
            return odtworzony != null &&
                   odtworzony.Id == item.Id &&
                   odtworzony.Tytul == item.Tytul &&
                   odtworzony.Ukonczone == item.Ukonczone;
        }
        catch
        {
            return false;
        }
    }
}

public class Program
{
    static void Main()
    {
        var item = new TodoItemFull(1, "Test serializacji", false, DateTime.Now, "Opis testowy");
        string json = JsonValidator.Serializuj(item);
        Console.WriteLine($"JSON: {json}");

        var odtworzony = JsonValidator.Deserializuj(json);
        Console.WriteLine($"Odtworzony: {odtworzony?.Tytul}, Ukończone: {odtworzony?.Ukonczone}");
        Console.WriteLine($"Serializacja poprawna: {JsonValidator.CzySerializacjaPoprawna(item)}");
    }
}
