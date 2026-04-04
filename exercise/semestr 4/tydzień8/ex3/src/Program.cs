public class BladWalidacjiException : Exception
{
    public string NazwaPola { get; }

    public BladWalidacjiException(string nazwaPloa, string komunikat)
        : base(komunikat)
    {
        NazwaPola = nazwaPloa;
    }
}

public class Produkt
{
    private string _nazwa = "";
    private decimal _cena;

    public string Nazwa
    {
        get => _nazwa;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new BladWalidacjiException(nameof(Nazwa), "Nazwa nie może być pusta.");
            _nazwa = value;
        }
    }

    public decimal Cena
    {
        get => _cena;
        set
        {
            if (value < 0)
                throw new BladWalidacjiException(nameof(Cena), "Cena nie może być ujemna.");
            _cena = value;
        }
    }

    public Produkt(string nazwa, decimal cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }

    public override string ToString() => $"{Nazwa}: {Cena:C}";
}

public class Program
{
    static void Main()
    {
        try
        {
            var p1 = new Produkt("Laptop", 2999.99m);
            Console.WriteLine(p1);

            var p2 = new Produkt("Mysz", -10m);
        }
        catch (BladWalidacjiException ex)
        {
            Console.WriteLine($"Błąd walidacji pola '{ex.NazwaPola}': {ex.Message}");
        }
    }
}
