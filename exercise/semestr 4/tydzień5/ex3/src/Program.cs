public interface IRepository<T> where T : class
{
    T Dodaj(T element);
    T? Znajdz(int id);
    IEnumerable<T> PobierzWszystkie();
    bool Usun(int id);
    int Liczba { get; }
}

public record Ksiazka(int Id, string Tytul, string Autor);

public class KsiazkaRepository : IRepository<Ksiazka>
{
    private readonly List<Ksiazka> _ksiazki = new();
    private int _nastepneId = 1;

    public Ksiazka Dodaj(Ksiazka ksiazka)
    {
        if (ksiazka == null) throw new ArgumentNullException(nameof(ksiazka));
        var nowa = ksiazka with { Id = _nastepneId++ };
        _ksiazki.Add(nowa);
        return nowa;
    }

    public Ksiazka? Znajdz(int id) =>
        _ksiazki.FirstOrDefault(k => k.Id == id);

    public IEnumerable<Ksiazka> PobierzWszystkie() => _ksiazki.AsReadOnly();

    public bool Usun(int id)
    {
        var ksiazka = Znajdz(id);
        if (ksiazka == null) return false;
        _ksiazki.Remove(ksiazka);
        return true;
    }

    public int Liczba => _ksiazki.Count;
}

public class Program
{
    static void Main()
    {
        IRepository<Ksiazka> repo = new KsiazkaRepository();
        repo.Dodaj(new Ksiazka(0, "Pan Tadeusz", "Adam Mickiewicz"));
        repo.Dodaj(new Ksiazka(0, "Lalka", "Bolesław Prus"));

        Console.WriteLine($"Książki ({repo.Liczba}):");
        foreach (var k in repo.PobierzWszystkie())
            Console.WriteLine($"  [{k.Id}] {k.Tytul} - {k.Autor}");
    }
}
