using System.Text.Json;

public record User(string Login, string Email, int Wiek);

public static class UserRepository
{
    private static readonly JsonSerializerOptions Opcje = new()
    {
        WriteIndented = true
    };

    public static void ZapiszDoPliku(User user, string sciezka)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));
        string json = JsonSerializer.Serialize(user, Opcje);
        File.WriteAllText(sciezka, json);
    }

    public static User? WczytajZPliku(string sciezka)
    {
        if (!File.Exists(sciezka))
            throw new FileNotFoundException($"Plik nie istnieje: {sciezka}");

        string json = File.ReadAllText(sciezka);
        return JsonSerializer.Deserialize<User>(json);
    }
}

public class Program
{
    static void Main()
    {
        string sciezka = Path.Combine(Path.GetTempPath(), "user.json");
        var user = new User("jkowalski", "jan@example.com", 30);

        UserRepository.ZapiszDoPliku(user, sciezka);
        Console.WriteLine($"Zapisano: {sciezka}");

        var wczytany = UserRepository.WczytajZPliku(sciezka);
        Console.WriteLine($"Login: {wczytany!.Login}, Email: {wczytany.Email}, Wiek: {wczytany.Wiek}");

        File.Delete(sciezka);
    }
}
