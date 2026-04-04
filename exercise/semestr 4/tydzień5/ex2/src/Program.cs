public record Product(int Id, string Nazwa, decimal Cena);

public class ProductRepository
{
    private readonly List<Product> _produkty = new();
    private int _nastepneId = 1;

    public Product Dodaj(string nazwa, decimal cena)
    {
        if (string.IsNullOrWhiteSpace(nazwa))
            throw new ArgumentException("Nazwa nie może być pusta.");
        if (cena < 0)
            throw new ArgumentException("Cena nie może być ujemna.");

        var produkt = new Product(_nastepneId++, nazwa, cena);
        _produkty.Add(produkt);
        return produkt;
    }

    public Product? Znajdz(int id) =>
        _produkty.FirstOrDefault(p => p.Id == id);

    public List<Product> PobierzWszystkie() => _produkty.ToList();

    public bool Usun(int id)
    {
        var produkt = Znajdz(id);
        if (produkt == null) return false;
        _produkty.Remove(produkt);
        return true;
    }

    public int Liczba => _produkty.Count;
}

public class Program
{
    static void Main()
    {
        var repo = new ProductRepository();
        repo.Dodaj("Laptop", 3999.99m);
        repo.Dodaj("Mysz", 79.99m);
        repo.Dodaj("Monitor", 1299.99m);

        Console.WriteLine($"Produkty ({repo.Liczba}):");
        foreach (var p in repo.PobierzWszystkie())
            Console.WriteLine($"  [{p.Id}] {p.Nazwa} - {p.Cena:C}");
    }
}
