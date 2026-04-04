public record PozycjaZamowienia(string Nazwa, decimal Cena, int Ilosc);

public record Zamowienie(int Id, List<PozycjaZamowienia> Pozycje);

public static class OrderService
{
    public static decimal ObliczWartosc(Zamowienie zamowienie)
    {
        if (zamowienie == null) throw new ArgumentNullException(nameof(zamowienie));
        if (zamowienie.Pozycje == null || zamowienie.Pozycje.Count == 0)
            return 0m;

        return zamowienie.Pozycje.Sum(p => p.Cena * p.Ilosc);
    }

    public static decimal ObliczZRabatem(Zamowienie zamowienie, decimal procentRabatu)
    {
        if (procentRabatu < 0 || procentRabatu > 100)
            throw new ArgumentException("Rabat musi być w zakresie 0-100%.");

        decimal wartosc = ObliczWartosc(zamowienie);
        return wartosc * (1 - procentRabatu / 100);
    }
}

public class Program
{
    static void Main()
    {
        var zamowienie = new Zamowienie(1, new List<PozycjaZamowienia>
        {
            new("Laptop", 3000m, 1),
            new("Mysz", 100m, 2),
            new("Kabel", 20m, 3)
        });

        Console.WriteLine($"Wartość zamówienia: {OrderService.ObliczWartosc(zamowienie):C}");
        Console.WriteLine($"Po rabacie 10%: {OrderService.ObliczZRabatem(zamowienie, 10):C}");
    }
}
