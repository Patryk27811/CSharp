public sealed class Logger
{
    private static Logger? _instancja;
    private static readonly object _blokada = new();
    private readonly List<string> _logi = new();

    private Logger() { }

    public static Logger Instancja
    {
        get
        {
            if (_instancja == null)
            {
                lock (_blokada)
                {
                    _instancja ??= new Logger();
                }
            }
            return _instancja;
        }
    }

    public void Zapisz(string komunikat)
    {
        string wpis = $"[{DateTime.Now:HH:mm:ss}] {komunikat}";
        _logi.Add(wpis);
        Console.WriteLine(wpis);
    }

    public IReadOnlyList<string> PobierzLogi() => _logi.AsReadOnly();

    internal static void Reset() => _instancja = null;
}

public class Program
{
    static void Main()
    {
        Logger.Instancja.Zapisz("Aplikacja uruchomiona.");
        Logger.Instancja.Zapisz("Ładowanie konfiguracji...");
        Logger.Instancja.Zapisz("Gotowy.");

        Console.WriteLine($"\nWszystkich logów: {Logger.Instancja.PobierzLogi().Count}");
    }
}
