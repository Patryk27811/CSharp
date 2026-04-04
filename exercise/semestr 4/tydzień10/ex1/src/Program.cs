using System.Text.Json;

public record TodoItem(int Id, string Tytul, bool Ukonczone, DateTime Utworzono);

public static class TodoStorage
{
    private static readonly JsonSerializerOptions Opcje = new() { WriteIndented = true };

    public static void Zapisz(List<TodoItem> lista, string sciezka)
    {
        string json = JsonSerializer.Serialize(lista, Opcje);
        File.WriteAllText(sciezka, json);
    }

    public static List<TodoItem> Wczytaj(string sciezka)
    {
        if (!File.Exists(sciezka)) return new List<TodoItem>();
        string json = File.ReadAllText(sciezka);
        return JsonSerializer.Deserialize<List<TodoItem>>(json) ?? new List<TodoItem>();
    }
}

public class TodoManager
{
    private readonly List<TodoItem> _lista = new();
    private int _nastepneId = 1;

    public TodoItem Dodaj(string tytul)
    {
        if (string.IsNullOrWhiteSpace(tytul))
            throw new ArgumentException("Tytuł nie może być pusty.");
        var item = new TodoItem(_nastepneId++, tytul, false, DateTime.Now);
        _lista.Add(item);
        return item;
    }

    public bool Ukoncz(int id)
    {
        int index = _lista.FindIndex(t => t.Id == id);
        if (index < 0) return false;
        _lista[index] = _lista[index] with { Ukonczone = true };
        return true;
    }

    public List<TodoItem> PobierzWszystkie() => _lista.ToList();
}

public class Program
{
    static void Main()
    {
        var manager = new TodoManager();
        manager.Dodaj("Kupić mleko");
        manager.Dodaj("Napisać raport");
        manager.Dodaj("Zadzwonić do klienta");
        manager.Ukoncz(1);

        string plik = Path.Combine(Path.GetTempPath(), "todo.json");
        TodoStorage.Zapisz(manager.PobierzWszystkie(), plik);

        Console.WriteLine("Lista ToDo:");
        foreach (var t in manager.PobierzWszystkie())
            Console.WriteLine($"  [{(t.Ukonczone ? "X" : " ")}] {t.Id}. {t.Tytul}");

        Console.WriteLine($"\nZapisano do: {plik}");
        File.Delete(plik);
    }
}
