public enum PoziomLogu { Info, Ostrzezenie, Blad }

public class FileLogger : IDisposable
{
    private readonly StreamWriter _pisarz;
    private bool _disposed;

    public FileLogger(string sciezka)
    {
        if (string.IsNullOrWhiteSpace(sciezka))
            throw new ArgumentException("Ścieżka nie może być pusta.");

        _pisarz = new StreamWriter(sciezka, append: true);
    }

    public void Zapisz(string komunikat, PoziomLogu poziom = PoziomLogu.Info)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        string wpis = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{poziom}] {komunikat}";
        _pisarz.WriteLine(wpis);
        _pisarz.Flush();
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _pisarz.Dispose();
            _disposed = true;
        }
    }
}

public class Program
{
    static void Main()
    {
        string plik = Path.GetTempFileName();
        using var logger = new FileLogger(plik);
        logger.Zapisz("Aplikacja uruchomiona.");
        logger.Zapisz("Ostrzeżenie testowe.", PoziomLogu.Ostrzezenie);
        logger.Zapisz("Błąd testowy.", PoziomLogu.Blad);

        Console.WriteLine("Logi:");
        foreach (var l in File.ReadAllLines(plik))
            Console.WriteLine(l);

        File.Delete(plik);
    }
}
