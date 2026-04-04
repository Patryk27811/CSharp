public interface IProduktRepository
{
    List<string> PobierzNazwy();
    int Liczba();
}

public class ProduktService
{
    private readonly IProduktRepository _repo;

    public ProduktService(IProduktRepository repo)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
    }

    public string PobierzPodsumowanie()
    {
        var liczba = _repo.Liczba();
        var nazwy = _repo.PobierzNazwy();
        return $"Produktów: {liczba}. Lista: {string.Join(", ", nazwy)}";
    }
}

public class PrawdziwyProduktRepository : IProduktRepository
{
    private readonly List<string> _produkty = new() { "Laptop", "Mysz", "Monitor" };
    public List<string> PobierzNazwy() => _produkty;
    public int Liczba() => _produkty.Count;
}

public class Program
{
    static void Main()
    {
        var service = new ProduktService(new PrawdziwyProduktRepository());
        Console.WriteLine(service.PobierzPodsumowanie());
    }
}
